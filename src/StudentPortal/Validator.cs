using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal
{
    internal class Validator
    {
        
        Database db = new Database();

        public void validateLogin(string email, string password)
        {
            // get instance of LoginForm for displaying of Message
            var loginForm = LoginForm.getInstance();
            // Instantiate Database
            Database db = new Database();

            // Check if fields are Empty or Blank
            if ( String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password) )
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


    }
}
