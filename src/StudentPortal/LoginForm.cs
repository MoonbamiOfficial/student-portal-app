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

namespace StudentPortal
{
    public partial class LoginForm : Form
    {
        private static LoginForm loginForm;
        {
            InitializeComponent();
        }

        public static LoginForm getInstance()
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
                return loginForm;
            }else
            {
                return loginForm;
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
        }

        // Globals
        string emailPlaceholder = "student_portal@gmail.com";
        string passwordPlaceholder = "Password";

        // Background panel events
        private void EmailBg_Click(object sender, EventArgs e)
        {
            EmailTextbox.Focus();
        }

        private void PasswordBg_Click(object sender, EventArgs e)
        {
            PasswordTextbox.Focus();
        }

        // Label events
        private void EmailLabel_Click(object sender, EventArgs e)
        {
            EmailTextbox.Focus();
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
            PasswordTextbox.Focus();
        }

        // Text field events
        private void EmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            WrongEmailLabel.Text = null;
        }
        private void PasswordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            WrongPasswordLabel.Text = null;
        }

        // Simple placeholders
        private void EmailTextbox_Enter(object sender, EventArgs e)
        {
            if (EmailTextbox.Text == emailPlaceholder || EmailTextbox.Text == emailPlaceholder.ToLower() || EmailTextbox.Text == emailPlaceholder.ToUpper())
            {
                EmailTextbox.Text = "";
                WrongEmailLabel.Text = null;
            }
        }

        private void EmailTextbox_Leave(object sender, EventArgs e)
        {
            if (EmailTextbox.Text == "")
            {
                EmailTextbox.Text = emailPlaceholder;
            }
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == passwordPlaceholder || PasswordTextbox.Text == passwordPlaceholder.ToLower() || PasswordTextbox.Text == passwordPlaceholder.ToUpper())
            {
                PasswordTextbox.Text = "";
                WrongPasswordLabel.Text = null;
                PasswordTextbox.UseSystemPasswordChar = true;
            }
        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "")
            {
                PasswordTextbox.Text = passwordPlaceholder;
                PasswordTextbox.UseSystemPasswordChar = true;
            }
        }

        // Login btn
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            char[] emailChars = EmailTextbox.Text.ToCharArray();
            char[] passChars = PasswordTextbox.Text.ToCharArray();

            if (EmailTextbox.Text == emailPlaceholder || EmailTextbox.Text == emailPlaceholder.ToLower() || EmailTextbox.Text == emailPlaceholder.ToUpper())
            {
                WrongEmailLabel.Text = "* Please enter a different email.";
            }
            else if (!EmailTextbox.Text.EndsWith("gmail.com") &&
                !EmailTextbox.Text.EndsWith("yahoo.com") &&
                !EmailTextbox.Text.EndsWith("email.com"))
            {
                WrongEmailLabel.Text = "* Please enter a proper domain name like (e.g yahoo.com)";
            }
            else WrongEmailLabel.Text = null;

            for (int i = 0; i < EmailTextbox.Text.Length; i++)
            {
                if (!emailChars.Contains('@'))
                {
                    WrongEmailLabel.Text = "* Please enter proper a email.";
                }
            };

            if (PasswordTextbox.Text == passwordPlaceholder || PasswordTextbox.Text == passwordPlaceholder.ToLower() || PasswordTextbox.Text == passwordPlaceholder.ToUpper())
            {
                WrongPasswordLabel.Text = "* Please enter a password";
            }

            if(PasswordTextbox.Text.Length < 8)
            {
                WrongPasswordLabel.Text = "* Please enter atleast 8 and above characters";
            }
            else if (!passChars.Contains('_') &&
                !passChars.Contains('-') &&
                !passChars.Contains('.') &&
                !passChars.Contains('*') &&
                !passChars.Contains('!') &&
                !passChars.Contains('#') &&
                !passChars.Contains('%') &&
                !passChars.Contains('%') &&
                !passChars.Contains('@'))
            {
                WrongPasswordLabel.Text = "* Low security. Please add characters like (e.g !*@#_$-%.)";
            }

            // server, user, database, password
            string connString = "server=localhost;user=root;database=stu_portal;password=";
            using ( MySqlConnection mySqlConn = new MySqlConnection(connString) ) {

                try
                {
                    mySqlConn.Open();
                    string email = EmailTextbox.Text;
                    string password = PasswordTextbox.Text;
                    string query = "SELECT * FROM student_info";
                    MySqlCommand mySqlCmd = new MySqlCommand(query, mySqlConn);
                    MySqlDataReader reader = mySqlCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (email.Equals(reader.GetString("email")) && password.Equals(reader.GetString("password")))
                        {
                            MessageBox.Show(reader.GetString("student_number"));
                        } else
                        {
                            MessageBox.Show("Login Failed");
                        }
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally { mySqlConn.Close(); }
            }


        }

        
    }
}
