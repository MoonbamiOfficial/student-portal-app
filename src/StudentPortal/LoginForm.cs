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

        // Background panel events
        private void EmailBg_Click(object sender, EventArgs e)
        {
            EmailTextbox.Focus();
        }

        private void PasswordBg_Click(object sender, EventArgs e)
        {
            PasswordTextbox.Focus();
        }

    }
}
