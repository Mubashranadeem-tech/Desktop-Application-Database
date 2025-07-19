using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database_Project
{
    public partial class TeacherDetailsP : Form
    {
        // Add connection string for MySQL database
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        public TeacherDetailsP()
        {
            InitializeComponent();
            // Load all teachers when the form loads
            LoadAllTeachers();
        }
        private void SearchTeachers(string name = "", string id = "", string className = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM teachers WHERE 1=1";

                    // Add conditions based on what was provided
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        query += " AND Name LIKE @name";
                    }

                    if (!string.IsNullOrWhiteSpace(id))
                    {
                        query += " AND teacher_id = @id";
                    }

                    if (!string.IsNullOrWhiteSpace(className))
                    {
                        query += " AND class_id LIKE @class";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters if needed
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(id))
                    {
                        // Try parsing if student_id is INT
                        if (int.TryParse(id, out int parsedId))
                        {
                            cmd.Parameters.AddWithValue("@id", parsedId);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id", id); // If it's string like 'S123'
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(className))
                    {
                        cmd.Parameters.AddWithValue("@class", "%" + className + "%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Assuming you have a DataGridView named dataGridView1
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching teachers: " + ex.Message, "Search Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to load all teachers (for reset or initial load)
        private void LoadAllTeachers()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM teachers";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Assuming you have a DataGridView named dataGridView1
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teachers: " + ex.Message, "Load Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the character input
                MessageBox.Show("Please! enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please! enter only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                MessageBox.Show("Please! enter only letters and numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrincipalDashboard principalDashboard = new PrincipalDashboard();
            principalDashboard.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StudentDetails1 studentDetails1 = new StudentDetails1();
            studentDetails1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ExpenseDetailsP expenses = new ExpenseDetailsP();
            expenses.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
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
            // Get values from search textboxes
            // Update these textbox names according to your form
            string name = textBox1.Text.Trim();  // Assuming textBox1 is for Name search
            string id = textBox5.Text.Trim();    // Assuming textBox2 is for ID search  
            string className = textBox2.Text.Trim(); // Assuming textBox3 is for Class search

            // If all fields are empty, load all teachers
            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(id) && string.IsNullOrWhiteSpace(className))
            {
                LoadAllTeachers();
            }
            else
            {
                // Otherwise, search based on the provided criteria
                SearchTeachers(name, id, className);
            }
        }

        private void TeacherDetailsP_Load(object sender, EventArgs e)
        {
            // Load all teachers when the form loads
            LoadAllTeachers();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
