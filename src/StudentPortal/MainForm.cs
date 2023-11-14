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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Sets the background of variable to transparent when the form loads
        private void HomeForm_Load(object sender, EventArgs e)
        {
            // Home specifics
            schoolHeader.Parent = schoolCover;
            schoolCover.BackColor = Color.Transparent;
            schoolHeaderDesc.Parent = schoolCover;
            schoolHeaderDesc.BackColor = Color.Transparent;

            // Profile specifics
            logoProfile.Parent = studentCoverProfile;
            logoProfile.BackColor = Color.Transparent;
        }
    }
}
