namespace StudentPortal
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.brandIcon = new System.Windows.Forms.PictureBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.brandNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.alreadyHaveLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.middleNameTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.firstNameBg = new System.Windows.Forms.Panel();
            this.middleNameBg = new System.Windows.Forms.Panel();
            this.birthdayBg = new System.Windows.Forms.Panel();
            this.birthdayPicker = new StudentPortal.CustomDatePicker();
            this.courseBg = new System.Windows.Forms.Panel();
            this.courseComboBox = new StudentPortal.StudentPortalControls.CustomComboBox();
            this.lastNameBg = new System.Windows.Forms.Panel();
            this.emailBg = new System.Windows.Forms.Panel();
            this.statusBg = new System.Windows.Forms.Panel();
            this.statusComboBox = new StudentPortal.StudentPortalControls.CustomComboBox();
            this.sexBg = new System.Windows.Forms.Panel();
            this.sexComboBox = new StudentPortal.StudentPortalControls.CustomComboBox();
            this.passwordBg = new System.Windows.Forms.Panel();
            this.confirmPasswordBg = new System.Windows.Forms.Panel();
            this.loginBg = new System.Windows.Forms.Panel();
            this.wrongFirstNameLabel = new System.Windows.Forms.Label();
            this.yearLevelLabel = new System.Windows.Forms.Label();
            this.yearLevelBg = new System.Windows.Forms.Panel();
            this.yearLevelComboBox = new StudentPortal.StudentPortalControls.CustomComboBox();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.semesterBg = new System.Windows.Forms.Panel();
            this.semesterComboBox = new StudentPortal.StudentPortalControls.CustomComboBox();
            this.wrongLastNameLabel = new System.Windows.Forms.Label();
            this.wrongEmailLabel = new System.Windows.Forms.Label();
            this.wrongPasswordLabel = new System.Windows.Forms.Label();
            this.wrongConfirmPasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brandIcon)).BeginInit();
            this.birthdayBg.SuspendLayout();
            this.courseBg.SuspendLayout();
            this.statusBg.SuspendLayout();
            this.sexBg.SuspendLayout();
            this.yearLevelBg.SuspendLayout();
            this.semesterBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // brandIcon
            // 
            this.brandIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.brandIcon.Image = global::StudentPortal.Properties.Resources.icon;
            this.brandIcon.Location = new System.Drawing.Point(29, 30);
            this.brandIcon.Margin = new System.Windows.Forms.Padding(0);
            this.brandIcon.Name = "brandIcon";
            this.brandIcon.Size = new System.Drawing.Size(100, 100);
            this.brandIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brandIcon.TabIndex = 0;
            this.brandIcon.TabStop = false;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(558, 828);
            this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(221, 34);
            this.confirmPasswordLabel.TabIndex = 0;
            this.confirmPasswordLabel.Text = "Confirm Password";
            this.confirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmPasswordLabel.Click += new System.EventHandler(this.confirmPasswordLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.passwordLabel.Location = new System.Drawing.Point(558, 680);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(117, 34);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // sexLabel
            // 
            this.sexLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sexLabel.BackColor = System.Drawing.Color.Transparent;
            this.sexLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.sexLabel.Location = new System.Drawing.Point(1181, 240);
            this.sexLabel.Margin = new System.Windows.Forms.Padding(0);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(42, 34);
            this.sexLabel.TabIndex = 0;
            this.sexLabel.Text = "Sex";
            this.sexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sexLabel.Click += new System.EventHandler(this.sexLabel_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.statusLabel.Location = new System.Drawing.Point(1181, 680);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(78, 34);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.emailLabel.Location = new System.Drawing.Point(558, 530);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 34);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.lastNameLabel.Location = new System.Drawing.Point(558, 388);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(128, 34);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // courseLabel
            // 
            this.courseLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.courseLabel.BackColor = System.Drawing.Color.Transparent;
            this.courseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.courseLabel.Location = new System.Drawing.Point(968, 530);
            this.courseLabel.Margin = new System.Windows.Forms.Padding(0);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(86, 34);
            this.courseLabel.TabIndex = 0;
            this.courseLabel.Text = "Course";
            this.courseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseLabel.Click += new System.EventHandler(this.courseLabel_Click);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.birthdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.birthdayLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.birthdayLabel.Location = new System.Drawing.Point(968, 388);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(103, 34);
            this.birthdayLabel.TabIndex = 0;
            this.birthdayLabel.Text = "Birthday";
            this.birthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.birthdayLabel.Click += new System.EventHandler(this.birthdayLabel_Click);
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.middleNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.middleNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.middleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.middleNameLabel.Location = new System.Drawing.Point(968, 240);
            this.middleNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(160, 34);
            this.middleNameLabel.TabIndex = 0;
            this.middleNameLabel.Text = "Middle Name";
            this.middleNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.middleNameLabel.Click += new System.EventHandler(this.middleNameLabel_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.firstNameLabel.Location = new System.Drawing.Point(558, 240);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(129, 34);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // brandNameLabel
            // 
            this.brandNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.brandNameLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.brandNameLabel.Location = new System.Drawing.Point(134, 56);
            this.brandNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.brandNameLabel.Name = "brandNameLabel";
            this.brandNameLabel.Size = new System.Drawing.Size(277, 48);
            this.brandNameLabel.TabIndex = 0;
            this.brandNameLabel.Text = "Student Portal";
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.headerLabel.Location = new System.Drawing.Point(671, 99);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(527, 96);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Let\'s Sign Up!";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alreadyHaveLabel
            // 
            this.alreadyHaveLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.alreadyHaveLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.alreadyHaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyHaveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.alreadyHaveLabel.Location = new System.Drawing.Point(58, 330);
            this.alreadyHaveLabel.Margin = new System.Windows.Forms.Padding(0);
            this.alreadyHaveLabel.Name = "alreadyHaveLabel";
            this.alreadyHaveLabel.Size = new System.Drawing.Size(323, 116);
            this.alreadyHaveLabel.TabIndex = 0;
            this.alreadyHaveLabel.Text = "Already Have An Account?";
            this.alreadyHaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descLabel
            // 
            this.descLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.descLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.descLabel.Location = new System.Drawing.Point(39, 496);
            this.descLabel.Margin = new System.Windows.Forms.Padding(0);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(361, 68);
            this.descLabel.TabIndex = 0;
            this.descLabel.Text = "Login and continue being part\nof this amazing community!";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.firstNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.firstNameTextbox.Location = new System.Drawing.Point(558, 300);
            this.firstNameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(340, 29);
            this.firstNameTextbox.TabIndex = 1;
            // 
            // middleNameTextbox
            // 
            this.middleNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.middleNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.middleNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleNameTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.middleNameTextbox.Location = new System.Drawing.Point(968, 300);
            this.middleNameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.middleNameTextbox.Name = "middleNameTextbox";
            this.middleNameTextbox.Size = new System.Drawing.Size(140, 29);
            this.middleNameTextbox.TabIndex = 2;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.emailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.emailTextbox.Location = new System.Drawing.Point(558, 592);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(340, 29);
            this.emailTextbox.TabIndex = 6;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.lastNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.lastNameTextbox.Location = new System.Drawing.Point(558, 448);
            this.lastNameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(340, 29);
            this.lastNameTextbox.TabIndex = 4;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.passwordTextbox.Location = new System.Drawing.Point(558, 740);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(340, 29);
            this.passwordTextbox.TabIndex = 9;
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.confirmPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(558, 888);
            this.confirmPasswordTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(340, 29);
            this.confirmPasswordTextbox.TabIndex = 12;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.loginBtn.Location = new System.Drawing.Point(70, 614);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(300, 80);
            this.loginBtn.TabIndex = 14;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.signUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.FlatAppearance.BorderSize = 0;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.White;
            this.signUpBtn.Location = new System.Drawing.Point(1008, 862);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(300, 80);
            this.signUpBtn.TabIndex = 13;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // firstNameBg
            // 
            this.firstNameBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.firstNameBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameBg.Location = new System.Drawing.Point(528, 274);
            this.firstNameBg.Margin = new System.Windows.Forms.Padding(0);
            this.firstNameBg.Name = "firstNameBg";
            this.firstNameBg.Size = new System.Drawing.Size(400, 80);
            this.firstNameBg.TabIndex = 0;
            this.firstNameBg.Click += new System.EventHandler(this.firstNameBg_Click);
            // 
            // middleNameBg
            // 
            this.middleNameBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.middleNameBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.middleNameBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.middleNameBg.Location = new System.Drawing.Point(938, 274);
            this.middleNameBg.Margin = new System.Windows.Forms.Padding(0);
            this.middleNameBg.Name = "middleNameBg";
            this.middleNameBg.Size = new System.Drawing.Size(200, 80);
            this.middleNameBg.TabIndex = 0;
            this.middleNameBg.Click += new System.EventHandler(this.middleNameBg_Click);
            // 
            // birthdayBg
            // 
            this.birthdayBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.birthdayBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.birthdayBg.Controls.Add(this.birthdayPicker);
            this.birthdayBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthdayBg.Location = new System.Drawing.Point(938, 422);
            this.birthdayBg.Margin = new System.Windows.Forms.Padding(0);
            this.birthdayBg.Name = "birthdayBg";
            this.birthdayBg.Size = new System.Drawing.Size(413, 80);
            this.birthdayBg.TabIndex = 0;
            this.birthdayBg.Click += new System.EventHandler(this.birthdayBg_Click);
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.birthdayPicker.BorderColor = System.Drawing.Color.Transparent;
            this.birthdayPicker.BorderSize = 0;
            this.birthdayPicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.birthdayPicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.birthdayPicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.birthdayPicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.birthdayPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthdayPicker.CustomFormat = "MMMM dd, yyy";
            this.birthdayPicker.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayPicker.Location = new System.Drawing.Point(0, 26);
            this.birthdayPicker.Margin = new System.Windows.Forms.Padding(0);
            this.birthdayPicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(413, 36);
            this.birthdayPicker.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.birthdayPicker.TabIndex = 5;
            this.birthdayPicker.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.birthdayPicker.Value = new System.DateTime(2023, 11, 12, 13, 32, 33, 0);
            // 
            // courseBg
            // 
            this.courseBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.courseBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.courseBg.Controls.Add(this.courseComboBox);
            this.courseBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseBg.Location = new System.Drawing.Point(938, 566);
            this.courseBg.Margin = new System.Windows.Forms.Padding(0);
            this.courseBg.Name = "courseBg";
            this.courseBg.Size = new System.Drawing.Size(200, 80);
            this.courseBg.TabIndex = 0;
            this.courseBg.Click += new System.EventHandler(this.courseBg_Click);
            // 
            // courseComboBox
            // 
            this.courseComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.courseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.courseComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.courseComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.courseComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.courseComboBox.BorderSize = 0;
            this.courseComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.courseComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(175)))), ((int)(((byte)(153)))));
            this.courseComboBox.Items.AddRange(new object[] {
            "BSMT",
            "BSCRIM",
            "BSTM",
            "BSIT",
            "BSCS",
            "BSCM",
            "BSESS",
            "BSPSYCH",
            "BS Arch",
            "BSBM",
            "BSDM",
            "BSIS"});
            this.courseComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.courseComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.courseComboBox.Location = new System.Drawing.Point(0, 26);
            this.courseComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.courseComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(200, 30);
            this.courseComboBox.TabIndex = 7;
            this.courseComboBox.Texts = "BSIT";
            // 
            // lastNameBg
            // 
            this.lastNameBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.lastNameBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameBg.Location = new System.Drawing.Point(528, 422);
            this.lastNameBg.Margin = new System.Windows.Forms.Padding(0);
            this.lastNameBg.Name = "lastNameBg";
            this.lastNameBg.Size = new System.Drawing.Size(400, 80);
            this.lastNameBg.TabIndex = 0;
            this.lastNameBg.Click += new System.EventHandler(this.lastNameBg_Click);
            // 
            // emailBg
            // 
            this.emailBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.emailBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailBg.Location = new System.Drawing.Point(528, 566);
            this.emailBg.Margin = new System.Windows.Forms.Padding(0);
            this.emailBg.Name = "emailBg";
            this.emailBg.Size = new System.Drawing.Size(400, 80);
            this.emailBg.TabIndex = 0;
            this.emailBg.Click += new System.EventHandler(this.emailBg_Click);
            // 
            // statusBg
            // 
            this.statusBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.statusBg.Controls.Add(this.statusComboBox);
            this.statusBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusBg.Location = new System.Drawing.Point(1151, 714);
            this.statusBg.Margin = new System.Windows.Forms.Padding(0);
            this.statusBg.Name = "statusBg";
            this.statusBg.Size = new System.Drawing.Size(200, 80);
            this.statusBg.TabIndex = 0;
            this.statusBg.Click += new System.EventHandler(this.statusBg_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.statusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.statusComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.statusComboBox.BorderSize = 0;
            this.statusComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.statusComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(175)))), ((int)(((byte)(153)))));
            this.statusComboBox.Items.AddRange(new object[] {
            "Regular",
            "Irregular"});
            this.statusComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.statusComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.statusComboBox.Location = new System.Drawing.Point(0, 26);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.statusComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 30);
            this.statusComboBox.TabIndex = 11;
            this.statusComboBox.Texts = "Regular";
            // 
            // sexBg
            // 
            this.sexBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sexBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.sexBg.Controls.Add(this.sexComboBox);
            this.sexBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sexBg.Location = new System.Drawing.Point(1151, 274);
            this.sexBg.Margin = new System.Windows.Forms.Padding(0);
            this.sexBg.Name = "sexBg";
            this.sexBg.Size = new System.Drawing.Size(200, 80);
            this.sexBg.TabIndex = 0;
            this.sexBg.Click += new System.EventHandler(this.sexBg_Click);
            // 
            // sexComboBox
            // 
            this.sexComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sexComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sexComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sexComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.sexComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.sexComboBox.BorderSize = 0;
            this.sexComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.sexComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(175)))), ((int)(((byte)(153)))));
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.sexComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.sexComboBox.Location = new System.Drawing.Point(0, 26);
            this.sexComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.sexComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(200, 30);
            this.sexComboBox.TabIndex = 3;
            this.sexComboBox.Texts = "Male";
            // 
            // passwordBg
            // 
            this.passwordBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.passwordBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBg.Location = new System.Drawing.Point(528, 714);
            this.passwordBg.Margin = new System.Windows.Forms.Padding(0);
            this.passwordBg.Name = "passwordBg";
            this.passwordBg.Size = new System.Drawing.Size(400, 80);
            this.passwordBg.TabIndex = 0;
            this.passwordBg.Click += new System.EventHandler(this.passwordBg_Click);
            // 
            // confirmPasswordBg
            // 
            this.confirmPasswordBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.confirmPasswordBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordBg.Location = new System.Drawing.Point(528, 862);
            this.confirmPasswordBg.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPasswordBg.Name = "confirmPasswordBg";
            this.confirmPasswordBg.Size = new System.Drawing.Size(400, 80);
            this.confirmPasswordBg.TabIndex = 0;
            this.confirmPasswordBg.Click += new System.EventHandler(this.confirmPasswordBg_Click);
            // 
            // loginBg
            // 
            this.loginBg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loginBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.loginBg.Location = new System.Drawing.Point(0, 0);
            this.loginBg.Margin = new System.Windows.Forms.Padding(0);
            this.loginBg.Name = "loginBg";
            this.loginBg.Size = new System.Drawing.Size(440, 1024);
            this.loginBg.TabIndex = 0;
            // 
            // wrongFirstNameLabel
            // 
            this.wrongFirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wrongFirstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongFirstNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wrongFirstNameLabel.Location = new System.Drawing.Point(528, 206);
            this.wrongFirstNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.wrongFirstNameLabel.Name = "wrongFirstNameLabel";
            this.wrongFirstNameLabel.Size = new System.Drawing.Size(400, 34);
            this.wrongFirstNameLabel.TabIndex = 0;
            this.wrongFirstNameLabel.Text = "* Sample error message";
            this.wrongFirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearLevelLabel
            // 
            this.yearLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yearLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLevelLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLevelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.yearLevelLabel.Location = new System.Drawing.Point(1181, 530);
            this.yearLevelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.yearLevelLabel.Name = "yearLevelLabel";
            this.yearLevelLabel.Size = new System.Drawing.Size(122, 34);
            this.yearLevelLabel.TabIndex = 0;
            this.yearLevelLabel.Text = "Year Level";
            this.yearLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yearLevelLabel.Click += new System.EventHandler(this.yearLevelLabel_Click);
            // 
            // yearLevelBg
            // 
            this.yearLevelBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yearLevelBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.yearLevelBg.Controls.Add(this.yearLevelComboBox);
            this.yearLevelBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearLevelBg.Location = new System.Drawing.Point(1151, 566);
            this.yearLevelBg.Margin = new System.Windows.Forms.Padding(0);
            this.yearLevelBg.Name = "yearLevelBg";
            this.yearLevelBg.Size = new System.Drawing.Size(200, 80);
            this.yearLevelBg.TabIndex = 0;
            this.yearLevelBg.Click += new System.EventHandler(this.yearLevelBg_Click);
            // 
            // yearLevelComboBox
            // 
            this.yearLevelComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yearLevelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.yearLevelComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.yearLevelComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.yearLevelComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.yearLevelComboBox.BorderSize = 0;
            this.yearLevelComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearLevelComboBox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLevelComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.yearLevelComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(175)))), ((int)(((byte)(153)))));
            this.yearLevelComboBox.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.yearLevelComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.yearLevelComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.yearLevelComboBox.Location = new System.Drawing.Point(0, 26);
            this.yearLevelComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.yearLevelComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.yearLevelComboBox.Name = "yearLevelComboBox";
            this.yearLevelComboBox.Size = new System.Drawing.Size(200, 30);
            this.yearLevelComboBox.TabIndex = 8;
            this.yearLevelComboBox.Texts = "1st Year";
            // 
            // semesterLabel
            // 
            this.semesterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.semesterLabel.BackColor = System.Drawing.Color.Transparent;
            this.semesterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.semesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.semesterLabel.Location = new System.Drawing.Point(968, 680);
            this.semesterLabel.Margin = new System.Windows.Forms.Padding(0);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(122, 34);
            this.semesterLabel.TabIndex = 0;
            this.semesterLabel.Text = "Semester";
            this.semesterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.semesterLabel.Click += new System.EventHandler(this.semesterLabel_Click);
            // 
            // semesterBg
            // 
            this.semesterBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.semesterBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.semesterBg.Controls.Add(this.semesterComboBox);
            this.semesterBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.semesterBg.Location = new System.Drawing.Point(938, 714);
            this.semesterBg.Margin = new System.Windows.Forms.Padding(0);
            this.semesterBg.Name = "semesterBg";
            this.semesterBg.Size = new System.Drawing.Size(200, 80);
            this.semesterBg.TabIndex = 0;
            this.semesterBg.Click += new System.EventHandler(this.semesterBg_Click);
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.semesterComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.semesterComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.semesterComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.semesterComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.semesterComboBox.BorderSize = 0;
            this.semesterComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.semesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterComboBox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.semesterComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(175)))), ((int)(((byte)(153)))));
            this.semesterComboBox.Items.AddRange(new object[] {
            "1st Sem",
            "2nd Sem"});
            this.semesterComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.semesterComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.semesterComboBox.Location = new System.Drawing.Point(0, 26);
            this.semesterComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.semesterComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(200, 30);
            this.semesterComboBox.TabIndex = 10;
            this.semesterComboBox.Texts = "1st Sem";
            // 
            // wrongLastNameLabel
            // 
            this.wrongLastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wrongLastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLastNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wrongLastNameLabel.Location = new System.Drawing.Point(528, 354);
            this.wrongLastNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.wrongLastNameLabel.Name = "wrongLastNameLabel";
            this.wrongLastNameLabel.Size = new System.Drawing.Size(400, 34);
            this.wrongLastNameLabel.TabIndex = 14;
            this.wrongLastNameLabel.Text = "* Sample error message";
            this.wrongLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wrongEmailLabel
            // 
            this.wrongEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wrongEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongEmailLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wrongEmailLabel.Location = new System.Drawing.Point(528, 502);
            this.wrongEmailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.wrongEmailLabel.Name = "wrongEmailLabel";
            this.wrongEmailLabel.Size = new System.Drawing.Size(400, 34);
            this.wrongEmailLabel.TabIndex = 15;
            this.wrongEmailLabel.Text = "* Sample error message";
            this.wrongEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wrongPasswordLabel
            // 
            this.wrongPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wrongPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongPasswordLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wrongPasswordLabel.Location = new System.Drawing.Point(528, 646);
            this.wrongPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.wrongPasswordLabel.Name = "wrongPasswordLabel";
            this.wrongPasswordLabel.Size = new System.Drawing.Size(400, 34);
            this.wrongPasswordLabel.TabIndex = 16;
            this.wrongPasswordLabel.Text = "* Sample error message";
            this.wrongPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wrongConfirmPasswordLabel
            // 
            this.wrongConfirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wrongConfirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongConfirmPasswordLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wrongConfirmPasswordLabel.Location = new System.Drawing.Point(528, 794);
            this.wrongConfirmPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.wrongConfirmPasswordLabel.Name = "wrongConfirmPasswordLabel";
            this.wrongConfirmPasswordLabel.Size = new System.Drawing.Size(400, 34);
            this.wrongConfirmPasswordLabel.TabIndex = 17;
            this.wrongConfirmPasswordLabel.Text = "* Sample error message";
            this.wrongConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.brandIcon);
            this.Controls.Add(this.wrongConfirmPasswordLabel);
            this.Controls.Add(this.wrongPasswordLabel);
            this.Controls.Add(this.wrongEmailLabel);
            this.Controls.Add(this.wrongLastNameLabel);
            this.Controls.Add(this.wrongFirstNameLabel);
            this.Controls.Add(this.brandNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.alreadyHaveLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.yearLevelLabel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.middleNameTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.confirmPasswordTextbox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.semesterBg);
            this.Controls.Add(this.yearLevelBg);
            this.Controls.Add(this.loginBg);
            this.Controls.Add(this.sexBg);
            this.Controls.Add(this.confirmPasswordBg);
            this.Controls.Add(this.passwordBg);
            this.Controls.Add(this.statusBg);
            this.Controls.Add(this.emailBg);
            this.Controls.Add(this.lastNameBg);
            this.Controls.Add(this.courseBg);
            this.Controls.Add(this.birthdayBg);
            this.Controls.Add(this.middleNameBg);
            this.Controls.Add(this.firstNameBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.brandIcon)).EndInit();
            this.birthdayBg.ResumeLayout(false);
            this.courseBg.ResumeLayout(false);
            this.statusBg.ResumeLayout(false);
            this.sexBg.ResumeLayout(false);
            this.yearLevelBg.ResumeLayout(false);
            this.semesterBg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel loginBg;
        private System.Windows.Forms.PictureBox brandIcon;
        private System.Windows.Forms.Label brandNameLabel;
        private System.Windows.Forms.Label alreadyHaveLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Panel firstNameBg;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Panel middleNameBg;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox middleNameTextbox;
        private System.Windows.Forms.Panel birthdayBg;
        private CustomDatePicker birthdayPicker;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Panel courseBg;
        private StudentPortalControls.CustomComboBox courseComboBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Panel lastNameBg;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Panel emailBg;
        private System.Windows.Forms.Panel statusBg;
        private StudentPortalControls.CustomComboBox statusComboBox;
        private System.Windows.Forms.Label sexLabel;
        private StudentPortalControls.CustomComboBox sexComboBox;
        private System.Windows.Forms.Panel sexBg;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Panel passwordBg;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextbox;
        private System.Windows.Forms.Panel confirmPasswordBg;
        private System.Windows.Forms.Label wrongFirstNameLabel;
        private System.Windows.Forms.Label yearLevelLabel;
        private System.Windows.Forms.Panel yearLevelBg;
        private StudentPortalControls.CustomComboBox yearLevelComboBox;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Panel semesterBg;
        private StudentPortalControls.CustomComboBox semesterComboBox;
        private System.Windows.Forms.Label wrongLastNameLabel;
        private System.Windows.Forms.Label wrongEmailLabel;
        private System.Windows.Forms.Label wrongPasswordLabel;
        private System.Windows.Forms.Label wrongConfirmPasswordLabel;
    }
}