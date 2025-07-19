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
    public partial class StudentReportA : Form
    {
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        public StudentReportA()
        {
            InitializeComponent();
            LoadClassDropdown();
            LoadExamDropdown();
            LoadSubjectDropdown();
            // Make sure the event is connected
            select_class.SelectedIndexChanged += select_class_SelectedIndexChanged;
        }

        private void LoadSubjectDropdown()
        {
            try
            {
                select_subject.Items.Clear();
                select_subject.Items.Add(""); // Empty option for "All Subjects"

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT subject_name FROM exam_results WHERE subject_name IS NOT NULL AND subject_name != '' ORDER BY subject_name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string subjectName = reader["subject_name"].ToString();
                        if (!string.IsNullOrWhiteSpace(subjectName))
                        {
                            select_subject.Items.Add(subjectName);
                        }
                    }
                    reader.Close();
                }

                select_subject.SelectedIndex = 0; // Select empty option by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to load subjects filtered by class
        private void LoadSubjectsByClass(string className)
        {
            try
            {
                select_subject.Items.Clear();
                select_subject.Items.Add(""); // Empty option for "All Subjects"

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT DISTINCT er.subject_name 
                                   FROM exam_results er
                                   INNER JOIN students st ON er.student_id = st.student_id
                                   INNER JOIN classes c ON st.class_id = c.class_id
                                   WHERE c.class_name = @className 
                                   AND er.subject_name IS NOT NULL 
                                   AND er.subject_name != ''
                                   ORDER BY er.subject_name";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@className", className);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string subjectName = reader["subject_name"].ToString();
                        if (!string.IsNullOrWhiteSpace(subjectName))
                        {
                            select_subject.Items.Add(subjectName);
                        }
                    }
                    reader.Close();
                }

                select_subject.SelectedIndex = 0; // Select empty option by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects for class: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClassDropdown()
        {
            try
            {
                select_class.Items.Clear();
                select_class.Items.Add(""); // Empty option for "All Classes"

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT class_name FROM classes ORDER BY class_name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        select_class.Items.Add(reader["class_name"].ToString());
                    }
                    reader.Close();
                }

                select_class.SelectedIndex = 0; // Select empty option by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message);
            }
        }

        private void LoadExamDropdown()
        {
            try
            {
                select_exam.Items.Clear();
                select_exam.Items.Add(""); // Empty option for "All Exams"

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT exam_name FROM exams ORDER BY exam_name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        select_exam.Items.Add(reader["exam_name"].ToString());
                    }
                    reader.Close();
                }

                select_exam.SelectedIndex = 0; // Select empty option by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading exam names: " + ex.Message);
            }
        }


        private void logout_Click(object sender, EventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 noticeBoard = new Form2();
            noticeBoard.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = !panel4.Visible;
        }

        private void studentdetails_Click(object sender, EventArgs e)
        {
            Form3 studentDetails = new Form3();
            studentDetails.Show();
            this.Hide();
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            Add_Student A1 = new Add_Student();
            A1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Visible = !panel5.Visible;
        }

        private void teachersetails_Click(object sender, EventArgs e)
        {
            Form5 teacherDetails = new Form5();
            teacherDetails.Show();
            this.Hide();
        }

        private void addteacher_Click(object sender, EventArgs e)
        {
            Form6 addTeacher = new Form6();
            addTeacher.Show();
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

        private void search_Click(object sender, EventArgs e)
        {
            string studentIdText = Search_id.Text.Trim();
            string selectedClass = select_class.SelectedItem?.ToString();
            string selectedSubject = select_subject.SelectedItem?.ToString();
            string selectedExam = select_exam.SelectedItem?.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // First check if there's any data in the table
                    MySqlCommand countCmd = new MySqlCommand("SELECT COUNT(*) FROM exam_results", conn);
                    int totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());

                    if (totalRecords == 0)
                    {
                        MessageBox.Show("No exam results exist in the database yet.", "Database Empty",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Build dynamic query based on selected filters
                    string query = @"SELECT er.result_id, er.student_id, er.exam_name, 
                        er.subject_name, er.marks_obtained, er.total_marks,
                        c.class_name, e.exam_name
                        FROM exam_results er
                        INNER JOIN students st ON er.student_id = st.student_id
                        INNER JOIN classes c ON st.class_id = c.class_id
                        INNER JOIN exams e ON er.exam_name = e.exam_name
                        WHERE 1 = 1";

                    List<MySqlParameter> parameters = new List<MySqlParameter>();
                    bool hasFilters = false;

                    // Add student ID filter if provided
                    if (!string.IsNullOrEmpty(studentIdText))
                    {
                        if (int.TryParse(studentIdText, out int studentId))
                        {
                            query += " AND er.student_id = @studentId";
                            parameters.Add(new MySqlParameter("@studentId", studentId));
                            hasFilters = true;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid Student ID (numbers only).");
                            return;
                        }
                    }

                    // Add class filter
                    if (!string.IsNullOrEmpty(selectedClass))
                    {
                        query += " AND c.class_name = @className";
                        parameters.Add(new MySqlParameter("@className", selectedClass));
                        hasFilters = true;
                    }

                    // Add subject filter if provided
                    if (!string.IsNullOrEmpty(selectedSubject))
                    {
                        query += " AND er.subject_name = @subjectName";
                        parameters.Add(new MySqlParameter("@subjectName", selectedSubject));
                        hasFilters = true;
                    }

                    // Add exam filter if provided
                    if (!string.IsNullOrEmpty(selectedExam))
                    {
                        query += " AND e.exam_name = @examName";
                        parameters.Add(new MySqlParameter("@examName", selectedExam));
                        hasFilters = true;
                    }

                    // Order results
                    query += " ORDER BY er.student_id ASC, er.subject_name ASC";

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

                    // Show message based on results
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"No exam results found for the specified criteria.\n\nTotal records in database: {totalRecords}",
                            "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Database Error: " + sqlEx.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void select_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear and reload subjects based on selected class
            select_subject.Items.Clear();
            select_subject.Items.Add(""); // Empty option for "All Subjects"

            string selectedClass = select_class.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedClass))
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        // Get subjects that have exam results for the selected class
                        // Since subject_name is already in exam_results table, we can query directly
                        string query = @"SELECT DISTINCT er.subject_name
FROM exam_results er
INNER JOIN students st ON er.student_id = st.student_id
INNER JOIN classes c ON st.class_id = c.class_id
WHERE c.class_name = @className
ORDER BY er.subject_name";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@className", selectedClass);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            select_subject.Items.Add(reader["subject_name"].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading subjects: " + ex.Message);
                }
            }

            select_subject.SelectedIndex = 0; // Select empty option by default
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



