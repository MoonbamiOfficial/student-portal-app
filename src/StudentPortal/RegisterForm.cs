using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentPortal
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        // Globals
        string fnPlaceholder = "Aa";
        string mnPlaceholder = "Aa";
        string lnPlaceholder = "Aa";
        string emailPlaceholder = "student_portal@gmail.com";

        // Background panel events
        private void FirstNameBg_Click(object sender, EventArgs e)
        {
            firstNameTextbox.Focus();
        }

        private void MiddleNameBg_Click(object sender, EventArgs e)
        {
            middleNameTextbox.Focus();
        }

        private void BirthdayBg_Click(object sender, EventArgs e)
        {
            birthdayPicker.Select();

        }

        private void CourseBg_Click(object sender, EventArgs e)
        {
            courseComboBox.Focus();
        }

        private void LastNameBg_Click(object sender, EventArgs e)
        {
            lastNameTextbox.Focus();
        }

        private void EmailBg_Click(object sender, EventArgs e)
        {
            emailTextbox.Focus();
        }

        private void StatusBg_Click(object sender, EventArgs e)
        {
            statusComboBox.Focus();
        }

        private void SexBg_Click(object sender, EventArgs e)
        {
            sexComboBox.Focus();
        }


        // Label events
        private void FirstNameLabel_Click(object sender, EventArgs e)
        {
            firstNameTextbox.Focus();
        }

        private void MiddleNameLabel_Click(object sender, EventArgs e)
        {
            middleNameTextbox.Focus();
        }

        private void BirthdayLabel_Click(object sender, EventArgs e)
        {
            birthdayLabel.Focus();
        }

        private void CourseLabel_Click(object sender, EventArgs e)
        {
            courseComboBox.Show();
        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {
            lastNameTextbox.Focus();
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {
            emailTextbox.Focus();
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
            statusComboBox.Focus();
        }

        private void SexLabel_Click(object sender, EventArgs e)
        {
            sexComboBox.Focus();
        }

        // Text field events
        private void FirstNameTextbox_Click(object sender, EventArgs e)
        {
            wrongFirstNameLabel.Text = null;
        }
        private void FirstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            wrongFirstNameLabel.Text = null;        
        }
        private void LastNameTextbox_Click(object sender, EventArgs e)
        {
            wrongLastNameLabel.Text = null;
        }
        private void LastNameTextbox_TextChanged(object sender, EventArgs e)
        {
            wrongLastNameLabel.Text = null;
        }
        private void EmailTextbox_Click(object sender, EventArgs e)
        {
            wrongEmailLabel.Text = null;
        }
        private void EmailTextbox_TextChanged(object sender, EventArgs e)
        {
            wrongEmailLabel.Text = null;
        }

        // Simple placeholders
        private void FirstNameTextbox_Enter(object sender, EventArgs e)
        {
            if (firstNameTextbox.Text == fnPlaceholder || firstNameTextbox.Text == fnPlaceholder.ToLower() || firstNameTextbox.Text == fnPlaceholder.ToUpper())
            {
                firstNameTextbox.Text = "";
                wrongFirstNameLabel.Text = null;
            }
        }

        private void FirstNameTextbox_Leave(object sender, EventArgs e)
        {
            if (firstNameTextbox.Text == "")
            {
                firstNameTextbox.Text = fnPlaceholder;
            }
        }

        private void MiddleNameTextbox_Enter(object sender, EventArgs e)
        {
            if (middleNameTextbox.Text == mnPlaceholder || middleNameTextbox.Text == mnPlaceholder.ToLower() || middleNameTextbox.Text == mnPlaceholder.ToUpper())
            {
                middleNameTextbox.Text = "";
            }
        }

        private void MiddleNameTextbox_Leave(object sender, EventArgs e)
        {
            if (middleNameTextbox.Text == "")
            {
                middleNameTextbox.Text = mnPlaceholder;
            }
        }
        private void LastNameTextbox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextbox.Text == lnPlaceholder || lastNameTextbox.Text == lnPlaceholder.ToLower() || lastNameTextbox.Text == lnPlaceholder.ToUpper())
            {
                lastNameTextbox.Text = "";
                wrongLastNameLabel.Text = null;
            }
        }
        private void LastNameTextbox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextbox.Text == "")
            {
                lastNameTextbox.Text = lnPlaceholder;
            }
        }

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

        // Sign Up btn
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (firstNameTextbox.Text == fnPlaceholder || firstNameTextbox.Text == fnPlaceholder.ToLower() || firstNameTextbox.Text == fnPlaceholder.ToUpper())
            {
                wrongFirstNameLabel.Text = "* Please enter a valid first name.";
            }
            else wrongFirstNameLabel.Text = null;

            if (lastNameTextbox.Text == lnPlaceholder || lastNameTextbox.Text == lnPlaceholder.ToLower() || lastNameTextbox.Text == lnPlaceholder.ToUpper())
            {
                wrongLastNameLabel.Text = "* Please enter a valid last name.";
            }
            else wrongLastNameLabel.Text = null;

            if (emailTextbox.Text == emailPlaceholder || emailTextbox.Text == emailPlaceholder.ToLower() || emailTextbox.Text == emailPlaceholder.ToUpper())
            {
                wrongEmailLabel.Text = "* Please enter a different email.";
            }
            else wrongEmailLabel.Text = null;

            char[] emailChars = emailTextbox.Text.ToCharArray();
            if (emailTextbox.Text == emailPlaceholder || emailTextbox.Text == emailPlaceholder.ToLower() || emailTextbox.Text == emailPlaceholder.ToUpper())
            {
                wrongEmailLabel.Text = "* Please enter a different email.";
            }
            else if (!emailTextbox.Text.EndsWith("gmail.com") &&
                !emailTextbox.Text.EndsWith("yahoo.com") &&
                !emailTextbox.Text.EndsWith("email.com"))
            {
                wrongEmailLabel.Text = "* Please enter a proper domain name";
            }
            else wrongEmailLabel.Text = null;

            for (int i = 0; i < emailTextbox.Text.Length; i++)
            {
                if (!emailChars.Contains('@'))
                {
                    wrongEmailLabel.Text = "* Please enter proper a email.";
                }
            };
        }

    }
}
