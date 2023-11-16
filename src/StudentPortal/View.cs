using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal.Panels
{
    internal class View
    {
        public void setPanelVisible(UserControl panel)
        {
            panel.Visible = true;
        }
        public void setPanelNotVisible(UserControl panel)
        {
            panel.Visible = false;
        }
        public void setBtnVisible(Button btn)
        {
            btn.Visible = true;
        }
        public void setBtnNotVisible(Button btn)
        {
            btn.Visible = false;
        }
    }
}
