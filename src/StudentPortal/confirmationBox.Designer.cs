﻿namespace StudentPortal
{
    partial class ConfirmationBox
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerTwoLabel = new System.Windows.Forms.Label();
            this.reminderLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.bottomBorder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Poppins SemiBold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.headerLabel.Location = new System.Drawing.Point(260, 139);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(759, 154);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Are you sure about the\ndetails you’ve entered? ";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerTwoLabel
            // 
            this.headerTwoLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerTwoLabel.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.headerTwoLabel.Location = new System.Drawing.Point(327, 323);
            this.headerTwoLabel.Name = "headerTwoLabel";
            this.headerTwoLabel.Size = new System.Drawing.Size(626, 90);
            this.headerTwoLabel.TabIndex = 1;
            this.headerTwoLabel.Text = "Some information cannot be changed \nonce you hit confirm";
            this.headerTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reminderLabel
            // 
            this.reminderLabel.BackColor = System.Drawing.Color.Transparent;
            this.reminderLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.reminderLabel.Location = new System.Drawing.Point(361, 553);
            this.reminderLabel.Name = "reminderLabel";
            this.reminderLabel.Size = new System.Drawing.Size(558, 28);
            this.reminderLabel.TabIndex = 2;
            this.reminderLabel.Text = "After signing up, student number will be auto generated";
            this.reminderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(665, 443);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(300, 80);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.confirmBtn.FlatAppearance.BorderSize = 3;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(63)))));
            this.confirmBtn.Location = new System.Drawing.Point(334, 443);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(300, 80);
            this.confirmBtn.TabIndex = 4;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.bottomBorder.Location = new System.Drawing.Point(0, 620);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(1280, 100);
            this.bottomBorder.TabIndex = 5;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.headerTwoLabel);
            this.Controls.Add(this.reminderLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.bottomBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label headerTwoLabel;
        private System.Windows.Forms.Label reminderLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Panel bottomBorder;
    }
}