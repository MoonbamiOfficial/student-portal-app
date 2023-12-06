using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using StudentPortal.Panels;

namespace StudentPortal
{
    public partial class LoginForm : Form
    {
        private static LoginForm loginForm;

        public LoginForm()
        {
            InitializeComponent();
        }
        Utils u = new Utils();
        public static LoginForm getInstance()
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
                return loginForm;
            } else
            {
                return loginForm;
            }
        }
        private void LoginForm_Activated(object sender, EventArgs e)
        {
            emailTextbox.Focus();
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            emailTextbox.Text = "";
            passwordTextbox.Text = "";
            wrongEmailLabel.Text = "";
            wrongPasswordLabel.Text = "";
            passwordTextbox.PasswordChar = '●';
            eyeIcon.IconChar = IconChar.Eye;
            Forms.registerForm.Show();
        }
        //
        //  Click label events
        //
        private void emailLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(emailTextbox);
        }
        private void passwordLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(passwordTextbox);
        }
        //
        //  Click bg panel events
        //
        private void emailBg_Click(object sender, EventArgs e)
        {
            u.setFocus(emailTextbox);
        }
        private void passwordBg_Click(object sender, EventArgs e)
        {
            u.setFocus(passwordTextbox);
        }
        // Resets the wrong input label when input fields are clicked

        private void emailTextbox_Enter(object sender, EventArgs e)
        {
            wrongEmailLabel.Text = "";
        }

        private void passwordTextbox_Enter(object sender, EventArgs e)
        {
            wrongPasswordLabel.Text = "";
        }

        // ------------ Wrong Email & Password label Setters ------------
        public void setWrongEmailLabel(string message)
        {
            wrongEmailLabel.Text = message;
        }
        public void setWrongPasswordLabel(string message)
        {
            wrongPasswordLabel.Text = message;
        }

        public void clearTxtField()
        {
            emailTextbox.Text = "";
            passwordTextbox.Text = "";
        }

        // ------------ Btn Login Method ------------
        public void clearInputs()
        {
            emailTextbox.Clear();
            passwordTextbox.Clear();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;

            Validator validator = new Validator();
            validator.validateLogin(email, password);

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        //
        //  Eye btn 
        //

        private void eyeIcon_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (passwordTextbox.PasswordChar == '●' && eyeIcon.IconChar == IconChar.Eye)
            {
                passwordTextbox.Focus();
                passwordTextbox.PasswordChar = '\0';
                eyeIcon.IconChar = IconChar.EyeSlash;
                
            }
            else if (passwordTextbox.PasswordChar == '\0' && eyeIcon.IconChar == IconChar.EyeSlash)
            {
                passwordTextbox.Focus();
                passwordTextbox.PasswordChar = '●';
                eyeIcon.IconChar = IconChar.Eye;
            }
        }
    }
}
