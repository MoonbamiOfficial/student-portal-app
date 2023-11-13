using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal
{
    internal class Database
    {
        private static readonly string server = "localhost";
        private static readonly string user = "root";
        private static readonly string password = "";
        private static readonly string database = "stu_portal";
        private static string connString = $"server={server};user={user};database={database};password={password};";

        // Initialize connection
        public MySqlConnection mySqlConn = new MySqlConnection(connString);

        // Method to open connection
        public bool connectDb()
        {
            try
            {
                mySqlConn.Open();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Method to close connection
        public bool closeDb()
        {
            try
            {
                mySqlConn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }





    }
}
