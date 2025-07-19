using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Admin_UI;
using MySql.Data.MySqlClient;
using Mysqlx.Notice;

namespace Database_Project
{
    public partial class TeacherDashboard : Form
    {

        private string connectionString = "server=localhost;user id=root;password=Mubashra;database=school_management_system_try10";
        public TeacherDashboard()
        {
            InitializeComponent();

            // for notice board 
            InitializeNotificationPanel();
            LoadNotifications();
        }
        // for notice board 
        private void InitializeNotificationPanel()
        {
            // Make textboxes read-only
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;

            // Set up textBox1 for principal messages
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            //textBox1.BackColor = Color.LightYellow;

            // Set up textBox2 for admin notices
            textBox2.Multiline = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            //textBox2.BackColor = Color.LightBlue;
        }

        private void LoadNotifications()
        {
            LoadPrincipalMessage();
            LoadAdminNotices();
        }

        private void LoadPrincipalMessage()
        {
            // Access the static message from PrincipalDashboard using reflection
            var field = typeof(PrincipalDashboard).GetField("_principalMessage",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            if (field != null)
            {
                string message = (string)field.GetValue(null);
                textBox1.Text = string.IsNullOrEmpty(message) ? "No message from Principal" : message;
            }
            else
            {
                textBox1.Text = "No message from Principal";
            }
        }

        private void LoadAdminNotices()
        {
            // Get all notices from NoticeManager and display them
            var notices = NoticeManager.GetAllNotices();
            if (notices.Count > 0)
            {
                StringBuilder noticeText = new StringBuilder();
                noticeText.AppendLine("📢 ADMIN NOTICES:");
                noticeText.AppendLine("═══════════════════════════════");

                foreach (var notice in notices)
                {
                    noticeText.AppendLine($"📋 {notice.Title}");
                    noticeText.AppendLine($"◊ {notice.Details}");
                    noticeText.AppendLine($"👤 {notice.PostedBy} - {notice.Date:MMM dd, yyyy}");
                    noticeText.AppendLine("─────────────────────────────");
                }
                textBox2.Text = noticeText.ToString();
            }
            else
            {
                textBox2.Text = "No notices from Admin";
            }
        }

        // Method to be called from PrincipalDashboard when message is updated
        public void UpdatePrincipalMessage(string message)
        {
            textBox1.Text = string.IsNullOrEmpty(message) ? "No message from Principal" : message;
            // _principalMessage = message;

        }

        // Method to be called from Form2 when notices are updated
        public void RefreshNotices()
        {
            LoadAdminNotices();
        }

        // Method to refresh all notifications (can be called from other forms)
        public void RefreshAllNotifications()
        {
            LoadNotifications();
        }
        private void TeacherDashboard_Load(object sender, EventArgs e)
        {

            LoadExamAverageData(); // Call pie chart initialization
            LoadClasses();
            LoadNotifications();
        }


        private void LoadClasses()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT class_id, class_name FROM classes", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> classes = new Dictionary<string, string>();
                while (reader.Read())
                {
                    classes.Add(reader["class_id"].ToString(), reader["class_name"].ToString());
                }
                select_class.DataSource = new BindingSource(classes, null);
                select_class.DisplayMember = "Value";
                select_class.ValueMember = "Key";
                con.Close();
            }
        }




        private void UpdateStudentCounts(string classId, DateTime selectedDate)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                // Total students
                MySqlCommand cmdTotal = new MySqlCommand("SELECT COUNT(*) FROM students WHERE class_id = @class_id", con);
                cmdTotal.Parameters.AddWithValue("@class_id", classId);
                int total = Convert.ToInt32(cmdTotal.ExecuteScalar());
                totalstudentcount.Text = total.ToString();

                // Absent students
                MySqlCommand cmdAbsent = new MySqlCommand("SELECT COUNT(*) FROM attendance WHERE class_id = @class_id AND date = @date AND status = 'Absent'", con);
                cmdAbsent.Parameters.AddWithValue("@class_id", classId);
                cmdAbsent.Parameters.AddWithValue("@date", selectedDate.ToString("yyyy-MM-dd"));
                int absent = Convert.ToInt32(cmdAbsent.ExecuteScalar());
                countabsentstudents.Text = absent.ToString();
            }
        }

        private void LoadExamAverageData()
        {
            string connectionString = "server=localhost;user id=root;password=Mubashra;database=school_management_system_try10;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"
                    SELECT c.class_name, AVG(r.marks_obtained) AS avg_marks
                    FROM exam_results r
                    JOIN students s ON r.student_id = s.student_id
                    JOIN classes c ON s.class_id = c.class_id
                    GROUP BY c.class_name
                    ORDER BY c.class_id;
                ";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Series series = new Series
                    {
                        ChartType = SeriesChartType.Pie,
                        IsValueShownAsLabel = true,
                        LabelForeColor = Color.Black,
                        LegendText = "#AXISLABEL"
                    };

                    Color[] customColors = new Color[]
                    {
                        Color.FromArgb(230, 230, 250), // Soft Lavender
                        Color.FromArgb(240, 255, 240), // Mint Green
                        Color.FromArgb(255, 218, 185), // Peach Puff
                        Color.FromArgb(224, 246, 255), // Baby Blue
                        Color.FromArgb(255, 228, 225), // Rose Pink
                        Color.FromArgb(255, 250, 205), // Lemon Chiffon
                        Color.FromArgb(176, 224, 230), // Powder Blue
                        Color.FromArgb(245, 222, 179), // Pale Coral
                        Color.FromArgb(204, 204, 255)  // Light Periwinkle
                    };

                    int colorIndex = 0;

                    while (reader.Read())
                    {
                        string className = reader["class_name"].ToString();
                        double avg = Convert.ToDouble(reader["avg_marks"]);

                        DataPoint point = new DataPoint
                        {
                            AxisLabel = className,
                            YValues = new double[] { avg },
                            Label = $"{avg:F1}",
                            Color = customColors[colorIndex % customColors.Length]
                        };

                        series.Points.Add(point);
                        colorIndex++;
                    }
                    chart1.Series.Clear();
                    chart1.Series.Add(series);
                    chart1.Titles.Clear();

                }
            }
        }


        private void attendance_Click(object sender, EventArgs e)
        {
            pnlDropdown.Visible = !pnlDropdown.Visible;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void markattendance_Click(object sender, EventArgs e)
        {
            DailyAttendance F3 = new DailyAttendance();
            F3.Show();
            this.Hide();
        }


        private void markleave_Click(object sender, EventArgs e)
        {
            MarkLeave markLeave = new MarkLeave();
            markLeave.Show();
            this.Hide();
        }

        private void exams_Click(object sender, EventArgs e)
        {
            exampanel.Visible = !exampanel.Visible;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MainDashboard F3 = new MainDashboard();
            F3.Show();
            this.Hide();
        }

        private void tchrDashboard_Click(object sender, EventArgs e)
        {
            TeacherDashboard F3 = new TeacherDashboard();
            F3.Show();
            this.Hide();
        }

        private void studentsearch_Click(object sender, EventArgs e)
        {
            StudentSearchT studentSearchT = new StudentSearchT();
            studentSearchT.Show();
            this.Hide();
        }



        private void lecturereport_Click(object sender, EventArgs e)
        {
            LectureReport F3 = new LectureReport();
            F3.Show();
            this.Hide();
        }

        private void sectionwiseresult_Click(object sender, EventArgs e)
        {
            ExamResult section_Wise_Result = new ExamResult();
            section_Wise_Result.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MarksEntry marksEntry = new MarksEntry();
            marksEntry.Show();
            this.Hide();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UpdateTopperStudent(string classId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT s.name, AVG(r.marks_obtained) AS avg_marks
                FROM students s
                JOIN exam_results r ON s.student_id = r.student_id
                WHERE s.class_id = @class_id
                GROUP BY s.student_id
                ORDER BY avg_marks DESC
                LIMIT 1;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@class_id", classId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                topperstudentname.Text = reader["name"].ToString();
                            }
                            else
                            {
                                topperstudentname.Text = "No topper";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching topper student: " + ex.Message);
                    topperstudentname.Text = "Error";
                }
            }
        }

        private void select_class_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (select_class.SelectedItem is KeyValuePair<string, string> selectedClass)
            {
                string classId = selectedClass.Key;

                UpdateStudentCounts(classId, select_date.Value.Date);
                UpdateTopperStudent(classId); // Add this line
            }
        }

        private void select_date_ValueChanged(object sender, EventArgs e)
        {

            if (select_class.SelectedItem is KeyValuePair<string, string> selectedClass)
            {
                UpdateStudentCounts(selectedClass.Key, select_date.Value.Date);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Total_Students_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
