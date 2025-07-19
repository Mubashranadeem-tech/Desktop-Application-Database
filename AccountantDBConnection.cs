//using System;
//using System.Data;
//using MySql.Data.MySqlClient;

//namespace Database_Project
//{
//    public class AccountantDBConnection
//    {
//        private MySqlConnection connection;
//        private string connectionString;

//        public AccountantDBConnection()
//        {
//            connectionString = "SERVER=localhost;DATABASE=school_management_system_try10;UID=root;PASSWORD=@KiraNMukhtiaR786;";
//            connection = new MySqlConnection(connectionString);


//        }

//        private bool OpenConnection()
//        {
//            try
//            {
//                if (connection.State != ConnectionState.Open)
//                {
//                    connection.Open();
//                }
//                return true;
//            }
//            catch (MySqlException ex)
//            {
//                Console.WriteLine(ex.Message);
//                return false;
//            }
//        }

//        private bool CloseConnection()
//        {
//            try
//            {
//                if (connection.State != ConnectionState.Closed)
//                {
//                    connection.Close();
//                }
//                return true;
//            }
//            catch (MySqlException ex)
//            {
//                Console.WriteLine(ex.Message);
//                return false;
//            }
//        }

//        public decimal GetDecimal(string query)
//        {
//            object result = GetSingleValue(query);
//            return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
//        }

//        public object GetSingleValue(string query)
//        {
//            using (MySqlConnection connection = new MySqlConnection(connectionString))
//            {
//                try
//                {
//                    connection.Open();
//                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
//                    {
//                        return cmd.ExecuteScalar();
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Database error: {ex.Message}");
//                    return 0;
//                }
//            }
//        }
//        // Add this to your AccountantDBConnection class
//        public int GetCount(string query)
//        {
//            try
//            {
//                if (OpenConnection())
//                {
//                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
//                    {
//                        object result = cmd.ExecuteScalar();
//                        CloseConnection();
//                        return result != DBNull.Value ? Convert.ToInt32(result) : 0;
//                    }
//                }
//                return 0;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error in GetCount: {ex.Message}");
//                return 0;
//            }
//        }



//    }
//}



using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Database_Project
{
    public class AccountantDBConnection
    {
        private MySqlConnection connection;
        private string connectionString;

        public AccountantDBConnection()
        {
            connectionString = "SERVER=localhost;DATABASE=school_management_system_try10;UID=root;PASSWORD=@KiraNMukhtiaR786;";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public int GetCount(string query)
        {
            try
            {
                if (OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        CloseConnection();
                        return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCount: {ex.Message}");
                return 0;
            }
        }

        public decimal GetDecimal(string query)
        {
            try
            {
                if (OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        CloseConnection();
                        return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetDecimal: {ex.Message}");
                return 0;
            }
        }
    }
}