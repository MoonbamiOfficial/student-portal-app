using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal.Panels.TodoPanels
{
    public partial class FinishedPanel : UserControl
    {
        public FinishedPanel()
        {
            InitializeComponent();
        }
        View view = new View();

        //
        //  On load event
        //
        private void FinishedPanel_Load(object sender, EventArgs e)
        {
            view.setPanelNotVisible(finishedOne);

            view.setBtnNotVisible(backBtn);
        }//
        //  Click events
        //
        private void finOneLabel_Click(object sender, EventArgs e)
        {
            view.setPanelVisible(finishedOne);

            finishedList.Visible = false;
            view.setBtnVisible(backBtn);
        }
        private void dateOneLabel_Click(object sender, EventArgs e)
        {
            view.setPanelVisible(finishedOne);

            finishedList.Visible = false;
            view.setBtnVisible(backBtn);
        }
        //
        // Back button
        //
        private void backBtn_Click(object sender, EventArgs e)
        {
            view.setPanelNotVisible(finishedOne);

            finishedList.Visible = true;
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
        private void finOneLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(finOneLabel);
            mouseEntered(dateOneLabel);
        }
        private void dateOneLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(finOneLabel);
            mouseEntered(dateOneLabel);
        }
        //
        // Mouse leave
        //
        private void mouseLeave(Label label)
        {
            label.BackColor = Color.Transparent;
            label.ForeColor = System.Drawing.Color.FromArgb(69, 159, 127);
        }
        private void finOneLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(finOneLabel);
            mouseLeave(dateOneLabel);
        }
        private void dateOneLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(finOneLabel);
            mouseLeave(dateOneLabel);
        }
    }
}
