using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm RegisterForm = new registerForm();
            RegisterForm.Show();
        }

        // Globals
        string emailPlaceholder = "student_portal@gmail.com";
        string passwordPlaceholder = "Password";

        // Background panel events
        private void EmailBg_Click(object sender, EventArgs e)
        {
            emailTextbox.Focus();
        }

        private void PasswordBg_Click(object sender, EventArgs e)
        {
            passwordTextbox.Focus();
        }

        // Label events
        private void EmailLabel_Click(object sender, EventArgs e)
        {
            emailTextbox.Focus();
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
            passwordTextbox.Focus();
        }

        // Text field events
        private void EmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            wrongEmailLabel.Text = null;
        }
        private void PasswordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            wrongPasswordLabel.Text = null;
        }

        // Simple placeholders
        private void EmailTextbox_Enter(object sender, EventArgs e)
        {
            if (emailTextbox.Text == emailPlaceholder || emailTextbox.Text == emailPlaceholder.ToLower() || emailTextbox.Text == emailPlaceholder.ToUpper())
            {
                emailTextbox.Text = "";
                wrongEmailLabel.Text = null;
            }
        }

        private void EmailTextbox_Leave(object sender, EventArgs e)
        {
            if (emailTextbox.Text == "")
            {
                emailTextbox.Text = emailPlaceholder;
            }
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == passwordPlaceholder || passwordTextbox.Text == passwordPlaceholder.ToLower() || passwordTextbox.Text == passwordPlaceholder.ToUpper())
            {
                passwordTextbox.Text = "";
                wrongPasswordLabel.Text = null;
                passwordTextbox.UseSystemPasswordChar = true;
            }
        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "")
            {
                passwordTextbox.Text = passwordPlaceholder;
                passwordTextbox.UseSystemPasswordChar = true;
            }
        }

        // Login btn
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            char[] emailChars = emailTextbox.Text.ToCharArray();
            char[] passChars = passwordTextbox.Text.ToCharArray();

            if (emailTextbox.Text == emailPlaceholder || emailTextbox.Text == emailPlaceholder.ToLower() || emailTextbox.Text == emailPlaceholder.ToUpper())
            {
                wrongEmailLabel.Text = "* Please enter a different email.";
            }
            else if (!emailTextbox.Text.EndsWith("gmail.com") &&
                !emailTextbox.Text.EndsWith("yahoo.com") &&
                !emailTextbox.Text.EndsWith("email.com"))
            {
                wrongEmailLabel.Text = "* Please enter a proper domain name like (e.g yahoo.com)";
            }
            else wrongEmailLabel.Text = null;

            for (int i = 0; i < emailTextbox.Text.Length; i++)
            {
                if (!emailChars.Contains('@'))
                {
                    wrongEmailLabel.Text = "* Please enter proper a email.";
                }
            };

            if (passwordTextbox.Text == passwordPlaceholder || passwordTextbox.Text == passwordPlaceholder.ToLower() || passwordTextbox.Text == passwordPlaceholder.ToUpper())
            {
                wrongPasswordLabel.Text = "* Please enter a password";
            }

            if(passwordTextbox.Text.Length < 8)
            {
                wrongPasswordLabel.Text = "* Please enter atleast 8 and above characters";
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
                wrongPasswordLabel.Text = "* Low security. Please add characters like (e.g !*@#_$-%.)";
            }
            
        }

        
    }
}
