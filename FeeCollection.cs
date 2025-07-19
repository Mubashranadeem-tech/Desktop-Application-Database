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
    public partial class FeeCollection : Form
    {

        // Add connection string for MySQL database
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        private bool isCollapsed;

        public FeeCollection()
        {
            InitializeComponent();
            LoadAllFeeData();
        }

        private void FeeCollection_Load(object sender, EventArgs e)
        {

        }
        private void LoadAllFeeData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    //string query = "SELECT * FROM fee_collection";
                    string query = "SELECT student_id, fee_amount, fee_date, payment_status FROM fee_collection";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fee collection data: " + ex.Message, "Load Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchFeeById(string studentId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM fee_collection WHERE student_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", studentId);

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




        private void button2_Click(object sender, EventArgs e)
        {
            Expenses F2 = new Expenses();
            F2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeeCollection F3 = new FeeCollection();
            F3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddExpense F4 = new AddExpense();
            F4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainDashboard F3 = new MainDashboard();
            F3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accountant F3 = new Accountant();
            F3.Show();
            this.Hide();
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the character input
                MessageBox.Show("Please! enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please! enter only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string studentId = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentId))
            {
                LoadAllFeeData();
            }
            else
            {
                SearchFeeById(studentId);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
