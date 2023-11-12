using System;
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
    }
}
