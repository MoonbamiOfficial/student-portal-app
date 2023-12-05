namespace StudentPortal.Panels.TodoPanels.ActivitiesFolder
{
    partial class ActivityTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityTwo));
            this.todoName = new System.Windows.Forms.Label();
            this.todoNumber = new System.Windows.Forms.Label();
            this.todoDeadline = new System.Windows.Forms.Label();
            this.verticalLine = new System.Windows.Forms.Panel();
            this.todoDesc = new System.Windows.Forms.Label();
            this.sampleVid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sampleVid)).BeginInit();
            this.SuspendLayout();
            // 
            // todoName
            // 
            this.todoName.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.todoName.Location = new System.Drawing.Point(25, 30);
            this.todoName.Margin = new System.Windows.Forms.Padding(0);
            this.todoName.Name = "todoName";
            this.todoName.Size = new System.Drawing.Size(659, 58);
            this.todoName.TabIndex = 0;
            this.todoName.Text = "Reflection";
            this.todoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // todoNumber
            // 
            this.todoNumber.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.todoNumber.Location = new System.Drawing.Point(25, 128);
            this.todoNumber.Margin = new System.Windows.Forms.Padding(0);
            this.todoNumber.Name = "todoNumber";
            this.todoNumber.Size = new System.Drawing.Size(84, 23);
            this.todoNumber.TabIndex = 0;
            this.todoNumber.Text = "Activity #2";
            this.todoNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // todoDeadline
            // 
            this.todoDeadline.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.todoDeadline.Location = new System.Drawing.Point(600, 128);
            this.todoDeadline.Margin = new System.Windows.Forms.Padding(0);
            this.todoDeadline.Name = "todoDeadline";
            this.todoDeadline.Size = new System.Drawing.Size(84, 23);
            this.todoDeadline.TabIndex = 0;
            this.todoDeadline.Text = "Due Dec 25";
            this.todoDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // verticalLine
            // 
            this.verticalLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(207)))), ((int)(((byte)(191)))));
            this.verticalLine.Location = new System.Drawing.Point(0, 183);
            this.verticalLine.Margin = new System.Windows.Forms.Padding(0);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(715, 5);
            this.verticalLine.TabIndex = 0;
            // 
            // todoDesc
            // 
            this.todoDesc.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.todoDesc.Location = new System.Drawing.Point(44, 209);
            this.todoDesc.Margin = new System.Windows.Forms.Padding(0);
            this.todoDesc.Name = "todoDesc";
            this.todoDesc.Size = new System.Drawing.Size(607, 300);
            this.todoDesc.TabIndex = 0;
            this.todoDesc.Text = "Make a reflection paper about this video";
            // 
            // sampleVid
            // 
            this.sampleVid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sampleVid.Image = ((System.Drawing.Image)(resources.GetObject("sampleVid.Image")));
            this.sampleVid.Location = new System.Drawing.Point(49, 311);
            this.sampleVid.Margin = new System.Windows.Forms.Padding(0);
            this.sampleVid.Name = "sampleVid";
            this.sampleVid.Size = new System.Drawing.Size(600, 250);
            this.sampleVid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sampleVid.TabIndex = 1;
            this.sampleVid.TabStop = false;
            // 
            // ActivityTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.sampleVid);
            this.Controls.Add(this.todoDesc);
            this.Controls.Add(this.verticalLine);
            this.Controls.Add(this.todoDeadline);
            this.Controls.Add(this.todoNumber);
            this.Controls.Add(this.todoName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ActivityTwo";
            this.Size = new System.Drawing.Size(715, 878);
            ((System.ComponentModel.ISupportInitialize)(this.sampleVid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label todoName;
        private System.Windows.Forms.Label todoNumber;
        private System.Windows.Forms.Label todoDeadline;
        private System.Windows.Forms.Panel verticalLine;
        private System.Windows.Forms.Label todoDesc;
        private System.Windows.Forms.PictureBox sampleVid;
    }
}
