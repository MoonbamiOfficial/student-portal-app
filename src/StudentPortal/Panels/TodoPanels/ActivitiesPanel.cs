using Google.Protobuf.WellKnownTypes;
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
    public partial class ActivitiesPanel : UserControl
    {
        public ActivitiesPanel()
        {
            InitializeComponent();
        }
        Utils u = new Utils();

        //
        //  On load event
        //
        private void ActivitiesPanel_Load(object sender, EventArgs e)
        {
            u.setPanelNotVisible(actOne);
            u.setPanelNotVisible(actTwo);
            u.setPanelNotVisible(actThree);

            u.setBtnNotVisible(backBtn);

        }
        //
        //  Click events
        //
        private void actOneLabel_Click(object sender, EventArgs e)
        {
            u.setPanelVisible(actOne);
            u.setPanelNotVisible(actTwo);
            u.setPanelVisible(actThree);

            activityList.Visible = false;
            u.setBtnVisible(backBtn);
        }
        private void dateOneLabel_Click(object sender, EventArgs e)
        {
            u.setPanelVisible(actOne);
            u.setPanelNotVisible(actTwo);
            u.setPanelVisible(actThree);

            activityList.Visible = false;
            u.setBtnVisible(backBtn);
        }
        private void actTwoLabel_Click(object sender, EventArgs e)
        {
            u.setPanelNotVisible(actOne);
            u.setPanelVisible(actTwo);
            u.setPanelVisible(actThree);

            activityList.Visible = false;
            u.setBtnVisible(backBtn);
        }
        private void dateTwoLabel_Click(object sender, EventArgs e)
        {
            u.setPanelNotVisible(actOne);
            u.setPanelVisible(actTwo);
            u.setPanelVisible(actThree);

            activityList.Visible = false;
            u.setBtnVisible(backBtn);
        }
        private void actThreeLabel_Click(object sender, EventArgs e)
        {
            u.setPanelNotVisible(actOne);
            u.setPanelNotVisible(actTwo);
            u.setPanelVisible(actThree);

            activityList.Visible = false;
            u.setBtnVisible(backBtn);
        }
        private void dateThreeLabel_Click(object sender, EventArgs e)
        {
            u.setPanelNotVisible(actOne);
            u.setPanelNotVisible(actTwo);
            u.setPanelVisible(actThree);

            activityList.Visible = false;
            u.setBtnVisible(backBtn);
        }
        //
        // Back button
        //
        private void backBtn_Click(object sender, EventArgs e)
        {
            u.setPanelNotVisible(actOne);
            u.setPanelNotVisible(actTwo);
            u.setPanelNotVisible(actThree);

            activityList.Visible = true;
            u.setBtnNotVisible(backBtn);

        }
        //
        //  Mouse Hover
        //
        private void mouseEntered(Label label)
        {
            label.BackColor = System.Drawing.Color.FromArgb(162, 207, 191);
            label.ForeColor = Color.White;
        }
        private void actOneLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(actOneLabel);
            mouseEntered(dateOneLabel);
        }
        private void actTwoLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(actTwoLabel);
            mouseEntered(dateTwoLabel);
        }
        private void actThreeLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(actThreeLabel);
            mouseEntered(dateThreeLabel);
        }
        private void dateOneLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(actOneLabel);
            mouseEntered(dateOneLabel);
        }
        private void dateTwoLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(actTwoLabel);
            mouseEntered(dateTwoLabel);
        }
        private void dateThreeLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(actThreeLabel);
            mouseEntered(dateThreeLabel);
        }
        //
        // Mouse leave
        //
        private void mouseLeave(Label label)
        {
            label.BackColor = Color.Transparent;
            label.ForeColor = System.Drawing.Color.FromArgb(69, 159, 127);
        }
        private void actOneLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(actOneLabel);
            mouseLeave(dateOneLabel);
        }
        private void actTwoLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(actTwoLabel);
            mouseLeave(dateTwoLabel);
        }
        private void actThreeLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(actThreeLabel);
            mouseLeave(dateThreeLabel);
        }
        private void dateOneLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(actOneLabel);
            mouseLeave(dateOneLabel);
        }
        private void dateTwoLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(actTwoLabel);
            mouseLeave(dateTwoLabel);
        }
        private void dateThreeLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(actThreeLabel);
            mouseLeave(dateThreeLabel);
        }
    }
}
