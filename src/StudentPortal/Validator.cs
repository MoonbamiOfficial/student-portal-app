using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal
{
    internal class Validator
    {
        public bool validateRegister(
            string firstName, string lastName, string email, string pass, string confirmPass,
            string sex, string birthday, string course, string yearLvl, string semester, 
            string status, string middleName = ""
            )
        {

            // Array to store all raw data that will 
            // be checked if it contains a null value
            string[] datas = { 
                firstName, lastName, email, pass, confirmPass, sex, 
                birthday, course, yearLvl, semester, status
            };

            // Use methods to validate and set data
            setName(firstName, lastName, middleName);
            setEmail(email);
            setPassword(pass, confirmPass);
            setOtherInformation(sex, birthday, course, yearLvl, semester, status);
            UserData.GenerateStudentNumber();
            if (containsNullOrEmptyValue(datas))
                return false;

            // Array to store the user's information.
            object[] userInfo = {
                UserData.name, UserData.email, UserData.password, UserData.sex, UserData.birthday,
                UserData.course, UserData.yearLvl, UserData.semester, UserData.status
            };

            // Check if the userInfo array contains a null value.
            bool hasNullValue = Array.Exists(userInfo, info => info == null);
            if (hasNullValue)
                return false;

            Database db = new Database();
            bool isEmailAvailable = db.isEmailAvailable(UserData.email);
            if (!isEmailAvailable)
            {
                Forms.registerForm.setWrongLabelEmail("Email has already been taken");
                return false;
            }

            return true;
        }

        // 
        //  Utility Methods
        //
       
        private void setName(string firstName, string lastName, string middleName = "")
        {
            string pattern = @"[!@#$%^&*()]";

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName))
            {
                Forms.registerForm.setWrongLabelFirstName("First name cannot be empty");
            }
            else if (string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName))
            {
                Forms.registerForm.setWrongLabelLastName("Last name cannot be empty");
            }
            else if (Regex.IsMatch(firstName, pattern) || Regex.IsMatch(firstName, @"\d"))
            {
                Forms.registerForm.setWrongLabelFirstName("Enter a valid first name");
            }
            else if (Regex.IsMatch(lastName, pattern) || Regex.IsMatch(lastName, @"\d"))
            {
                Forms.registerForm.setWrongLabelLastName("Enter a valid last name");
            }
            else
            {
                if (!string.IsNullOrEmpty(middleName))
                {
                    // set full name with middle name.
                    UserData.name = $"{firstName} {middleName} {lastName}";
                }
                else
                {
                    // set full name without middle name.
                    UserData.name = $"{firstName} {lastName}";
                }
            }
        }
        private void setEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                Forms.registerForm.setWrongLabelEmail("Email cannot be empty");
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Forms.registerForm.setWrongLabelEmail("Enter a valid email address");
            }
            else
            {
                // set email value.
                UserData.email = email;
            }
        }
        private void setPassword(string pass, string confirmPass)
        {
            if (string.IsNullOrEmpty(pass) || string.IsNullOrWhiteSpace(pass))
            {
                Forms.registerForm.setWrongLabelPassword("Password cannot be empty");
            }
            else if (pass.Length < 8)
            {
                Forms.registerForm.setWrongLabelPassword("Atleast more then 8 Character");
            }
            else if (!isStrongPassword(pass))
            {
                Forms.registerForm.setWrongLabelPassword("Password is too weak, use uppercase or special character");
            }
            else if (!pass.Equals(confirmPass))
            {
                Forms.registerForm.setWrongLabelPassword("Password does not match");
                Forms.registerForm.setWrongLabelConfirmPassword("Password does not match");
            }
            else
            {
                // set password value.
                UserData.password = pass;
            }
        }   
        public bool isStrongPassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[^A-Za-z0-9]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
        public void setOtherInformation(string sex, string bday, string course, string yearLvl, string sem, string status)
        {
            UserData.sex = sex;
            UserData.birthday = bday;
            UserData.course = course;
            switch (yearLvl)
            {
                case "1st Year":
                    UserData.yearLvl = 1;
                    break;
                case "2nd Year":
                    UserData.yearLvl = 2;
                    break;
                case "3rd Year":
                    UserData.yearLvl = 3;
                    break;
                case "4th Year":
                    UserData.yearLvl = 4;
                    break;
                default:
                    UserData.yearLvl = 0;
                    break;
            }
            switch (sem)
            {
                case "1st Sem":
                    UserData.semester = 1;
                    break;
                case "2nd Sem":
                    UserData.semester = 2;
                    break;
                default:
                    UserData.semester = 0;
                    break;
            }
            UserData.status = status;
        }
        private bool containsNullOrEmptyValue(string[] values)
        {
            foreach (var value in values)
            {
                if (String.IsNullOrEmpty(value))
                {
                    return true;
                }
            }
            return false;
        }
        //
        //  Login
        //
        private LoginForm loginForm = LoginForm.getInstance();
        public void validateLogin(string email, string password)
        {
            Database db = new Database();

            // Check if fields are Empty or Blank
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                loginForm.setWrongEmailLabel("Fields cannot be Blank");
                loginForm.setWrongPasswordLabel("Fields cannot be Blank");
                loginForm.clearTxtField();
                return;
            }
            // Execute query to the database
            bool isSuccessful = db.ExecuteLogin(email, password);

            if (isSuccessful)
            {
                loginForm.Hide();
                var mainForm = MainForm.getInstance();
                mainForm.Show();    
            }
        }
        //
        //  Update
        //
        public bool validateEmailAndPassword(string email, string pass, string confirmPass)
        {
            bool isPassStrong = isStrongPassword(pass);
            string stuNumber = StudentInfo.stuNumber.ToString();
            Database db = new Database();
            if (email.Equals(StudentInfo.email) && pass.Equals(StudentInfo.password))
            {
                MessageBox.Show("No changes made");
                return false;
            }
            // Route to change Password Only
            else if (email.Equals(StudentInfo.email) && !pass.Equals(StudentInfo.password))
            {
                if (!isPassStrong) 
                {
                    MessageBox.Show("Password must be at least 8 characters long and contains at least one uppercase letter and a special character ");
                    return false;
                }
                else if (!pass.Equals(confirmPass))
                {
                    MessageBox.Show("Password does not Match");
                    return false;
                }
                DialogResult result = MessageBox.Show("Do you want to Change Password Only?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.UpdateEmailAndPassword(stuNumber: stuNumber, pass: pass);
                    return true;
                }
                else { return false; }
            }
            // Route to change Email Only
            else if (pass.Equals(StudentInfo.password) && !email.Equals(StudentInfo.email))
            {
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Enter a valid email");
                    return false;
                }
                DialogResult result = MessageBox.Show("Do you want to Change Email Only?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.UpdateEmailAndPassword(stuNumber: stuNumber, email: email);
                    return true;
                }
                else { return false; }
            }
            // Route to change both
            else
            {
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Enter a valid email");
                    return false;
                }
                else if (!isPassStrong)
                {
                    MessageBox.Show("Password must be at least 8 characters long and contains at least one uppercase letter and a special character ");
                    return false;
                }
                else if (!pass.Equals(confirmPass))
                {
                    MessageBox.Show("Password does not Match");
                    return false;
                }
                DialogResult result = MessageBox.Show("Do you want to Change both Email and Password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.UpdateEmailAndPassword(stuNumber: stuNumber, email: email, pass: pass);
                    return true;
                }
                else { return false; }
            }
        }
    }
}
