namespace StudentPortal.Panels.TodoPanels
{
    partial class ProjectsPanel
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
            this.projectsList = new System.Windows.Forms.Panel();
            this.one = new System.Windows.Forms.Panel();
            this.dateOneLabel = new System.Windows.Forms.Label();
            this.projOneLabel = new System.Windows.Forms.Label();
            this.projOne = new StudentPortal.Panels.TodoPanels.TodosFolder.ProjectOne();
            this.projectsList.SuspendLayout();
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
            // projectsList
            // 
            this.projectsList.Controls.Add(this.one);
            this.projectsList.Controls.Add(this.dateOneLabel);
            this.projectsList.Controls.Add(this.projOneLabel);
            this.projectsList.Location = new System.Drawing.Point(0, 0);
            this.projectsList.Name = "projectsList";
            this.projectsList.Size = new System.Drawing.Size(715, 878);
            this.projectsList.TabIndex = 46;
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
            this.dateOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.dateOneLabel.Location = new System.Drawing.Point(600, 35);
            this.dateOneLabel.Name = "dateOneLabel";
            this.dateOneLabel.Size = new System.Drawing.Size(86, 23);
            this.dateOneLabel.TabIndex = 1;
            this.dateOneLabel.Text = "Due Jan 3";
            this.dateOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateOneLabel.Click += new System.EventHandler(this.dateOneLabel_Click);
            this.dateOneLabel.MouseEnter += new System.EventHandler(this.dateOneLabel_MouseEnter);
            this.dateOneLabel.MouseLeave += new System.EventHandler(this.dateOneLabel_MouseLeave);
            // 
            // projOneLabel
            // 
            this.projOneLabel.BackColor = System.Drawing.Color.Transparent;
            this.projOneLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projOneLabel.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.projOneLabel.Location = new System.Drawing.Point(0, 0);
            this.projOneLabel.Margin = new System.Windows.Forms.Padding(0);
            this.projOneLabel.Name = "projOneLabel";
            this.projOneLabel.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.projOneLabel.Size = new System.Drawing.Size(715, 98);
            this.projOneLabel.TabIndex = 1;
            this.projOneLabel.Text = "Project #1";
            this.projOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projOneLabel.Click += new System.EventHandler(this.projOneLabel_Click);
            this.projOneLabel.MouseEnter += new System.EventHandler(this.projOneLabel_MouseEnter);
            this.projOneLabel.MouseLeave += new System.EventHandler(this.projOneLabel_MouseLeave);
            // 
            // projOne
            // 
            this.projOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.projOne.Location = new System.Drawing.Point(0, 0);
            this.projOne.Margin = new System.Windows.Forms.Padding(0);
            this.projOne.Name = "projOne";
            this.projOne.Size = new System.Drawing.Size(715, 878);
            this.projOne.TabIndex = 2;
            // 
            // ProjectsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.projectsList);
            this.Controls.Add(this.projOne);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProjectsPanel";
            this.Size = new System.Drawing.Size(715, 878);
            this.Load += new System.EventHandler(this.ProjectsPanel_Load);
            this.projectsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel projectsList;
        private System.Windows.Forms.Panel one;
        private System.Windows.Forms.Label dateOneLabel;
        private System.Windows.Forms.Label projOneLabel;
        private TodosFolder.ProjectOne projOne;
    }
}
