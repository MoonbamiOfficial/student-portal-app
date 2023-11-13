namespace StudentPortal
{
    partial class homeForm
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
            this.sideNavBg = new System.Windows.Forms.Panel();
            this.userIcon = new StudentPortal.StudentPortalControls.pictureBoxCustom();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // sideNavBg
            // 
            this.sideNavBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.sideNavBg.Location = new System.Drawing.Point(0, 0);
            this.sideNavBg.Name = "sideNavBg";
            this.sideNavBg.Size = new System.Drawing.Size(440, 1024);
            this.sideNavBg.TabIndex = 0;
            // 
            // userIcon
            // 
            this.userIcon.Location = new System.Drawing.Point(134, 50);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(150, 150);
            this.userIcon.TabIndex = 1;
            this.userIcon.TabStop = false;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.sideNavBg);
            this.Name = "homeForm";
            this.Text = "homeForm";
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideNavBg;
        private StudentPortalControls.pictureBoxCustom userIcon;
    }
}