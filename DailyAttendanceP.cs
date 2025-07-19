using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_UI;
using MySql.Data.MySqlClient;

namespace Database_Project
{
    public partial class DailyAttendanceP : Form
    {
        // Add connection string for MySQL database
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        public DailyAttendanceP()
        {
            InitializeComponent();
        }

        private void tchrDashboard_Click(object sender, EventArgs e)
        {
            PrincipalDashboard F3 = new PrincipalDashboard();
            F3.Show();
            this.Hide();
        }

        private void attendance_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DailyAttendance F3 = new DailyAttendance();
            F3.Show();
            this.Hide();
        }

        private void exams_Click(object sender, EventArgs e)
        {

        }

        private void studentsearch_Click(object sender, EventArgs e)
        {
            StudentSearchT studentSearchT = new StudentSearchT();
            studentSearchT.Show();
            this.Hide();
        }


        private void markleave_Click(object sender, EventArgs e)
        {
            MarkLeave markLeave = new MarkLeave();
            markLeave.Show();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MarksEntry marksEntry = new MarksEntry();
            marksEntry.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            PrincipalDashboard principalDashboard = new PrincipalDashboard();
            principalDashboard.Show();
            this.Hide();
        }

        private void Studentdetails_Click(object sender, EventArgs e)
        {
            StudentDetails1 studentDetails1 = new StudentDetails1();
            studentDetails1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExpenseDetailsP expenseDetailsP = new ExpenseDetailsP();
            expenseDetailsP.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DailyAttendanceP dailyAttendanceP = new DailyAttendanceP();
            dailyAttendanceP.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ExamResultP examResultP = new ExamResultP();
            examResultP.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TeacherDetailsP teacherDetailsP = new TeacherDetailsP();
            teacherDetailsP.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string studentIdText = Enter_ID.Text.Trim(); // Student ID
            string classId = Enter_CLASS_ID.Text.Trim();       // Class ID

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // First, let's check if there's any data in the table
                    MySqlCommand countCmd = new MySqlCommand("SELECT COUNT(*) FROM attendance", conn);
                    int totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());

                    if (totalRecords == 0)
                    {
                        MessageBox.Show("No attendance records exist in the database yet.", "Database Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Start base query
                    string query = "SELECT attendance_id, student_id, class_id, date, status FROM attendance WHERE 1=1";

                    List<MySqlParameter> parameters = new List<MySqlParameter>();
                    bool hasFilters = false;

                    // Add student ID filter if provided
                    if (!string.IsNullOrEmpty(studentIdText))
                    {
                        // Parse student ID to int since it's INT in database
                        if (int.TryParse(studentIdText, out int studentId))
                        {
                            query += " AND student_id = @studentId";
                            parameters.Add(new MySqlParameter("@studentId", studentId));
                            hasFilters = true;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid Student ID (numbers only).");
                            return;
                        }
                    }

                    // Add class ID filter if provided
                    if (!string.IsNullOrEmpty(classId))
                    {
                        query += " AND class_id = @classId";
                        parameters.Add(new MySqlParameter("@classId", classId));
                        hasFilters = true;
                    }

                    // Add date filter only if no other filters are provided, or if user specifically wants to filter by date
                    // You can modify this logic based on your requirements
                    if (!hasFilters)
                    {
                        // If no student ID or class ID provided, use date filter
                        string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                        query += " AND date = @date";
                        parameters.Add(new MySqlParameter("@date", selectedDate));
                    }

                    // Order by most recent first
                    query += " ORDER BY  attendance_id ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add all parameters to command
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Show in DataGridView
                    dataGridView1.DataSource = dt;

                    // Show message if no records found
                    if (dt.Rows.Count == 0)
                    {
                        if (hasFilters)
                        {
                            MessageBox.Show($"No attendance records found for the specified criteria.\n\nTotal records in database: {totalRecords}", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                            MessageBox.Show($"No attendance records found for date: {selectedDate}\n\nTotal records in database: {totalRecords}\n\nTry selecting a different date or search without date filter.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Make columns more readable
                        if (dataGridView1.Columns.Count > 0)
                        {
                            dataGridView1.Columns["attendance_id"].HeaderText = "ID";
                            dataGridView1.Columns["student_id"].HeaderText = "Student ID";
                            dataGridView1.Columns["class_id"].HeaderText = "Class ID";
                            dataGridView1.Columns["date"].HeaderText = "Date";
                            dataGridView1.Columns["status"].HeaderText = "Status";

                        }


                    }
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Database Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
