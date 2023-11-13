namespace StudentPortal
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.brandIcon = new System.Windows.Forms.PictureBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.wrongPasswordLabel = new System.Windows.Forms.Label();
            this.wrongEmailLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.newHereLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.brandNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.emailBg = new System.Windows.Forms.Panel();
            this.passwordBg = new System.Windows.Forms.Panel();
            this.loginBg = new System.Windows.Forms.Panel();
            this.signUpBg = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.brandIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.LoginPanel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1424, 985);
            this.LoginPanel.TabIndex = 0;
            // 
            // brandIcon
            // 
            this.brandIcon.Image = global::StudentPortal.Properties.Resources.icon;
            this.brandIcon.Location = new System.Drawing.Point(29, 30);
            this.brandIcon.Name = "brandIcon";
            this.brandIcon.Size = new System.Drawing.Size(100, 100);
            this.brandIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brandIcon.TabIndex = 0;
            this.brandIcon.TabStop = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.passwordTextbox.Location = new System.Drawing.Point(130, 642);
            this.passwordTextbox.MaxLength = 50;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(739, 32);
            this.passwordTextbox.TabIndex = 11;
            this.passwordTextbox.Text = "Password";
            this.passwordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            this.passwordTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextbox_KeyPress);
            this.passwordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.emailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextbox.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.emailTextbox.Location = new System.Drawing.Point(130, 468);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(739, 32);
            this.emailTextbox.TabIndex = 3;
            this.emailTextbox.Text = "student_portal@gmail.com";
            this.emailTextbox.Enter += new System.EventHandler(this.EmailTextbox_Enter);
            this.emailTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextbox_KeyPress);
            this.emailTextbox.Leave += new System.EventHandler(this.EmailTextbox_Leave);
            // 
            // wrongPasswordLabel
            // 
            this.wrongPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongPasswordLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongPasswordLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wrongPasswordLabel.Location = new System.Drawing.Point(100, 538);
            this.wrongPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.wrongPasswordLabel.Name = "wrongPasswordLabel";
            this.wrongPasswordLabel.Size = new System.Drawing.Size(800, 34);
            this.wrongPasswordLabel.TabIndex = 24;
            this.wrongPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wrongEmailLabel
            // 
            this.wrongEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongEmailLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongEmailLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wrongEmailLabel.Location = new System.Drawing.Point(100, 361);
            this.wrongEmailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.wrongEmailLabel.Name = "wrongEmailLabel";
            this.wrongEmailLabel.Size = new System.Drawing.Size(800, 34);
            this.wrongEmailLabel.TabIndex = 23;
            this.wrongEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.emailLabel.Location = new System.Drawing.Point(130, 395);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(78, 40);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.passwordLabel.Location = new System.Drawing.Point(130, 569);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(137, 40);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // newHereLabel
            // 
            this.newHereLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.newHereLabel.Font = new System.Drawing.Font("Poppins SemiBold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHereLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.newHereLabel.Location = new System.Drawing.Point(1052, 349);
            this.newHereLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newHereLabel.Name = "newHereLabel";
            this.newHereLabel.Size = new System.Drawing.Size(336, 77);
            this.newHereLabel.TabIndex = 0;
            this.newHereLabel.Text = "New Here?";
            this.newHereLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descLabel
            // 
            this.descLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.descLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.descLabel.Location = new System.Drawing.Point(1036, 476);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(367, 68);
            this.descLabel.TabIndex = 1;
            this.descLabel.Text = "Sign up and start being part of this amazing community!";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandNameLabel
            // 
            this.brandNameLabel.AutoSize = true;
            this.brandNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.brandNameLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.brandNameLabel.Location = new System.Drawing.Point(134, 56);
            this.brandNameLabel.Name = "brandNameLabel";
            this.brandNameLabel.Size = new System.Drawing.Size(210, 48);
            this.brandNameLabel.TabIndex = 2;
            this.brandNameLabel.Text = "Student Portal";
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Poppins SemiBold", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.headerLabel.Location = new System.Drawing.Point(280, 199);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(439, 96);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Let\'s Login!";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUpBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.signUpBtn.Location = new System.Drawing.Point(1070, 594);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(300, 80);
            this.signUpBtn.TabIndex = 8;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(350, 809);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(300, 80);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // emailBg
            // 
            this.emailBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.emailBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailBg.Location = new System.Drawing.Point(100, 435);
            this.emailBg.Name = "emailBg";
            this.emailBg.Size = new System.Drawing.Size(800, 100);
            this.emailBg.TabIndex = 10;
            this.emailBg.Click += new System.EventHandler(this.EmailBg_Click);
            // 
            // passwordBg
            // 
            this.passwordBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.passwordBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBg.Location = new System.Drawing.Point(100, 609);
            this.passwordBg.Name = "passwordBg";
            this.passwordBg.Size = new System.Drawing.Size(800, 100);
            this.passwordBg.TabIndex = 11;
            this.passwordBg.Click += new System.EventHandler(this.PasswordBg_Click);
            // 
            // loginBg
            // 
            this.loginBg.Location = new System.Drawing.Point(0, 0);
            this.loginBg.Name = "loginBg";
            this.loginBg.Size = new System.Drawing.Size(1000, 1024);
            this.loginBg.TabIndex = 13;
            // 
            // signUpBg
            // 
            this.signUpBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.signUpBg.Dock = System.Windows.Forms.DockStyle.Right;
            this.signUpBg.Location = new System.Drawing.Point(984, 0);
            this.signUpBg.Name = "signUpBg";
            this.signUpBg.Size = new System.Drawing.Size(440, 985);
            this.signUpBg.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.brandIcon);
            this.Controls.Add(this.brandNameLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.wrongPasswordLabel);
            this.Controls.Add(this.wrongEmailLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.newHereLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.signUpBg);
            this.Controls.Add(this.loginBg);
            this.Controls.Add(this.passwordBg);
            this.Controls.Add(this.emailBg);
            this.Controls.Add(this.LoginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.brandIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel signUpBg;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label brandNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox brandIcon;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label newHereLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Panel emailBg;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Panel passwordBg;
        private System.Windows.Forms.Panel loginBg;
        private System.Windows.Forms.Label wrongEmailLabel;
        private System.Windows.Forms.Label wrongPasswordLabel;
    }
}

