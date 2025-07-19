//using System;
//using System.Data;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;


//namespace Database_Project
//{

//    public static class DatabaseConnection
//    {

//        private static string connectionString = "server=localhost; database=login; uid=root; pwd=@KiraNMukhtiaR786;";

//        public static MySqlConnection GetConnection()
//        {
//            return new MySqlConnection(connectionString);
//        }

//        public static bool TestConnection()
//        {
//            try
//            {
//                using (MySqlConnection conn = GetConnection())
//                {
//                    conn.Open();
//                    return true; // Connection successful
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Connection Error: " + ex.Message);
//                return false; // Connection failed
//            }
//        }

//        public static DataTable ExecuteQuery(string query)
//        {
//            using (MySqlConnection conn = GetConnection())
//            {
//                conn.Open();
//                MySqlCommand cmd = new MySqlCommand(query, conn);
//                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
//                DataTable dt = new DataTable();
//                adapter.Fill(dt);
//                return dt;
//            }
//        }
//    }
//}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Database_Project
{
    public static class DatabaseConnection
    {
        // Updated connection string - make sure it matches your MySQL settings
        private static string connectionString = "server=localhost; database=login; uid=root; pwd=Mubashra;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    // Add visual confirmation for debugging
                    // MessageBox.Show("Database connection successful!");
                    return true; // Connection successful
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
                return false; // Connection failed
            }
        }

        // Helper method to debug database contents
        public static void DebugLoginTable()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM login.login";
                    MessageBox.Show("Executing query: " + query);

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"Found {dt.Rows.Count} rows in login table:");

                        // List all column names first
                        sb.Append("Columns: ");
                        foreach (DataColumn col in dt.Columns)
                        {
                            sb.Append($"{col.ColumnName}, ");
                        }
                        sb.AppendLine();

                        // Then display all rows
                        foreach (DataRow row in dt.Rows)
                        {
                            sb.Append("Row: ");
                            foreach (DataColumn col in dt.Columns)
                            {
                                sb.Append($"{col.ColumnName}=[{row[col]}], ");
                            }
                            sb.AppendLine();
                        }

                        MessageBox.Show(sb.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Login table is empty!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debugging login table: " + ex.Message);
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query Error: " + ex.Message + "\nQuery: " + query);
                    return new DataTable(); // Return empty table on error
                }
            }
        }
    }
}