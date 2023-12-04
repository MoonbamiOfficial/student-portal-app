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
            this.studentCover = new System.Windows.Forms.PictureBox();
            this.studentNameNumber = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.studentIcon = new StudentPortal.StudentPortalControls.CustomPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentCover)).BeginInit();
            this.studentNameNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.passwordLabel.Location = new System.Drawing.Point(80, 566);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(117, 34);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.emailLabel.Location = new System.Drawing.Point(580, 566);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 34);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // studentNumber
            // 
            this.studentNumber.BackColor = System.Drawing.Color.Transparent;
            this.studentNumber.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentNumber.Location = new System.Drawing.Point(226, 3);
            this.studentNumber.Margin = new System.Windows.Forms.Padding(3);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(100, 48);
            this.studentNumber.TabIndex = 0;
            this.studentNumber.Text = "#202111966";
            this.studentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentEmail
            // 
            this.studentEmail.BackColor = System.Drawing.Color.Transparent;
            this.studentEmail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentEmail.Location = new System.Drawing.Point(3, 57);
            this.studentEmail.Margin = new System.Windows.Forms.Padding(3);
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(631, 32);
            this.studentEmail.TabIndex = 0;
            this.studentEmail.Text = "user_student@gmail.com";
            this.studentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.BackColor = System.Drawing.Color.Transparent;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.studentName.Location = new System.Drawing.Point(3, 3);
            this.studentName.Margin = new System.Windows.Forms.Padding(3);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(217, 31);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "User Username";
            this.studentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(80, 730);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(221, 34);
            this.confirmPasswordLabel.TabIndex = 0;
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
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(546, 764);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(157, 80);
            this.editBtn.TabIndex = 4;
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
            this.emailTextbox.Multiline = true;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.ReadOnly = true;
            this.emailTextbox.Size = new System.Drawing.Size(340, 29);
            this.emailTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.passwordTextbox.Location = new System.Drawing.Point(80, 626);
            this.passwordTextbox.Multiline = true;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.ReadOnly = true;
            this.passwordTextbox.Size = new System.Drawing.Size(340, 29);
            this.passwordTextbox.TabIndex = 1;
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.confirmPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextbox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(80, 790);
            this.confirmPasswordTextbox.Multiline = true;
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.ReadOnly = true;
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(340, 29);
            this.confirmPasswordTextbox.TabIndex = 3;
            // 
            // emailBg
            // 
            this.emailBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.emailBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailBg.Location = new System.Drawing.Point(550, 600);
            this.emailBg.Name = "emailBg";
            this.emailBg.Size = new System.Drawing.Size(400, 80);
            this.emailBg.TabIndex = 0;
            this.emailBg.Click += new System.EventHandler(this.emailBg_Click);
            // 
            // confirmPasswordBg
            // 
            this.confirmPasswordBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.confirmPasswordBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordBg.Location = new System.Drawing.Point(50, 764);
            this.confirmPasswordBg.Name = "confirmPasswordBg";
            this.confirmPasswordBg.Size = new System.Drawing.Size(400, 80);
            this.confirmPasswordBg.TabIndex = 0;
            this.confirmPasswordBg.Click += new System.EventHandler(this.confirmPasswordBg_Click);
            // 
            // passwordBg
            // 
            this.passwordBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.passwordBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBg.Location = new System.Drawing.Point(50, 600);
            this.passwordBg.Name = "passwordBg";
            this.passwordBg.Size = new System.Drawing.Size(400, 80);
            this.passwordBg.TabIndex = 0;
            this.passwordBg.Click += new System.EventHandler(this.passwordBg_Click);
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
            this.studentNameNumber.Controls.Add(this.studentEmail);
            this.studentNameNumber.Location = new System.Drawing.Point(316, 410);
            this.studentNameNumber.Margin = new System.Windows.Forms.Padding(0);
            this.studentNameNumber.Name = "studentNameNumber";
            this.studentNameNumber.Size = new System.Drawing.Size(654, 100);
            this.studentNameNumber.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(793, 764);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(157, 80);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
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
            this.Controls.Add(this.studentIcon);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.confirmPasswordTextbox);
            this.Controls.Add(this.studentCover);
            this.Controls.Add(this.passwordBg);
            this.Controls.Add(this.confirmPasswordBg);
            this.Controls.Add(this.emailBg);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1000, 1024);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentCover)).EndInit();
            this.studentNameNumber.ResumeLayout(false);
            this.studentNameNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StudentPortalControls.CustomPictureBox studentIcon;
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
        private System.Windows.Forms.Button saveBtn;
    }
}
