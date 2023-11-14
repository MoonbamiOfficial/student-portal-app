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
            this.userName = new System.Windows.Forms.Label();
            this.sideNavHome = new System.Windows.Forms.Panel();
            this.userIcon = new StudentPortal.StudentPortalControls.pictureBoxCustom();
            this.userEmail = new System.Windows.Forms.Label();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.profileBtn = new FontAwesome.Sharp.IconButton();
            this.degreeBtn = new FontAwesome.Sharp.IconButton();
            this.todoBtn = new FontAwesome.Sharp.IconButton();
            this.settingBtn = new FontAwesome.Sharp.IconButton();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.schoolHeader = new System.Windows.Forms.Label();
            this.schoolHeaderDesc = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.schoolCover = new System.Windows.Forms.PictureBox();
            this.schoolLogo = new System.Windows.Forms.PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.studentNumber = new System.Windows.Forms.Label();
            this.studentEmail = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.studentIcon = new StudentPortal.StudentPortalControls.pictureBoxCustom();
            this.logo = new System.Windows.Forms.PictureBox();
            this.userCover = new System.Windows.Forms.PictureBox();
            this.emaiLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.passwordBg = new System.Windows.Forms.Panel();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.confirmPasswordBg = new System.Windows.Forms.Panel();
            this.confirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.emailbg = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sideNavProfile = new System.Windows.Forms.Panel();
            this.pictureBoxCustom1 = new StudentPortal.StudentPortalControls.pictureBoxCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.sideNavHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolLogo)).BeginInit();
            this.homePanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCover)).BeginInit();
            this.sideNavProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustom1)).BeginInit();
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
            // sideNavHome
            // 
            this.sideNavHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.sideNavHome.Controls.Add(this.userIcon);
            this.sideNavHome.Controls.Add(this.userEmail);
            this.sideNavHome.Controls.Add(this.userName);
            this.sideNavHome.Controls.Add(this.homeBtn);
            this.sideNavHome.Controls.Add(this.profileBtn);
            this.sideNavHome.Controls.Add(this.degreeBtn);
            this.sideNavHome.Controls.Add(this.todoBtn);
            this.sideNavHome.Controls.Add(this.settingBtn);
            this.sideNavHome.Controls.Add(this.logOutBtn);
            this.sideNavHome.Location = new System.Drawing.Point(0, 0);
            this.sideNavHome.Name = "sideNavHome";
            this.sideNavHome.Size = new System.Drawing.Size(440, 1024);
            this.sideNavHome.TabIndex = 2;
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
            // homePanel
            // 
            this.homePanel.Controls.Add(this.sideNavHome);
            this.homePanel.Controls.Add(this.desc);
            this.homePanel.Controls.Add(this.header);
            this.homePanel.Controls.Add(this.schoolHeaderDesc);
            this.homePanel.Controls.Add(this.schoolHeader);
            this.homePanel.Controls.Add(this.schoolLogo);
            this.homePanel.Controls.Add(this.schoolCover);
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1440, 1024);
            this.homePanel.TabIndex = 9;
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.sideNavProfile);
            this.profilePanel.Controls.Add(this.studentIcon);
            this.profilePanel.Controls.Add(this.logo);
            this.profilePanel.Controls.Add(this.userCover);
            this.profilePanel.Controls.Add(this.passwordLabel);
            this.profilePanel.Controls.Add(this.emaiLabel);
            this.profilePanel.Controls.Add(this.studentNumber);
            this.profilePanel.Controls.Add(this.studentEmail);
            this.profilePanel.Controls.Add(this.studentName);
            this.profilePanel.Controls.Add(this.confirmPasswordLabel);
            this.profilePanel.Controls.Add(this.editBtn);
            this.profilePanel.Controls.Add(this.emailTextBox);
            this.profilePanel.Controls.Add(this.passwordTextbox);
            this.profilePanel.Controls.Add(this.confirmPasswordTextbox);
            this.profilePanel.Controls.Add(this.emailbg);
            this.profilePanel.Controls.Add(this.confirmPasswordBg);
            this.profilePanel.Controls.Add(this.passwordBg);
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(1440, 1024);
            this.profilePanel.TabIndex = 18;
            // 
            // studentNumber
            // 
            this.studentNumber.BackColor = System.Drawing.Color.Transparent;
            this.studentNumber.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentNumber.Location = new System.Drawing.Point(1182, 423);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(110, 28);
            this.studentNumber.TabIndex = 16;
            this.studentNumber.Text = "#202111966";
            this.studentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentEmail
            // 
            this.studentEmail.BackColor = System.Drawing.Color.Transparent;
            this.studentEmail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentEmail.Location = new System.Drawing.Point(756, 458);
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(420, 28);
            this.studentEmail.TabIndex = 15;
            this.studentEmail.Text = "user_student@gmail.com";
            this.studentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentName
            // 
            this.studentName.BackColor = System.Drawing.Color.Transparent;
            this.studentName.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentName.Location = new System.Drawing.Point(756, 410);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(420, 48);
            this.studentName.TabIndex = 14;
            this.studentName.Text = "User Username";
            this.studentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentIcon
            // 
            this.studentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentIcon.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.studentIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.studentIcon.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.studentIcon.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.studentIcon.BorderSize = 8;
            this.studentIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentIcon.GradientAngle = 0F;
            this.studentIcon.Image = global::StudentPortal.Properties.Resources.maleStudent;
            this.studentIcon.Location = new System.Drawing.Point(490, 285);
            this.studentIcon.Margin = new System.Windows.Forms.Padding(0);
            this.studentIcon.Name = "studentIcon";
            this.studentIcon.Size = new System.Drawing.Size(250, 250);
            this.studentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentIcon.TabIndex = 14;
            this.studentIcon.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::StudentPortal.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(1260, 220);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 150);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // userCover
            // 
            this.userCover.Image = global::StudentPortal.Properties.Resources.entrance;
            this.userCover.Location = new System.Drawing.Point(440, 0);
            this.userCover.Name = "userCover";
            this.userCover.Size = new System.Drawing.Size(1000, 400);
            this.userCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userCover.TabIndex = 4;
            this.userCover.TabStop = false;
            // 
            // emaiLabel
            // 
            this.emaiLabel.BackColor = System.Drawing.Color.Transparent;
            this.emaiLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.emaiLabel.Location = new System.Drawing.Point(1019, 600);
            this.emaiLabel.Name = "emaiLabel";
            this.emaiLabel.Size = new System.Drawing.Size(67, 34);
            this.emaiLabel.TabIndex = 17;
            this.emaiLabel.Text = "Email";
            this.emaiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.passwordLabel.Location = new System.Drawing.Point(520, 600);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(117, 34);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(520, 764);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(221, 34);
            this.confirmPasswordLabel.TabIndex = 19;
            this.confirmPasswordLabel.Text = "Confirm Password";
            this.confirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(1039, 798);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(300, 80);
            this.editBtn.TabIndex = 20;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // passwordBg
            // 
            this.passwordBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.passwordBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBg.Location = new System.Drawing.Point(490, 634);
            this.passwordBg.Name = "passwordBg";
            this.passwordBg.Size = new System.Drawing.Size(400, 80);
            this.passwordBg.TabIndex = 21;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.passwordTextbox.Location = new System.Drawing.Point(520, 660);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(340, 29);
            this.passwordTextbox.TabIndex = 22;
            this.passwordTextbox.Text = "Aa";
            // 
            // confirmPasswordBg
            // 
            this.confirmPasswordBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.confirmPasswordBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordBg.Location = new System.Drawing.Point(490, 798);
            this.confirmPasswordBg.Name = "confirmPasswordBg";
            this.confirmPasswordBg.Size = new System.Drawing.Size(400, 80);
            this.confirmPasswordBg.TabIndex = 23;
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.confirmPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(520, 824);
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(340, 29);
            this.confirmPasswordTextbox.TabIndex = 24;
            this.confirmPasswordTextbox.Text = "Aa";
            // 
            // emailbg
            // 
            this.emailbg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.emailbg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailbg.Location = new System.Drawing.Point(989, 634);
            this.emailbg.Name = "emailbg";
            this.emailbg.Size = new System.Drawing.Size(400, 80);
            this.emailbg.TabIndex = 25;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.emailTextBox.Location = new System.Drawing.Point(1019, 660);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(340, 29);
            this.emailTextBox.TabIndex = 26;
            this.emailTextBox.Text = "Aa";
            // 
            // sideNavProfile
            // 
            this.sideNavProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.sideNavProfile.Controls.Add(this.pictureBoxCustom1);
            this.sideNavProfile.Controls.Add(this.label1);
            this.sideNavProfile.Controls.Add(this.label2);
            this.sideNavProfile.Controls.Add(this.iconButton1);
            this.sideNavProfile.Controls.Add(this.iconButton2);
            this.sideNavProfile.Controls.Add(this.iconButton3);
            this.sideNavProfile.Controls.Add(this.iconButton4);
            this.sideNavProfile.Controls.Add(this.iconButton5);
            this.sideNavProfile.Controls.Add(this.button1);
            this.sideNavProfile.Location = new System.Drawing.Point(0, 0);
            this.sideNavProfile.Name = "sideNavProfile";
            this.sideNavProfile.Size = new System.Drawing.Size(440, 1024);
            this.sideNavProfile.TabIndex = 27;
            // 
            // pictureBoxCustom1
            // 
            this.pictureBoxCustom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.pictureBoxCustom1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBoxCustom1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.pictureBoxCustom1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.pictureBoxCustom1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBoxCustom1.BorderSize = 8;
            this.pictureBoxCustom1.GradientAngle = 0F;
            this.pictureBoxCustom1.Image = global::StudentPortal.Properties.Resources.maleStudent;
            this.pictureBoxCustom1.Location = new System.Drawing.Point(134, 50);
            this.pictureBoxCustom1.Name = "pictureBoxCustom1";
            this.pictureBoxCustom1.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxCustom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustom1.TabIndex = 0;
            this.pictureBoxCustom1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(10, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "user_student@gmail.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(10, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(0, 316);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(440, 100);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "HOME";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseMnemonic = false;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.iconButton2.FlatAppearance.BorderSize = 5;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 32;
            this.iconButton2.Location = new System.Drawing.Point(0, 416);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(440, 100);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.Text = "PROFILE";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseMnemonic = false;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 32;
            this.iconButton3.Location = new System.Drawing.Point(0, 516);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(440, 100);
            this.iconButton3.TabIndex = 11;
            this.iconButton3.Text = "DEGREE";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseMnemonic = false;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.IconSize = 32;
            this.iconButton4.Location = new System.Drawing.Point(0, 616);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(440, 100);
            this.iconButton4.TabIndex = 12;
            this.iconButton4.Text = "TO-DO";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseMnemonic = false;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton5.IconSize = 32;
            this.iconButton5.Location = new System.Drawing.Point(0, 716);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(440, 100);
            this.iconButton5.TabIndex = 13;
            this.iconButton5.Text = "SETTING";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseMnemonic = false;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(70, 850);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.homePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.sideNavHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolLogo)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCover)).EndInit();
            this.sideNavProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustom1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Panel sideNavHome;
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
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label studentNumber;
        private System.Windows.Forms.Label studentEmail;
        private System.Windows.Forms.Label studentName;
        private StudentPortalControls.pictureBoxCustom studentIcon;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox userCover;
        private System.Windows.Forms.Label emaiLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Panel passwordBg;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Panel emailbg;
        private System.Windows.Forms.TextBox confirmPasswordTextbox;
        private System.Windows.Forms.Panel confirmPasswordBg;
        private System.Windows.Forms.Panel sideNavProfile;
        private StudentPortalControls.pictureBoxCustom pictureBoxCustom1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Button button1;
    }
}