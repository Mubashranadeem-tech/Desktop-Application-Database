using Database_Project;
using Database_Project.Properties;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Drawing.Drawing2D;

namespace Admin_UI
{
    public partial class Form1 : Form
    {

        private string connectionString = "Server=localhost;Database=school_management_system_try10;Uid=root;Pwd=Mubashra;";
        private int presentCount = 0;
        private int absentCount = 0;
        private AccountantDBConnection dbConnect;
        public Form1()
        {
            InitializeComponent();
            dbConnect = new AccountantDBConnection();
            this.ClientSize = new Size(1366, 800); // Make form big enough to show graph at (419, 320)
            LoadAttendanceData();

            dateTimePicker1.ValueChanged += (s, e) =>
            {
                LoadAttendanceData();
                this.Invalidate(); // Redraw the graph
            };


            // for notice board
            RefreshNotices(); // Load notices when form opens
        }
        // Method to refresh notices in textBox1
        public void RefreshNotices()
        {
            var notices = NoticeManager.GetAllNotices();

            textBox1.Clear(); // Clear existing content

            if (notices.Count == 0)
            {
                textBox1.Text = "No notices available.";
                return;
            }

            // Display all notices in textBox1
            foreach (var notice in notices)
            {
                textBox1.AppendText($"📋 {notice.Title}\r\n");
                textBox1.AppendText($"◊ {notice.Details}\r\n");
                textBox1.AppendText($"👤 Posted by: {notice.PostedBy} on {notice.Date.ToString("MMM dd, yyyy")}\r\n");
                textBox1.AppendText("──────────────────────────────\r\n\r\n");
            }
        }

        public void UpdatePrincipalMessage(string message)
        {

            if (textBox3.InvokeRequired)
            {
                textBox3.Invoke(new Action(() =>
                {
                    textBox3.Text = message;
                    textBox3.Refresh(); // Force immediate update
                }));
            }
            else
            {
                textBox3.Text = message;
                textBox3.Refresh();
            }

        }
        private void LoadAttendanceData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            SUM(CASE WHEN status = 'Present' THEN 1 ELSE 0 END) as present_count,
                            SUM(CASE WHEN status = 'Absent' THEN 1 ELSE 0 END) as absent_count
                        FROM attendance
                        WHERE DATE(date) = @selectedDate";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@selectedDate", dateTimePicker1.Value.Date);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                presentCount = reader["present_count"] == DBNull.Value ? 0 : Convert.ToInt32(reader["present_count"]);
                                absentCount = reader["absent_count"] == DBNull.Value ? 0 : Convert.ToInt32(reader["absent_count"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}\nUsing sample data.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                presentCount = 75;
                absentCount = 25;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawAttendanceGraph(e.Graphics);
        }

        private void DrawAttendanceGraph(Graphics g)
        {
            // Target location and size
            int graphX = 419;
            int graphY = 320;
            int graphWidth = 884;
            int graphHeight = 455;

            int padding = 60;
            int chartWidth = graphWidth - (2 * padding);
            int chartHeight = graphHeight - (2 * padding);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw chart background
            using (SolidBrush bgBrush = new SolidBrush(Color.White))
            {
                g.FillRectangle(bgBrush, graphX, graphY, graphWidth, graphHeight);
            }

            // Draw title
            using (Font titleFont = new Font("Arial", 16, FontStyle.Bold))
            {
                string title = "Student Attendance";
                SizeF titleSize = g.MeasureString(title, titleFont);
                float titleX = graphX + (graphWidth - titleSize.Width) / 2;
                float titleY = graphY + 20;
                g.DrawString(title, titleFont, Brushes.Black, titleX, titleY);
            }

            int yAxisMax = 760;
            int[] yAxisValues = { 760, 600, 400, 200, 0 };

            Font axisFont = new Font("Arial", 10);
            Font valueFont = new Font("Arial", 12);

            try
            {
                // Y-axis grid lines & labels
                using (Pen gridPen = new Pen(Color.LightGray, 1))
                {
                    foreach (int value in yAxisValues)
                    {
                        int y = graphY + padding + chartHeight - (int)(chartHeight * (value / (float)yAxisMax));
                        g.DrawLine(gridPen, graphX + padding, y, graphX + padding + chartWidth, y);
                        g.DrawString(value.ToString(), axisFont, Brushes.Black, graphX + padding - 40, y - 8);
                    }
                }

                // X-axis and Y-axis lines
                using (Pen axisPen = new Pen(Color.Black, 2))
                {
                    g.DrawLine(axisPen, graphX + padding, graphY + padding, graphX + padding, graphY + padding + chartHeight); // Y-axis
                    g.DrawLine(axisPen, graphX + padding, graphY + padding + chartHeight, graphX + padding + chartWidth, graphY + padding + chartHeight); // X-axis
                }

                // Bar setup
                int barWidth = 100;
                int spacing = 20;
                int startX = graphX + padding + spacing;

                // Present bar
                int presentHeight = (int)(chartHeight * (presentCount / (float)yAxisMax));
                using (Brush presentBrush = new SolidBrush(Color.FromArgb(70, 130, 180)))
                {
                    int barY = graphY + padding + chartHeight - presentHeight;
                    g.FillRectangle(presentBrush, startX, barY, barWidth, presentHeight);
                    g.DrawString(presentCount.ToString(), valueFont, Brushes.Black, startX + (barWidth / 2) - 15, barY - 25);
                }

                // Absent bar
                int absentHeight = (int)(chartHeight * (absentCount / (float)yAxisMax));
                using (Brush absentBrush = new SolidBrush(Color.FromArgb(135, 206, 250)))
                {
                    int barX = startX + barWidth + spacing;
                    int barY = graphY + padding + chartHeight - absentHeight;
                    g.FillRectangle(absentBrush, barX, barY, barWidth, absentHeight);
                    g.DrawString(absentCount.ToString(), valueFont, Brushes.Black, barX + (barWidth / 2) - 15, barY - 25);
                }

                // Bar labels
                using (Font labelFont = new Font("Arial", 12))
                {
                    g.DrawString("Present", labelFont, Brushes.Black, startX, graphY + padding + chartHeight + 10);
                    g.DrawString("Absent", labelFont, Brushes.Black, startX + barWidth + spacing, graphY + padding + chartHeight + 10);
                }

                // Legend
                DrawLegend(g, graphX + graphWidth - 150, graphY + padding);
            }
            finally
            {
                axisFont.Dispose();
                valueFont.Dispose();
            }
        }

        private void DrawLegend(Graphics g, int x, int y)
        {
            using (Font legendFont = new Font("Arial", 10))
            {
                using (Brush presentBrush = new SolidBrush(Color.FromArgb(70, 130, 180)))
                {
                    g.FillRectangle(presentBrush, x, y, 15, 15);
                }
                g.DrawString("Present", legendFont, Brushes.Black, x + 20, y);

                using (Brush absentBrush = new SolidBrush(Color.FromArgb(135, 206, 250)))
                {
                    g.FillRectangle(absentBrush, x, y + 25, 15, 15);
                }
                g.DrawString("Absent", legendFont, Brushes.Black, x + 20, y + 25);
            }
        }

        private void Students_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form2 noticeBoard = new Form2();
            noticeBoard.FormClosed += (s, args) => this.RefreshNotices(); // Refresh when Form2 is closed
            noticeBoard.Show();
            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            UpdateDashboardCounts();
            // for notice board
            // Notice Board (Form2) messages go here
            textBox1.Multiline = true;
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;

            // Principal Dashboard messages go here
            textBox3.Multiline = true;
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Vertical;


            RefreshNotices();

        }

        private void UpdateDashboardCounts()
        {
            try
            {
                // Get and display total student count
                int studentCount = dbConnect.GetCount("SELECT COUNT(*) FROM students");
                StudentsCount.Text = studentCount.ToString();

                // Get and display total teacher count
                int teacherCount = dbConnect.GetCount("SELECT COUNT(*) FROM teachers");
                TeachersCount.Text = teacherCount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating dashboard: {ex.Message}");
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Form3 studentDetails = new Form3();
            studentDetails.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Student A1 = new Add_Student();
            A1.Show();
            this.Hide();
        }

        private void teacherdetails_Click(object sender, EventArgs e)
        {
            Form5 teacherDetails = new Form5();
            teacherDetails.Show();
            this.Hide();
        }

        private void ADDteacher_Click(object sender, EventArgs e)
        {
            Form6 addTeacher = new Form6();
            addTeacher.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MainDashboard F3 = new MainDashboard();
            F3.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StudentReportA studentReportA = new StudentReportA();
            studentReportA.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DailyAttendanceA dailyAttendanceA = new DailyAttendanceA();
            dailyAttendanceA.Show();
            this.Hide();
        }




        // linked in 
        private void linkedin_Click(object sender, EventArgs e)
        {
            try
            {
                string linkedinUrl = "https://www.linkedin.com/in/al-hamd-knowledge-house-school-83767b368/";
                Process.Start(new ProcessStartInfo
                {
                    FileName = linkedinUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening LinkedIn: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // linkedin icon
        private void label6_Click(object sender, EventArgs e)
        {
            OpenLinkedInProfile();
        }

        private void linkedinTextLabel_Click(object sender, EventArgs e)
        {
            OpenLinkedInProfile();
        }

        private void OpenLinkedInProfile()
        {
            try
            {
                string linkedinUrl = "https://www.linkedin.com/in/al-hamd-knowledge-house-school-83767b368/";
                Process.Start(new ProcessStartInfo
                {
                    FileName = linkedinUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening LinkedIn: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // facebook 
        private void facebook_Click(object sender, EventArgs e)
        {
            try
            {
                string facebookUrl = "https://www.facebook.com/profile.php?id=61576716724303";
                Process.Start(new ProcessStartInfo
                {
                    FileName = facebookUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Facebook: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void facebookIconLabel_Click(object sender, EventArgs e)
        {
            OpenFacebookProfile();
        }

        private void facebooktextLabel_Click(object sender, EventArgs e)
        {
            OpenFacebookProfile();
        }
        private void OpenFacebookProfile()
        {
            try
            {
                string facebookUrl = "https://www.facebook.com/profile.php?id=61576716724303";
                Process.Start(new ProcessStartInfo
                {
                    FileName = facebookUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Facebook: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            try
            {
                string twitterUrl = "https://x.com/al_hamdhouse";
                Process.Start(new ProcessStartInfo
                {
                    FileName = twitterUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Twitter/X: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void twittertext_Click(object sender, EventArgs e)
        {
            OpenTwitterProfile();
        }


        private void OpenTwitterProfile()
        {
            try
            {
                string twitterUrl = "https://x.com/al_hamdhouse";
                Process.Start(new ProcessStartInfo
                {
                    FileName = twitterUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Twitter/X: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void facebook_Paint(object sender, PaintEventArgs e)
        {

        }
        // instagram
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                string instagramUrl = "https://www.instagram.com/al_hamd_knowledge_house/";
                Process.Start(new ProcessStartInfo
                {
                    FileName = instagramUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Instagram/X: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenInstagramProfile()
        {
            try
            {
                string instagramUrl = "https://www.instagram.com/al_hamd_knowledge_house/";
                Process.Start(new ProcessStartInfo
                {
                    FileName = instagramUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Instagram/X: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insta_label_Click(object sender, EventArgs e)
        {
            OpenInstagramProfile();
        }
        private void twittericon_Click(object sender, EventArgs e)
        {
            OpenInstagramProfile();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}






