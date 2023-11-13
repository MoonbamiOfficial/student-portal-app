using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace StudentPortal
{
    internal class Database
    {
        private static readonly string server = "localhost";
        private static readonly string user = "root";
        private static readonly string password = "";
        private static readonly string database = "stu_portal";
        private static string connString = $"server={server};user={user};database={database};password={password};";

        public void ExecuteLogin(string query, string email, string password)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                try
                {
                    mySqlConn.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand(query, mySqlConn);
                    MySqlDataReader reader = mySqlCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Check if the email and password column is empty
                        if (reader.IsDBNull(1) && reader.IsDBNull(2))
                        {
                            MessageBox.Show("Email and Password column is Empty");
                            return;
                        }
                        else
                        {
                            if (email.Equals(reader.GetString("email")) && password.Equals(reader.GetString("password")))
                            {
                                // Code for when login is successful
                                MessageBox.Show("Login Success");
                            }
                            else
                            {
                                MessageBox.Show("Login Failed invalid Email or Password");
                            }
                        }
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }finally
                {
                    mySqlConn.Close();
                }
            }

        }



    }
}
