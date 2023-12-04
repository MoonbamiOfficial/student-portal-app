using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal
{
    //  Creates a global variable for form instances
    public static class Forms
    {
        public static LoginForm loginForm = LoginForm.getInstance();
        public static RegisterForm registerForm = RegisterForm.getInstance();
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(LoginForm.getInstance());
        }
    }
}
