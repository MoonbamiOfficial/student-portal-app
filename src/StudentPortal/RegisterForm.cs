using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentPortal
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
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
            FirstNameTextbox.Focus();
        }

        private void MiddleNameBg_Click(object sender, EventArgs e)
        {
            MiddleNameTextbox.Focus();
        }

        private void BirthdayBg_Click(object sender, EventArgs e)
        {
            BirthdayPicker.Select();

        }

        private void CourseBg_Click(object sender, EventArgs e)
        {
            CourseComboBox.Focus();
        }

        private void LastNameBg_Click(object sender, EventArgs e)
        {
            LastNameTextbox.Focus();
        }

        private void EmailBg_Click(object sender, EventArgs e)
        {
            EmailTextbox.Focus();
        }

        private void StatusBg_Click(object sender, EventArgs e)
        {
            StatusComboBox.Focus();
        }

        private void SexBg_Click(object sender, EventArgs e)
        {
            SexComboBox.Focus();
        }


        // Label events
        private void FirstNameLabel_Click(object sender, EventArgs e)
        {
            FirstNameTextbox.Focus();
        }

        private void MiddleNameLabel_Click(object sender, EventArgs e)
        {
            MiddleNameTextbox.Focus();
        }

        private void BirthdayLabel_Click(object sender, EventArgs e)
        {
            BirthdayLabel.Focus();
        }

        private void CourseLabel_Click(object sender, EventArgs e)
        {
            CourseComboBox.Show();
        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {
            LastNameTextbox.Focus();
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {
            EmailTextbox.Focus();
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
            StatusComboBox.Focus();
        }

        private void SexLabel_Click(object sender, EventArgs e)
        {
            SexComboBox.Focus();
        }

        // Text field events
        private void FirstNameTextbox_Click(object sender, EventArgs e)
        {
            WrongFirstNameLabel.Text = null;
        }
        private void FirstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            WrongFirstNameLabel.Text = null;        
        }
        private void LastNameTextbox_Click(object sender, EventArgs e)
        {
            WrongLastNameLabel.Text = null;
        }
        private void LastNameTextbox_TextChanged(object sender, EventArgs e)
        {
            WrongLastNameLabel.Text = null;
        }
        private void EmailTextbox_Click(object sender, EventArgs e)
        {
            WrongEmailLabel.Text = null;
        }
        private void EmailTextbox_TextChanged(object sender, EventArgs e)
        {
            WrongEmailLabel.Text = null;
        }

        // Simple placeholders
        private void FirstNameTextbox_Enter(object sender, EventArgs e)
        {
            if (FirstNameTextbox.Text == fnPlaceholder || FirstNameTextbox.Text == fnPlaceholder.ToLower() || FirstNameTextbox.Text == fnPlaceholder.ToUpper())
            {
                FirstNameTextbox.Text = "";
                WrongFirstNameLabel.Text = null;
            }
        }

        private void FirstNameTextbox_Leave(object sender, EventArgs e)
        {
            if (FirstNameTextbox.Text == "")
            {
                FirstNameTextbox.Text = fnPlaceholder;
            }
        }

        private void MiddleNameTextbox_Enter(object sender, EventArgs e)
        {
            if (MiddleNameTextbox.Text == mnPlaceholder || MiddleNameTextbox.Text == mnPlaceholder.ToLower() || MiddleNameTextbox.Text == mnPlaceholder.ToUpper())
            {
                MiddleNameTextbox.Text = "";
            }
        }

        private void MiddleNameTextbox_Leave(object sender, EventArgs e)
        {
            if (MiddleNameTextbox.Text == "")
            {
                MiddleNameTextbox.Text = mnPlaceholder;
            }
        }
        private void LastNameTextbox_Enter(object sender, EventArgs e)
        {
            if (LastNameTextbox.Text == lnPlaceholder || LastNameTextbox.Text == lnPlaceholder.ToLower() || LastNameTextbox.Text == lnPlaceholder.ToUpper())
            {
                LastNameTextbox.Text = "";
                WrongLastNameLabel.Text = null;
            }
        }
        private void LastNameTextbox_Leave(object sender, EventArgs e)
        {
            if (LastNameTextbox.Text == "")
            {
                LastNameTextbox.Text = lnPlaceholder;
            }
        }

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

        // Sign Up btn
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (FirstNameTextbox.Text == fnPlaceholder || FirstNameTextbox.Text == fnPlaceholder.ToLower() || FirstNameTextbox.Text == fnPlaceholder.ToUpper())
            {
                WrongFirstNameLabel.Text = "* Please enter a valid first name.";
            }
            else WrongFirstNameLabel.Text = null;

            if (LastNameTextbox.Text == lnPlaceholder || LastNameTextbox.Text == lnPlaceholder.ToLower() || LastNameTextbox.Text == lnPlaceholder.ToUpper())
            {
                WrongLastNameLabel.Text = "* Please enter a valid last name.";
            }
            else WrongLastNameLabel.Text = null;

            if (EmailTextbox.Text == emailPlaceholder || EmailTextbox.Text == emailPlaceholder.ToLower() || EmailTextbox.Text == emailPlaceholder.ToUpper())
            {
                WrongEmailLabel.Text = "* Please enter a different email.";
            }
            else WrongEmailLabel.Text = null;

            char[] emailChars = EmailTextbox.Text.ToCharArray();
            if (EmailTextbox.Text == emailPlaceholder || EmailTextbox.Text == emailPlaceholder.ToLower() || EmailTextbox.Text == emailPlaceholder.ToUpper())
            {
                WrongEmailLabel.Text = "* Please enter a different email.";
            }
            else if (!EmailTextbox.Text.EndsWith("gmail.com") &&
                !EmailTextbox.Text.EndsWith("yahoo.com") &&
                !EmailTextbox.Text.EndsWith("email.com"))
            {
                WrongEmailLabel.Text = "* Please enter a proper domain name";
            }
            else WrongEmailLabel.Text = null;

            for (int i = 0; i < EmailTextbox.Text.Length; i++)
            {
                if (!emailChars.Contains('@'))
                {
                    WrongEmailLabel.Text = "* Please enter proper a email.";
                }
            };
        }

    }
}
