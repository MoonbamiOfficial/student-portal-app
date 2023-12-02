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
        public static LoginForm loginForm = new LoginForm();
        public static RegisterForm registerForm = new RegisterForm();
        public static MainForm mainForm = new MainForm();
        public static ConfirmationBox confirmationBox = new ConfirmationBox();
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
