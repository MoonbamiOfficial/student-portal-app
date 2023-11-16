using StudentPortal.Panels.TodoPanels.TodosFolder;
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
    public partial class MissedPanel : UserControl
    {
        public MissedPanel()
        {
            InitializeComponent();
        }
        View view = new View();

        //
        //  On load event
        //
        private void MissedPanel_Load(object sender, EventArgs e)
        {
            view.setPanelNotVisible(missedOne);

            view.setBtnNotVisible(backBtn);
        }//
        //  Click events
        //
        private void missedOneLabel_Click(object sender, EventArgs e)
        {
            view.setPanelVisible(missedOne);

            missedList.Visible = false;
            view.setBtnVisible(backBtn);
        }
        private void dateOneLabel_Click(object sender, EventArgs e)
        {
            view.setPanelVisible(missedOne);

            missedList.Visible = false;
            view.setBtnVisible(backBtn);
        }
        //
        // Back button
        //
        private void backBtn_Click(object sender, EventArgs e)
        {
            view.setPanelNotVisible(missedOne);

            missedList.Visible = true;
            view.setBtnNotVisible(backBtn);

        }
        //
        //  Mouse Hover
        //
        private void mouseEntered(Label label)
        {
            label.BackColor = System.Drawing.Color.FromArgb(162, 207, 191);
            label.ForeColor = Color.White;
        }
        private void missedOneLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(missedOneLabel);
            mouseEntered(dateOneLabel);
        }
        private void dateOneLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(missedOneLabel);
            mouseEntered(dateOneLabel);
        }
        //
        // Mouse leave
        //
        private void mouseLeave(Label label)
        {
            label.BackColor = Color.Transparent;
            label.ForeColor = Color.Maroon;
        }
        private void missedOneLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(missedOneLabel);
            mouseLeave(dateOneLabel);
        }
        private void dateOneLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(missedOneLabel);
            mouseLeave(dateOneLabel);
        }
    }
}
