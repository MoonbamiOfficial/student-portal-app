using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal.Panels
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }
        Utils u = new Utils();
        private void Profile_Load(object sender, EventArgs e)
        {
            logo.Parent = studentCover;
            logo.BackColor = Color.Transparent;
        }
        //
        //  Label events
        //
        private void passwordLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(passwordTextbox);
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(emailTextbox);
        }

        private void confirmPasswordLabel_Click(object sender, EventArgs e)
        {
            u.setFocus(confirmPasswordTextbox);
        }
        //
        //  BG Panel events
        //
        private void passwordBg_Click(object sender, EventArgs e)
        {
            u.setFocus(passwordTextbox);
        }

        private void emailBg_Click(object sender, EventArgs e)
        {
            u.setFocus(emailTextbox);
        }

        private void confirmPasswordBg_Click(object sender, EventArgs e)
        {
            u.setFocus(confirmPasswordTextbox);
        }
        //
        // Edit btn event
        //
        private void editBtn_Click(object sender, EventArgs e)
        {
            // ---------- DO SOME VERIFICATIONS HERE BACKENDERIST - JAM ----------

            editBtn.Text = "Save";
            
        }
        
    }
}
