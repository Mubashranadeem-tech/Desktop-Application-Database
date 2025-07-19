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
    public partial class ExpenseDetailsP : Form
    {
        // Add connection string for MySQL database
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        public ExpenseDetailsP()
        {
            InitializeComponent();
            LoadAllExpense();
        }
        private void LoadAllExpense()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM expenses";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading expense data: " + ex.Message, "Load Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchexpenseByserialnum(string serialnum)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM expenses WHERE Sr_No = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", serialnum);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching fee by ID: " + ex.Message, "Search Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchExpenseByDate(string feeDate)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM expenses WHERE expense_date = @date";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@date", feeDate);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching fee by date: " + ex.Message, "Search Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sirf numbers (0-9) aur Backspace allow karega
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PrincipalDashboard principalDashboard = new PrincipalDashboard();
            principalDashboard.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpenseDetailsP_Load(object sender, EventArgs e)
        {

            LoadAllExpense();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string serialnum = textBox1.Text.Trim();
            //string feeDate = textBox4.Text.Trim();


            if (!string.IsNullOrWhiteSpace(serialnum))
            {
                SearchexpenseByserialnum(serialnum);
            }
            //else if (!string.IsNullOrWhiteSpace(feeDate))
            //{
            //    SearchExpenseByDate(feeDate);
            //}
            else
            {
                LoadAllExpense();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
