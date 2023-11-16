namespace StudentPortal.Panels
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.studentNumber = new System.Windows.Forms.Label();
            this.studentEmail = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.emailBg = new System.Windows.Forms.Panel();
            this.confirmPasswordBg = new System.Windows.Forms.Panel();
            this.passwordBg = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.studentCover = new System.Windows.Forms.PictureBox();
            this.studentNameNumber = new System.Windows.Forms.FlowLayoutPanel();
            this.confirmEmailLabel = new System.Windows.Forms.Label();
            this.confirmEmailBg = new System.Windows.Forms.Panel();
            this.confirmEmailTextbox = new System.Windows.Forms.TextBox();
            this.studentIcon = new StudentPortal.StudentPortalControls.pictureBoxCustom();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCover)).BeginInit();
            this.studentNameNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.passwordLabel.Location = new System.Drawing.Point(80, 566);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(117, 34);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.emailLabel.Location = new System.Drawing.Point(580, 566);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 34);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // studentNumber
            // 
            this.studentNumber.BackColor = System.Drawing.Color.Transparent;
            this.studentNumber.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentNumber.Location = new System.Drawing.Point(240, 0);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(100, 48);
            this.studentNumber.TabIndex = 16;
            this.studentNumber.Text = "#202111966";
            this.studentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentEmail
            // 
            this.studentEmail.BackColor = System.Drawing.Color.Transparent;
            this.studentEmail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentEmail.Location = new System.Drawing.Point(316, 458);
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(420, 28);
            this.studentEmail.TabIndex = 15;
            this.studentEmail.Text = "user_student@gmail.com";
            this.studentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.BackColor = System.Drawing.Color.Transparent;
            this.studentName.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentName.Location = new System.Drawing.Point(3, 0);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(231, 48);
            this.studentName.TabIndex = 14;
            this.studentName.Text = "User Username";
            this.studentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(80, 730);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(221, 34);
            this.confirmPasswordLabel.TabIndex = 19;
            this.confirmPasswordLabel.Text = "Confirm Password";
            this.confirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmPasswordLabel.Click += new System.EventHandler(this.confirmPasswordLabel_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(350, 880);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(300, 80);
            this.editBtn.TabIndex = 20;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.emailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.emailTextbox.Location = new System.Drawing.Point(580, 626);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(340, 29);
            this.emailTextbox.TabIndex = 26;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.passwordTextbox.Location = new System.Drawing.Point(80, 626);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(340, 29);
            this.passwordTextbox.TabIndex = 22;
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.confirmPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(80, 790);
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(340, 29);
            this.confirmPasswordTextbox.TabIndex = 24;
            // 
            // emailBg
            // 
            this.emailBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.emailBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailBg.Location = new System.Drawing.Point(550, 600);
            this.emailBg.Name = "emailBg";
            this.emailBg.Size = new System.Drawing.Size(400, 80);
            this.emailBg.TabIndex = 25;
            this.emailBg.Click += new System.EventHandler(this.emailBg_Click);
            // 
            // confirmPasswordBg
            // 
            this.confirmPasswordBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.confirmPasswordBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordBg.Location = new System.Drawing.Point(50, 764);
            this.confirmPasswordBg.Name = "confirmPasswordBg";
            this.confirmPasswordBg.Size = new System.Drawing.Size(400, 80);
            this.confirmPasswordBg.TabIndex = 23;
            this.confirmPasswordBg.Click += new System.EventHandler(this.confirmPasswordBg_Click);
            // 
            // passwordBg
            // 
            this.passwordBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.passwordBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBg.Location = new System.Drawing.Point(50, 600);
            this.passwordBg.Name = "passwordBg";
            this.passwordBg.Size = new System.Drawing.Size(400, 80);
            this.passwordBg.TabIndex = 21;
            this.passwordBg.Click += new System.EventHandler(this.passwordBg_Click);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::StudentPortal.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(820, 220);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 150);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // studentCover
            // 
            this.studentCover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentCover.Image = global::StudentPortal.Properties.Resources.entrance;
            this.studentCover.Location = new System.Drawing.Point(0, 0);
            this.studentCover.Name = "studentCover";
            this.studentCover.Size = new System.Drawing.Size(1000, 400);
            this.studentCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentCover.TabIndex = 4;
            this.studentCover.TabStop = false;
            // 
            // studentNameNumber
            // 
            this.studentNameNumber.BackColor = System.Drawing.Color.Transparent;
            this.studentNameNumber.Controls.Add(this.studentName);
            this.studentNameNumber.Controls.Add(this.studentNumber);
            this.studentNameNumber.Location = new System.Drawing.Point(316, 410);
            this.studentNameNumber.Margin = new System.Windows.Forms.Padding(0);
            this.studentNameNumber.Name = "studentNameNumber";
            this.studentNameNumber.Size = new System.Drawing.Size(654, 55);
            this.studentNameNumber.TabIndex = 27;
            // 
            // confirmEmailLabel
            // 
            this.confirmEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmEmailLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.confirmEmailLabel.Location = new System.Drawing.Point(580, 730);
            this.confirmEmailLabel.Name = "confirmEmailLabel";
            this.confirmEmailLabel.Size = new System.Drawing.Size(170, 34);
            this.confirmEmailLabel.TabIndex = 28;
            this.confirmEmailLabel.Text = "Confirm Email";
            this.confirmEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmEmailLabel.Click += new System.EventHandler(this.confirmEmailLabel_Click);
            // 
            // confirmEmailBg
            // 
            this.confirmEmailBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.confirmEmailBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmEmailBg.Location = new System.Drawing.Point(550, 764);
            this.confirmEmailBg.Name = "confirmEmailBg";
            this.confirmEmailBg.Size = new System.Drawing.Size(400, 80);
            this.confirmEmailBg.TabIndex = 29;
            this.confirmEmailBg.Click += new System.EventHandler(this.confirmEmailBg_Click);
            // 
            // confirmEmailTextbox
            // 
            this.confirmEmailTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.confirmEmailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmEmailTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmEmailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.confirmEmailTextbox.Location = new System.Drawing.Point(580, 790);
            this.confirmEmailTextbox.Name = "confirmEmailTextbox";
            this.confirmEmailTextbox.Size = new System.Drawing.Size(340, 29);
            this.confirmEmailTextbox.TabIndex = 30;
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
            this.studentIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.studentIcon.GradientAngle = 0F;
            this.studentIcon.Image = global::StudentPortal.Properties.Resources.maleStudent;
            this.studentIcon.Location = new System.Drawing.Point(50, 285);
            this.studentIcon.Margin = new System.Windows.Forms.Padding(0);
            this.studentIcon.Name = "studentIcon";
            this.studentIcon.Size = new System.Drawing.Size(250, 250);
            this.studentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentIcon.TabIndex = 14;
            this.studentIcon.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.studentNameNumber);
            this.Controls.Add(this.studentEmail);
            this.Controls.Add(this.studentIcon);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.confirmEmailLabel);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.confirmEmailTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.confirmPasswordTextbox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.studentCover);
            this.Controls.Add(this.passwordBg);
            this.Controls.Add(this.confirmPasswordBg);
            this.Controls.Add(this.emailBg);
            this.Controls.Add(this.confirmEmailBg);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1000, 1024);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCover)).EndInit();
            this.studentNameNumber.ResumeLayout(false);
            this.studentNameNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StudentPortalControls.pictureBoxCustom studentIcon;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox studentCover;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label studentNumber;
        private System.Windows.Forms.Label studentEmail;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox confirmPasswordTextbox;
        private System.Windows.Forms.Panel emailBg;
        private System.Windows.Forms.Panel confirmPasswordBg;
        private System.Windows.Forms.Panel passwordBg;
        private System.Windows.Forms.FlowLayoutPanel studentNameNumber;
        private System.Windows.Forms.Label confirmEmailLabel;
        private System.Windows.Forms.Panel confirmEmailBg;
        private System.Windows.Forms.TextBox confirmEmailTextbox;
    }
}
