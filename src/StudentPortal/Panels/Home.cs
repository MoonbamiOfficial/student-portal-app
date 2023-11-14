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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            schoolHeader.Parent = schoolCover;
            schoolHeader.BackColor = Color.Transparent;
            schoolHeaderDesc.Parent = schoolCover;
            schoolHeaderDesc.BackColor = Color.Transparent;
        }
    }
}
