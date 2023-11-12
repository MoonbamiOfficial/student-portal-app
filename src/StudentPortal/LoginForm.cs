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

        // Simple placeholders
        private void EmailTextbox_Enter(object sender, EventArgs e)
        {
            if (EmailTextbox.Text == emailPlaceholder || EmailTextbox.Text == emailPlaceholder.ToLower() || EmailTextbox.Text == emailPlaceholder.ToUpper())
            {
                EmailTextbox.Text = "";
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
            }
        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "")
            {
                PasswordTextbox.Text = passwordPlaceholder;
            }
        }
    }
}
