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
            this.headerDesc = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.schoolHeaderDesc = new System.Windows.Forms.Label();
            this.schoolHeader = new System.Windows.Forms.Label();
            this.schoolCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCover)).BeginInit();
            this.SuspendLayout();
            // 
            // headerDesc
            // 
            this.headerDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerDesc.BackColor = System.Drawing.Color.Transparent;
            this.headerDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.headerDesc.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.headerDesc.Location = new System.Drawing.Point(41, 840);
            this.headerDesc.Name = "headerDesc";
            this.headerDesc.Size = new System.Drawing.Size(500, 84);
            this.headerDesc.TabIndex = 0;
            this.headerDesc.Text = "The ideal application where students can create their own private space, monitor " +
    "their activities, home works, projects, grades and many more. ";
            this.headerDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerDesc.UseMnemonic = false;
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.header.Font = new System.Drawing.Font("Poppins SemiBold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.header.Location = new System.Drawing.Point(41, 650);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(431, 180);
            this.header.TabIndex = 0;
            this.header.Text = "Your Journey Starts Here.";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.header.UseMnemonic = false;
            // 
            // schoolHeaderDesc
            // 
            this.schoolHeaderDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schoolHeaderDesc.BackColor = System.Drawing.Color.Transparent;
            this.schoolHeaderDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.schoolHeaderDesc.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolHeaderDesc.ForeColor = System.Drawing.Color.White;
            this.schoolHeaderDesc.Location = new System.Drawing.Point(208, 316);
            this.schoolHeaderDesc.Name = "schoolHeaderDesc";
            this.schoolHeaderDesc.Size = new System.Drawing.Size(583, 56);
            this.schoolHeaderDesc.TabIndex = 0;
            this.schoolHeaderDesc.Text = "TO DREAM, LEARN & DISCOVER";
            this.schoolHeaderDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.schoolHeaderDesc.UseMnemonic = false;
            // 
            // schoolHeader
            // 
            this.schoolHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schoolHeader.BackColor = System.Drawing.Color.Transparent;
            this.schoolHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.schoolHeader.Font = new System.Drawing.Font("Poppins", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolHeader.ForeColor = System.Drawing.Color.White;
            this.schoolHeader.Location = new System.Drawing.Point(239, 200);
            this.schoolHeader.Name = "schoolHeader";
            this.schoolHeader.Size = new System.Drawing.Size(514, 116);
            this.schoolHeader.TabIndex = 0;
            this.schoolHeader.Text = "GET READY";
            this.schoolHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schoolCover
            // 
            this.schoolCover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schoolCover.Image = global::StudentPortal.Properties.Resources.classroom;
            this.schoolCover.Location = new System.Drawing.Point(0, 0);
            this.schoolCover.Name = "schoolCover";
            this.schoolCover.Size = new System.Drawing.Size(1000, 600);
            this.schoolCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schoolCover.TabIndex = 3;
            this.schoolCover.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.schoolHeader);
            this.Controls.Add(this.schoolHeaderDesc);
            this.Controls.Add(this.header);
            this.Controls.Add(this.headerDesc);
            this.Controls.Add(this.schoolCover);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1000, 1024);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label headerDesc;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label schoolHeaderDesc;
        private System.Windows.Forms.Label schoolHeader;
        private System.Windows.Forms.PictureBox schoolCover;
    }
}
