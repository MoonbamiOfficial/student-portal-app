using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal
{
    public partial class ConfirmationBox : Form
    {
        public ConfirmationBox()
        {
            InitializeComponent();
        }
        //
        //  Hover event
        //
        private void mouseEntered(Button btn)
        {
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = System.Drawing.Color.FromArgb(0, 86, 63);
            btn.ForeColor = Color.White;
        }
        private void mouseLeave(Button btn)
        {
            btn.FlatAppearance.BorderSize = 3;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = System.Drawing.Color.FromArgb(0, 86, 63);

        }
        private void confirmBtn_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(confirmBtn);
        }

        private void confirmBtn_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(confirmBtn);
        }
        //
        //  Cancelled
        //
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
        //
        //  Confirmed
        //
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // once confirmed, you know what to do with the database
            // this also closes the confirmation box and return to login form
            this.Dispose();
            RegisterForm registerForm = (RegisterForm)Application.OpenForms["RegisterForm"];
            registerForm.Dispose();
            new LoginForm().Show();
        }

    }
}
