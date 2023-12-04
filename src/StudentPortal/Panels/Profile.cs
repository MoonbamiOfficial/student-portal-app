using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal.Panels
{
    public partial class Profile : UserControl
    {
        bool isEditable = false;
        public Profile()
        {
            InitializeComponent();
        }
        Utils u = new Utils();
        private void Profile_Load(object sender, EventArgs e)
        {
            if (StudentInfo.sex == "Female") studentIcon.Image = StudentPortal.Properties.Resources.femaleStudent;
            else if (StudentInfo.sex == "Male") studentIcon.Image = StudentPortal.Properties.Resources.maleStudent;

            studentName.Text = StudentInfo.fullname;
            studentNumber.Text = StudentInfo.stuNumber.ToString();
            studentEmail.Text = StudentInfo.email;

            emailTextbox.Text = StudentInfo.email;
            passwordTextbox.Text = StudentInfo.password;
        }
        //
        //  Label events
        //
        private void passwordLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(passwordTextbox);
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(emailTextbox);
        }

        private void confirmPasswordLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(confirmPasswordTextbox);
        }
        //
        //  BG Panel events
        //
        private void passwordBg_Click(object sender, EventArgs e)
        {
            u.setFocus(passwordTextbox);
        }

        private void emailBg_Click(object sender, EventArgs e)
        {
            u.setFocus(emailTextbox);
        }

        private void confirmPasswordBg_Click(object sender, EventArgs e)
        {
            u.setFocus(confirmPasswordTextbox);
        }
        //
        // Edit btn event
        //
        bool isClicked = false;
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (editBtn.Text.Equals("Cancel"))
            {
                emailTextbox.Text = StudentInfo.email;
                passwordTextbox.Text = StudentInfo.password;
                confirmPasswordTextbox.Text = "";
                editBtn.Text = "Edit";
                isEditable = false;
                emailTextbox.ReadOnly = true;
                passwordTextbox.ReadOnly = true;
                confirmPasswordTextbox.ReadOnly = true;
            }
            else if (isEditable == false)
            {
                emailTextbox.ReadOnly = false;
                passwordTextbox.ReadOnly = false;
                confirmPasswordTextbox.ReadOnly = false;
                editBtn.Text = "Cancel";
                isEditable = true;
            }
        }
        public void clearConfirmPasswordTxtBox()
        {
            confirmPasswordTextbox.Text = "";
        }
        // Save Button
        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;
            string confirmPassword = confirmPasswordTextbox.Text;

            // Check if the fields are null or blank.
            if ( String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password) || String.IsNullOrWhiteSpace(confirmPassword) )
            {
                MessageBox.Show("Fields cannot be empty");
                return;
            }
            Validator validator = new Validator();
            bool isSuccessful = validator.validateEmailAndPassword(emailTextbox.Text, passwordTextbox.Text, confirmPasswordTextbox.Text);
            if (isSuccessful)
            {
                studentEmail.Text = StudentInfo.email;
            }
        }
    }
}
