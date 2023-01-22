﻿namespace WindowsClient
{
    partial class EditAccount
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GeneralInfoPanel = new System.Windows.Forms.Panel();
            this.AddressPanel = new System.Windows.Forms.Panel();
            this.GeneralInfoBttn = new System.Windows.Forms.Button();
            this.GeneralGroupBox = new System.Windows.Forms.GroupBox();
            this.FirstNamelbl = new System.Windows.Forms.Label();
            this.ShowTwoBttn = new System.Windows.Forms.Button();
            this.PasswordTwotxt = new System.Windows.Forms.TextBox();
            this.PasswordClbl = new System.Windows.Forms.Label();
            this.ShowOneBttn = new System.Windows.Forms.Button();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.LastNamelbl = new System.Windows.Forms.Label();
            this.LastNametxt = new System.Windows.Forms.TextBox();
            this.FirstNametxt = new System.Windows.Forms.TextBox();
            this.UpdatePersonalBttn = new System.Windows.Forms.Button();
            this.CancelPersonalBttn = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GeneralInfoPanel.SuspendLayout();
            this.GeneralGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.GeneralInfoBttn);
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(978, 253);
            this.HeaderPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsClient.Properties.Resources.LogoWhiteThumbnail;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GeneralInfoPanel
            // 
            this.GeneralInfoPanel.Controls.Add(this.CancelPersonalBttn);
            this.GeneralInfoPanel.Controls.Add(this.UpdatePersonalBttn);
            this.GeneralInfoPanel.Controls.Add(this.GeneralGroupBox);
            this.GeneralInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralInfoPanel.Location = new System.Drawing.Point(0, 253);
            this.GeneralInfoPanel.Name = "GeneralInfoPanel";
            this.GeneralInfoPanel.Size = new System.Drawing.Size(978, 531);
            this.GeneralInfoPanel.TabIndex = 1;
            // 
            // AddressPanel
            // 
            this.AddressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddressPanel.Location = new System.Drawing.Point(0, 784);
            this.AddressPanel.Name = "AddressPanel";
            this.AddressPanel.Size = new System.Drawing.Size(978, 297);
            this.AddressPanel.TabIndex = 2;
            // 
            // GeneralInfoBttn
            // 
            this.GeneralInfoBttn.BackColor = System.Drawing.Color.White;
            this.GeneralInfoBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralInfoBttn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeneralInfoBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.GeneralInfoBttn.Location = new System.Drawing.Point(0, 177);
            this.GeneralInfoBttn.Name = "GeneralInfoBttn";
            this.GeneralInfoBttn.Size = new System.Drawing.Size(978, 76);
            this.GeneralInfoBttn.TabIndex = 0;
            this.GeneralInfoBttn.Text = "Personal Details";
            this.GeneralInfoBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneralInfoBttn.UseVisualStyleBackColor = false;
            // 
            // GeneralGroupBox
            // 
            this.GeneralGroupBox.Controls.Add(this.FirstNamelbl);
            this.GeneralGroupBox.Controls.Add(this.ShowTwoBttn);
            this.GeneralGroupBox.Controls.Add(this.PasswordTwotxt);
            this.GeneralGroupBox.Controls.Add(this.PasswordClbl);
            this.GeneralGroupBox.Controls.Add(this.ShowOneBttn);
            this.GeneralGroupBox.Controls.Add(this.Passwordtxt);
            this.GeneralGroupBox.Controls.Add(this.Passwordlbl);
            this.GeneralGroupBox.Controls.Add(this.Emailtxt);
            this.GeneralGroupBox.Controls.Add(this.Emaillbl);
            this.GeneralGroupBox.Controls.Add(this.LastNamelbl);
            this.GeneralGroupBox.Controls.Add(this.LastNametxt);
            this.GeneralGroupBox.Controls.Add(this.FirstNametxt);
            this.GeneralGroupBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeneralGroupBox.ForeColor = System.Drawing.Color.White;
            this.GeneralGroupBox.Location = new System.Drawing.Point(62, 24);
            this.GeneralGroupBox.Name = "GeneralGroupBox";
            this.GeneralGroupBox.Size = new System.Drawing.Size(735, 369);
            this.GeneralGroupBox.TabIndex = 3;
            this.GeneralGroupBox.TabStop = false;
            this.GeneralGroupBox.Text = "Personal Details";
            // 
            // FirstNamelbl
            // 
            this.FirstNamelbl.AutoSize = true;
            this.FirstNamelbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNamelbl.ForeColor = System.Drawing.Color.White;
            this.FirstNamelbl.Location = new System.Drawing.Point(103, 52);
            this.FirstNamelbl.Name = "FirstNamelbl";
            this.FirstNamelbl.Size = new System.Drawing.Size(137, 30);
            this.FirstNamelbl.TabIndex = 1;
            this.FirstNamelbl.Text = "First Name :";
            // 
            // ShowTwoBttn
            // 
            this.ShowTwoBttn.BackColor = System.Drawing.Color.White;
            this.ShowTwoBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowTwoBttn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowTwoBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ShowTwoBttn.Location = new System.Drawing.Point(552, 294);
            this.ShowTwoBttn.Name = "ShowTwoBttn";
            this.ShowTwoBttn.Size = new System.Drawing.Size(80, 32);
            this.ShowTwoBttn.TabIndex = 14;
            this.ShowTwoBttn.Text = "Show";
            this.ShowTwoBttn.UseVisualStyleBackColor = false;
            // 
            // PasswordTwotxt
            // 
            this.PasswordTwotxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTwotxt.Location = new System.Drawing.Point(272, 296);
            this.PasswordTwotxt.Name = "PasswordTwotxt";
            this.PasswordTwotxt.Size = new System.Drawing.Size(274, 31);
            this.PasswordTwotxt.TabIndex = 10;
            // 
            // PasswordClbl
            // 
            this.PasswordClbl.AutoSize = true;
            this.PasswordClbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordClbl.ForeColor = System.Drawing.Color.White;
            this.PasswordClbl.Location = new System.Drawing.Point(29, 293);
            this.PasswordClbl.Name = "PasswordClbl";
            this.PasswordClbl.Size = new System.Drawing.Size(213, 30);
            this.PasswordClbl.TabIndex = 8;
            this.PasswordClbl.Text = "Confirm Password :";
            // 
            // ShowOneBttn
            // 
            this.ShowOneBttn.BackColor = System.Drawing.Color.White;
            this.ShowOneBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowOneBttn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowOneBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ShowOneBttn.Location = new System.Drawing.Point(552, 229);
            this.ShowOneBttn.Name = "ShowOneBttn";
            this.ShowOneBttn.Size = new System.Drawing.Size(80, 32);
            this.ShowOneBttn.TabIndex = 13;
            this.ShowOneBttn.Text = "Show";
            this.ShowOneBttn.UseVisualStyleBackColor = false;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Passwordtxt.Location = new System.Drawing.Point(272, 230);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(274, 31);
            this.Passwordtxt.TabIndex = 9;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Passwordlbl.ForeColor = System.Drawing.Color.White;
            this.Passwordlbl.Location = new System.Drawing.Point(118, 231);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(124, 30);
            this.Passwordlbl.TabIndex = 7;
            this.Passwordlbl.Text = "Password :";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Emailtxt.Location = new System.Drawing.Point(272, 170);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(274, 31);
            this.Emailtxt.TabIndex = 6;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Emaillbl.ForeColor = System.Drawing.Color.White;
            this.Emaillbl.Location = new System.Drawing.Point(159, 170);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(81, 30);
            this.Emaillbl.TabIndex = 5;
            this.Emaillbl.Text = "Email :";
            // 
            // LastNamelbl
            // 
            this.LastNamelbl.AutoSize = true;
            this.LastNamelbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastNamelbl.ForeColor = System.Drawing.Color.White;
            this.LastNamelbl.Location = new System.Drawing.Point(106, 111);
            this.LastNamelbl.Name = "LastNamelbl";
            this.LastNamelbl.Size = new System.Drawing.Size(134, 30);
            this.LastNamelbl.TabIndex = 3;
            this.LastNamelbl.Text = "Last Name :";
            // 
            // LastNametxt
            // 
            this.LastNametxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNametxt.Location = new System.Drawing.Point(272, 112);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(274, 31);
            this.LastNametxt.TabIndex = 4;
            // 
            // FirstNametxt
            // 
            this.FirstNametxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNametxt.Location = new System.Drawing.Point(272, 53);
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(274, 31);
            this.FirstNametxt.TabIndex = 2;
            // 
            // UpdatePersonalBttn
            // 
            this.UpdatePersonalBttn.BackColor = System.Drawing.Color.White;
            this.UpdatePersonalBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePersonalBttn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdatePersonalBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.UpdatePersonalBttn.Location = new System.Drawing.Point(724, 413);
            this.UpdatePersonalBttn.Name = "UpdatePersonalBttn";
            this.UpdatePersonalBttn.Size = new System.Drawing.Size(144, 76);
            this.UpdatePersonalBttn.TabIndex = 2;
            this.UpdatePersonalBttn.Text = "Update";
            this.UpdatePersonalBttn.UseVisualStyleBackColor = false;
            // 
            // CancelPersonalBttn
            // 
            this.CancelPersonalBttn.BackColor = System.Drawing.Color.White;
            this.CancelPersonalBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelPersonalBttn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelPersonalBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.CancelPersonalBttn.Location = new System.Drawing.Point(91, 413);
            this.CancelPersonalBttn.Name = "CancelPersonalBttn";
            this.CancelPersonalBttn.Size = new System.Drawing.Size(144, 76);
            this.CancelPersonalBttn.TabIndex = 4;
            this.CancelPersonalBttn.Text = "Cancel";
            this.CancelPersonalBttn.UseVisualStyleBackColor = false;
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1004, 699);
            this.Controls.Add(this.AddressPanel);
            this.Controls.Add(this.GeneralInfoPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "EditAccount";
            this.Text = "Edit Account";
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GeneralInfoPanel.ResumeLayout(false);
            this.GeneralGroupBox.ResumeLayout(false);
            this.GeneralGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HeaderPanel;
        private Button GeneralInfoBttn;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel GeneralInfoPanel;
        private Panel AddressPanel;
        private Button CancelPersonalBttn;
        private Button UpdatePersonalBttn;
        private GroupBox GeneralGroupBox;
        private Label FirstNamelbl;
        private Button ShowTwoBttn;
        private TextBox PasswordTwotxt;
        private Label PasswordClbl;
        private Button ShowOneBttn;
        private TextBox Passwordtxt;
        private Label Passwordlbl;
        private TextBox Emailtxt;
        private Label Emaillbl;
        private Label LastNamelbl;
        private TextBox LastNametxt;
        private TextBox FirstNametxt;
    }
}