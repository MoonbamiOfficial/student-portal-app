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

        public void executeRegister(
            string fullName, string email, string password, string sex, string birthday,
            string course, int yearLevel, int semester, string status, string query = ""
            )
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                try
                {
                    query = "INSERT INTO stu_info (fullname, email, password, sex, birthday, course, yearLevel, semester, status) " +
                        "VALUES (@fullname, @email, @password, @sex, @birthday, @course, @yearLevel, @semester, @status)";
                    MySqlCommand cmd = new MySqlCommand(query, mySqlConn);
                    cmd.Parameters.AddWithValue("@fullname", fullName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@birthday", birthday);
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@yearLevel", yearLevel);
                    cmd.Parameters.AddWithValue("@semester", semester);
                    cmd.Parameters.AddWithValue("@status", status);

                    mySqlConn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected.ToString());

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public bool ExecuteLogin(string email, string password)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                try
                {
                    mySqlConn.Open();
                    string query = "SELECT * FROM stu_info WHERE Email = @email AND Password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                            // check if there is rows in the reader.
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                        {
                                    StudentInfo.fullname = reader.GetString("fullname");
                                    StudentInfo.email = reader.GetString("email");
                                    StudentInfo.sex = reader.GetString("sex");
                                    StudentInfo.birthday = reader.GetString("birthday");
                                    StudentInfo.course = reader.GetString("course");
                                    StudentInfo.yearLvl = reader.GetInt32("yearLevel");
                                    StudentInfo.semester = reader.GetInt32("semester");
                                    StudentInfo.status = reader.GetString("status");
                                    StudentInfo.stuNumber = reader.GetInt64("stu_number");
                                    StudentInfo.password = reader.GetString("password");
                                }
                                MessageBox.Show("Login Successful!");
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("No rows found in query");
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

        }



    }
}
