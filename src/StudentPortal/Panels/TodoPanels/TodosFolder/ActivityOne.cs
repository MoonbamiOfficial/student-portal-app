using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal.Panels.TodoPanels
{
    public partial class ActivityOne : UserControl
    {
        public ActivityOne()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new ActivityOne().Visible = false;
        }
    }
}
