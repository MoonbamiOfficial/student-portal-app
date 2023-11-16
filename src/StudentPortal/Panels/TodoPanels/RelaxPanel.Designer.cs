namespace StudentPortal.Panels.TodoPanels
{
    partial class RelaxPanel
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
            this.relaxMessage = new System.Windows.Forms.Label();
            this.emoticon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // relaxMessage
            // 
            this.relaxMessage.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relaxMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.relaxMessage.Location = new System.Drawing.Point(114, 470);
            this.relaxMessage.Name = "relaxMessage";
            this.relaxMessage.Size = new System.Drawing.Size(519, 48);
            this.relaxMessage.TabIndex = 0;
            this.relaxMessage.Text = "YOU CAN RELAX FOR NOW";
            this.relaxMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emoticon
            // 
            this.emoticon.BackColor = System.Drawing.Color.Transparent;
            this.emoticon.Font = new System.Drawing.Font("Poppins SemiBold", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoticon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.emoticon.Location = new System.Drawing.Point(113, 319);
            this.emoticon.Name = "emoticon";
            this.emoticon.Size = new System.Drawing.Size(521, 128);
            this.emoticon.TabIndex = 0;
            this.emoticon.Text = "(─‿─)";
            this.emoticon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RelaxPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.emoticon);
            this.Controls.Add(this.relaxMessage);
            this.Name = "RelaxPanel";
            this.Size = new System.Drawing.Size(715, 878);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label relaxMessage;
        private System.Windows.Forms.Label emoticon;
    }
}
