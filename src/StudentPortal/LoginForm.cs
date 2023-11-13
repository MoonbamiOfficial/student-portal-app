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

        private LoginForm()
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
                PasswordTextbox.UseSystemPasswordChar = false;
            }
        }
        // ------------ Wrong Email & Password label Setters ------------
        public void setWrongEmailLabel(string message)
        {
            WrongEmailLabel.Text = message;
        }
        public void setWrongPasswordLabel(string message)
        {
            WrongPasswordLabel.Text = message;
        }

        public void clearTxtField()
        {
            EmailTextbox.Text = "";
            PasswordTextbox.Text = "";
        }

        // ------------ Btn Login Method ------------
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTextbox.Text;
            string password = PasswordTextbox.Text;

            // Check if the email and password is equal to the placeholder text.
            // If true we will will return the function.
            if (email == emailPlaceholder || password == passwordPlaceholder)
            {
                WrongEmailLabel.Text = "Enter email to login";
                WrongPasswordLabel.Text = "Enter password to login";
                return;
            }
            
            Validator validator = new Validator();
            validator.validateLogin(email, password);
        }

        
    }
}
