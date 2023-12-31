﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace StudentPortal
{
    public partial class MainForm : Form
    {
        private static MainForm mainForm;
        public MainForm()
        {
            InitializeComponent();
        }
        

        public static MainForm getInstance() {
            if (mainForm == null)
            {
                mainForm = new MainForm();
                return mainForm;
            }else { return mainForm; }
        }
        public void clearInstance()
        {
            mainForm = null;
        }

        //
        //  Sets the appearance of active button
        //
        public void setActiveBtn(IconButton btn)
        {
            Color bgColor = Color.FromArgb(222, 245, 229);
            Color moodColor = Color.FromArgb(0, 86, 63);

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
            Color bgColor = Color.FromArgb(69, 159, 127);

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

            if (StudentInfo.sex == "Female") studentIcon.Image = Properties.Resources.femaleStudent;
            else if (StudentInfo.sex == "Male") studentIcon.Image = Properties.Resources.maleStudent;
            loadInformation(StudentInfo.fullname, StudentInfo.email);
            home.Visible = true;
            profile.Visible = false;
            degree.Visible = false;
            todo.Visible = false;

        }
        //
        //  Side nav button events
        //
        private void loadInformation(string fullname, string email)
        {
            studentName.Text = fullname;
            studentEmail.Text = email;
        }
        private void studentIcon_Click(object sender, EventArgs e)
        {
            this.Text = "Profile";

            setInactiveBtn(homeBtn);
            setActiveBtn(profileBtn);
            setInactiveBtn(degreeBtn);
            setInactiveBtn(todoBtn);

            home.Visible = false;
            profile.Visible = true;
            degree.Visible = false;
            todo.Visible = false;
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Home";

            setActiveBtn(homeBtn);
            setInactiveBtn(profileBtn);
            setInactiveBtn(degreeBtn);
            setInactiveBtn(todoBtn);

            home.Visible = true;
            profile.Visible = false;
            degree.Visible = false;
            todo.Visible = false;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Profile";

            setInactiveBtn(homeBtn);
            setActiveBtn(profileBtn);
            setInactiveBtn(degreeBtn);
            setInactiveBtn(todoBtn);

            home.Visible = false;
            profile.Visible = true;
            degree.Visible = false;
            todo.Visible = false;

        }

        private void degreeBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Degree";

            setInactiveBtn(homeBtn);
            setInactiveBtn(profileBtn);
            setActiveBtn(degreeBtn);
            setInactiveBtn(todoBtn);

            home.Visible = false;
            profile.Visible = false;
            degree.Visible = true;
            todo.Visible = false;

        }

        private void todoBtn_Click(object sender, EventArgs e)
        {
            this.Text = "To-Do";

            setInactiveBtn(homeBtn);
            setInactiveBtn(profileBtn);
            setInactiveBtn(degreeBtn);
            setActiveBtn(todoBtn);

            home.Visible = false;
            profile.Visible = false;
            degree.Visible = false;
            todo.Visible = true;
        }
        //
        //  Logs out to after clicking log out
        //
        private LoginForm loginForm = LoginForm.getInstance();
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            clearInstance();
            this.Hide();
            loginForm.clearInputs();
            loginForm.passwordTextbox.PasswordChar = '●';
            loginForm.eyeIcon.IconChar = IconChar.Eye;
            loginForm.Show();
        }
        public void setUpdatedEmail(string email)
        {
            studentEmail.Text = email;
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
