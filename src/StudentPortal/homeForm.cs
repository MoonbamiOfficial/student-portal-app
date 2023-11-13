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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        // To load transparent label
        private void homeForm_Load(object sender, EventArgs e)
        {
            schoolCoverHeader.Parent = schoolCover;
            schoolCoverHeader.BackColor = Color.Transparent;
        }
    }
}
