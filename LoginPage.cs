//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Admin_UI;
//using MySql.Data.MySqlClient;

//namespace Database_Project
//{


//    public partial class LoginPage : Form
//    {

//        private string expectedRole;
//        public LoginPage(string role)
//        {
//            InitializeComponent();
//            expectedRole = role; // Store role passed from MainDashboard
//        }

//        private void LoginPage_Load(object sender, EventArgs e)
//        {

//        }

//        private void btnLogin_Click(object sender, EventArgs e)
//        {
//            string username = txtUsername.Text.Trim();
//            string password = txtPassword.Text.Trim();

//            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
//            {
//                MessageBox.Show("Please enter both username and password.");
//                return;
//            }

//            using (MySqlConnection conn = DatabaseConnection.GetConnection())
//            {
//                try
//                {
//                    conn.Open();

//                    string query = "SELECT role FROM login WHERE username = @username AND password = @password";
//                    MySqlCommand cmd = new MySqlCommand(query, conn);
//                    cmd.Parameters.AddWithValue("@username", username);
//                    cmd.Parameters.AddWithValue("@password", password);

//                    object result = cmd.ExecuteScalar();

//                    if (result != null)
//                    {
//                        string roleFromDB = result.ToString();

//                        // Check if the entered credentials match the selected role
//                        if (roleFromDB != expectedRole)
//                        {
//                            MessageBox.Show("Invalid username or password for the selected role.");
//                            return;
//                        }



//                        // Open respective dashboard
//                        if (roleFromDB == "admin")
//                        {
//                            this.Hide();
//                            Form1 f1 = new Form1();
//                            f1.Show();
//                        }
//                        else if (roleFromDB == "accountant")
//                        {
//                            this.Hide();
//                            Accountant accountantForm = new Accountant();
//                            accountantForm.Show();
//                        }
//                        else if (roleFromDB == "teacher")
//                        {
//                            this.Hide();
//                            TeacherDashboard teacherForm = new TeacherDashboard();
//                            teacherForm.Show();
//                        }
//                        else if (roleFromDB == "principal")
//                        {
//                            this.Hide();
//                            PrincipalDashboard principalDashboardForm = new PrincipalDashboard();
//                            principalDashboardForm.Show();
//                        }
//                        else
//                        {
//                            MessageBox.Show("Unknown role detected.");
//                        }
//                    }
//                    else
//                    {
//                        MessageBox.Show("Invalid username or password.");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("Database error: " + ex.Message);
//                }
//            }
//        }



//        private void btnLogin_EnabledChanged(object sender, EventArgs e)
//        {

//        }

//        private void checkBox1_CheckedChanged(object sender, EventArgs e)
//        {
//            // show password
//            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void pictureBox1_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
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
    public partial class LoginPage : Form
    {
        private string expectedRole;
        public LoginPage(string role)
        {
            InitializeComponent();
            expectedRole = role; // Store role passed from MainDashboard
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Test direct connection to database with the simplest possible query
            TestSimpleQuery();
        }

        private void TestSimpleQuery()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost; database=login; uid=root; pwd=Mubashra;"))
            {
                try
                {

                    // Try to get the database and table names first
                    MySqlCommand showTablesCmd = new MySqlCommand("SHOW TABLES", conn);
                    MySqlDataAdapter tablesAdapter = new MySqlDataAdapter(showTablesCmd);
                    DataTable tablesDt = new DataTable();
                    tablesAdapter.Fill(tablesDt);

                    if (tablesDt.Rows.Count > 0)
                    {
                        string tableName = tablesDt.Rows[0][0].ToString();




                        MySqlCommand dataCmd = new MySqlCommand($"SELECT * FROM {tableName}", conn);
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(dataCmd);
                        DataTable dataDt = new DataTable();
                        dataAdapter.Fill(dataDt);

                        StringBuilder data = new StringBuilder($"Table {tableName} data ({dataDt.Rows.Count} rows):\n");
                        foreach (DataRow row in dataDt.Rows)
                        {
                            data.Append("Row: ");
                            foreach (DataColumn col in dataDt.Columns)
                            {
                                data.Append($"{col.ColumnName}=[{row[col]}], ");
                            }
                            data.AppendLine();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in test query: " + ex.Message);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            //MessageBox.Show($"Attempting login with: Username='{username}', Password='{password}', Expected Role='{expectedRole}'");

            using (MySqlConnection conn = new MySqlConnection("server=localhost; database=login; uid=root; pwd=Mubashra;"))
            {
                try
                {
                    conn.Open();

                    // Try a direct query first without parameters
                    string directSql = $"SELECT * FROM login WHERE username='{username}' AND Password='{password}'";
                    //MessageBox.Show("Executing query: " + directSql);

                    MySqlCommand directCmd = new MySqlCommand(directSql, conn);
                    MySqlDataAdapter directAdapter = new MySqlDataAdapter(directCmd);
                    DataTable directResults = new DataTable();
                    directAdapter.Fill(directResults);

                    if (directResults.Rows.Count > 0)
                    {
                        // Success - found matching user
                        StringBuilder foundData = new StringBuilder("Found matching user:\n");
                        foreach (DataColumn col in directResults.Columns)
                        {
                            foundData.Append($"{col.ColumnName}=[{directResults.Rows[0][col]}], ");
                        }
                        //MessageBox.Show(foundData.ToString());

                        // Get the role
                        string roleFromDB = directResults.Rows[0]["Role"].ToString();

                        // Check if role matches expected
                        if (roleFromDB.ToLower() == expectedRole.ToLower())
                        {
                            //MessageBox.Show("Login Successful! Redirecting to " + roleFromDB + " dashboard.");

                            // Open respective dashboard
                            if (roleFromDB.ToLower() == "admin")
                            {
                                this.Hide();
                                Form1 f1 = new Form1();
                                f1.Show();
                            }
                            else if (roleFromDB.ToLower() == "accountant")
                            {
                                this.Hide();
                                Accountant accountantForm = new Accountant();
                                accountantForm.Show();
                            }
                            else if (roleFromDB.ToLower() == "teacher")
                            {
                                this.Hide();
                                TeacherDashboard teacherForm = new TeacherDashboard();
                                teacherForm.Show();
                            }
                            else if (roleFromDB.ToLower() == "principal")
                            {
                                this.Hide();
                                PrincipalDashboard principalDashboardForm = new PrincipalDashboard();
                                principalDashboardForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Unknown role detected: " + roleFromDB);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Role mismatch! Found '{roleFromDB}' but expected '{expectedRole}'");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No matching records found for these credentials.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login error: " + ex.Message);
                }
            }
        }

        private void btnLogin_EnabledChanged(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}