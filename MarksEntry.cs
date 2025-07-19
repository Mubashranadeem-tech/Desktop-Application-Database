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
    public partial class MarksEntry : Form
    {
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        //private MySqlConnection connection;
        private int currentResultId = 0;
        public MarksEntry()
        {
            InitializeComponent();
            //connection = new MySqlConnection(connectionString);
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

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarksEntry marksEntry = new MarksEntry();
            marksEntry.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fetch_Click(object sender, EventArgs e)
        {


            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(Enter_id.Text))
                {
                    MessageBox.Show("Please enter Student ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Enter_class.Text))
                {
                    MessageBox.Show("Please enter Subject Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Exam_Type.Text))
                {
                    MessageBox.Show("Please enter Exam Type.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT marks_obtained, total_marks 
                           FROM exam_results 
                           WHERE student_id = @student_id 
                           AND subject_name = @subject_name 
                           AND exam_name = @exam_name";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", Convert.ToInt32(Enter_id.Text));
                        command.Parameters.AddWithValue("@subject_name", Enter_class.Text.Trim());
                        command.Parameters.AddWithValue("@exam_name", Exam_Type.Text.Trim());

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Enter_obtained_marks.Text = reader["marks_obtained"].ToString();
                                Enter_total_marks.Text = reader["total_marks"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("No record found with the specified criteria.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Enter_obtained_marks.Clear();
                                Enter_total_marks.Clear();
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Student ID (numeric value).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate all input fields
                if (string.IsNullOrWhiteSpace(Enter_id.Text))
                {
                    MessageBox.Show("Please enter Student ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Enter_class.Text))
                {
                    MessageBox.Show("Please enter Subject Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Enter_obtained_marks.Text))
                {
                    MessageBox.Show("Please enter Obtained Marks.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Enter_total_marks.Text))
                {
                    MessageBox.Show("Please enter Total Marks.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Exam_Type.Text))
                {
                    MessageBox.Show("Please enter Exam Type.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate numeric values
                int studentId = Convert.ToInt32(Enter_id.Text);
                int obtainedMarks = Convert.ToInt32(Enter_obtained_marks.Text);
                int totalMarks = Convert.ToInt32(Enter_total_marks.Text);

                // Validate marks logic
                if (obtainedMarks > totalMarks)
                {
                    MessageBox.Show("Obtained marks cannot be greater than total marks.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (obtainedMarks < 0 || totalMarks <= 0)
                {
                    MessageBox.Show("Please enter valid marks (obtained marks >= 0, total marks > 0).", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if student exists
                    string checkStudentQuery = "SELECT COUNT(*) FROM students WHERE student_id = @student_id";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkStudentQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@student_id", studentId);
                        int studentExists = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (studentExists == 0)
                        {
                            MessageBox.Show("Student ID does not exist in the database.", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Check if record already exists
                    string checkExistQuery = @"SELECT COUNT(*) FROM exam_results 
                                     WHERE student_id = @student_id 
                                     AND subject_name = @subject_name 
                                     AND exam_name = @exam_name";

                    using (MySqlCommand checkCommand = new MySqlCommand(checkExistQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@student_id", studentId);
                        checkCommand.Parameters.AddWithValue("@subject_name", Enter_class.Text.Trim());
                        checkCommand.Parameters.AddWithValue("@exam_name", Exam_Type.Text.Trim());

                        int recordExists = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (recordExists > 0)
                        {
                            MessageBox.Show("A record with this Student ID, Subject, and Exam Type already exists. Use Edit button to modify.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new record
                    string insertQuery = @"INSERT INTO exam_results (student_id, exam_name, subject_name, marks_obtained, total_marks) 
                                 VALUES (@student_id, @exam_name, @subject_name, @marks_obtained, @total_marks)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", studentId);
                        command.Parameters.AddWithValue("@exam_name", Exam_Type.Text.Trim());
                        command.Parameters.AddWithValue("@subject_name", Enter_class.Text.Trim());
                        command.Parameters.AddWithValue("@marks_obtained", obtainedMarks);
                        command.Parameters.AddWithValue("@total_marks", totalMarks);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAllTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Student ID, Obtained Marks, and Total Marks.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertExamResult()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO exam_results 
                                   (student_id, exam_name, subject_name, marks_obtained, total_marks) 
                                   VALUES (@student_id, @exam_name, @subject_name, @marks_obtained, @total_marks)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", int.Parse(Enter_id.Text.Trim()));
                        command.Parameters.AddWithValue("@exam_name", Exam_Type.Text.Trim());
                        command.Parameters.AddWithValue("@subject_name", Enter_class.Text.Trim());
                        command.Parameters.AddWithValue("@marks_obtained", int.Parse(Enter_obtained_marks.Text.Trim()));
                        command.Parameters.AddWithValue("@total_marks", int.Parse(Enter_total_marks.Text.Trim()));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successfully!", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAllTextBoxes();
                            currentResultId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add record.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Database Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //// Get values from form fields
            //string studentId = Enter_id.Text.Trim();
            //string subjectName = Enter_class.Text.Trim();
            //string marksObtained = Enter_obtained_marks.Text.Trim();
            //string totalMarks = Enter_total_marks.Text.Trim();
            //string examName = Exam_Type.Text.Trim(); // Assuming you have a textbox for exam type

            //// Validate input
            //if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(subjectName) ||
            //    string.IsNullOrEmpty(marksObtained) || string.IsNullOrEmpty(totalMarks) ||
            //    string.IsNullOrEmpty(examName))
            //{
            //    MessageBox.Show("Please fill all required fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //try
            //{
            //    // First check if the student exists
            //    connection.Open();
            //    string checkStudentQuery = "SELECT COUNT(*) FROM students WHERE student_id = @studentId";
            //    MySqlCommand checkCmd = new MySqlCommand(checkStudentQuery, connection);
            //    checkCmd.Parameters.AddWithValue("@studentId", studentId);

            //    int studentCount = Convert.ToInt32(checkCmd.ExecuteScalar());
            //    if (studentCount == 0)
            //    {
            //        MessageBox.Show("Student ID does not exist in the database.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        connection.Close();
            //        return;
            //    }

            //    // Insert new exam result
            //    string insertQuery = "INSERT INTO exam_results (student_id, exam_name, subject_name, marks_obtained, total_marks) " +
            //                        "VALUES (@studentId, @examName, @subjectName, @marksObtained, @totalMarks)";

            //    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
            //    cmd.Parameters.AddWithValue("@studentId", studentId);
            //    cmd.Parameters.AddWithValue("@examName", examName);
            //    cmd.Parameters.AddWithValue("@subjectName", subjectName);
            //    cmd.Parameters.AddWithValue("@marksObtained", marksObtained);
            //    cmd.Parameters.AddWithValue("@totalMarks", totalMarks);

            //    int rowsAffected = cmd.ExecuteNonQuery();

            //    if (rowsAffected > 0)
            //    {
            //        MessageBox.Show("Exam result added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        ClearForm(); // Clear the form fields after successful insertion
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to add exam result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            try
            {
                // Validate all input fields
                if (string.IsNullOrWhiteSpace(Enter_id.Text))
                {
                    MessageBox.Show("Please enter Student ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Enter_class.Text))
                {
                    MessageBox.Show("Please enter Subject Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Enter_obtained_marks.Text))
                {
                    MessageBox.Show("Please enter Obtained Marks.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Enter_total_marks.Text))
                {
                    MessageBox.Show("Please enter Total Marks.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Exam_Type.Text))
                {
                    MessageBox.Show("Please enter Exam Type.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate numeric values
                int studentId = Convert.ToInt32(Enter_id.Text);
                int obtainedMarks = Convert.ToInt32(Enter_obtained_marks.Text);
                int totalMarks = Convert.ToInt32(Enter_total_marks.Text);

                // Validate marks logic
                if (obtainedMarks > totalMarks)
                {
                    MessageBox.Show("Obtained marks cannot be greater than total marks.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (obtainedMarks < 0 || totalMarks <= 0)
                {
                    MessageBox.Show("Please enter valid marks (obtained marks >= 0, total marks > 0).", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if record exists before updating
                    string checkQuery = @"SELECT COUNT(*) FROM exam_results 
                                WHERE student_id = @student_id 
                                AND subject_name = @subject_name 
                                AND exam_name = @exam_name";

                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@student_id", studentId);
                        checkCommand.Parameters.AddWithValue("@subject_name", Enter_class.Text.Trim());
                        checkCommand.Parameters.AddWithValue("@exam_name", Exam_Type.Text.Trim());

                        int recordExists = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (recordExists == 0)
                        {
                            MessageBox.Show("No record found with the specified criteria. Use Add button to create a new record.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Update existing record
                    string updateQuery = @"UPDATE exam_results 
                                 SET marks_obtained = @marks_obtained, total_marks = @total_marks 
                                 WHERE student_id = @student_id 
                                 AND subject_name = @subject_name 
                                 AND exam_name = @exam_name";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", studentId);
                        command.Parameters.AddWithValue("@subject_name", Enter_class.Text.Trim());
                        command.Parameters.AddWithValue("@exam_name", Exam_Type.Text.Trim());
                        command.Parameters.AddWithValue("@marks_obtained", obtainedMarks);
                        command.Parameters.AddWithValue("@total_marks", totalMarks);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAllTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Student ID, Obtained Marks, and Total Marks.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //// Get values from form fields
            //string studentId = Enter_id.Text.Trim();
            //string subjectName = Enter_class.Text.Trim();
            //string marksObtained = Enter_obtained_marks.Text.Trim();
            //string totalMarks = Enter_total_marks.Text.Trim();
            //string examName = Exam_Type.Text.Trim(); // Assuming you have a textbox for exam type

            //// Validate input
            //if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(subjectName) ||
            //    string.IsNullOrEmpty(marksObtained) || string.IsNullOrEmpty(totalMarks) ||
            //    string.IsNullOrEmpty(examName))
            //{
            //    MessageBox.Show("Please fill all required fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //try
            //{
            //    connection.Open();

            //    // Update exam result
            //    string updateQuery = "UPDATE exam_results SET " +
            //                        "subject_name = @subjectName, " +
            //                        "marks_obtained = @marksObtained, " +
            //                        "total_marks = @totalMarks, " +
            //                        "exam_name = @examName " +
            //                        "WHERE student_id = @studentId AND subject_name = @subjectName AND exam_name = @examName";

            //    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
            //    cmd.Parameters.AddWithValue("@studentId", studentId);
            //    cmd.Parameters.AddWithValue("@subjectName", subjectName);
            //    cmd.Parameters.AddWithValue("@marksObtained", marksObtained);
            //    cmd.Parameters.AddWithValue("@totalMarks", totalMarks);
            //    cmd.Parameters.AddWithValue("@examName", examName);

            //    int rowsAffected = cmd.ExecuteNonQuery();

            //    if (rowsAffected > 0)
            //    {
            //        MessageBox.Show("Exam result updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("No records found to update or no changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }

        // Helper method to clear form fields
        //private void ClearForm()
        //{
        //    Enter_id.Text = string.Empty;
        //    Enter_class.Text = string.Empty;
        //    Enter_obtained_marks.Text = string.Empty;
        //    Enter_total_marks.Text = string.Empty;
        //    Exam_Type.Text = string.Empty; // Assuming you have this textbox
        //}

        //// You might want to add a method to validate if the input marks are valid numbers
        //private bool ValidateMarks(string obtained, string total)
        //{
        //    if (!int.TryParse(obtained, out int obtainedMarks) || !int.TryParse(total, out int totalMarks))
        //    {
        //        MessageBox.Show("Marks must be valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    if (obtainedMarks < 0 || totalMarks <= 0 || obtainedMarks > totalMarks)
        //    {
        //        MessageBox.Show("Invalid marks. Obtained marks must be between 0 and total marks.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    return true;
        //}






        // CLEAR TEXTBOXES METHOD
        private void ClearAllTextBoxes()
        {
            Enter_id.Clear();
            Enter_class.Clear();
            Enter_obtained_marks.Clear();
            Enter_total_marks.Clear();
            Exam_Type.Clear();
        }







        private void MarksEntry_Load(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }

        private void Enter_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

