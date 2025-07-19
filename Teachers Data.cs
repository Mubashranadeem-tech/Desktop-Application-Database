using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_Project;
using MySql.Data.MySqlClient; 
// forr sql connection
namespace Admin_UI

{

    public partial class Form5 : Form
    {
        // Add connection string for MySQL database
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        public Form5()
        {

            InitializeComponent();
            //panel2.Visible = false;
            panel3.Visible = false;

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
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            Form2 noticeBoard = new Form2();
            noticeBoard.Show();
            this.Hide();
        }
        private void StudentDropDown_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void studentdetails_Click_1(object sender, EventArgs e)
        {
            Form3 studentDetails = new Form3();
            studentDetails.Show();
            this.Hide();
        }

        private void addstudent_Click_1(object sender, EventArgs e)
        {
            Add_Student A1 = new Add_Student();
            A1.Show();
            this.Hide();
        }

        private void teacherdropdown_Click(object sender, EventArgs e)
        {
            panel5.Visible = !panel5.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 teacherDetails = new Form5();
            teacherDetails.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 addTeacher = new Form6();
            addTeacher.Show();
            this.Hide();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            // Load all teachers when the form loads
            LoadAllTeachers();
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Hide();
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

        private void Studentreport_Click(object sender, EventArgs e)
        {
            StudentReportA studentReportA = new StudentReportA();
            studentReportA.Show();
            this.Hide();
        }

        private void attendance_Click(object sender, EventArgs e)
        {
            DailyAttendanceA dailyAttendanceA = new DailyAttendanceA();
            dailyAttendanceA.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

