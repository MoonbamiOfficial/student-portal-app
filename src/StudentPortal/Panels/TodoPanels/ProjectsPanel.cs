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
    public partial class ProjectsPanel : UserControl
    {
        public ProjectsPanel()
        {
            InitializeComponent();
        }
        View view = new View();

        //
        //  On load event
        //
        private void ProjectsPanel_Load(object sender, EventArgs e)
        {
            view.setPanelNotVisible(projOne);

            view.setBtnNotVisible(backBtn);
        }
        //
        //  Click events
        //
        private void projOneLabel_Click(object sender, EventArgs e)
        {
            view.setPanelVisible(projOne);

            projectsList.Visible = false;
            view.setBtnVisible(backBtn);
        }
        private void dateOneLabel_Click(object sender, EventArgs e)
        {
            view.setPanelVisible(projOne);

            projectsList.Visible = false;
            view.setBtnVisible(backBtn);
        }
        //
        // Back button
        //
        private void backBtn_Click(object sender, EventArgs e)
        {
            view.setPanelNotVisible(projOne);

            projectsList.Visible = true;
            view.setBtnNotVisible(backBtn);

        }
        //
        //  Mouse enter
        //
        private void mouseEntered(Label label)
        {
            label.BackColor = System.Drawing.Color.FromArgb(162, 207, 191);
            label.ForeColor = Color.White;
        }
        private void projOneLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(projOneLabel);
            mouseEntered(dateOneLabel);
        }
        private void dateOneLabel_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(projOneLabel);
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
        private void projOneLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(projOneLabel);
            mouseLeave(dateOneLabel);
        }
        private void dateOneLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(projOneLabel);
            mouseLeave(dateOneLabel);
        }
    }
}