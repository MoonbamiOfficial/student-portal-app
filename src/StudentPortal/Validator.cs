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
        private string name = null;
        private string email = null;
        private string password = null;
        private string sex = null;
        private string birthday = null;
        private string course = null;
        private int yearLvl = 0;
        private int semester = 0;
        private string status = null;
        



        private RegisterForm registerForm = RegisterForm.getInstance();
        private LoginForm loginForm = LoginForm.getInstance();

        public void validateLogin(string email, string password)
        {
            
            // Instantiate Database
            Database db = new Database();

            // Check if fields are Empty or Blank
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                loginForm.setWrongEmailLabel("Fields cannot be Blank");
                loginForm.setWrongPasswordLabel("Fields cannot be Blank");
                loginForm.clearTxtField();
                return;
            }

            string query = "SELECT * FROM student_info";

            // Execute query to the database
            db.ExecuteLogin(query, email, password);
        }

        //###############################################################################
        
        public bool validateRegister(
            string firstName, string lastName, string email, string pass, string confirmPass,
            string sex, string birthday, string course, string yearLvl, string semester, 
            string status,string middleName = ""
            )
        {
            string[] values = { 
                firstName, lastName, email, pass, confirmPass, sex, 
                birthday, course, yearLvl, semester, status
            };

            setName(firstName, lastName, middleName);
            setEmail(email);
            setPassword(pass, confirmPass);
            setOtherInformation(sex, birthday, course, yearLvl, semester, status);

            if (containsNullOrEmptyValue(values))
                return false;

            object[] userInfo = {
                this.name, this.email, this.password, this.sex, this.birthday,
                this.course, this.yearLvl, this.semester, this.status
            };
            bool hasNullValue = Array.Exists(userInfo, info => info == null);
            if (hasNullValue)
                return false;

            //MessageBox.Show($"name: {this.name} email: {this.email} pass: {this.password} sex: {this.sex}" +
            //        $"bday: {this.birthday} course: {this.course} year: {this.yearLvl} sem: {this.semester} status: {this.status}");
            
            Database db = new Database();
            db.executeRegister(this.name, this.email, this.password, this.sex, this.birthday, this.course, this.yearLvl, this.semester, this.status);
            
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
                registerForm.setWrongLabelFirstName("First name cannot be empty");
            }
            else if (string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName))
            {
                registerForm.setWrongLabelLastName("Last name cannot be empty");
            }
            else if (Regex.IsMatch(firstName, pattern) || Regex.IsMatch(firstName, @"\d"))
            {
                registerForm.setWrongLabelFirstName("Enter a valid first name");
            }
            else if (Regex.IsMatch(lastName, pattern) || Regex.IsMatch(lastName, @"\d"))
            {
                registerForm.setWrongLabelLastName("Enter a valid last name");
            }
            else
            {
                if (!string.IsNullOrEmpty(middleName))
                {
                    // set full name with middle name.
                    this.name = $"{firstName} {middleName} {lastName}";
                }
                else
                {
                    // set full name without middle name.
                    this.name = $"{firstName} {lastName}";
                }
            }
        }
        private void setEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                registerForm.setWrongLabelEmail("Email cannot be empty");
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                registerForm.setWrongLabelEmail("Enter a valid email address");
            }
            else
            {
                // set email value.
                this.email = email;
            }
        }
        private void setPassword(string pass, string confirmPass)
        {
            if (string.IsNullOrEmpty(pass) || string.IsNullOrWhiteSpace(pass))
            {
                registerForm.setWrongLabelPassword("Password cannot be empty");
            }
            else if (pass.Length < 8)
            {
                registerForm.setWrongLabelPassword("Atleast more then 8 Character");
            }
            else if (!isStrongPassword(pass))
            {
                registerForm.setWrongLabelPassword("Password is too weak");
            }
            else if (!pass.Equals(confirmPass))
            {
                registerForm.setWrongLabelPassword("Password does not match");
                registerForm.setWrongLabelConfirmPassword("Password does not match");
            }
            else
            {
                // set password value.
                password = pass;
            }
        }
        public bool isStrongPassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[^A-Za-z0-9]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
        public void setOtherInformation(string sex, string bday, string course, string yearLvl, string sem, string status)
        {
            this.sex = sex;
            this.birthday = bday;
            this.course = course;
            switch (yearLvl)
            {
                case "1st Year":
                    this.yearLvl = 1;
                    break;
                case "2nd Year":
                    this.yearLvl = 2;
                    break;
                case "3rd Year":
                    this.yearLvl = 3;
                    break;
                case "4th Year":
                    this.yearLvl = 4;
                    break;
                default: 
                    this.yearLvl = 0;
                    break;
            }
            switch (sem)
            {
                case "1st Sem":
                    this.semester = 1;
                    break;
                case "2nd Sem":
                    this.semester = 2;
                    break;
                default:
                    this.semester = 0;
                    break;
            }
            this.status = status;
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
    }
}
