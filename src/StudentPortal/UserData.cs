using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentPortal
{
    public static class UserData
    {
        public static string name { get; set; }
        public static string email;
        public static string password;
        public static string sex;
        public static string birthday;
        public static string course;
        public static int yearLvl;
        public static int semester;
        public static string status;
        public static long idNumber;

        public static void GenerateStudentNumber()
        {
            DateTime now = DateTime.Now;

            // Format the date and time as a string (yyyyMMss)
            string formattedDateTime = now.ToString("yyyyMMss");
            // Append milliseconds to ensure uniqueness within the same second
            formattedDateTime += now.Millisecond.ToString("D3");
            idNumber = long.Parse(formattedDateTime);
        }
    }

}
