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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Database_Project
{
    public partial class ExamResult : Form
    {
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";

        public ExamResult()
        {
            InitializeComponent();

            // Load all dropdowns in the correct order
            LoadClassDropdown();
            LoadExamDropdown();
            LoadSubjectDropdown();

            // Attach event handlers after loading data
            select_class.SelectedIndexChanged += select_class_SelectedIndexChanged;
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
                MessageBox.Show("Error loading classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string query = "SELECT DISTINCT exam_name FROM exam_results WHERE exam_name IS NOT NULL AND exam_name != '' ORDER BY exam_name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string examName = reader["exam_name"].ToString();
                        if (!string.IsNullOrWhiteSpace(examName))
                        {
                            select_exam.Items.Add(examName);
                        }
                    }
                    reader.Close();
                }

                select_exam.SelectedIndex = 0; // Select empty option by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading exam names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button3_Click(object sender, EventArgs e)
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

        private void markattendance_Click(object sender, EventArgs e)
        {
            DailyAttendance F3 = new DailyAttendance();
            F3.Show();
            this.Hide();
        }

        private void attendance_Click(object sender, EventArgs e)
        {
            pnlDropdown.Visible = !pnlDropdown.Visible;
        }

        private void exams_Click(object sender, EventArgs e)
        {
            exampanel.Visible = !exampanel.Visible;
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

        private void Section_wise_result_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarksEntry marksEntry = new MarksEntry();
            marksEntry.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
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

                    string query = @"SELECT er.result_id, er.student_id,  
                                   er.subject_name, er.marks_obtained, er.total_marks,
                                   c.class_name, er.exam_name
                                   FROM exam_results er
                                   INNER JOIN students st ON er.student_id = st.student_id
                                   INNER JOIN classes c ON st.class_id = c.class_id
                                   WHERE 1=1";

                    List<MySqlParameter> parameters = new List<MySqlParameter>();

                    // Add student ID filter if provided
                    if (!string.IsNullOrEmpty(studentIdText))
                    {
                        if (int.TryParse(studentIdText, out int studentId))
                        {
                            query += " AND er.student_id = @studentId";
                            parameters.Add(new MySqlParameter("@studentId", studentId));
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid Student ID (numbers only).", "Invalid Input",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Add class filter
                    if (!string.IsNullOrEmpty(selectedClass))
                    {
                        query += " AND c.class_name = @className";
                        parameters.Add(new MySqlParameter("@className", selectedClass));
                    }

                    // Add subject filter if provided
                    if (!string.IsNullOrEmpty(selectedSubject))
                    {
                        query += " AND er.subject_name = @subjectName";
                        parameters.Add(new MySqlParameter("@subjectName", selectedSubject));
                    }

                    // Add exam filter if provided
                    if (!string.IsNullOrEmpty(selectedExam))
                    {
                        query += " AND er.exam_name LIKE @examName";
                        parameters.Add(new MySqlParameter("@examName", "%" + selectedExam.Replace(" ", "%") + "%"));
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
                    else
                    {
                        // Optional: Show count of found records
                        // MessageBox.Show($"Found {dt.Rows.Count} exam result(s).", "Search Results", 
                        //               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Database Error: " + sqlEx.Message, "Database Error",
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
            string selectedClass = select_class.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedClass))
            {
                // Load subjects filtered by the selected class
                LoadSubjectsByClass(selectedClass);
            }
            else
            {
                // If no specific class is selected (empty option), load all subjects
                LoadSubjectDropdown();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}