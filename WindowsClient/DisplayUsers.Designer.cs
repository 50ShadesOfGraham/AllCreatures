namespace WindowsClient
{
    partial class DisplayUsers
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.btnFlag = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReports = new System.Windows.Forms.RichTextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddr3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblVerified = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(24, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 47);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Users";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.White;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnDisplay.Location = new System.Drawing.Point(35, 63);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(136, 33);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.button1.Location = new System.Drawing.Point(743, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listUsers
            // 
            this.listUsers.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 15;
            this.listUsers.Location = new System.Drawing.Point(35, 100);
            this.listUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(137, 19);
            this.listUsers.TabIndex = 9;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listUsers_MouseDoubleClick);
            // 
            // btnFlag
            // 
            this.btnFlag.BackColor = System.Drawing.Color.White;
            this.btnFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlag.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnFlag.Location = new System.Drawing.Point(617, 356);
            this.btnFlag.Margin = new System.Windows.Forms.Padding(2);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(100, 34);
            this.btnFlag.TabIndex = 38;
            this.btnFlag.Text = "Flag";
            this.btnFlag.UseVisualStyleBackColor = false;
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.Color.White;
            this.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnBan.Location = new System.Drawing.Point(502, 356);
            this.btnBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(86, 34);
            this.btnBan.TabIndex = 37;
            this.btnBan.Text = "Ban User";
            this.btnBan.UseVisualStyleBackColor = false;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(535, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "User Report";
            // 
            // txtReports
            // 
            this.txtReports.Location = new System.Drawing.Point(541, 202);
            this.txtReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReports.Name = "txtReports";
            this.txtReports.Size = new System.Drawing.Size(221, 110);
            this.txtReports.TabIndex = 35;
            this.txtReports.Text = "";
            this.txtReports.TextChanged += new System.EventHandler(this.txtReports_TextChanged);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(617, 118);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(145, 23);
            this.txtGender.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(535, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Gender";
            // 
            // txtAddr3
            // 
            this.txtAddr3.Location = new System.Drawing.Point(315, 334);
            this.txtAddr3.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddr3.Name = "txtAddr3";
            this.txtAddr3.Size = new System.Drawing.Size(145, 23);
            this.txtAddr3.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(208, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Address Line3";
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(315, 292);
            this.txtAddr2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(145, 23);
            this.txtAddr2.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(208, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Address Line2";
            // 
            // txtAddr1
            // 
            this.txtAddr1.Location = new System.Drawing.Point(315, 255);
            this.txtAddr1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(145, 23);
            this.txtAddr1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Address Line1";
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(315, 200);
            this.txtDob.Margin = new System.Windows.Forms.Padding(2);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(145, 23);
            this.txtDob.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date Of Birth";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(315, 160);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(145, 23);
            this.txtLname.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Last Name";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(315, 116);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(145, 23);
            this.txtFname.TabIndex = 22;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(208, 118);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(81, 19);
            this.TitleLbl.TabIndex = 21;
            this.TitleLbl.Text = "First Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(315, 82);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 23);
            this.txtEmail.TabIndex = 40;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(208, 86);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(315, 370);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(145, 23);
            this.txtEircode.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(208, 374);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Eircode";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(617, 82);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(145, 23);
            this.txtCounty.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(535, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 43;
            this.label9.Text = "County";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(315, 19);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(71, 19);
            this.lblUserType.TabIndex = 45;
            this.lblUserType.Text = "UserType";
            // 
            // lblVerified
            // 
            this.lblVerified.AutoSize = true;
            this.lblVerified.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVerified.ForeColor = System.Drawing.Color.White;
            this.lblVerified.Location = new System.Drawing.Point(467, 19);
            this.lblVerified.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerified.Name = "lblVerified";
            this.lblVerified.Size = new System.Drawing.Size(61, 19);
            this.lblVerified.TabIndex = 46;
            this.lblVerified.Text = "Verified";
            // 
            // DisplayUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(937, 430);
            this.Controls.Add(this.lblVerified);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEircode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReports);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddr3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddr2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddr1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DisplayUsers";
            this.Text = "DisplayUsers";
            this.Load += new System.EventHandler(this.DisplayUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private Button btnDisplay;
        private Button button1;
        private ListBox listUsers;
        private Button btnFlag;
        private Button btnBan;
        private Label label7;
        private RichTextBox txtReports;
        private TextBox txtGender;
        private Label label6;
        private TextBox txtAddr3;
        private Label label5;
        private TextBox txtAddr2;
        private Label label4;
        private TextBox txtAddr1;
        private Label label3;
        private TextBox txtDob;
        private Label label2;
        private TextBox txtLname;
        private Label label1;
        private TextBox txtFname;
        private Label TitleLbl;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtEircode;
        private Label label8;
        private TextBox txtCounty;
        private Label label9;
        private Label lblUserType;
        private Label lblVerified;
    }
}