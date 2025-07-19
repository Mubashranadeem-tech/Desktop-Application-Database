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
    public partial class MarkLeave : Form
    {
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";

        private Dictionary<string, string> classMap = new Dictionary<string, string>()
        {
            { "Nursery", "00" },
            { "Prep", "001" },
            { "One", "01" },
            { "Two", "02" },
            { "Three", "03" },
            { "Four", "04" },
            { "Five", "05" },
            { "Six", "06" },
            { "Seven", "07" }
        };

        private DataTable studentsTable = new DataTable();
        private DateTime attendanceDate = DateTime.Today;

        public MarkLeave()
        {
            InitializeComponent();
            LoadClassComboBox();
            SetupDataGridView();
            dateTimePickerAttendance.Value = attendanceDate;
        }

        private void LoadClassComboBox()
        {
            comboBoxClass.Items.Clear();
            foreach (var className in classMap.Keys)
            {
                comboBoxClass.Items.Add(className);
            }
            comboBoxClass.SelectedIndex = 0; // Select the first class by default
        }

        private void SetupDataGridView()
        {
            // Clear existing columns
            dataGridViewStudents.Columns.Clear();

            // Configure DataGridView properties
            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.RowHeadersVisible = false;

            // Add ID column
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.Name = "IdColumn";
            idColumn.DataPropertyName = "student_id";
            idColumn.ReadOnly = true;
            idColumn.Width = 70;
            dataGridViewStudents.Columns.Add(idColumn);

            // Add name column
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "NameColumn";
            nameColumn.DataPropertyName = "name";
            nameColumn.ReadOnly = true;
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewStudents.Columns.Add(nameColumn);

            // Add checkbox column for attendance
            DataGridViewCheckBoxColumn presentColumn = new DataGridViewCheckBoxColumn();
            presentColumn.HeaderText = "Present";
            presentColumn.Name = "PresentColumn";
            presentColumn.Width = 70;
            dataGridViewStudents.Columns.Add(presentColumn);
        }

        private void LoadStudentsByClass(string classId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get students for the selected class
                    string query = "SELECT student_id, name FROM students WHERE class_id = @ClassId ORDER BY student_id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassId", classId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    studentsTable.Clear();
                    adapter.Fill(studentsTable);

                    // Add Present column if it doesn't exist
                    if (!studentsTable.Columns.Contains("is_present"))
                    {
                        studentsTable.Columns.Add("is_present", typeof(bool));
                    }

                    // Load existing attendance data if any
                    LoadAttendanceData(classId);

                    dataGridViewStudents.DataSource = studentsTable;

                    // Show student count in label
                    labelStudentCount.Text = $"Total Students: {studentsTable.Rows.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAttendanceData(string classId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query using correct column names from your database schema
                    string query = "SELECT student_id, status FROM attendance WHERE class_id = @ClassId AND date = @AttendanceDate";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassId", classId);
                    command.Parameters.AddWithValue("@AttendanceDate", attendanceDate.ToString("yyyy-MM-dd"));

                    MySqlDataReader reader = command.ExecuteReader();

                    // Create a dictionary of student attendance
                    Dictionary<int, bool> attendanceDict = new Dictionary<int, bool>();
                    while (reader.Read())
                    {
                        int studentId = reader.GetInt32("student_id");
                        string status = reader.GetString("status");
                        bool isPresent = status.Equals("Present", StringComparison.OrdinalIgnoreCase);
                        attendanceDict[studentId] = isPresent;
                    }
                    reader.Close();

                    // Apply attendance data to the DataTable
                    foreach (DataRow row in studentsTable.Rows)
                    {
                        int studentId = Convert.ToInt32(row["student_id"]);
                        if (attendanceDict.ContainsKey(studentId))
                        {
                            row["is_present"] = attendanceDict[studentId];
                        }
                        else
                        {
                            row["is_present"] = false; // Default to absent if no record found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Just log the error but continue - might be first time taking attendance
                Console.WriteLine("Error loading attendance data: " + ex.Message);

                // Set all students to absent by default
                foreach (DataRow row in studentsTable.Rows)
                {
                    row["is_present"] = false;
                }
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            MarksEntry marksEntry = new MarksEntry();
            marksEntry.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex >= 0)
            {
                string selectedClassName = comboBoxClass.SelectedItem.ToString();
                string classId = classMap[selectedClassName];
                LoadStudentsByClass(classId);

                // Update the class name label
                labelClass.Text = $"Class: {selectedClassName}";
            }
        }

        private void buttonSaveAttendance_Click(object sender, EventArgs e)
        {

            // Validate input
            if (comboBoxClass.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a class first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridViewStudents.Rows.Count == 0)
            {
                MessageBox.Show("No students found to mark attendance.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedClassName = comboBoxClass.SelectedItem.ToString();
            string classId = classMap[selectedClassName];

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Begin transaction for data consistency
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // First, check if attendance already exists for this class and date
                        string checkQuery = "SELECT COUNT(*) FROM attendance WHERE class_id = @ClassId AND date = @AttendanceDate";
                        MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection, transaction);
                        checkCommand.Parameters.AddWithValue("@ClassId", classId);
                        checkCommand.Parameters.AddWithValue("@AttendanceDate", attendanceDate.ToString("yyyy-MM-dd"));

                        int existingRecords = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingRecords > 0)
                        {
                            // Delete existing attendance records for this class and date
                            string deleteQuery = "DELETE FROM attendance WHERE class_id = @ClassId AND date = @AttendanceDate";
                            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection, transaction);
                            deleteCommand.Parameters.AddWithValue("@ClassId", classId);
                            deleteCommand.Parameters.AddWithValue("@AttendanceDate", attendanceDate.ToString("yyyy-MM-dd"));
                            int deletedRecords = deleteCommand.ExecuteNonQuery();

                            Console.WriteLine($"Deleted {deletedRecords} existing attendance records");
                        }

                        // Insert new attendance records using correct column names
                        string insertQuery = "INSERT INTO attendance (student_id, class_id, date, status) " +
                                           "VALUES (@StudentId, @ClassId, @AttendanceDate, @Status)";

                        int recordsInserted = 0;

                        foreach (DataGridViewRow row in dataGridViewStudents.Rows)
                        {
                            if (!row.IsNewRow && row.Cells["IdColumn"].Value != null)
                            {
                                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection, transaction);

                                int studentId = Convert.ToInt32(row.Cells["IdColumn"].Value);
                                bool isPresent = row.Cells["PresentColumn"].Value != null && (bool)row.Cells["PresentColumn"].Value;
                                string status = isPresent ? "Present" : "Absent";

                                insertCommand.Parameters.AddWithValue("@StudentId", studentId);
                                insertCommand.Parameters.AddWithValue("@ClassId", classId);
                                insertCommand.Parameters.AddWithValue("@AttendanceDate", attendanceDate.ToString("yyyy-MM-dd"));
                                insertCommand.Parameters.AddWithValue("@Status", status);

                                insertCommand.ExecuteNonQuery();
                                recordsInserted++;
                            }
                        }

                        // Commit transaction
                        transaction.Commit();

                        // Show success message with details
                        string message = $"Attendance saved successfully!\n\n" +
                                       $"Class: {selectedClassName}\n" +
                                       $"Date: {attendanceDate.ToString("yyyy-MM-dd")}\n" +
                                       $"Students: {recordsInserted} records saved";

                        MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Log success
                        Console.WriteLine($"Attendance saved: {recordsInserted} records for class {selectedClassName} on {attendanceDate.ToString("yyyy-MM-dd")}");

                        // Clear all checkboxes after successful save
                        ClearAllCheckboxes();

                        // Update the attendance summary
                        ShowAttendanceSummary();
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction on error
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error saving attendance: {ex.Message}\n\n" +
                                    $"Please check your database connection and try again.";
                MessageBox.Show(errorMessage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Log the full error
                Console.WriteLine($"Database Error: {ex.ToString()}");
            }
        }

        private void buttonMarkAllPresent_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["PresentColumn"].Value = true;
                }
            }

            // Refresh the display and update summary
            dataGridViewStudents.Refresh();
            ShowAttendanceSummary();
        }

        private void buttonMarkAllAbsent_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["PresentColumn"].Value = false;
                }
            }

            // Refresh the display and update summary
            dataGridViewStudents.Refresh();
            ShowAttendanceSummary();
        }

        private void MarkLeave_Load(object sender, EventArgs e)
        {
            // Initialize form when loaded
            if (comboBoxClass.Items.Count > 0 && comboBoxClass.SelectedIndex >= 0)
            {
                string selectedClassName = comboBoxClass.SelectedItem.ToString();
                string classId = classMap[selectedClassName];
                LoadStudentsByClass(classId);
            }
        }


        // Method to get attendance summary
        private void ShowAttendanceSummary()
        {
            if (dataGridViewStudents.Rows.Count == 0) return;

            int totalStudents = 0;
            int presentCount = 0;
            int absentCount = 0;

            foreach (DataGridViewRow row in dataGridViewStudents.Rows)
            {
                if (!row.IsNewRow && row.Cells["IdColumn"].Value != null)
                {
                    totalStudents++;
                    bool isPresent = row.Cells["PresentColumn"].Value != null && (bool)row.Cells["PresentColumn"].Value;

                    if (isPresent)
                        presentCount++;
                    else
                        absentCount++;
                }
            }

            // Update the student count label with attendance summary
            labelStudentCount.Text = $"Total: {totalStudents} ";
        }



        private void dateTimePickerAttendance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClearAllCheckboxes()
        {
            foreach (DataGridViewRow row in dataGridViewStudents.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["PresentColumn"].Value = false;
                }
            }

            // Refresh the display
            dataGridViewStudents.Refresh();
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}