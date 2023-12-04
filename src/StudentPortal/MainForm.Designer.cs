namespace StudentPortal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.studentName = new System.Windows.Forms.Label();
            this.sideNav = new System.Windows.Forms.Panel();
            this.studentEmail = new System.Windows.Forms.Label();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.profileBtn = new FontAwesome.Sharp.IconButton();
            this.degreeBtn = new FontAwesome.Sharp.IconButton();
            this.todoBtn = new FontAwesome.Sharp.IconButton();
            this.settingBtn = new FontAwesome.Sharp.IconButton();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.studentIcon = new StudentPortal.StudentPortalControls.CustomPictureBox();
            this.home = new StudentPortal.Panels.Home();
            this.profile = new StudentPortal.Panels.Profile();
            this.degree = new StudentPortal.Panels.Degree();
            this.todo = new StudentPortal.Panels.Todo();
            this.sideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.studentName.Location = new System.Drawing.Point(10, 220);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(420, 45);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "User Username";
            this.studentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sideNav
            // 
            this.sideNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.sideNav.Controls.Add(this.studentIcon);
            this.sideNav.Controls.Add(this.studentName);
            this.sideNav.Controls.Add(this.studentEmail);
            this.sideNav.Controls.Add(this.homeBtn);
            this.sideNav.Controls.Add(this.profileBtn);
            this.sideNav.Controls.Add(this.degreeBtn);
            this.sideNav.Controls.Add(this.todoBtn);
            this.sideNav.Controls.Add(this.settingBtn);
            this.sideNav.Controls.Add(this.logOutBtn);
            this.sideNav.Location = new System.Drawing.Point(0, 0);
            this.sideNav.Name = "sideNav";
            this.sideNav.Size = new System.Drawing.Size(440, 985);
            this.sideNav.TabIndex = 0;
            // 
            // studentEmail
            // 
            this.studentEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentEmail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.studentEmail.Location = new System.Drawing.Point(10, 265);
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(420, 30);
            this.studentEmail.TabIndex = 0;
            this.studentEmail.Text = "user_student@gmail.com";
            this.studentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.homeBtn.FlatAppearance.BorderSize = 5;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.House;
            this.homeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.homeBtn.IconSize = 32;
            this.homeBtn.Location = new System.Drawing.Point(0, 296);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(440, 100);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "HOME";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseMnemonic = false;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.profileBtn.IconColor = System.Drawing.Color.White;
            this.profileBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.profileBtn.IconSize = 32;
            this.profileBtn.Location = new System.Drawing.Point(0, 396);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(440, 100);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "PROFILE";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profileBtn.UseMnemonic = false;
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // degreeBtn
            // 
            this.degreeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.degreeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.degreeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.degreeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.degreeBtn.FlatAppearance.BorderSize = 0;
            this.degreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.degreeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeBtn.ForeColor = System.Drawing.Color.White;
            this.degreeBtn.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.degreeBtn.IconColor = System.Drawing.Color.White;
            this.degreeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.degreeBtn.IconSize = 32;
            this.degreeBtn.Location = new System.Drawing.Point(0, 496);
            this.degreeBtn.Name = "degreeBtn";
            this.degreeBtn.Size = new System.Drawing.Size(440, 100);
            this.degreeBtn.TabIndex = 3;
            this.degreeBtn.Text = "DEGREE";
            this.degreeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.degreeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.degreeBtn.UseMnemonic = false;
            this.degreeBtn.UseVisualStyleBackColor = false;
            this.degreeBtn.Click += new System.EventHandler(this.degreeBtn_Click);
            // 
            // todoBtn
            // 
            this.todoBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.todoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.todoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todoBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.todoBtn.FlatAppearance.BorderSize = 0;
            this.todoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoBtn.ForeColor = System.Drawing.Color.White;
            this.todoBtn.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.todoBtn.IconColor = System.Drawing.Color.White;
            this.todoBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.todoBtn.IconSize = 32;
            this.todoBtn.Location = new System.Drawing.Point(0, 596);
            this.todoBtn.Name = "todoBtn";
            this.todoBtn.Size = new System.Drawing.Size(440, 100);
            this.todoBtn.TabIndex = 4;
            this.todoBtn.Text = "TO-DO";
            this.todoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.todoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.todoBtn.UseMnemonic = false;
            this.todoBtn.UseVisualStyleBackColor = false;
            this.todoBtn.Click += new System.EventHandler(this.todoBtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.Color.White;
            this.settingBtn.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.settingBtn.IconColor = System.Drawing.Color.White;
            this.settingBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.settingBtn.IconSize = 32;
            this.settingBtn.Location = new System.Drawing.Point(0, 696);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(440, 100);
            this.settingBtn.TabIndex = 5;
            this.settingBtn.Text = "SETTING";
            this.settingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingBtn.UseMnemonic = false;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(70, 811);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(300, 80);
            this.logOutBtn.TabIndex = 6;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // studentIcon
            // 
            this.studentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentIcon.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.studentIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.studentIcon.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.studentIcon.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.studentIcon.BorderSize = 8;
            this.studentIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentIcon.GradientAngle = 0F;
            this.studentIcon.Image = global::StudentPortal.Properties.Resources.maleStudent;
            this.studentIcon.Location = new System.Drawing.Point(134, 50);
            this.studentIcon.Name = "studentIcon";
            this.studentIcon.Size = new System.Drawing.Size(150, 150);
            this.studentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentIcon.TabIndex = 0;
            this.studentIcon.TabStop = false;
            this.studentIcon.Click += new System.EventHandler(this.studentIcon_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.home.Location = new System.Drawing.Point(440, 0);
            this.home.Margin = new System.Windows.Forms.Padding(0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(985, 985);
            this.home.TabIndex = 0;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.profile.Location = new System.Drawing.Point(440, 0);
            this.profile.Margin = new System.Windows.Forms.Padding(0);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(985, 985);
            this.profile.TabIndex = 0;
            // 
            // degree
            // 
            this.degree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.degree.Location = new System.Drawing.Point(440, -20);
            this.degree.Margin = new System.Windows.Forms.Padding(0);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(985, 985);
            this.degree.TabIndex = 0;
            // 
            // todo
            // 
            this.todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.todo.Location = new System.Drawing.Point(440, 0);
            this.todo.Margin = new System.Windows.Forms.Padding(0);
            this.todo.Name = "todo";
            this.todo.Size = new System.Drawing.Size(985, 985);
            this.todo.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.sideNav);
            this.Controls.Add(this.home);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.todo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Panel sideNav;
        private StudentPortalControls.CustomPictureBox studentIcon;
        private System.Windows.Forms.Label studentEmail;
        private System.Windows.Forms.Button logOutBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton profileBtn;
        private FontAwesome.Sharp.IconButton degreeBtn;
        private FontAwesome.Sharp.IconButton todoBtn;
        private FontAwesome.Sharp.IconButton settingBtn;
        private Panels.Home home;
        private Panels.Profile profile;
        private Panels.Degree degree;
        private Panels.Todo todo;
    }
}