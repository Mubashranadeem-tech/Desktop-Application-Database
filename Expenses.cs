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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Database_Project
{
    public partial class Expenses : Form
    {

        // Add connection string for MySQL database
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        private bool isCollapsed;
        public Expenses()
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
        private void Expenses_Load(object sender, EventArgs e)
        {
            LoadAllExpense();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please! enter only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       


        private void button3_Click(object sender, EventArgs e)
        {
            Expenses F2 = new Expenses();
            F2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FeeCollection F3 = new FeeCollection();
            F3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddExpense F4 = new AddExpense();
            F4.Show();
            this.Hide();
        }


        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            MainDashboard F3 = new MainDashboard();
            F3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accountant F3 = new Accountant();
            F3.Show();
            this.Hide();
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
    }
}

