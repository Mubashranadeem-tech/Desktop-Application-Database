
using System;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Admin_UI;
using MySql.Data.MySqlClient;

namespace Database_Project
{
    public partial class PrincipalDashboard : Form
    {
        private int maleCount = 0;
        private int femaleCount = 0;
        private string connectionString = "Server=localhost;Database=school_management_system_try10;Uid=root;Pwd=Mubashra;";

        private AccountantDBConnection dbConnect;

        // for notice board 
        private static string _principalMessage = "";
        public PrincipalDashboard()
        {
            InitializeComponent();

            dbConnect = new AccountantDBConnection();
            LoadExpenseChart();
            LoadStudentData();
            // for notice board
            textBox2.Multiline = true;
            textBox2.ScrollBars = ScrollBars.Vertical;

            // Load the saved message when form loads
            LoadSavedMessage();

            // Also load notices from Form2
            LoadNoticesFromForm2();
        }

        private void LoadSavedMessage()
        {
            // Restore the principal message if it exists
            if (!string.IsNullOrEmpty(_principalMessage))
            {
                textBox2.Text = _principalMessage;
            }
        }

        private void LoadNoticesFromForm2()
        {
            // Get all notices and display them in textBox1
            var notices = NoticeManager.GetAllNotices();
            if (notices.Count > 0)
            {
                StringBuilder noticeText = new StringBuilder();
                foreach (var notice in notices)
                {
                    noticeText.AppendLine($"📋 {notice.Title}");
                    noticeText.AppendLine($"◊ {notice.Details}");
                    noticeText.AppendLine($"👤 {notice.PostedBy} - {notice.Date:MMM dd, yyyy}");
                    noticeText.AppendLine("─────────────────────────────");
                }
                textBox1.Text = noticeText.ToString();
            }
            else
            {
                textBox1.Text = "No notices available.";
            }
        }
        // Method to refresh notices (called from Form2)
        public void RefreshNotices()
        {
            LoadNoticesFromForm2();
        }
        // Method to update principal message (called from other forms)
        public void UpdatePrincipalMessage(string message)
        {
            _principalMessage = message;
            textBox2.Text = message;
        }

        private void LoadExpenseChart()
        {
            decimal paid = 0;
            decimal unpaid = 0;

            // fetch totals from DB
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                const string query = "SELECT status, SUM(amount) as total FROM expenses GROUP BY status";
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var status = reader.GetString("status");
                            var total = reader.GetDecimal("total");
                            if (status == "Paid")
                                paid = total;
                            else if (status == "Unpaid")
                                unpaid = total;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading expenses: " + ex.Message);
                    return;
                }
            }

            // clear any existing series
            chartExpenses.Series.Clear();
            chartExpenses.ChartAreas.Clear();

            // Create chart area
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartExpenses.ChartAreas.Add(chartArea);

            // Shared X value (e.g., "Expenses")
            string xValue = "Expense";

            // Series #1 — Paid
            var paidSeries = new Series("Paid")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };
            paidSeries.Points.AddXY(xValue, paid);
            paidSeries.Color = Color.MediumSeaGreen;
            chartExpenses.Series.Add(paidSeries);

            // Series #2 — Unpaid
            var unpaidSeries = new Series("Unpaid")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };
            unpaidSeries.Points.AddXY(xValue, unpaid);
            unpaidSeries.Color = Color.IndianRed;
            chartExpenses.Series.Add(unpaidSeries);

            // Make bars thicker by increasing PointWidth
            foreach (var series in chartExpenses.Series)
            {
                series["PointWidth"] = "1.0"; // Increase to make the bars thicker
            }

        }

        public void LoadStudentData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Count male students
                    string maleSql = "SELECT COUNT(*) FROM students WHERE gender = 'Male'";
                    using (MySqlCommand maleCmd = new MySqlCommand(maleSql, connection))
                    {
                        maleCount = Convert.ToInt32(maleCmd.ExecuteScalar());
                        lblMaleCount.Text = maleCount.ToString();
                    }

                    // Count female students
                    string femaleSql = "SELECT COUNT(*) FROM students WHERE gender = 'Female'";
                    using (MySqlCommand femaleCmd = new MySqlCommand(femaleSql, connection))
                    {
                        femaleCount = Convert.ToInt32(femaleCmd.ExecuteScalar());
                        lblFemaleCount.Text = femaleCount.ToString();
                    }
                }

                // Force the chart to redraw with new data
                chartPanel.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrincipalDashboard_Load(object sender, EventArgs e)
        {
            UpdateFinancialData();
            AccountantDBConnection dbConnect = new AccountantDBConnection();

            // Get the count of result IDs from the exam_results table
            int resultCount = dbConnect.GetCount("SELECT COUNT(result_id) FROM exam_results");

            //Display the count in your label
            resultcount.Text = resultCount.ToString();
        }
        //private void RefreshDashboardData()
        //{
        //    AccountantDBConnection dbConnect = new AccountantDBConnection();

        //    // Update result count
        //    int resultCount = dbConnect.GetCount("SELECT COUNT(result_id) FROM exam_results");
        //    resultcount.Text = resultCount.ToString();


        //}

        private void UpdateFinancialData()
        {
            try
            {
                // Get count of exam results
                //int resultsCount = dbConnect.GetCount("SELECT COUNT(result_id) FROM exam_results");
                //resultcount.Text = resultsCount.ToString();


                // Get and display total earnings (from fee collection)
                decimal totalEarnings = dbConnect.GetDecimal("SELECT SUM(fee_amount) FROM fee_collection WHERE payment_status = 'Paid'");
                Earnings.Text = $"Rs.{totalEarnings:N0}";

                // Get and display total expenses
                decimal totalExpenses = dbConnect.GetDecimal("SELECT SUM(amount) FROM expenses WHERE status = 'Paid'");
                ExpenseCount.Text = $"Rs.{totalExpenses:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating financial data: {ex.Message}");
            }
        }

        // ... [Keep all your existing button click methods unchanged] ...


        private void button8_Click(object sender, EventArgs e)
        {
            TeacherDetailsP teacherDetailsP = new TeacherDetailsP();
            teacherDetailsP.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExpenseDetailsP expenses = new ExpenseDetailsP();
            expenses.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrincipalDashboard principalDashboard = new PrincipalDashboard();
            principalDashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDetails1 studentDetails1 = new StudentDetails1();
            studentDetails1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ExamResultP examResultP = new ExamResultP();
            examResultP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DailyAttendanceP dailyAttendanceP = new DailyAttendanceP();
            dailyAttendanceP.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Hide();
        }

        private void chartPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawDonutChart(e.Graphics);
        }

        private void DrawDonutChart(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Get panel dimensions
            int width = chartPanel.Width;
            int height = chartPanel.Height;

            // Calculate chart radius and center
            int radius = Math.Min(width, height) / 2 - 10;
            int centerX = width / 2;
            int centerY = height / 2;

            // Calculate total students
            int totalStudents = maleCount + femaleCount;

            if (totalStudents == 0)
            {
                // Draw empty circle if there are no students
                using (Pen pen = new Pen(Color.Gray, 20))
                {
                    g.DrawEllipse(pen, centerX - radius, centerY - radius, radius * 2, radius * 2);
                }
                return;
            }

            // Define colors
            Color maleColor = Color.FromArgb(255, 168, 0);    // Orange
            Color femaleColor = Color.FromArgb(43, 91, 226);  // Blue

            // Calculate angles
            float femaleAngle = (float)femaleCount / totalStudents * 360;
            float maleAngle = (float)maleCount / totalStudents * 360;

            // Draw female segment
            if (femaleCount > 0)
            {
                using (SolidBrush brush = new SolidBrush(femaleColor))
                {
                    g.FillPie(brush, centerX - radius, centerY - radius, radius * 2, radius * 2, 0, femaleAngle);
                }
            }

            // Draw male segment
            if (maleCount > 0)
            {
                using (SolidBrush brush = new SolidBrush(maleColor))
                {
                    g.FillPie(brush, centerX - radius, centerY - radius, radius * 2, radius * 2, femaleAngle, maleAngle);
                }
            }

            // Draw inner white circle (to create donut effect)
            int innerRadius = radius - 20;
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.FillEllipse(brush, centerX - innerRadius, centerY - innerRadius, innerRadius * 2, innerRadius * 2);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear the current message?", "Confirm",
     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBox2.Clear();
                _principalMessage = ""; // Clear the static variable
                                        // Optional: Also clear from Admin Dashboard
                UpdateAdminDashboard("");
                // Update Teacher Dashboard
                UpdateTeacherDashboard("");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a message", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the message in static variable for persistence
            _principalMessage = textBox2.Text;

            // Send to Admin Dashboard
            UpdateAdminDashboard(_principalMessage);
            //for teacher dashboard
            UpdateTeacherDashboard(_principalMessage);

            MessageBox.Show("Message saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateAdminDashboard(string message)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1 adminForm)
                {
                    adminForm.UpdatePrincipalMessage(message);
                    break;
                }
            }
        }
        private void UpdateTeacherDashboard(string message)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is TeacherDashboard teacherForm)
                {
                    teacherForm.UpdatePrincipalMessage(message);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void chartExpenses_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Earnings1_Click(object sender, EventArgs e)
        {

        }
    }
}