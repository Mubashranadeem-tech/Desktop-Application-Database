using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_Project;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin_UI
{
    public partial class Add_Student : Form
    {
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        public Add_Student()
        {

            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 noticeBoard = new Form2();
            noticeBoard.Show();
            this.Hide();
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            Add_Student A1 = new Add_Student();
            A1.Show();
            this.Hide();
        }

        private void StudentDropDown_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void teacherdropdown_Click(object sender, EventArgs e)
        {
            panel5.Visible = !panel5.Visible;
        }
        private void studentdetails_Click(object sender, EventArgs e)
        {
            Form3 studentDetails = new Form3();
            studentDetails.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MainDashboard F3 = new MainDashboard();
            F3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 teacherDetails = new Form5();
            teacherDetails.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form6 addTeacher = new Form6();
            addTeacher.Show();
            this.Hide();
        }

        private void Studentreport_Click(object sender, EventArgs e)
        {
            StudentReportA studentReportA = new StudentReportA();
            studentReportA.Show();
            this.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the character input
                MessageBox.Show("Please! enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the character input
                MessageBox.Show("Please! enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please! enter only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                MessageBox.Show("Please! enter only letters and numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Block invalid input
                MessageBox.Show("Please! enter only numbers and '-'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            //TextBox txt = sender as TextBox;
            //string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            //if (!string.IsNullOrWhiteSpace(txt.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txt.Text, pattern))
            //{
            //    MessageBox.Show("Please enter the correct email format(example@gmail.com).", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt.Focus();
            //}
        }

        private void attendance_Click(object sender, EventArgs e)
        {
            DailyAttendanceA dailyAttendanceA = new DailyAttendanceA();
            dailyAttendanceA.Show();
            this.Hide();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                MessageBox.Show("Please! enter only letters and numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate all required fields are filled
                if (string.IsNullOrWhiteSpace(Enter_Id.Text) ||
                    string.IsNullOrWhiteSpace(Enter_Name.Text) ||
                    (!radioButton_male.Checked && !radioButton_female.Checked) ||
                    string.IsNullOrWhiteSpace(Enter_Father_name.Text) ||
                    string.IsNullOrWhiteSpace(Enter_Class.Text) ||
                    string.IsNullOrWhiteSpace(Enter_Address.Text) ||
                    string.IsNullOrWhiteSpace(Enter_dob.Text) ||
                    string.IsNullOrWhiteSpace(Enter_phone_no.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Please fill all the data", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create database connection
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // First verify if the class exists
                    string verifyClassQuery = "SELECT class_id FROM classes WHERE class_id = @classId";
                    using (MySqlCommand verifyClassCmd = new MySqlCommand(verifyClassQuery, connection))
                    {
                        verifyClassCmd.Parameters.AddWithValue("@classId", Enter_Class.Text);
                        object result = verifyClassCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Invalid Class ID. Please enter a valid class.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Create SQL insert command
                    string insertQuery = @"INSERT INTO students 
                                  (student_id, name, gender, father_name, class_id, address, dob, phone_number, email) 
                                  VALUES 
                                  (@studentId, @name, @gender, @fatherName, @classId, @address, @dob, @phoneNumber, @email)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        // Parse student ID - if it's auto-increment, modify as needed
                        // If auto-increment is being used, you would typically remove this parameter
                        // and modify the SQL to not include student_id in the column list
                        cmd.Parameters.AddWithValue("@studentId", Enter_Id.Text);
                        cmd.Parameters.AddWithValue("@name", Enter_Name.Text);
                        // Get selected gender
                        string gender = radioButton_male.Checked ? "Male" : "Female";
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@fatherName", Enter_Father_name.Text);
                        cmd.Parameters.AddWithValue("@classId", Enter_Class.Text);
                        cmd.Parameters.AddWithValue("@address", Enter_Address.Text);

                        // Parse date of birth - assumes format is yyyy-MM-dd
                        DateTime dob;
                        if (DateTime.TryParse(Enter_dob.Text, out dob))
                        {
                            cmd.Parameters.AddWithValue("@dob", dob.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            MessageBox.Show("Invalid date format. Please use YYYY-MM-DD format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        cmd.Parameters.AddWithValue("@phoneNumber", Enter_phone_no.Text);
                        cmd.Parameters.AddWithValue("@email", textBox3.Text);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm(); // Method to clear the form fields after successful insertion
                        }
                        else
                        {
                            MessageBox.Show("Failed to add student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle specific database errors
                if (ex.Number == 1062) // Duplicate entry error
                {
                    MessageBox.Show("A student with this ID already exists.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 1452) // Foreign key constraint failure
                {
                    MessageBox.Show("Invalid Class ID. Please enter a valid class.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle other general exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if textboxes are filled (student data is loaded)
                if (string.IsNullOrEmpty(Enter_Id.Text) || string.IsNullOrEmpty(Enter_Name.Text))
                {
                    MessageBox.Show("Please fetch a student record first before attempting to delete.",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int studentId;
                if (!int.TryParse(Enter_Id.Text, out studentId))
                {
                    MessageBox.Show("Invalid student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student record?\n\n" +
                                                     "Student ID: " + studentId + "\n" +
                                                     "Name: " + Enter_Name.Text,
                                                     "Confirm Deletion",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // First need to check and delete related records in other tables
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Start a transaction to ensure data integrity
                        using (MySqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                // Delete related attendance records
                                string deleteAttendanceQuery = "DELETE FROM attendance WHERE student_id = @studentId";
                                using (MySqlCommand command = new MySqlCommand(deleteAttendanceQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@studentId", studentId);
                                    command.ExecuteNonQuery();
                                }

                                // Delete related fee collection records
                                string deleteFeeQuery = "DELETE FROM fee_collection WHERE student_id = @studentId";
                                using (MySqlCommand command = new MySqlCommand(deleteFeeQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@studentId", studentId);
                                    command.ExecuteNonQuery();
                                }

                                // Delete related exam results
                                string deleteExamResultsQuery = "DELETE FROM exam_results WHERE student_id = @studentId";
                                using (MySqlCommand command = new MySqlCommand(deleteExamResultsQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@studentId", studentId);
                                    command.ExecuteNonQuery();
                                }

                                // Finally, delete the student record
                                string deleteStudentQuery = "DELETE FROM students WHERE student_id = @studentId";
                                using (MySqlCommand command = new MySqlCommand(deleteStudentQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@studentId", studentId);
                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        transaction.Commit();

                                        ClearForm();
                                        Enter_Id.Text = string.Empty;
                                    }
                                    else
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show("Failed to delete student record.", "Error",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw new Exception("Transaction failed: " + ex.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student record: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Fetch_Click(object sender, EventArgs e)
        {

            try
            {
                // Get the ID from the textbox
                if (string.IsNullOrEmpty(Enter_Id.Text))
                {
                    MessageBox.Show("Please enter a student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int studentId;
                if (!int.TryParse(Enter_Id.Text, out studentId))
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create connection and command
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT name, gender, father_name, class_id, address, dob, 
                                     phone_number, email FROM students WHERE student_id = @studentId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentId", studentId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the textboxes with data
                                Enter_Name.Text = reader["name"].ToString();

                                // Set the gender radio button
                                string gender = reader["gender"].ToString();
                                if (gender == "Male")
                                    radioButton_male.Checked = true;
                                else if (gender == "Female")
                                    radioButton_female.Checked = true;

                                Enter_Father_name.Text = reader["father_name"].ToString();
                                Enter_Class.Text = reader["class_id"].ToString();
                                Enter_Address.Text = reader["address"].ToString();

                                // Handle date format for DOB
                                if (reader["dob"] != DBNull.Value)
                                {
                                    DateTime dob = Convert.ToDateTime(reader["dob"]);
                                    Enter_dob.Text = dob.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    Enter_dob.Text = string.Empty;
                                }

                                Enter_phone_no.Text = reader["phone_number"].ToString();
                                textBox3.Text = reader["email"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No student found with ID: " + studentId, "Not Found",
                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student data: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if textboxes are filled (student data is loaded)
                if (string.IsNullOrEmpty(Enter_Id.Text) || string.IsNullOrEmpty(Enter_Name.Text))
                {
                    MessageBox.Show("Please fetch a student record first before attempting to edit.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int studentId;
                if (!int.TryParse(Enter_Id.Text, out studentId))
                {
                    MessageBox.Show("Invalid student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate required fields
                if (string.IsNullOrEmpty(Enter_Name.Text))
                {

                    MessageBox.Show("Student name is required.", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Enter_Name.Focus();
                    return;
                }

                if (!radioButton_male.Checked && !radioButton_female.Checked)
                {
                    MessageBox.Show("Please select gender.", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get gender value
                string gender = radioButton_male.Checked ? "Male" : "Female";

                // Check if class exists
                if (!string.IsNullOrEmpty(Enter_Class.Text))
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string checkClassQuery = "SELECT COUNT(*) FROM classes WHERE class_id = @classId";
                        using (MySqlCommand command = new MySqlCommand(checkClassQuery, connection))
                        {
                            command.Parameters.AddWithValue("@classId", Enter_Class.Text);
                            int classCount = Convert.ToInt32(command.ExecuteScalar());

                            if (classCount == 0)
                            {
                                MessageBox.Show("The specified Class ID does not exist. Please enter a valid Class ID.",
                                             "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Enter_Class.Focus();
                                return;
                            }
                        }
                    }
                }

                // Parse date if provided
                DateTime? dob = null;
                if (!string.IsNullOrEmpty(Enter_dob.Text))
                {
                    try
                    {
                        dob = DateTime.Parse(Enter_dob.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid date format for Date of Birth. Please use YYYY-MM-DD format.",
                                      "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enter_dob.Focus();
                        return;
                    }
                }

                // Confirm update
                DialogResult result = MessageBox.Show("Are you sure you want to update this student record?",
                                                    "Confirm Update",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = @"
                            UPDATE students 
                            SET name = @name, 
                                gender = @gender, 
                                father_name = @fatherName, 
                                class_id = @classId, 
                                address = @address, 
                                dob = @dob, 
                                phone_number = @phoneNumber, 
                                email = @email 
                            WHERE student_id = @studentId";


                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@name", Enter_Name.Text);
                            command.Parameters.AddWithValue("@gender", gender);
                            command.Parameters.AddWithValue("@fatherName", Enter_Father_name.Text ?? (object)DBNull.Value);

                            if (string.IsNullOrEmpty(Enter_Class.Text))
                                command.Parameters.AddWithValue("@classId", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@classId", Enter_Class.Text);

                            command.Parameters.AddWithValue("@address", Enter_Address.Text ?? (object)DBNull.Value);

                            if (dob.HasValue)
                                command.Parameters.AddWithValue("@dob", dob.Value);
                            else
                                command.Parameters.AddWithValue("@dob", DBNull.Value);

                            command.Parameters.AddWithValue("@phoneNumber", Enter_phone_no.Text ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@email", textBox3.Text ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@studentId", studentId);

                            int rowsAffected = command.ExecuteNonQuery();


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student record: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Helper method to clear the form after successful insertion
        private void ClearForm()
        {
            // Clear all form fields
            Enter_Id.Clear();
            Enter_Name.Clear();
            // Clear radio button selection
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            Enter_Father_name.Clear();
            Enter_Class.Clear();
            Enter_Address.Clear();
            Enter_dob.Clear();
            Enter_phone_no.Clear();
            textBox3.Clear();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
