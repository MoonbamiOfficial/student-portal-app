using StudentPortal.Panels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentPortal
{
    public partial class RegisterForm : Form
    {
        private static RegisterForm registerForm;
        public RegisterForm()
        {
            InitializeComponent();
        }
        public static RegisterForm getInstance()
        {
            if (registerForm == null)
            {
                registerForm = new RegisterForm();
                return registerForm;
            }
            else
            {
                return registerForm;
            }
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            sexComboBox.SelectedIndex = 0;
            courseComboBox.SelectedIndex = 0;
            yearLevelComboBox.SelectedIndex = 0;
            semesterComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndex = 0;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new LoginForm().Show();
        }
        Utils u = new Utils();

        //
        //  Click label events
        //
        private void firstNameLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(firstNameTextbox);
        }

        private void middleNameLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(middleNameTextbox);
        }

        private void sexLabel_Click(object sender, EventArgs e)
        {
            u.setSelect(sexComboBox);
        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(lastNameTextbox);
        }

        private void birthdayLabel_Click(object sender, EventArgs e)
        {
            u.setOpen(birthdayPicker);
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(emailTextbox);
        }

        private void courseLabel_Click(object sender, EventArgs e)
        {
            u.setSelect(courseComboBox);
        }

        private void yearLevelLabel_Click(object sender, EventArgs e)
        {
            u.setSelect(yearLevelComboBox);
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {
            u.setSelect(statusComboBox);
        }

        private void semesterLabel_Click(object sender, EventArgs e)
        {
            u.setSelect(semesterComboBox);
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(passwordTextbox);
        }

        private void confirmPasswordLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(confirmPasswordTextbox);
        }
        //
        //  Click bg panel events
        private void firstNameBg_Click(object sender, EventArgs e)
        {
            u.setFocus(firstNameTextbox);
        }

        private void middleNameBg_Click(object sender, EventArgs e)
        {
            u.setFocus(middleNameTextbox);
        }

        private void sexBg_Click(object sender, EventArgs e)
        {
            u.setSelect(sexComboBox);
        }

        private void lastNameBg_Click(object sender, EventArgs e)
        {
            u.setFocus(lastNameTextbox);
        }

        private void birthdayBg_Click(object sender, EventArgs e)
        {
            u.setOpen(birthdayPicker);
        }

        private void emailBg_Click(object sender, EventArgs e)
        {
            u.setFocus(emailTextbox);
        }

        private void courseBg_Click(object sender, EventArgs e)
        {
            u.setSelect(courseComboBox);
        }

        private void yearLevelBg_Click(object sender, EventArgs e)
        {
            u.setSelect(yearLevelComboBox);
        }
        private void statusBg_Click(object sender, EventArgs e)
        {
            u.setSelect(statusComboBox);

        }
        private void semesterBg_Click(object sender, EventArgs e)
        {
            u.setSelect(semesterComboBox);
        }  
        private void passwordBg_Click(object sender, EventArgs e)
        {
            u.setFocus(passwordTextbox);
        }
        private void confirmPasswordBg_Click(object sender, EventArgs e)
        {
            u.setFocus(confirmPasswordTextbox);
        }

        //
        //  Getters and Setters for Wrong Label
        //
        public void setWrongLabelFirstName(string input)
        {
            wrongFirstNameLabel.Text = input;
        }
        public void setWrongLabelLastName(string input)
        {
            wrongLastNameLabel.Text = input;
        }
        public void setWrongLabelEmail(string input)
        {
            wrongEmailLabel.Text = input;
        }
        public void setWrongLabelPassword(string input)
        {
            wrongPasswordLabel.Text = input;
        }
        public void setWrongLabelConfirmPassword(string input)
        {
            wrongConfirmPasswordLabel.Text = input;
        }

        //
        //  Sign up event
        //
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextbox.Text;
            string lastName = lastNameTextbox.Text;
            string middleName = middleNameTextbox.Text;
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;
            string confirmPassword = confirmPasswordTextbox.Text;
            string sex = sexComboBox.SelectedItem.ToString();
            string birthday = birthdayPicker.Value.ToString("MM-dd-yyyy");
            string course = courseComboBox.SelectedItem.ToString();
            string yearLvl = yearLevelComboBox.SelectedItem.ToString();
            string semester = semesterComboBox.SelectedItem.ToString();
            string status = statusComboBox.SelectedItem.ToString();


            Validator validator = new Validator();
            bool isRegisteredSuccefully = validator.validateRegister(
                firstName, lastName, email, password, confirmPassword, sex, birthday, course,
                yearLvl, semester, status
                );
            if (isRegisteredSuccefully)
            {
                new ConfirmationBox().Show();
            }
        }

        // Function to close the application on exit
        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void firstNameTextbox_Enter(object sender, EventArgs e)
        {
            wrongFirstNameLabel.Text = "";
        }

        private void lastNameTextbox_Enter(object sender, EventArgs e)
        {
            wrongLastNameLabel.Text = "";
        }

        private void emailTextbox_Enter(object sender, EventArgs e)
        {
            wrongEmailLabel.Text = "";
        }

        private void passwordTextbox_Enter(object sender, EventArgs e)
        {
            wrongPasswordLabel.Text = "";
        }

        private void confirmPasswordTextbox_Enter(object sender, EventArgs e)
        {
            wrongConfirmPasswordLabel.Text = "";
        }

        
    }
}
