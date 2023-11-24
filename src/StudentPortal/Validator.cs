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
        private RegisterForm registerForm = RegisterForm.getInstance();
        private LoginForm loginForm = LoginForm.getInstance();
        

        public bool validateRegister(
            string firstName, string lastName, string email, string pass, string confirmPass,
            string sex, string birthday, string course, string yearLvl, string semester, 
            string status,string middleName = ""
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
                registerForm.setWrongLabelEmail("Email cannot be empty");
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                registerForm.setWrongLabelEmail("Enter a valid email address");
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
                registerForm.setWrongLabelPassword("Password cannot be empty");
            }
            else if (pass.Length < 8)
            {
                registerForm.setWrongLabelPassword("Atleast more then 8 Character");
            }
            else if (!isStrongPassword(pass))
            {
                registerForm.setWrongLabelPassword("Password is too weak, use uppercase or special character");
            }
            else if (!pass.Equals(confirmPass))
            {
                registerForm.setWrongLabelPassword("Password does not match");
                registerForm.setWrongLabelConfirmPassword("Password does not match");
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
            bool isSucessfull = db.ExecuteLogin(email, password);

            if (isSucessfull)
            {
                LoginForm loginForm = (LoginForm)Application.OpenForms["LoginForm"];
                loginForm.Hide();
                new MainForm().Show();
            }

        }
    }
}
