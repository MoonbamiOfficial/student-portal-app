namespace StudentPortal.Panels
{
    partial class Home
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
            this.headerDescHome = new System.Windows.Forms.Label();
            this.headerHome = new System.Windows.Forms.Label();
            this.schoolHeaderDescHome = new System.Windows.Forms.Label();
            this.schoolHeaderHome = new System.Windows.Forms.Label();
            this.schoolLogoHome = new System.Windows.Forms.PictureBox();
            this.schoolCoverHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.schoolLogoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCoverHome)).BeginInit();
            this.SuspendLayout();
            // 
            // headerDescHome
            // 
            this.headerDescHome.BackColor = System.Drawing.Color.Transparent;
            this.headerDescHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.headerDescHome.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerDescHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.headerDescHome.Location = new System.Drawing.Point(41, 840);
            this.headerDescHome.Name = "headerDescHome";
            this.headerDescHome.Size = new System.Drawing.Size(500, 84);
            this.headerDescHome.TabIndex = 7;
            this.headerDescHome.Text = "The ideal application where students can create their own private space, monitor " +
    "their activities, home works, projects, grades and many more. ";
            this.headerDescHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerDescHome.UseMnemonic = false;
            // 
            // headerHome
            // 
            this.headerHome.BackColor = System.Drawing.Color.Transparent;
            this.headerHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.headerHome.Font = new System.Drawing.Font("Poppins SemiBold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.headerHome.Location = new System.Drawing.Point(41, 650);
            this.headerHome.Name = "headerHome";
            this.headerHome.Size = new System.Drawing.Size(431, 180);
            this.headerHome.TabIndex = 6;
            this.headerHome.Text = "Your Journey Starts Here.";
            this.headerHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerHome.UseMnemonic = false;
            // 
            // schoolHeaderDescHome
            // 
            this.schoolHeaderDescHome.BackColor = System.Drawing.Color.Transparent;
            this.schoolHeaderDescHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.schoolHeaderDescHome.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolHeaderDescHome.ForeColor = System.Drawing.Color.White;
            this.schoolHeaderDescHome.Location = new System.Drawing.Point(208, 316);
            this.schoolHeaderDescHome.Name = "schoolHeaderDescHome";
            this.schoolHeaderDescHome.Size = new System.Drawing.Size(583, 56);
            this.schoolHeaderDescHome.TabIndex = 5;
            this.schoolHeaderDescHome.Text = "TO DREAM, LEARN & DISCOVER";
            this.schoolHeaderDescHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.schoolHeaderDescHome.UseMnemonic = false;
            // 
            // schoolHeaderHome
            // 
            this.schoolHeaderHome.BackColor = System.Drawing.Color.Transparent;
            this.schoolHeaderHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.schoolHeaderHome.Font = new System.Drawing.Font("Poppins", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolHeaderHome.ForeColor = System.Drawing.Color.White;
            this.schoolHeaderHome.Location = new System.Drawing.Point(239, 200);
            this.schoolHeaderHome.Name = "schoolHeaderHome";
            this.schoolHeaderHome.Size = new System.Drawing.Size(514, 116);
            this.schoolHeaderHome.TabIndex = 4;
            this.schoolHeaderHome.Text = "GET READY";
            this.schoolHeaderHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schoolLogoHome
            // 
            this.schoolLogoHome.BackColor = System.Drawing.Color.Transparent;
            this.schoolLogoHome.Image = global::StudentPortal.Properties.Resources.logo;
            this.schoolLogoHome.Location = new System.Drawing.Point(628, 663);
            this.schoolLogoHome.Name = "schoolLogoHome";
            this.schoolLogoHome.Size = new System.Drawing.Size(250, 250);
            this.schoolLogoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schoolLogoHome.TabIndex = 8;
            this.schoolLogoHome.TabStop = false;
            // 
            // schoolCoverHome
            // 
            this.schoolCoverHome.Image = global::StudentPortal.Properties.Resources.classroom;
            this.schoolCoverHome.Location = new System.Drawing.Point(0, 0);
            this.schoolCoverHome.Name = "schoolCoverHome";
            this.schoolCoverHome.Size = new System.Drawing.Size(1000, 600);
            this.schoolCoverHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schoolCoverHome.TabIndex = 3;
            this.schoolCoverHome.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.schoolHeaderHome);
            this.Controls.Add(this.schoolHeaderDescHome);
            this.Controls.Add(this.headerHome);
            this.Controls.Add(this.headerDescHome);
            this.Controls.Add(this.schoolLogoHome);
            this.Controls.Add(this.schoolCoverHome);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1000, 1024);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolLogoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCoverHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label headerDescHome;
        private System.Windows.Forms.Label headerHome;
        private System.Windows.Forms.Label schoolHeaderDescHome;
        private System.Windows.Forms.Label schoolHeaderHome;
        private System.Windows.Forms.PictureBox schoolLogoHome;
        private System.Windows.Forms.PictureBox schoolCoverHome;
    }
}
