using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using StudentPortal.Panels;

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
            string course, int yearLevel, int semester, string status, long stuNumber, string query = ""
            )
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                try
                {
                    query = "INSERT INTO stu_info (fullname, email, password, sex, birthday, course, yearLevel, semester, status, stu_number) " +
                        "VALUES (@fullname, @email, @password, @sex, @birthday, @course, @yearLevel, @semester, @status, @stuNumber)";
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
                    cmd.Parameters.AddWithValue("@stuNumber", stuNumber);


                    mySqlConn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Query successful rows affected: " + rowsAffected.ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { mySqlConn.Close(); }
            }
        }
        public bool isEmailAvailable(string email)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                try
                {
                    mySqlConn.Open();

                    string emailQuery = "SELECT * FROM stu_info WHERE Email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(emailQuery, mySqlConn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // if an existing email is found return true
                            if (reader.HasRows)
                                return false;
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally { mySqlConn.Close(); }
            }
        }
        public bool ExecuteLogin(string email, string password)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                try
                {
                    mySqlConn.Open();
                    string query = "SELECT * FROM stu_info WHERE BINARY Email = @email AND BINARY password = @password";
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
                                return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally { mySqlConn.Close(); }
            }
        }

        public void UpdateEmailAndPassword(string stuNumber, string email = "", string pass = "")
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                try
                {
                    mySqlConn.Open();
                    
                    // Route to Update Password Only
                    if (String.IsNullOrEmpty(email))
                    {
                        String updatePassQuery = "UPDATE stu_info SET password = @pass WHERE stu_number = @stuNumber";
                        using (MySqlCommand cmd = new MySqlCommand(updatePassQuery, mySqlConn))
                        {
                            cmd.Parameters.AddWithValue("@pass", pass);
                            cmd.Parameters.AddWithValue("@stuNumber", stuNumber);

                            // Check if query is successful
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated Successfully");
                                StudentInfo.password = pass;
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Updating Password failed error in query");
                                return;
                            }
                        }
                    }
                    // Route to Update Email Only
                    else if (String.IsNullOrEmpty(pass))
                    {
                        String updateEmailQuery = "UPDATE stu_info SET email = @email WHERE stu_number = @stuNumber";
                        using (MySqlCommand cmd = new MySqlCommand(updateEmailQuery, mySqlConn))
                        {
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@stuNumber", stuNumber);

                            // Check if query is successful
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Email updated Successfully");
                                StudentInfo.email = email;
                                var mainForm = MainForm.getInstance();
                                mainForm.setUpdatedEmail(StudentInfo.email);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Updating Email failed error in query");
                                return;
                            }
                        }
                    }
                    // Route to Update both Email and Password
                    else
                    {
                        String updateEmailAndPassQuery = "UPDATE stu_info SET email = @email, password = @pass WHERE stu_number = @stuNumber";
                        using (MySqlCommand cmd = new MySqlCommand(updateEmailAndPassQuery, mySqlConn))
                        {
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@pass", pass);
                            cmd.Parameters.AddWithValue("@stuNumber", stuNumber);

                            // Check if query is successful
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Email and Password updated Successfully");

                                StudentInfo.email = email;
                                StudentInfo.password = pass;

                                var mainForm = MainForm.getInstance();
                                mainForm.setUpdatedEmail(StudentInfo.email);

                                return;
                            }
                            else
                            {
                                MessageBox.Show("Updating Information failed error in query");
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally { mySqlConn.Close(); }
            }
        }
    }
}
