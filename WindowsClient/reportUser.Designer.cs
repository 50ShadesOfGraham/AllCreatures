﻿namespace WindowsClient
{
    partial class reportUser
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
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttlLabel = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.comboReason = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::WindowsClient.Properties.Resources.LogoWhiteThumbnail;
            this.LogoBox.Location = new System.Drawing.Point(10, 9);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(105, 95);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 2;
            this.LogoBox.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnReport.Location = new System.Drawing.Point(154, 243);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(124, 34);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnExit.Location = new System.Drawing.Point(380, 243);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 148;
            this.label2.Text = "Describe reason :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 147;
            this.label1.Text = "Reason :";
            // 
            // ttlLabel
            // 
            this.ttlLabel.AutoSize = true;
            this.ttlLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ttlLabel.ForeColor = System.Drawing.Color.White;
            this.ttlLabel.Location = new System.Drawing.Point(154, 24);
            this.ttlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ttlLabel.Name = "ttlLabel";
            this.ttlLabel.Size = new System.Drawing.Size(153, 21);
            this.ttlLabel.TabIndex = 146;
            this.ttlLabel.Text = "UserName(email) :";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(360, 24);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(144, 23);
            this.txtUser.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(312, 115);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(192, 100);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.Text = "";
            // 
            // comboReason
            // 
            this.comboReason.FormattingEnabled = true;
            this.comboReason.Items.AddRange(new object[] {
            "Animal Abuse",
            "Spam",
            "Harrassment",
            "Racism"});
            this.comboReason.Location = new System.Drawing.Point(360, 68);
            this.comboReason.Name = "comboReason";
            this.comboReason.Size = new System.Drawing.Size(144, 23);
            this.comboReason.TabIndex = 2;
            // 
            // reportUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.comboReason);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttlLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.LogoBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "reportUser";
            this.Text = "reportUser";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LogoBox;
        private Button btnReport;
        private Button btnExit;
        private Label label2;
        private Label label1;
        private Label ttlLabel;
        private TextBox txtUser;
        private RichTextBox txtDesc;
        private ComboBox comboReason;
    }
}