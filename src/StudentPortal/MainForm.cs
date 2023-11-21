using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace StudentPortal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //
        //  Sets the appearance of active button
        //
        public void setActiveBtn(IconButton btn)
        {
            System.Drawing.Color bgColor = System.Drawing.Color.FromArgb(222, 245, 229);
            System.Drawing.Color moodColor = System.Drawing.Color.FromArgb(0, 86, 63);

            btn.FlatAppearance.BorderColor = moodColor;
            btn.FlatAppearance.BorderSize = 5;
            btn.BackColor = bgColor;
            btn.ForeColor = moodColor;
            btn.IconColor = moodColor;
        }
        //
        //  Sets the appearance of inactive button
        //
        public void setInactiveBtn(IconButton btn)
        {
            System.Drawing.Color bgColor = System.Drawing.Color.FromArgb(69, 159, 127);

            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = bgColor;
            btn.ForeColor = Color.White;
            btn.IconColor = Color.White;
        }
        //
        //  Sets the default visible panel to Home on load
        //
        private void MainForm_Load(object sender, EventArgs e)
        {
            home.Visible = true;
            profile.Visible = false;
            degree.Visible = false;
        }
        //
        //  Side nav button events
        //
        private void studentIcon_Click(object sender, EventArgs e)
        {
            setInactiveBtn(homeBtn);
            setActiveBtn(profileBtn);
            setInactiveBtn(degreeBtn);
            setInactiveBtn(todoBtn);
            setInactiveBtn(settingBtn);

            home.Visible = false;
            profile.Visible = true;
            degree.Visible = false;
            todo.Visible = false;
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            setActiveBtn(homeBtn);
            setInactiveBtn(profileBtn);
            setInactiveBtn(degreeBtn);
            setInactiveBtn(todoBtn);
            setInactiveBtn(settingBtn);

            home.Visible = true;
            profile.Visible = false;
            degree.Visible = false;
            todo.Visible = false;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            setInactiveBtn(homeBtn);
            setActiveBtn(profileBtn);
            setInactiveBtn(degreeBtn);
            setInactiveBtn(todoBtn);
            setInactiveBtn(settingBtn);

            home.Visible = false;
            profile.Visible = true;
            degree.Visible = false;
            todo.Visible = false;

        }

        private void degreeBtn_Click(object sender, EventArgs e)
        {
            setInactiveBtn(homeBtn);
            setInactiveBtn(profileBtn);
            setActiveBtn(degreeBtn);
            setInactiveBtn(todoBtn);
            setInactiveBtn(settingBtn);

            home.Visible = false;
            profile.Visible = false;
            degree.Visible = true;
            todo.Visible = false;

        }

        private void todoBtn_Click(object sender, EventArgs e)
        {
            setInactiveBtn(homeBtn);
            setInactiveBtn(profileBtn);
            setInactiveBtn(degreeBtn);
            setActiveBtn(todoBtn);
            setInactiveBtn(settingBtn);

            home.Visible = false;
            profile.Visible = false;
            degree.Visible = false;
            todo.Visible = true;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            setInactiveBtn(homeBtn);
            setInactiveBtn(profileBtn);
            setInactiveBtn(degreeBtn);
            setInactiveBtn(todoBtn);
            setActiveBtn(settingBtn);

            home.Visible = false;
            profile.Visible = false;
            degree.Visible = false;
            todo.Visible = false;
        }
        //
        //  Temporary code - logs out to after clicking log out
        //
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new LoginForm().Show();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
