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
    public partial class StudentDetails1 : Form
    {
        // Add connection string for MySQL database
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        public StudentDetails1()
        {
            InitializeComponent();
            LoadAllStudents();
        }


        private void SearchStudents(string name = "", string id = "", string className = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM students WHERE 1=1";

                    // Add conditions based on what was provided
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        query += " AND Name LIKE @name";
                    }

                    if (!string.IsNullOrWhiteSpace(id))
                    {
                        query += " AND student_id = @id"; ;
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


                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching students: " + ex.Message, "Search Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to load all students (for reset or initial load)
        private void LoadAllStudents()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM students";
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
                MessageBox.Show("Error loading students: " + ex.Message, "Load Error",
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

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDetails1 studentDetails1 = new StudentDetails1();
            studentDetails1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExpenseDetailsP expenseDetailsP = new ExpenseDetailsP();
            expenseDetailsP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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
            string name = textBox1.Text.Trim();  //name wala textbox
            string id = textBox5.Text.Trim();     //id wala
            string className = textBox2.Text.Trim(); //class wala

            // If all fields are empty, load all students
            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(id) && string.IsNullOrWhiteSpace(className))
            {
                LoadAllStudents();
            }
            else
            {
                // Otherwise, search based on the provided criteria
                SearchStudents(name, id, className);
            }
        }

        private void StudentDetails1_Load(object sender, EventArgs e)
        {
            LoadAllStudents();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
