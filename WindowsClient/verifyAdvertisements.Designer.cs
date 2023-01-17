﻿namespace WindowsClient
{
    partial class verifyAdvertisements
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
            this.AdCatComboBx = new System.Windows.Forms.ComboBox();
            this.WAYSlbl = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnAssess = new System.Windows.Forms.Button();
            this.btnAnimals = new System.Windows.Forms.Button();
            this.listboxAni = new System.Windows.Forms.ListBox();
            this.listBoxAssess = new System.Windows.Forms.ListBox();
            this.listBoxFood = new System.Windows.Forms.ListBox();
            this.panelAssBtn = new System.Windows.Forms.Panel();
            this.panelAnimalsBtn = new System.Windows.Forms.Panel();
            this.panelfoodBtn = new System.Windows.Forms.Panel();
            this.ttlLabel = new System.Windows.Forms.Label();
            this.lblVerified = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtAnimalType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDetail1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDetail2 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDetail3 = new System.Windows.Forms.RichTextBox();
            this.txtVerified = new System.Windows.Forms.TextBox();
            this.panelAnimalsDisp = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtStat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAccess = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubCat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccessCat = new System.Windows.Forms.TextBox();
            this.panelFood = new System.Windows.Forms.Panel();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.panelAssBtn.SuspendLayout();
            this.panelAnimalsBtn.SuspendLayout();
            this.panelfoodBtn.SuspendLayout();
            this.panelAnimalsDisp.SuspendLayout();
            this.panelAccess.SuspendLayout();
            this.panelFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdCatComboBx
            // 
            this.AdCatComboBx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdCatComboBx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdCatComboBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.AdCatComboBx.FormattingEnabled = true;
            this.AdCatComboBx.Items.AddRange(new object[] {
            "   Animal",
            "   Food",
            "   Accessories"});
            this.AdCatComboBx.Location = new System.Drawing.Point(363, 11);
            this.AdCatComboBx.Margin = new System.Windows.Forms.Padding(2);
            this.AdCatComboBx.Name = "AdCatComboBx";
            this.AdCatComboBx.Size = new System.Drawing.Size(198, 23);
            this.AdCatComboBx.TabIndex = 4;
            this.AdCatComboBx.SelectedIndexChanged += new System.EventHandler(this.AdCatComboBx_SelectedIndexChanged);
            // 
            // WAYSlbl
            // 
            this.WAYSlbl.AutoSize = true;
            this.WAYSlbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WAYSlbl.ForeColor = System.Drawing.Color.White;
            this.WAYSlbl.Location = new System.Drawing.Point(157, 11);
            this.WAYSlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WAYSlbl.Name = "WAYSlbl";
            this.WAYSlbl.Size = new System.Drawing.Size(193, 20);
            this.WAYSlbl.TabIndex = 3;
            this.WAYSlbl.Text = "Advertisement Category : ";
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::WindowsClient.Properties.Resources.LogoWhiteThumbnail;
            this.LogoBox.Location = new System.Drawing.Point(11, 11);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(105, 95);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 1;
            this.LogoBox.TabStop = false;
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.White;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnFood.Location = new System.Drawing.Point(0, 0);
            this.btnFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(212, 33);
            this.btnFood.TabIndex = 98;
            this.btnFood.Text = "Display Food";
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnAssess
            // 
            this.btnAssess.BackColor = System.Drawing.Color.White;
            this.btnAssess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAssess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnAssess.Location = new System.Drawing.Point(2, 2);
            this.btnAssess.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssess.Name = "btnAssess";
            this.btnAssess.Size = new System.Drawing.Size(212, 33);
            this.btnAssess.TabIndex = 99;
            this.btnAssess.Text = "Display Assessories";
            this.btnAssess.UseVisualStyleBackColor = false;
            this.btnAssess.Click += new System.EventHandler(this.btnAssess_Click);
            // 
            // btnAnimals
            // 
            this.btnAnimals.BackColor = System.Drawing.Color.White;
            this.btnAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnimals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.btnAnimals.Location = new System.Drawing.Point(0, 0);
            this.btnAnimals.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(212, 33);
            this.btnAnimals.TabIndex = 100;
            this.btnAnimals.Text = "Display Animals";
            this.btnAnimals.UseVisualStyleBackColor = false;
            this.btnAnimals.Click += new System.EventHandler(this.btnAnimals_Click);
            // 
            // listboxAni
            // 
            this.listboxAni.FormattingEnabled = true;
            this.listboxAni.ItemHeight = 15;
            this.listboxAni.Location = new System.Drawing.Point(222, -1);
            this.listboxAni.Name = "listboxAni";
            this.listboxAni.Size = new System.Drawing.Size(186, 34);
            this.listboxAni.TabIndex = 101;
            this.listboxAni.SelectedIndexChanged += new System.EventHandler(this.listboxAni_SelectedIndexChanged);
            this.listboxAni.DoubleClick += new System.EventHandler(this.listboxAni_DoubleClick);
            // 
            // listBoxAssess
            // 
            this.listBoxAssess.FormattingEnabled = true;
            this.listBoxAssess.ItemHeight = 15;
            this.listBoxAssess.Location = new System.Drawing.Point(224, 3);
            this.listBoxAssess.Name = "listBoxAssess";
            this.listBoxAssess.Size = new System.Drawing.Size(186, 34);
            this.listBoxAssess.TabIndex = 102;
            this.listBoxAssess.DoubleClick += new System.EventHandler(this.listBoxAssess_DoubleClick);
            // 
            // listBoxFood
            // 
            this.listBoxFood.FormattingEnabled = true;
            this.listBoxFood.ItemHeight = 15;
            this.listBoxFood.Location = new System.Drawing.Point(224, -1);
            this.listBoxFood.Name = "listBoxFood";
            this.listBoxFood.Size = new System.Drawing.Size(186, 34);
            this.listBoxFood.TabIndex = 103;
            this.listBoxFood.DoubleClick += new System.EventHandler(this.listBoxFood_DoubleClick);
            // 
            // panelAssBtn
            // 
            this.panelAssBtn.Controls.Add(this.btnAssess);
            this.panelAssBtn.Controls.Add(this.listBoxAssess);
            this.panelAssBtn.Location = new System.Drawing.Point(155, 80);
            this.panelAssBtn.Name = "panelAssBtn";
            this.panelAssBtn.Size = new System.Drawing.Size(413, 41);
            this.panelAssBtn.TabIndex = 104;
            // 
            // panelAnimalsBtn
            // 
            this.panelAnimalsBtn.Controls.Add(this.btnAnimals);
            this.panelAnimalsBtn.Controls.Add(this.listboxAni);
            this.panelAnimalsBtn.Location = new System.Drawing.Point(157, 39);
            this.panelAnimalsBtn.Name = "panelAnimalsBtn";
            this.panelAnimalsBtn.Size = new System.Drawing.Size(411, 35);
            this.panelAnimalsBtn.TabIndex = 105;
            // 
            // panelfoodBtn
            // 
            this.panelfoodBtn.Controls.Add(this.btnFood);
            this.panelfoodBtn.Controls.Add(this.listBoxFood);
            this.panelfoodBtn.Location = new System.Drawing.Point(155, 127);
            this.panelfoodBtn.Name = "panelfoodBtn";
            this.panelfoodBtn.Size = new System.Drawing.Size(413, 35);
            this.panelfoodBtn.TabIndex = 106;
            // 
            // ttlLabel
            // 
            this.ttlLabel.AutoSize = true;
            this.ttlLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ttlLabel.ForeColor = System.Drawing.Color.White;
            this.ttlLabel.Location = new System.Drawing.Point(148, 211);
            this.ttlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ttlLabel.Name = "ttlLabel";
            this.ttlLabel.Size = new System.Drawing.Size(44, 21);
            this.ttlLabel.TabIndex = 116;
            this.ttlLabel.Text = "Title";
            // 
            // lblVerified
            // 
            this.lblVerified.AutoSize = true;
            this.lblVerified.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVerified.ForeColor = System.Drawing.Color.White;
            this.lblVerified.Location = new System.Drawing.Point(147, 351);
            this.lblVerified.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerified.Name = "lblVerified";
            this.lblVerified.Size = new System.Drawing.Size(70, 21);
            this.lblVerified.TabIndex = 117;
            this.lblVerified.Text = "Verified";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(144, 319);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 118;
            this.label10.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 119;
            this.label2.Text = "Description";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(288, 319);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(143, 19);
            this.txtPrice.TabIndex = 120;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(288, 262);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(185, 40);
            this.txtDescription.TabIndex = 121;
            this.txtDescription.Text = "";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(291, 214);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(143, 19);
            this.txtTitle.TabIndex = 122;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(2, 2);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(101, 21);
            this.lblStatus.TabIndex = 124;
            this.lblStatus.Text = "AnimalType";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(142, 2);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(143, 19);
            this.txtType.TabIndex = 125;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(29, 10);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(101, 21);
            this.lblType.TabIndex = 126;
            this.lblType.Text = "AnimalType";
            // 
            // txtAnimalType
            // 
            this.txtAnimalType.Location = new System.Drawing.Point(173, 13);
            this.txtAnimalType.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnimalType.Multiline = true;
            this.txtAnimalType.Name = "txtAnimalType";
            this.txtAnimalType.ReadOnly = true;
            this.txtAnimalType.Size = new System.Drawing.Size(143, 19);
            this.txtAnimalType.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 128;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(143, 19);
            this.txtName.TabIndex = 129;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 130;
            this.label5.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(173, 74);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(44, 19);
            this.txtAge.TabIndex = 131;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 132;
            this.label6.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(173, 107);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2);
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(143, 19);
            this.txtGender.TabIndex = 133;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 134;
            this.label7.Text = "Details One";
            // 
            // txtDetail1
            // 
            this.txtDetail1.Location = new System.Drawing.Point(173, 139);
            this.txtDetail1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetail1.Name = "txtDetail1";
            this.txtDetail1.ReadOnly = true;
            this.txtDetail1.Size = new System.Drawing.Size(191, 40);
            this.txtDetail1.TabIndex = 135;
            this.txtDetail1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 136;
            this.label8.Text = "Details Two";
            // 
            // txtDetail2
            // 
            this.txtDetail2.Location = new System.Drawing.Point(173, 193);
            this.txtDetail2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetail2.Name = "txtDetail2";
            this.txtDetail2.ReadOnly = true;
            this.txtDetail2.Size = new System.Drawing.Size(188, 40);
            this.txtDetail2.TabIndex = 137;
            this.txtDetail2.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 259);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 138;
            this.label9.Text = "Details Three";
            // 
            // txtDetail3
            // 
            this.txtDetail3.Location = new System.Drawing.Point(169, 259);
            this.txtDetail3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetail3.Name = "txtDetail3";
            this.txtDetail3.ReadOnly = true;
            this.txtDetail3.Size = new System.Drawing.Size(200, 48);
            this.txtDetail3.TabIndex = 139;
            this.txtDetail3.Text = "";
            // 
            // txtVerified
            // 
            this.txtVerified.Location = new System.Drawing.Point(288, 351);
            this.txtVerified.Margin = new System.Windows.Forms.Padding(2);
            this.txtVerified.Multiline = true;
            this.txtVerified.Name = "txtVerified";
            this.txtVerified.ReadOnly = true;
            this.txtVerified.Size = new System.Drawing.Size(143, 19);
            this.txtVerified.TabIndex = 140;
            // 
            // panelAnimalsDisp
            // 
            this.panelAnimalsDisp.Controls.Add(this.label13);
            this.panelAnimalsDisp.Controls.Add(this.txtBreed);
            this.panelAnimalsDisp.Controls.Add(this.lblType);
            this.panelAnimalsDisp.Controls.Add(this.txtAnimalType);
            this.panelAnimalsDisp.Controls.Add(this.label1);
            this.panelAnimalsDisp.Controls.Add(this.txtName);
            this.panelAnimalsDisp.Controls.Add(this.label5);
            this.panelAnimalsDisp.Controls.Add(this.txtAge);
            this.panelAnimalsDisp.Controls.Add(this.txtDetail3);
            this.panelAnimalsDisp.Controls.Add(this.label6);
            this.panelAnimalsDisp.Controls.Add(this.txtGender);
            this.panelAnimalsDisp.Controls.Add(this.label9);
            this.panelAnimalsDisp.Controls.Add(this.label7);
            this.panelAnimalsDisp.Controls.Add(this.txtDetail1);
            this.panelAnimalsDisp.Controls.Add(this.txtDetail2);
            this.panelAnimalsDisp.Controls.Add(this.label8);
            this.panelAnimalsDisp.Location = new System.Drawing.Point(119, 438);
            this.panelAnimalsDisp.Name = "panelAnimalsDisp";
            this.panelAnimalsDisp.Size = new System.Drawing.Size(633, 321);
            this.panelAnimalsDisp.TabIndex = 107;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.button2.Location = new System.Drawing.Point(350, 764);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 34);
            this.button2.TabIndex = 145;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.button1.Location = new System.Drawing.Point(520, 764);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 144;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.button3.Location = new System.Drawing.Point(174, 764);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 34);
            this.button3.TabIndex = 143;
            this.button3.Text = "Verify";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtStat
            // 
            this.txtStat.Location = new System.Drawing.Point(619, 214);
            this.txtStat.Margin = new System.Windows.Forms.Padding(2);
            this.txtStat.Multiline = true;
            this.txtStat.Name = "txtStat";
            this.txtStat.ReadOnly = true;
            this.txtStat.Size = new System.Drawing.Size(143, 19);
            this.txtStat.TabIndex = 142;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(504, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 141;
            this.label3.Text = "Status";
            // 
            // panelAccess
            // 
            this.panelAccess.Controls.Add(this.label11);
            this.panelAccess.Controls.Add(this.txtSubCat);
            this.panelAccess.Controls.Add(this.label4);
            this.panelAccess.Controls.Add(this.txtAccessCat);
            this.panelAccess.Location = new System.Drawing.Point(528, 253);
            this.panelAccess.Name = "panelAccess";
            this.panelAccess.Size = new System.Drawing.Size(334, 72);
            this.panelAccess.TabIndex = 146;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(22, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 21);
            this.label11.TabIndex = 144;
            this.label11.Text = "AccessSubCategory";
            // 
            // txtSubCat
            // 
            this.txtSubCat.Location = new System.Drawing.Point(179, 42);
            this.txtSubCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubCat.Multiline = true;
            this.txtSubCat.Name = "txtSubCat";
            this.txtSubCat.ReadOnly = true;
            this.txtSubCat.Size = new System.Drawing.Size(143, 19);
            this.txtSubCat.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 142;
            this.label4.Text = "AccessCategory";
            // 
            // txtAccessCat
            // 
            this.txtAccessCat.Location = new System.Drawing.Point(179, 9);
            this.txtAccessCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccessCat.Multiline = true;
            this.txtAccessCat.Name = "txtAccessCat";
            this.txtAccessCat.ReadOnly = true;
            this.txtAccessCat.Size = new System.Drawing.Size(143, 19);
            this.txtAccessCat.TabIndex = 141;
            // 
            // panelFood
            // 
            this.panelFood.Controls.Add(this.txtDetails);
            this.panelFood.Controls.Add(this.label12);
            this.panelFood.Controls.Add(this.txtType);
            this.panelFood.Controls.Add(this.lblStatus);
            this.panelFood.Location = new System.Drawing.Point(144, 375);
            this.panelFood.Name = "panelFood";
            this.panelFood.Size = new System.Drawing.Size(290, 45);
            this.panelFood.TabIndex = 147;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(141, 23);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(143, 19);
            this.txtDetails.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 21);
            this.label12.TabIndex = 126;
            this.label12.Text = "Details";
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(447, 13);
            this.txtBreed.Margin = new System.Windows.Forms.Padding(2);
            this.txtBreed.Multiline = true;
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.ReadOnly = true;
            this.txtBreed.Size = new System.Drawing.Size(143, 19);
            this.txtBreed.TabIndex = 140;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(341, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 21);
            this.label13.TabIndex = 141;
            this.label13.Text = "PureBreed";
            // 
            // verifyAdvertisements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1115, 860);
            this.Controls.Add(this.panelFood);
            this.Controls.Add(this.panelAccess);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelAnimalsDisp);
            this.Controls.Add(this.panelfoodBtn);
            this.Controls.Add(this.panelAnimalsBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStat);
            this.Controls.Add(this.panelAssBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AdCatComboBx);
            this.Controls.Add(this.txtVerified);
            this.Controls.Add(this.WAYSlbl);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.ttlLabel);
            this.Controls.Add(this.lblVerified);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Name = "verifyAdvertisements";
            this.Text = "verifyAdvertisements";
            this.Load += new System.EventHandler(this.verifyAdvertisements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.panelAssBtn.ResumeLayout(false);
            this.panelAnimalsBtn.ResumeLayout(false);
            this.panelfoodBtn.ResumeLayout(false);
            this.panelAnimalsDisp.ResumeLayout(false);
            this.panelAnimalsDisp.PerformLayout();
            this.panelAccess.ResumeLayout(false);
            this.panelAccess.PerformLayout();
            this.panelFood.ResumeLayout(false);
            this.panelFood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox AdCatComboBx;
        private Label WAYSlbl;
        private PictureBox LogoBox;
        private Button btnFood;
        private Button btnAssess;
        private Button btnAnimals;
        private ListBox listboxAni;
        private ListBox listBoxAssess;
        private ListBox listBoxFood;
        private Panel panelAssBtn;
        private Panel panelAnimalsBtn;
        private Panel panelfoodBtn;
        private Label ttlLabel;
        private Label lblVerified;
        private Label label10;
        private Label label2;
        private TextBox txtPrice;
        private RichTextBox txtDescription;
        private TextBox txtTitle;
        private Label lblStatus;
        private TextBox txtType;
        private Label lblType;
        private TextBox txtAnimalType;
        private Label label1;
        private TextBox txtName;
        private Label label5;
        private TextBox txtAge;
        private Label label6;
        private TextBox txtGender;
        private Label label7;
        private RichTextBox txtDetail1;
        private Label label8;
        private RichTextBox txtDetail2;
        private Label label9;
        private RichTextBox txtDetail3;
        private TextBox txtVerified;
        private Panel panelAnimalsDisp;
        private TextBox txtStat;
        private Label label3;
        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panelAccess;
        private Label label11;
        private TextBox txtSubCat;
        private Label label4;
        private TextBox txtAccessCat;
        private Panel panelFood;
        private TextBox txtDetails;
        private Label label12;
        private Label label13;
        private TextBox txtBreed;
    }
}