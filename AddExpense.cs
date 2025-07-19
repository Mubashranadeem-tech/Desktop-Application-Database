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
using MySql.Data.MySqlClient;

namespace Database_Project
{
    public partial class AddExpense : Form
    {
        private string connectionString = "server=localhost;database=school_management_system_try10;uid=root;pwd=Mubashra;";
        private bool isCollapsed;
        public AddExpense()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FeeCollection F3 = new FeeCollection();
            F3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Expenses F2 = new Expenses();
            F2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddExpense F4 = new AddExpense();
            F4.Show();
            this.Hide();
        }

        private void AddExpense_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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


        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please! enter only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the character input
                MessageBox.Show("Please! enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Block invalid input
                MessageBox.Show("Please! enter only numbers and '-'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the character input
                MessageBox.Show("Please! enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fetch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Sr_no.Text))
                {
                    MessageBox.Show("Please enter Sr No to fetch data.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM expenses WHERE Sr_No = @srno";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@srno", Sr_no.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Enter_name.Text = reader["name"].ToString();
                        Enter_amount.Text = reader["amount"].ToString();
                        Enter_phone_no.Text = reader["phone_number"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader["expense_date"]);
                        expense_type.Text = reader["expense_type"].ToString();

                       
                    }
                    else
                    {
                        MessageBox.Show("No record found with this Sr No.");
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Enter_name.Text) || string.IsNullOrEmpty(Enter_amount.Text))
                {
                    MessageBox.Show("Please fill Name and Amount fields.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO expenses (name, amount, expense_date, status, expense_type, phone_number) 
                                   VALUES (@name, @amount, @date, 'Unpaid', @expensetype, @phone)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", Enter_name.Text);
                    cmd.Parameters.AddWithValue("@amount", decimal.Parse(Enter_amount.Text));
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@expensetype", expense_type.Text);
                    cmd.Parameters.AddWithValue("@phone", Enter_phone_no.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Record added successfully!");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add record.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Sr_no.Text))
                {
                    MessageBox.Show("Please enter Sr No to edit record.");
                    return;
                }

                if (string.IsNullOrEmpty(Enter_name.Text) || string.IsNullOrEmpty(Enter_amount.Text))
                {
                    MessageBox.Show("Please fill Name and Amount fields.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE expenses SET 
                           name = @name, 
                           amount = @amount, 
                           expense_date = @date, 
                           expense_type = @expensetype, 
                           phone_number = @phone 
                           WHERE Sr_No = @srno";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", Enter_name.Text);
                    cmd.Parameters.AddWithValue("@amount", decimal.Parse(Enter_amount.Text));
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@expensetype", expense_type.Text);
                    cmd.Parameters.AddWithValue("@phone", Enter_phone_no.Text);
                    cmd.Parameters.AddWithValue("@srno", Sr_no.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        
                        ClearFields(); // Clear all fields after successful update
                    }
                    else
                    {
                        MessageBox.Show("No record found to update or update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Sr_no.Text))
                {
                    MessageBox.Show("Please enter Sr No to delete record.");
                    return;
                }

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM expenses WHERE Sr_No = @srno";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@srno", Sr_no.Text);

                        int deleteResult = cmd.ExecuteNonQuery();

                        if (deleteResult > 0)
                        {
                            MessageBox.Show("Record deleted successfully!");
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No record found to delete.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            Sr_no.Text = "";
            Enter_name.Text = "";
            Enter_amount.Text = "";
            Enter_phone_no.Text = "";
            expense_type.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
    }

}
