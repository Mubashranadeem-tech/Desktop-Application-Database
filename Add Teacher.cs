using Admin_UI;
using Database_Project;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_UI
{
    public partial class Form6 : Form
    {
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        private bool isCollapsed;
        public Form6()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel3.Visible = false;
        }
        private void Students_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }
        private void Teachers_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }
        private void Studentdetails_Click(object sender, EventArgs e)
        {
            Form3 studentDetails = new Form3();
            studentDetails.Show();
            this.Hide();
        }
        private void AddStudent_Click(object sender, EventArgs e)
        {
            Add_Student A1 = new Add_Student();
            A1.Show();
            this.Hide();
        }
        private void Teacherdetails_Click(object sender, EventArgs e)
        {
            Form5 teacherDetails = new Form5();
            teacherDetails.Show();
            this.Hide();
        }
        private void AddTeacher_Click(object sender, EventArgs e)
        {
            Form6 addTeacher = new Form6();
            addTeacher.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 noticeBoard = new Form2();
            noticeBoard.Show();
            this.Hide();
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            MainDashboard F3 = new MainDashboard();
            F3.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                MessageBox.Show("Please! enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                MessageBox.Show("Please! enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                MessageBox.Show("Please! enter only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Block invalid input
                MessageBox.Show("Please! enter only numbers and '-'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                MessageBox.Show("Please! enter only letters and numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = true; // Block invalid input
            //    MessageBox.Show("Please! enter only letters and numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void textBox3_Leave_1(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!string.IsNullOrWhiteSpace(txt.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txt.Text, pattern))
            {
                MessageBox.Show("Please enter the correct email format(example@gmail.com).", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
            }
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

        private void ADD_Click(object sender, EventArgs e)
        {
            


            try
            {
                // Validate required fields
                if (string.IsNullOrEmpty(Enter_Name.Text))
                {
                    MessageBox.Show("Teacher name is required.", "Validation Error",
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

                // Get subject ID from subject name
                int? subjectId = null;
                if (!string.IsNullOrEmpty(Enter_Subject.Text))
                {
                    subjectId = GetSubjectId(Enter_Subject.Text);
                    if (subjectId == null)
                    {
                        DialogResult result = MessageBox.Show("Subject '" + Enter_Subject.Text + "' does not exist. Would you like to create it?",
                                                           "Subject Not Found",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            subjectId = CreateNewSubject(Enter_Subject.Text);
                        }
                        else
                        {
                            Enter_Subject.Focus();
                            return;
                        }
                    }
                }

                // Validate class ID if entered
                if (!string.IsNullOrEmpty(Enter_Class.Text))
                {
                    bool classExists = CheckClassExists(Enter_Class.Text);
                    if (!classExists)
                    {
                        MessageBox.Show("The specified Class ID does not exist. Please enter a valid Class ID.",
                                      "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enter_Class.Focus();
                        return;
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

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                        INSERT INTO teachers 
                        (name, gender, class_id, subject_id, address, dob, phone_number, email, cnic) 
                        VALUES 
                        (@name, @gender, @classId, @subjectId, @address, @dob, @phoneNumber, @email, @cnic)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@name", Enter_Name.Text);
                        command.Parameters.AddWithValue("@gender", gender);

                        if (string.IsNullOrEmpty(Enter_Class.Text))
                            command.Parameters.AddWithValue("@classId", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@classId", Enter_Class.Text);

                        if (subjectId.HasValue)
                            command.Parameters.AddWithValue("@subjectId", subjectId.Value);
                        else
                            command.Parameters.AddWithValue("@subjectId", DBNull.Value);

                        command.Parameters.AddWithValue("@address",
                            string.IsNullOrEmpty(Enter_Address.Text) ? (object)DBNull.Value : Enter_Address.Text);

                        if (dob.HasValue)
                            command.Parameters.AddWithValue("@dob", dob.Value);
                        else
                            command.Parameters.AddWithValue("@dob", DBNull.Value);

                        command.Parameters.AddWithValue("@phoneNumber",
                            string.IsNullOrEmpty(Enter_Phone_no.Text) ? (object)DBNull.Value : Enter_Phone_no.Text);

                        command.Parameters.AddWithValue("@email",
                            string.IsNullOrEmpty(Enter_email.Text) ? (object)DBNull.Value : Enter_email.Text);

                        command.Parameters.AddWithValue("@cnic",
                            string.IsNullOrEmpty(Enter_cnic.Text) ? (object)DBNull.Value : Enter_cnic.Text);

                        command.ExecuteNonQuery();

                        // Get the ID of the newly inserted teacher
                        command.CommandText = "SELECT LAST_INSERT_ID()";
                        int newTeacherId = Convert.ToInt32(command.ExecuteScalar());

                        MessageBox.Show("Teacher added successfully with ID: " + newTeacherId, "Success",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear all textboxes
                        ClearTextBoxes();

                        // Set only the ID field with the new teacher ID
                        Enter_Id.Text = newTeacherId.ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate key error
                {
                    MessageBox.Show("A teacher with this information already exists.", "Duplicate Entry",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding teacher: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBoxes();
            }
        }

        private void Fetch_Click(object sender, EventArgs e)
        {
           


            try
            {
                // Get the ID from the textbox
                if (string.IsNullOrEmpty(Enter_Id.Text))
                {
                    MessageBox.Show("Please enter a teacher ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int teacherId;
                if (!int.TryParse(Enter_Id.Text, out teacherId))
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Clear text boxes before fetching new data
                ClearTextBoxes();

                // Create connection and command
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT name, gender, class_id, subject_id, address, dob, 
                                     phone_number, email, cnic FROM teachers WHERE teacher_id = @teacherId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teacherId", teacherId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the textboxes with data
                                Enter_Name.Text = reader["name"].ToString();

                                // Set the gender
                                string gender = reader["gender"].ToString();
                                if (gender == "Male")
                                    radioButton_male.Checked = true;
                                else if (gender == "Female")
                                    radioButton_female.Checked = true;

                                Enter_Class.Text = reader["class_id"].ToString();

                                // Get subject name based on subject_id
                                if (reader["subject_id"] != DBNull.Value)
                                {
                                    int subjectId = Convert.ToInt32(reader["subject_id"]);
                                    Enter_Subject.Text = GetSubjectName(subjectId);
                                }
                                else
                                {
                                    Enter_Subject.Text = string.Empty;
                                }

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

                                Enter_Phone_no.Text = reader["phone_number"].ToString();
                                Enter_email.Text = reader["email"].ToString();
                                Enter_cnic.Text = reader["cnic"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No teacher found with ID: " + teacherId, "Not Found",
                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTextBoxes();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving teacher data: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBoxes();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
           

            try
            {
                // Check if textboxes are filled (teacher data is loaded)
                if (string.IsNullOrEmpty(Enter_Id.Text) || string.IsNullOrEmpty(Enter_Name.Text))
                {
                    MessageBox.Show("Please fetch a teacher record first before attempting to edit.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int teacherId;
                if (!int.TryParse(Enter_Id.Text, out teacherId))
                {
                    MessageBox.Show("Invalid teacher ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate required fields
                if (string.IsNullOrEmpty(Enter_Name.Text))
                {
                    MessageBox.Show("Teacher name is required.", "Validation Error",
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

                // Get subject ID from subject name
                int? subjectId = null;
                if (!string.IsNullOrEmpty(Enter_Subject.Text))
                {
                    subjectId = GetSubjectId(Enter_Subject.Text);
                    if (subjectId == null)
                    {
                        DialogResult result = MessageBox.Show("Subject '" + Enter_Subject.Text + "' does not exist. Would you like to create it?",
                                                           "Subject Not Found",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            subjectId = CreateNewSubject(Enter_Subject.Text);
                        }
                        else
                        {
                            Enter_Subject.Focus();
                            return;
                        }
                    }
                }

                // Validate class ID if entered
                if (!string.IsNullOrEmpty(Enter_Class.Text))
                {
                    bool classExists = CheckClassExists(Enter_Class.Text);
                    if (!classExists)
                    {
                        MessageBox.Show("The specified Class ID does not exist. Please enter a valid Class ID.",
                                      "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enter_Class.Focus();
                        return;
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
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to update this teacher record?",
                                                         "Confirm Update",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = @"
                            UPDATE teachers 
                            SET name = @name, 
                                gender = @gender, 
                                class_id = @classId, 
                                subject_id = @subjectId, 
                                address = @address, 
                                dob = @dob, 
                                phone_number = @phoneNumber, 
                                email = @email, 
                                cnic = @cnic 
                            WHERE teacher_id = @teacherId";

                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            // Set parameters
                            command.Parameters.AddWithValue("@name", Enter_Name.Text);
                            command.Parameters.AddWithValue("@gender", gender);

                            if (string.IsNullOrEmpty(Enter_Class.Text))
                                command.Parameters.AddWithValue("@classId", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@classId", Enter_Class.Text);

                            if (subjectId.HasValue)
                                command.Parameters.AddWithValue("@subjectId", subjectId.Value);
                            else
                                command.Parameters.AddWithValue("@subjectId", DBNull.Value);

                            command.Parameters.AddWithValue("@address",
                                string.IsNullOrEmpty(Enter_Address.Text) ? (object)DBNull.Value : Enter_Address.Text);

                            if (dob.HasValue)
                                command.Parameters.AddWithValue("@dob", dob.Value);
                            else
                                command.Parameters.AddWithValue("@dob", DBNull.Value);

                            command.Parameters.AddWithValue("@phoneNumber",
                                string.IsNullOrEmpty(Enter_Phone_no.Text) ? (object)DBNull.Value : Enter_Phone_no.Text);

                            command.Parameters.AddWithValue("@email",
                                string.IsNullOrEmpty(Enter_email.Text) ? (object)DBNull.Value : Enter_email.Text);

                            command.Parameters.AddWithValue("@cnic",
                                string.IsNullOrEmpty(Enter_cnic.Text) ? (object)DBNull.Value : Enter_cnic.Text);

                            command.Parameters.AddWithValue("@teacherId", teacherId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                

                                // Clear all textboxes
                                ClearTextBoxes();
                                Enter_Id.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("Failed to update teacher record. The teacher ID may no longer exist.",
                                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                // Clear all textboxes
                                ClearTextBoxes();
                                Enter_Id.Text = string.Empty;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating teacher record: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear all textboxes
                ClearTextBoxes();
                Enter_Id.Text = string.Empty;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            


            try
            {
                // Check if textboxes are filled (teacher data is loaded)
                if (string.IsNullOrEmpty(Enter_Id.Text) || string.IsNullOrEmpty(Enter_Name.Text))
                {
                    MessageBox.Show("Please fetch a teacher record first before attempting to delete.",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int teacherId;
                if (!int.TryParse(Enter_Id.Text, out teacherId))
                {
                    MessageBox.Show("Invalid teacher ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher record?\n\n" +
                                                     "Teacher ID: " + teacherId + "\n" +
                                                     "Name: " + Enter_Name.Text,
                                                     "Confirm Deletion",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Start a transaction to ensure data integrity
                        using (MySqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                // Delete related lecture report records
                                string deleteLectureReportQuery = "DELETE FROM lecture_report WHERE teacher_id = @teacherId";
                                using (MySqlCommand command = new MySqlCommand(deleteLectureReportQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@teacherId", teacherId);
                                    command.ExecuteNonQuery();
                                }

                                // Delete the teacher record
                                string deleteTeacherQuery = "DELETE FROM teachers WHERE teacher_id = @teacherId";
                                using (MySqlCommand command = new MySqlCommand(deleteTeacherQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@teacherId", teacherId);
                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        transaction.Commit();
                                        MessageBox.Show("Teacher record deleted successfully.", "Success",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ClearTextBoxes();
                                        Enter_Id.Text = string.Empty;
                                    }
                                    else
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show("Failed to delete teacher record.", "Error",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        // Clear all textboxes even on error
                                        ClearTextBoxes();
                                        Enter_Id.Text = string.Empty;
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
                MessageBox.Show("Error deleting teacher record: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear all textboxes on error
                ClearTextBoxes();
                Enter_Id.Text = string.Empty;
            }
        }

        
        private string GetSubjectName(int subjectId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT subject_name FROM subjects WHERE subject_id = @subjectId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@subjectId", subjectId);
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;
                }
            }
        }

        
        private int? GetSubjectId(string subjectName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT subject_id FROM subjects WHERE subject_name = @subjectName";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@subjectName", subjectName);
                    object result = command.ExecuteScalar();
                    return result != null ? (int?)Convert.ToInt32(result) : null;
                }
            }
        }

        
        private int CreateNewSubject(string subjectName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO subjects (subject_name) VALUES (@subjectName); SELECT LAST_INSERT_ID();";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@subjectName", subjectName);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

       

        private bool CheckClassExists(string classId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM classes WHERE class_id = @classId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@classId", classId);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    

        private void ClearTextBoxes()
        {
            // Clear all textboxes
            Enter_Name.Text = string.Empty;
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            Enter_Class.Text = string.Empty;
            Enter_Subject.Text = string.Empty;
            Enter_Address.Text = string.Empty;
            Enter_dob.Text = string.Empty;
            Enter_Phone_no.Text = string.Empty;
            Enter_email.Text = string.Empty;
            Enter_cnic.Text = string.Empty;
        }
    }
}


