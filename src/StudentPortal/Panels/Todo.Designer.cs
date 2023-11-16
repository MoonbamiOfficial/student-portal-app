namespace StudentPortal.Panels
{
    partial class Todo
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
            this.horizontalLine = new System.Windows.Forms.Panel();
            this.verticalLine = new System.Windows.Forms.Panel();
            this.todoHeader = new System.Windows.Forms.Label();
            this.sideNavLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.activitiesBtn = new FontAwesome.Sharp.IconButton();
            this.homeWorkBtn = new FontAwesome.Sharp.IconButton();
            this.projectsBtn = new FontAwesome.Sharp.IconButton();
            this.quizzesBtn = new FontAwesome.Sharp.IconButton();
            this.testsBtn = new FontAwesome.Sharp.IconButton();
            this.missedBtn = new FontAwesome.Sharp.IconButton();
            this.finishedBtn = new FontAwesome.Sharp.IconButton();
            this.activitiesPanel = new StudentPortal.Panels.TodoPanels.ActivitiesPanel();
            this.projectsPanel = new StudentPortal.Panels.TodoPanels.ProjectsPanel();
            this.relaxPanel = new StudentPortal.Panels.TodoPanels.RelaxPanel();
            this.relax = new StudentPortal.Panels.TodoPanels.RelaxPanel();
            this.missedPanel = new StudentPortal.Panels.TodoPanels.MissedPanel();
            this.finishedPanel = new StudentPortal.Panels.TodoPanels.FinishedPanel();
            this.sideNavLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // horizontalLine
            // 
            this.horizontalLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(207)))), ((int)(((byte)(191)))));
            this.horizontalLine.Location = new System.Drawing.Point(0, 126);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(1000, 5);
            this.horizontalLine.TabIndex = 0;
            // 
            // verticalLine
            // 
            this.verticalLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(207)))), ((int)(((byte)(191)))));
            this.verticalLine.Location = new System.Drawing.Point(280, 126);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(5, 1000);
            this.verticalLine.TabIndex = 1;
            // 
            // todoHeader
            // 
            this.todoHeader.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.todoHeader.Location = new System.Drawing.Point(30, 20);
            this.todoHeader.Name = "todoHeader";
            this.todoHeader.Size = new System.Drawing.Size(192, 58);
            this.todoHeader.TabIndex = 0;
            this.todoHeader.Text = "TO-DOs";
            this.todoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sideNavLayoutPanel
            // 
            this.sideNavLayoutPanel.Controls.Add(this.activitiesBtn);
            this.sideNavLayoutPanel.Controls.Add(this.homeWorkBtn);
            this.sideNavLayoutPanel.Controls.Add(this.projectsBtn);
            this.sideNavLayoutPanel.Controls.Add(this.quizzesBtn);
            this.sideNavLayoutPanel.Controls.Add(this.testsBtn);
            this.sideNavLayoutPanel.Controls.Add(this.missedBtn);
            this.sideNavLayoutPanel.Controls.Add(this.finishedBtn);
            this.sideNavLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideNavLayoutPanel.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideNavLayoutPanel.Location = new System.Drawing.Point(0, 129);
            this.sideNavLayoutPanel.Name = "sideNavLayoutPanel";
            this.sideNavLayoutPanel.Size = new System.Drawing.Size(280, 746);
            this.sideNavLayoutPanel.TabIndex = 0;
            // 
            // activitiesBtn
            // 
            this.activitiesBtn.BackColor = System.Drawing.Color.Transparent;
            this.activitiesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activitiesBtn.FlatAppearance.BorderSize = 0;
            this.activitiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activitiesBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.activitiesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.activitiesBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.activitiesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.activitiesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.activitiesBtn.IconSize = 35;
            this.activitiesBtn.Location = new System.Drawing.Point(0, 0);
            this.activitiesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.activitiesBtn.Name = "activitiesBtn";
            this.activitiesBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.activitiesBtn.Size = new System.Drawing.Size(280, 100);
            this.activitiesBtn.TabIndex = 1;
            this.activitiesBtn.Text = "ACTIVITIES";
            this.activitiesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activitiesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.activitiesBtn.UseVisualStyleBackColor = false;
            this.activitiesBtn.Click += new System.EventHandler(this.activitiesBtn_Click);
            this.activitiesBtn.MouseEnter += new System.EventHandler(this.activitiesBtn_MouseEnter);
            this.activitiesBtn.MouseLeave += new System.EventHandler(this.activitiesBtn_MouseLeave);
            // 
            // homeWorkBtn
            // 
            this.homeWorkBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeWorkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeWorkBtn.FlatAppearance.BorderSize = 0;
            this.homeWorkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeWorkBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.homeWorkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.homeWorkBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.homeWorkBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.homeWorkBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeWorkBtn.IconSize = 35;
            this.homeWorkBtn.Location = new System.Drawing.Point(0, 100);
            this.homeWorkBtn.Margin = new System.Windows.Forms.Padding(0);
            this.homeWorkBtn.Name = "homeWorkBtn";
            this.homeWorkBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.homeWorkBtn.Size = new System.Drawing.Size(280, 100);
            this.homeWorkBtn.TabIndex = 2;
            this.homeWorkBtn.Text = "HOMEWORK";
            this.homeWorkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeWorkBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.homeWorkBtn.UseVisualStyleBackColor = false;
            this.homeWorkBtn.Click += new System.EventHandler(this.homeWorkBtn_Click);
            this.homeWorkBtn.MouseEnter += new System.EventHandler(this.homeWorkBtn_MouseEnter);
            this.homeWorkBtn.MouseLeave += new System.EventHandler(this.homeWorkBtn_MouseLeave);
            // 
            // projectsBtn
            // 
            this.projectsBtn.BackColor = System.Drawing.Color.Transparent;
            this.projectsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectsBtn.FlatAppearance.BorderSize = 0;
            this.projectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.projectsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.projectsBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.projectsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.projectsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.projectsBtn.IconSize = 35;
            this.projectsBtn.Location = new System.Drawing.Point(0, 200);
            this.projectsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.projectsBtn.Name = "projectsBtn";
            this.projectsBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.projectsBtn.Size = new System.Drawing.Size(280, 100);
            this.projectsBtn.TabIndex = 3;
            this.projectsBtn.Text = "PROJECTS";
            this.projectsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.projectsBtn.UseVisualStyleBackColor = false;
            this.projectsBtn.Click += new System.EventHandler(this.projectsBtn_Click);
            this.projectsBtn.MouseEnter += new System.EventHandler(this.projectsBtn_MouseEnter);
            this.projectsBtn.MouseLeave += new System.EventHandler(this.projectsBtn_MouseLeave);
            // 
            // quizzesBtn
            // 
            this.quizzesBtn.BackColor = System.Drawing.Color.Transparent;
            this.quizzesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quizzesBtn.FlatAppearance.BorderSize = 0;
            this.quizzesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizzesBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.quizzesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.quizzesBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.quizzesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.quizzesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.quizzesBtn.IconSize = 35;
            this.quizzesBtn.Location = new System.Drawing.Point(0, 300);
            this.quizzesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.quizzesBtn.Name = "quizzesBtn";
            this.quizzesBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.quizzesBtn.Size = new System.Drawing.Size(280, 100);
            this.quizzesBtn.TabIndex = 4;
            this.quizzesBtn.Text = "QUIZZES";
            this.quizzesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quizzesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.quizzesBtn.UseVisualStyleBackColor = false;
            this.quizzesBtn.Click += new System.EventHandler(this.quizzesBtn_Click);
            this.quizzesBtn.MouseEnter += new System.EventHandler(this.quizzesBtn_MouseEnter);
            this.quizzesBtn.MouseLeave += new System.EventHandler(this.quizzesBtn_MouseLeave);
            // 
            // testsBtn
            // 
            this.testsBtn.BackColor = System.Drawing.Color.Transparent;
            this.testsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testsBtn.FlatAppearance.BorderSize = 0;
            this.testsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testsBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.testsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.testsBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.testsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.testsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.testsBtn.IconSize = 35;
            this.testsBtn.Location = new System.Drawing.Point(0, 400);
            this.testsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.testsBtn.Name = "testsBtn";
            this.testsBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.testsBtn.Size = new System.Drawing.Size(280, 100);
            this.testsBtn.TabIndex = 5;
            this.testsBtn.Text = "TESTS";
            this.testsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.testsBtn.UseVisualStyleBackColor = false;
            this.testsBtn.Click += new System.EventHandler(this.testsBtn_Click);
            this.testsBtn.MouseEnter += new System.EventHandler(this.testsBtn_MouseEnter);
            this.testsBtn.MouseLeave += new System.EventHandler(this.testsBtn_MouseLeave);
            // 
            // missedBtn
            // 
            this.missedBtn.BackColor = System.Drawing.Color.Transparent;
            this.missedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.missedBtn.FlatAppearance.BorderSize = 0;
            this.missedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missedBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.missedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.missedBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.missedBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.missedBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.missedBtn.IconSize = 35;
            this.missedBtn.Location = new System.Drawing.Point(0, 500);
            this.missedBtn.Margin = new System.Windows.Forms.Padding(0);
            this.missedBtn.Name = "missedBtn";
            this.missedBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.missedBtn.Size = new System.Drawing.Size(280, 100);
            this.missedBtn.TabIndex = 6;
            this.missedBtn.Text = "MISSED";
            this.missedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.missedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.missedBtn.UseVisualStyleBackColor = false;
            this.missedBtn.Click += new System.EventHandler(this.missedBtn_Click);
            this.missedBtn.MouseEnter += new System.EventHandler(this.missedBtn_MouseEnter);
            this.missedBtn.MouseLeave += new System.EventHandler(this.missedBtn_MouseLeave);
            // 
            // finishedBtn
            // 
            this.finishedBtn.BackColor = System.Drawing.Color.Transparent;
            this.finishedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishedBtn.FlatAppearance.BorderSize = 0;
            this.finishedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishedBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.finishedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.finishedBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.finishedBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.finishedBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.finishedBtn.IconSize = 35;
            this.finishedBtn.Location = new System.Drawing.Point(0, 600);
            this.finishedBtn.Margin = new System.Windows.Forms.Padding(0);
            this.finishedBtn.Name = "finishedBtn";
            this.finishedBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.finishedBtn.Size = new System.Drawing.Size(280, 100);
            this.finishedBtn.TabIndex = 7;
            this.finishedBtn.Text = "FINISHED";
            this.finishedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.finishedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.finishedBtn.UseVisualStyleBackColor = false;
            this.finishedBtn.Click += new System.EventHandler(this.finishedBtn_Click);
            this.finishedBtn.MouseEnter += new System.EventHandler(this.finishedBtn_MouseEnter);
            this.finishedBtn.MouseLeave += new System.EventHandler(this.finishedBtn_MouseLeave);
            // 
            // activitiesPanel
            // 
            this.activitiesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.activitiesPanel.Location = new System.Drawing.Point(283, 129);
            this.activitiesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.activitiesPanel.Name = "activitiesPanel";
            this.activitiesPanel.Size = new System.Drawing.Size(715, 884);
            this.activitiesPanel.TabIndex = 7;
            // 
            // projectsPanel
            // 
            this.projectsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.projectsPanel.Location = new System.Drawing.Point(283, 129);
            this.projectsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.projectsPanel.Name = "projectsPanel";
            this.projectsPanel.Size = new System.Drawing.Size(715, 878);
            this.projectsPanel.TabIndex = 8;
            // 
            // relaxPanel
            // 
            this.relaxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.relaxPanel.Location = new System.Drawing.Point(283, 129);
            this.relaxPanel.Name = "relaxPanel";
            this.relaxPanel.Size = new System.Drawing.Size(715, 878);
            this.relaxPanel.TabIndex = 9;
            // 
            // relax
            // 
            this.relax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.relax.Location = new System.Drawing.Point(285, 132);
            this.relax.Name = "relax";
            this.relax.Size = new System.Drawing.Size(715, 878);
            this.relax.TabIndex = 4;
            // 
            // missedPanel
            // 
            this.missedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.missedPanel.Location = new System.Drawing.Point(283, 129);
            this.missedPanel.Name = "missedPanel";
            this.missedPanel.Size = new System.Drawing.Size(715, 878);
            this.missedPanel.TabIndex = 10;
            // 
            // finishedPanel
            // 
            this.finishedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.finishedPanel.Location = new System.Drawing.Point(285, 129);
            this.finishedPanel.Name = "finishedPanel";
            this.finishedPanel.Size = new System.Drawing.Size(715, 878);
            this.finishedPanel.TabIndex = 11;
            // 
            // Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.todoHeader);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.verticalLine);
            this.Controls.Add(this.activitiesPanel);
            this.Controls.Add(this.projectsPanel);
            this.Controls.Add(this.relaxPanel);
            this.Controls.Add(this.missedPanel);
            this.Controls.Add(this.finishedPanel);
            this.Controls.Add(this.sideNavLayoutPanel);
            this.Name = "Todo";
            this.Size = new System.Drawing.Size(1000, 1024);
            this.Load += new System.EventHandler(this.Todo_Load);
            this.sideNavLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel horizontalLine;
        private System.Windows.Forms.Panel verticalLine;
        private System.Windows.Forms.Label todoHeader;
        private System.Windows.Forms.FlowLayoutPanel sideNavLayoutPanel;
        private FontAwesome.Sharp.IconButton activitiesBtn;
        private FontAwesome.Sharp.IconButton homeWorkBtn;
        private FontAwesome.Sharp.IconButton projectsBtn;
        private FontAwesome.Sharp.IconButton quizzesBtn;
        private FontAwesome.Sharp.IconButton testsBtn;
        private FontAwesome.Sharp.IconButton missedBtn;
        private TodoPanels.RelaxPanel relax;
        private TodoPanels.ActivitiesPanel activitiesPanel;
        private TodoPanels.ProjectsPanel projectsPanel;
        private TodoPanels.RelaxPanel relaxPanel;
        private FontAwesome.Sharp.IconButton finishedBtn;
        private TodoPanels.MissedPanel missedPanel;
        private TodoPanels.FinishedPanel finishedPanel;
    }
}
