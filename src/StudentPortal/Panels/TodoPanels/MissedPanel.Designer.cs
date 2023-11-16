namespace StudentPortal.Panels.TodoPanels
{
    partial class MissedPanel
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
            this.backBtn = new System.Windows.Forms.Button();
            this.missedList = new System.Windows.Forms.Panel();
            this.one = new System.Windows.Forms.Panel();
            this.dateOneLabel = new System.Windows.Forms.Label();
            this.missedOneLabel = new System.Windows.Forms.Label();
            this.missedOne = new StudentPortal.Panels.TodoPanels.TodosFolder.MissedOne();
            this.missedList.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(358, 697);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(300, 80);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // missedList
            // 
            this.missedList.Controls.Add(this.one);
            this.missedList.Controls.Add(this.dateOneLabel);
            this.missedList.Controls.Add(this.missedOneLabel);
            this.missedList.Location = new System.Drawing.Point(0, 0);
            this.missedList.Name = "missedList";
            this.missedList.Size = new System.Drawing.Size(715, 878);
            this.missedList.TabIndex = 47;
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(207)))), ((int)(((byte)(191)))));
            this.one.Location = new System.Drawing.Point(0, 93);
            this.one.Margin = new System.Windows.Forms.Padding(0);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(715, 5);
            this.one.TabIndex = 0;
            // 
            // dateOneLabel
            // 
            this.dateOneLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateOneLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateOneLabel.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOneLabel.ForeColor = System.Drawing.Color.Maroon;
            this.dateOneLabel.Location = new System.Drawing.Point(600, 35);
            this.dateOneLabel.Name = "dateOneLabel";
            this.dateOneLabel.Size = new System.Drawing.Size(86, 23);
            this.dateOneLabel.TabIndex = 1;
            this.dateOneLabel.Text = "Due Jan 24";
            this.dateOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateOneLabel.Click += new System.EventHandler(this.dateOneLabel_Click);
            this.dateOneLabel.MouseEnter += new System.EventHandler(this.dateOneLabel_MouseEnter);
            this.dateOneLabel.MouseLeave += new System.EventHandler(this.dateOneLabel_MouseLeave);
            // 
            // missedOneLabel
            // 
            this.missedOneLabel.BackColor = System.Drawing.Color.Transparent;
            this.missedOneLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.missedOneLabel.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missedOneLabel.ForeColor = System.Drawing.Color.Maroon;
            this.missedOneLabel.Location = new System.Drawing.Point(0, 0);
            this.missedOneLabel.Margin = new System.Windows.Forms.Padding(0);
            this.missedOneLabel.Name = "missedOneLabel";
            this.missedOneLabel.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.missedOneLabel.Size = new System.Drawing.Size(715, 98);
            this.missedOneLabel.TabIndex = 1;
            this.missedOneLabel.Text = "Homework #2";
            this.missedOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.missedOneLabel.Click += new System.EventHandler(this.missedOneLabel_Click);
            this.missedOneLabel.MouseEnter += new System.EventHandler(this.missedOneLabel_MouseEnter);
            this.missedOneLabel.MouseLeave += new System.EventHandler(this.missedOneLabel_MouseLeave);
            // 
            // missedOne
            // 
            this.missedOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.missedOne.Location = new System.Drawing.Point(0, 0);
            this.missedOne.Name = "missedOne";
            this.missedOne.Size = new System.Drawing.Size(715, 878);
            this.missedOne.TabIndex = 5;
            // 
            // MissedPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.missedList);
            this.Controls.Add(this.missedOne);
            this.Name = "MissedPanel";
            this.Size = new System.Drawing.Size(715, 878);
            this.Load += new System.EventHandler(this.MissedPanel_Load);
            this.missedList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel missedList;
        private System.Windows.Forms.Panel one;
        private System.Windows.Forms.Label dateOneLabel;
        private System.Windows.Forms.Label missedOneLabel;
        private TodosFolder.MissedOne missedOne;
    }
}
