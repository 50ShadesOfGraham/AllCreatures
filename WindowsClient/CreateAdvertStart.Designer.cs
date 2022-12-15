namespace WindowsClient
{
    partial class CreateAdvertStart
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
            this.WAYSPanel = new System.Windows.Forms.Panel();
            this.AdBundleComboBx = new System.Windows.Forms.ComboBox();
            this.WAYSlbl = new System.Windows.Forms.Label();
            this.BundlePanel = new System.Windows.Forms.Panel();
            this.BundlePriceTextBox = new System.Windows.Forms.TextBox();
            this.NoOfItemsComboBx = new System.Windows.Forms.ComboBox();
            this.BundlePricelbl = new System.Windows.Forms.Label();
            this.NoItemslbl = new System.Windows.Forms.Label();
            this.BundleBttn = new System.Windows.Forms.Button();
            this.AdvertisementPanel = new System.Windows.Forms.Panel();
            this.AdvertBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.WAYSPanel.SuspendLayout();
            this.BundlePanel.SuspendLayout();
            this.AdvertisementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBox.Image = global::WindowsClient.Properties.Resources.LogoWhiteSignIn;
            this.LogoBox.Location = new System.Drawing.Point(0, 0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(800, 247);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // WAYSPanel
            // 
            this.WAYSPanel.Controls.Add(this.AdBundleComboBx);
            this.WAYSPanel.Controls.Add(this.WAYSlbl);
            this.WAYSPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WAYSPanel.Location = new System.Drawing.Point(0, 247);
            this.WAYSPanel.Name = "WAYSPanel";
            this.WAYSPanel.Size = new System.Drawing.Size(800, 92);
            this.WAYSPanel.TabIndex = 1;
            // 
            // AdBundleComboBx
            // 
            this.AdBundleComboBx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdBundleComboBx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdBundleComboBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.AdBundleComboBx.FormattingEnabled = true;
            this.AdBundleComboBx.Items.AddRange(new object[] {
            "   an Advertisement",
            "   a Bundle(Multiple Advertisements)"});
            this.AdBundleComboBx.Location = new System.Drawing.Point(205, 33);
            this.AdBundleComboBx.Name = "AdBundleComboBx";
            this.AdBundleComboBx.Size = new System.Drawing.Size(390, 33);
            this.AdBundleComboBx.TabIndex = 1;
            this.AdBundleComboBx.SelectedIndexChanged += new System.EventHandler(this.AdBundleComboBx_SelectedIndexChanged);
            // 
            // WAYSlbl
            // 
            this.WAYSlbl.AutoSize = true;
            this.WAYSlbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WAYSlbl.ForeColor = System.Drawing.Color.White;
            this.WAYSlbl.Location = new System.Drawing.Point(45, 32);
            this.WAYSlbl.Name = "WAYSlbl";
            this.WAYSlbl.Size = new System.Drawing.Size(154, 30);
            this.WAYSlbl.TabIndex = 0;
            this.WAYSlbl.Text = "I Am Selling : ";
            // 
            // BundlePanel
            // 
            this.BundlePanel.Controls.Add(this.BundlePriceTextBox);
            this.BundlePanel.Controls.Add(this.NoOfItemsComboBx);
            this.BundlePanel.Controls.Add(this.BundlePricelbl);
            this.BundlePanel.Controls.Add(this.NoItemslbl);
            this.BundlePanel.Controls.Add(this.BundleBttn);
            this.BundlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BundlePanel.Location = new System.Drawing.Point(0, 339);
            this.BundlePanel.Name = "BundlePanel";
            this.BundlePanel.Size = new System.Drawing.Size(800, 298);
            this.BundlePanel.TabIndex = 2;
            // 
            // BundlePriceTextBox
            // 
            this.BundlePriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BundlePriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.BundlePriceTextBox.Location = new System.Drawing.Point(383, 126);
            this.BundlePriceTextBox.Name = "BundlePriceTextBox";
            this.BundlePriceTextBox.Size = new System.Drawing.Size(183, 31);
            this.BundlePriceTextBox.TabIndex = 4;
            this.BundlePriceTextBox.TextChanged += new System.EventHandler(this.BundlePriceTextBox_TextChanged);
            // 
            // NoOfItemsComboBx
            // 
            this.NoOfItemsComboBx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NoOfItemsComboBx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoOfItemsComboBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.NoOfItemsComboBx.FormattingEnabled = true;
            this.NoOfItemsComboBx.Items.AddRange(new object[] {
            "   2",
            "   3"});
            this.NoOfItemsComboBx.Location = new System.Drawing.Point(383, 39);
            this.NoOfItemsComboBx.Name = "NoOfItemsComboBx";
            this.NoOfItemsComboBx.Size = new System.Drawing.Size(124, 33);
            this.NoOfItemsComboBx.TabIndex = 2;
            this.NoOfItemsComboBx.SelectedIndexChanged += new System.EventHandler(this.NoOfItemsComboBx_SelectedIndexChanged);
            // 
            // BundlePricelbl
            // 
            this.BundlePricelbl.AutoSize = true;
            this.BundlePricelbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BundlePricelbl.ForeColor = System.Drawing.Color.White;
            this.BundlePricelbl.Location = new System.Drawing.Point(187, 125);
            this.BundlePricelbl.Name = "BundlePricelbl";
            this.BundlePricelbl.Size = new System.Drawing.Size(155, 30);
            this.BundlePricelbl.TabIndex = 3;
            this.BundlePricelbl.Text = "Bundle Price: ";
            // 
            // NoItemslbl
            // 
            this.NoItemslbl.AutoSize = true;
            this.NoItemslbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoItemslbl.ForeColor = System.Drawing.Color.White;
            this.NoItemslbl.Location = new System.Drawing.Point(190, 38);
            this.NoItemslbl.Name = "NoItemslbl";
            this.NoItemslbl.Size = new System.Drawing.Size(152, 30);
            this.NoItemslbl.TabIndex = 2;
            this.NoItemslbl.Text = "No. of Items: ";
            // 
            // BundleBttn
            // 
            this.BundleBttn.BackColor = System.Drawing.Color.White;
            this.BundleBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.BundleBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BundleBttn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BundleBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.BundleBttn.Location = new System.Drawing.Point(591, 205);
            this.BundleBttn.Name = "BundleBttn";
            this.BundleBttn.Size = new System.Drawing.Size(176, 80);
            this.BundleBttn.TabIndex = 1;
            this.BundleBttn.Text = "Next";
            this.BundleBttn.UseVisualStyleBackColor = false;
            this.BundleBttn.Click += new System.EventHandler(this.BundleBttn_Click);
            // 
            // AdvertisementPanel
            // 
            this.AdvertisementPanel.Controls.Add(this.AdvertBttn);
            this.AdvertisementPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdvertisementPanel.Location = new System.Drawing.Point(0, 637);
            this.AdvertisementPanel.Name = "AdvertisementPanel";
            this.AdvertisementPanel.Size = new System.Drawing.Size(800, 150);
            this.AdvertisementPanel.TabIndex = 3;
            // 
            // AdvertBttn
            // 
            this.AdvertBttn.BackColor = System.Drawing.Color.White;
            this.AdvertBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.AdvertBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdvertBttn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdvertBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.AdvertBttn.Location = new System.Drawing.Point(591, 53);
            this.AdvertBttn.Name = "AdvertBttn";
            this.AdvertBttn.Size = new System.Drawing.Size(176, 80);
            this.AdvertBttn.TabIndex = 0;
            this.AdvertBttn.Text = "Next";
            this.AdvertBttn.UseVisualStyleBackColor = false;
            this.AdvertBttn.Click += new System.EventHandler(this.AdvertBttn_Click);
            // 
            // CreateAdvertStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.AdvertisementPanel);
            this.Controls.Add(this.BundlePanel);
            this.Controls.Add(this.WAYSPanel);
            this.Controls.Add(this.LogoBox);
            this.Name = "CreateAdvertStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Advertisement";
            this.Load += new System.EventHandler(this.CreateAdvertStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.WAYSPanel.ResumeLayout(false);
            this.WAYSPanel.PerformLayout();
            this.BundlePanel.ResumeLayout(false);
            this.BundlePanel.PerformLayout();
            this.AdvertisementPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox LogoBox;
        private Panel WAYSPanel;
        private ComboBox AdBundleComboBx;
        private Label WAYSlbl;
        private Panel BundlePanel;
        private TextBox BundlePriceTextBox;
        private ComboBox NoOfItemsComboBx;
        private Label BundlePricelbl;
        private Label NoItemslbl;
        private Button BundleBttn;
        private Panel AdvertisementPanel;
        private Button AdvertBttn;
    }
}