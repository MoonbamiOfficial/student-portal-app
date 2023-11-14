namespace StudentPortal
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.userName = new System.Windows.Forms.Label();
            this.sideNavBg = new System.Windows.Forms.Panel();
            this.userEmail = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.schoolHeader = new System.Windows.Forms.Label();
            this.schoolHeaderDesc = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.schoolCover = new System.Windows.Forms.PictureBox();
            this.userIcon = new StudentPortal.StudentPortalControls.pictureBoxCustom();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.profileBtn = new FontAwesome.Sharp.IconButton();
            this.degreeBtn = new FontAwesome.Sharp.IconButton();
            this.todoBtn = new FontAwesome.Sharp.IconButton();
            this.settingBtn = new FontAwesome.Sharp.IconButton();
            this.schoolLogo = new System.Windows.Forms.PictureBox();
            this.sideNavBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.userName.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.userName.Location = new System.Drawing.Point(10, 220);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(420, 45);
            this.userName.TabIndex = 1;
            this.userName.Text = "User Username";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sideNavBg
            // 
            this.sideNavBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.sideNavBg.Controls.Add(this.userIcon);
            this.sideNavBg.Controls.Add(this.userEmail);
            this.sideNavBg.Controls.Add(this.userName);
            this.sideNavBg.Controls.Add(this.homeBtn);
            this.sideNavBg.Controls.Add(this.profileBtn);
            this.sideNavBg.Controls.Add(this.degreeBtn);
            this.sideNavBg.Controls.Add(this.todoBtn);
            this.sideNavBg.Controls.Add(this.settingBtn);
            this.sideNavBg.Controls.Add(this.logOutBtn);
            this.sideNavBg.Location = new System.Drawing.Point(0, 0);
            this.sideNavBg.Name = "sideNavBg";
            this.sideNavBg.Size = new System.Drawing.Size(440, 1024);
            this.sideNavBg.TabIndex = 2;
            // 
            // userEmail
            // 
            this.userEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.userEmail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.userEmail.Location = new System.Drawing.Point(10, 265);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(420, 30);
            this.userEmail.TabIndex = 3;
            this.userEmail.Text = "user_student@gmail.com";
            this.userEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(70, 850);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(300, 80);
            this.logOutBtn.TabIndex = 1;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            // 
            // schoolHeader
            // 
            this.schoolHeader.BackColor = System.Drawing.Color.Transparent;
            this.schoolHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.schoolHeader.Font = new System.Drawing.Font("Poppins", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolHeader.ForeColor = System.Drawing.Color.White;
            this.schoolHeader.Location = new System.Drawing.Point(679, 200);
            this.schoolHeader.Name = "schoolHeader";
            this.schoolHeader.Size = new System.Drawing.Size(514, 116);
            this.schoolHeader.TabIndex = 4;
            this.schoolHeader.Text = "GET READY";
            this.schoolHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schoolHeaderDesc
            // 
            this.schoolHeaderDesc.BackColor = System.Drawing.Color.Transparent;
            this.schoolHeaderDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.schoolHeaderDesc.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolHeaderDesc.ForeColor = System.Drawing.Color.White;
            this.schoolHeaderDesc.Location = new System.Drawing.Point(648, 316);
            this.schoolHeaderDesc.Name = "schoolHeaderDesc";
            this.schoolHeaderDesc.Size = new System.Drawing.Size(583, 56);
            this.schoolHeaderDesc.TabIndex = 5;
            this.schoolHeaderDesc.Text = "TO DREAM, LEARN & DISCOVER";
            this.schoolHeaderDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.schoolHeaderDesc.UseMnemonic = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.header.Font = new System.Drawing.Font("Poppins SemiBold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.header.Location = new System.Drawing.Point(481, 650);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(431, 180);
            this.header.TabIndex = 6;
            this.header.Text = "Your Journey Starts Here.";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.header.UseMnemonic = false;
            // 
            // desc
            // 
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.desc.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.desc.Location = new System.Drawing.Point(481, 840);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(500, 84);
            this.desc.TabIndex = 7;
            this.desc.Text = "The ideal application where students can create their own private space, monitor " +
    "their activities, home works, projects, grades and many more. ";
            this.desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.desc.UseMnemonic = false;
            // 
            // schoolCover
            // 
            this.schoolCover.Image = global::StudentPortal.Properties.Resources.classroom;
            this.schoolCover.Location = new System.Drawing.Point(440, 0);
            this.schoolCover.Name = "schoolCover";
            this.schoolCover.Size = new System.Drawing.Size(1000, 600);
            this.schoolCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schoolCover.TabIndex = 3;
            this.schoolCover.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.userIcon.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.userIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.userIcon.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.userIcon.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.userIcon.BorderSize = 8;
            this.userIcon.GradientAngle = 0F;
            this.userIcon.Image = global::StudentPortal.Properties.Resources.maleStudent;
            this.userIcon.Location = new System.Drawing.Point(134, 50);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(150, 150);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIcon.TabIndex = 0;
            this.userIcon.TabStop = false;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.homeBtn.FlatAppearance.BorderSize = 5;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.House;
            this.homeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.homeBtn.IconSize = 32;
            this.homeBtn.Location = new System.Drawing.Point(0, 316);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(440, 100);
            this.homeBtn.TabIndex = 9;
            this.homeBtn.Text = "HOME";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseMnemonic = false;
            this.homeBtn.UseVisualStyleBackColor = false;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.profileBtn.IconColor = System.Drawing.Color.White;
            this.profileBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.profileBtn.IconSize = 32;
            this.profileBtn.Location = new System.Drawing.Point(0, 416);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(440, 100);
            this.profileBtn.TabIndex = 10;
            this.profileBtn.Text = "PROFILE";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profileBtn.UseMnemonic = false;
            this.profileBtn.UseVisualStyleBackColor = false;
            // 
            // degreeBtn
            // 
            this.degreeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.degreeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.degreeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.degreeBtn.FlatAppearance.BorderSize = 0;
            this.degreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.degreeBtn.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeBtn.ForeColor = System.Drawing.Color.White;
            this.degreeBtn.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.degreeBtn.IconColor = System.Drawing.Color.White;
            this.degreeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.degreeBtn.IconSize = 32;
            this.degreeBtn.Location = new System.Drawing.Point(0, 516);
            this.degreeBtn.Name = "degreeBtn";
            this.degreeBtn.Size = new System.Drawing.Size(440, 100);
            this.degreeBtn.TabIndex = 11;
            this.degreeBtn.Text = "DEGREE";
            this.degreeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.degreeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.degreeBtn.UseMnemonic = false;
            this.degreeBtn.UseVisualStyleBackColor = false;
            // 
            // todoBtn
            // 
            this.todoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.todoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todoBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.todoBtn.FlatAppearance.BorderSize = 0;
            this.todoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoBtn.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoBtn.ForeColor = System.Drawing.Color.White;
            this.todoBtn.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.todoBtn.IconColor = System.Drawing.Color.White;
            this.todoBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.todoBtn.IconSize = 32;
            this.todoBtn.Location = new System.Drawing.Point(0, 616);
            this.todoBtn.Name = "todoBtn";
            this.todoBtn.Size = new System.Drawing.Size(440, 100);
            this.todoBtn.TabIndex = 12;
            this.todoBtn.Text = "TO-DO";
            this.todoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.todoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.todoBtn.UseMnemonic = false;
            this.todoBtn.UseVisualStyleBackColor = false;
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.Color.White;
            this.settingBtn.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.settingBtn.IconColor = System.Drawing.Color.White;
            this.settingBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.settingBtn.IconSize = 32;
            this.settingBtn.Location = new System.Drawing.Point(0, 716);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(440, 100);
            this.settingBtn.TabIndex = 13;
            this.settingBtn.Text = "SETTING";
            this.settingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingBtn.UseMnemonic = false;
            this.settingBtn.UseVisualStyleBackColor = false;
            // 
            // schoolLogo
            // 
            this.schoolLogo.BackColor = System.Drawing.Color.Transparent;
            this.schoolLogo.Image = global::StudentPortal.Properties.Resources.logo;
            this.schoolLogo.Location = new System.Drawing.Point(1068, 663);
            this.schoolLogo.Name = "schoolLogo";
            this.schoolLogo.Size = new System.Drawing.Size(250, 250);
            this.schoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schoolLogo.TabIndex = 8;
            this.schoolLogo.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.schoolLogo);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.header);
            this.Controls.Add(this.schoolHeaderDesc);
            this.Controls.Add(this.schoolHeader);
            this.Controls.Add(this.schoolCover);
            this.Controls.Add(this.sideNavBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.sideNavBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Panel sideNavBg;
        private StudentPortalControls.pictureBoxCustom userIcon;
        private System.Windows.Forms.Label userEmail;
        private System.Windows.Forms.Button logOutBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton profileBtn;
        private FontAwesome.Sharp.IconButton degreeBtn;
        private FontAwesome.Sharp.IconButton todoBtn;
        private FontAwesome.Sharp.IconButton settingBtn;
        private System.Windows.Forms.PictureBox schoolCover;
        private System.Windows.Forms.Label schoolHeader;
        private System.Windows.Forms.Label schoolHeaderDesc;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.PictureBox schoolLogo;
    }
}