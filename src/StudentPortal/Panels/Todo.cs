using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentPortal.Panels
{
    public partial class Todo : UserControl
    {
        public Todo()
        {
            InitializeComponent();
        }
        // Setters
        private void setActiveBtn(IconButton btn)
        {
            btn.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
        }
        private void setInactiveBtn(IconButton btn)
        {
            btn.IconChar = FontAwesome.Sharp.IconChar.None;
        }
        private void mouseEntered(IconButton btn)
        {
            btn.BackColor = System.Drawing.Color.FromArgb(162, 207, 191);
            btn.ForeColor = Color.White;
        }
        private void mouseLeave(IconButton btn)
        {
            btn.BackColor = Color.Transparent;
            btn.ForeColor = System.Drawing.Color.FromArgb(69, 159, 127);
        }
        //
        //  On load event
        private void Todo_Load(object sender, EventArgs e)
        {
            setActiveBtn(activitiesBtn);
            activitiesPanel.Visible = true;
        }
        //
        //  Click events in side nav
        //
        private void activitiesBtn_Click(object sender, EventArgs e)
        {
            setActiveBtn(activitiesBtn);
            setInactiveBtn(homeWorkBtn);
            setInactiveBtn(projectsBtn);
            setInactiveBtn(quizzesBtn);
            setInactiveBtn(testsBtn);
            setInactiveBtn(missedBtn);
            setInactiveBtn(finishedBtn);

            activitiesPanel.Visible = true;
            projectsPanel.Visible = false;
            relaxPanel.Visible = false;
            missedPanel.Visible = false;
            finishedPanel.Visible = false;

        }

        private void homeWorkBtn_Click(object sender, EventArgs e)
        {
            setInactiveBtn(activitiesBtn);
            setActiveBtn(homeWorkBtn);
            setInactiveBtn(projectsBtn);
            setInactiveBtn(quizzesBtn);
            setInactiveBtn(testsBtn);
            setInactiveBtn(missedBtn);
            setInactiveBtn(finishedBtn);

            activitiesPanel.Visible = false;
            projectsPanel.Visible = false;
            relaxPanel.Visible = true;
            missedPanel.Visible = false;
            finishedPanel.Visible = false;
        }

        private void projectsBtn_Click(object sender, EventArgs e)
        {
            setInactiveBtn(activitiesBtn);
            setInactiveBtn(homeWorkBtn);
            setActiveBtn(projectsBtn);
            setInactiveBtn(quizzesBtn);
            setInactiveBtn(testsBtn);
            setInactiveBtn(missedBtn);
            setInactiveBtn(finishedBtn);

            activitiesPanel.Visible = false;
            projectsPanel.Visible = true;
            relaxPanel.Visible = false;
            missedPanel.Visible = false;
            finishedPanel.Visible = false;
        }

        private void quizzesBtn_Click(object sender, EventArgs e)
        {
            setInactiveBtn(activitiesBtn);
            setInactiveBtn(homeWorkBtn);
            setInactiveBtn(projectsBtn);
            setActiveBtn(quizzesBtn);
            setInactiveBtn(testsBtn);
            setInactiveBtn(missedBtn);
            setInactiveBtn(finishedBtn);

            activitiesPanel.Visible = false;
            projectsPanel.Visible = false;
            relaxPanel.Visible = true;
            missedPanel.Visible = false;
            finishedPanel.Visible = false;
        }

        private void testsBtn_Click(object sender, EventArgs e)
        {
            setInactiveBtn(activitiesBtn);
            setInactiveBtn(homeWorkBtn);
            setInactiveBtn(projectsBtn);
            setInactiveBtn(quizzesBtn);
            setActiveBtn(testsBtn);
            setInactiveBtn(missedBtn);
            setInactiveBtn(finishedBtn);

            activitiesPanel.Visible = false;
            projectsPanel.Visible = false;
            relaxPanel.Visible = true;
            missedPanel.Visible = false;
            finishedPanel.Visible = false;
        }

        private void missedBtn_Click(object sender, EventArgs e)
        {
            setInactiveBtn(activitiesBtn);
            setInactiveBtn(homeWorkBtn);
            setInactiveBtn(projectsBtn);
            setInactiveBtn(quizzesBtn);
            setInactiveBtn(testsBtn);
            setActiveBtn(missedBtn);
            setInactiveBtn(finishedBtn);

            activitiesPanel.Visible = false;
            projectsPanel.Visible = false;
            relaxPanel.Visible = false;
            missedPanel.Visible = true;
            finishedPanel.Visible = false;
        }
        private void finishedBtn_Click(object sender, EventArgs e)
        {
            setInactiveBtn(activitiesBtn);
            setInactiveBtn(homeWorkBtn);
            setInactiveBtn(projectsBtn);
            setInactiveBtn(quizzesBtn);
            setInactiveBtn(testsBtn);
            setInactiveBtn(missedBtn);
            setActiveBtn(finishedBtn);

            activitiesPanel.Visible = false;
            projectsPanel.Visible = false;
            relaxPanel.Visible = false;
            missedPanel.Visible = false;
            finishedPanel.Visible = true;
        }
        //
        // Mouse enter events
        //
        private void activitiesBtn_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(activitiesBtn);
        }

        private void homeWorkBtn_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(homeWorkBtn);
        }

        private void projectsBtn_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(projectsBtn);
        }

        private void quizzesBtn_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(quizzesBtn);
        }

        private void testsBtn_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(testsBtn);
        }

        private void missedBtn_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(missedBtn);
        }
        private void finishedBtn_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered(finishedBtn);
        }
        //
        //  Mouse leaves
        //
        private void activitiesBtn_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(activitiesBtn);
        }

        private void homeWorkBtn_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(homeWorkBtn);
        }

        private void projectsBtn_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(projectsBtn);
        }

        private void quizzesBtn_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(quizzesBtn);
        }

        private void testsBtn_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(testsBtn);
        }

        private void missedBtn_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(missedBtn);
        }

        private void finishedBtn_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(finishedBtn);
        }

    }
}
