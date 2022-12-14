namespace WindowsClient
{
    partial class CreateAdvertisementStart
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
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.AdvertorBundleComboBox = new System.Windows.Forms.ComboBox();
            this.WAISlbl = new System.Windows.Forms.Label();
            this.WAISPanel = new System.Windows.Forms.Panel();
            this.SingleAdvertPanel = new System.Windows.Forms.Panel();
            this.NextAdvertBttn = new System.Windows.Forms.Button();
            this.BundlePanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NoItemsLbl = new System.Windows.Forms.Label();
            this.BundleBttn = new System.Windows.Forms.Button();
            this.BundlePricelbl = new System.Windows.Forms.Label();
            this.txtBundlePrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.WAISPanel.SuspendLayout();
            this.SingleAdvertPanel.SuspendLayout();
            this.BundlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPictureBox.Image = global::WindowsClient.Properties.Resources.LogoWhiteSignIn;
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(800, 243);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // AdvertorBundleComboBox
            // 
            this.AdvertorBundleComboBox.FormattingEnabled = true;
            this.AdvertorBundleComboBox.Items.AddRange(new object[] {
            "   an Advertisement",
            "    a Bundle(Multiple Advertisements)"});
            this.AdvertorBundleComboBox.Location = new System.Drawing.Point(332, 28);
            this.AdvertorBundleComboBox.Name = "AdvertorBundleComboBox";
            this.AdvertorBundleComboBox.Size = new System.Drawing.Size(291, 33);
            this.AdvertorBundleComboBox.TabIndex = 1;
            // 
            // WAISlbl
            // 
            this.WAISlbl.AutoSize = true;
            this.WAISlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WAISlbl.ForeColor = System.Drawing.Color.White;
            this.WAISlbl.Location = new System.Drawing.Point(134, 28);
            this.WAISlbl.Name = "WAISlbl";
            this.WAISlbl.Size = new System.Drawing.Size(192, 28);
            this.WAISlbl.TabIndex = 2;
            this.WAISlbl.Text = "What Am I Selling?";
            // 
            // WAISPanel
            // 
            this.WAISPanel.Controls.Add(this.WAISlbl);
            this.WAISPanel.Controls.Add(this.AdvertorBundleComboBox);
            this.WAISPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WAISPanel.Location = new System.Drawing.Point(0, 243);
            this.WAISPanel.Name = "WAISPanel";
            this.WAISPanel.Size = new System.Drawing.Size(800, 80);
            this.WAISPanel.TabIndex = 3;
            // 
            // SingleAdvertPanel
            // 
            this.SingleAdvertPanel.Controls.Add(this.NextAdvertBttn);
            this.SingleAdvertPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SingleAdvertPanel.Location = new System.Drawing.Point(0, 323);
            this.SingleAdvertPanel.Name = "SingleAdvertPanel";
            this.SingleAdvertPanel.Size = new System.Drawing.Size(800, 101);
            this.SingleAdvertPanel.TabIndex = 4;
            // 
            // NextAdvertBttn
            // 
            this.NextAdvertBttn.BackColor = System.Drawing.Color.White;
            this.NextAdvertBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextAdvertBttn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextAdvertBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.NextAdvertBttn.Location = new System.Drawing.Point(595, 18);
            this.NextAdvertBttn.Name = "NextAdvertBttn";
            this.NextAdvertBttn.Size = new System.Drawing.Size(179, 68);
            this.NextAdvertBttn.TabIndex = 0;
            this.NextAdvertBttn.Text = "Next";
            this.NextAdvertBttn.UseVisualStyleBackColor = false;
            // 
            // BundlePanel
            // 
            this.BundlePanel.Controls.Add(this.txtBundlePrice);
            this.BundlePanel.Controls.Add(this.BundlePricelbl);
            this.BundlePanel.Controls.Add(this.BundleBttn);
            this.BundlePanel.Controls.Add(this.NoItemsLbl);
            this.BundlePanel.Controls.Add(this.comboBox1);
            this.BundlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BundlePanel.Location = new System.Drawing.Point(0, 424);
            this.BundlePanel.Name = "BundlePanel";
            this.BundlePanel.Size = new System.Drawing.Size(800, 245);
            this.BundlePanel.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(342, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // NoItemsLbl
            // 
            this.NoItemsLbl.AutoSize = true;
            this.NoItemsLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoItemsLbl.ForeColor = System.Drawing.Color.White;
            this.NoItemsLbl.Location = new System.Drawing.Point(89, 23);
            this.NoItemsLbl.Name = "NoItemsLbl";
            this.NoItemsLbl.Size = new System.Drawing.Size(237, 28);
            this.NoItemsLbl.TabIndex = 3;
            this.NoItemsLbl.Text = "No. of Advertisements :";
            // 
            // BundleBttn
            // 
            this.BundleBttn.BackColor = System.Drawing.Color.White;
            this.BundleBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BundleBttn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BundleBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.BundleBttn.Location = new System.Drawing.Point(595, 148);
            this.BundleBttn.Name = "BundleBttn";
            this.BundleBttn.Size = new System.Drawing.Size(179, 68);
            this.BundleBttn.TabIndex = 4;
            this.BundleBttn.Text = "Next";
            this.BundleBttn.UseVisualStyleBackColor = false;
            // 
            // BundlePricelbl
            // 
            this.BundlePricelbl.AutoSize = true;
            this.BundlePricelbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BundlePricelbl.ForeColor = System.Drawing.Color.White;
            this.BundlePricelbl.Location = new System.Drawing.Point(184, 98);
            this.BundlePricelbl.Name = "BundlePricelbl";
            this.BundlePricelbl.Size = new System.Drawing.Size(142, 28);
            this.BundlePricelbl.TabIndex = 5;
            this.BundlePricelbl.Text = "Bundle Price :";
            // 
            // txtBundlePrice
            // 
            this.txtBundlePrice.Location = new System.Drawing.Point(342, 98);
            this.txtBundlePrice.Name = "txtBundlePrice";
            this.txtBundlePrice.Size = new System.Drawing.Size(150, 31);
            this.txtBundlePrice.TabIndex = 6;
            // 
            // CreateAdvertisementStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.BundlePanel);
            this.Controls.Add(this.SingleAdvertPanel);
            this.Controls.Add(this.WAISPanel);
            this.Controls.Add(this.LogoPictureBox);
            this.Name = "CreateAdvertisementStart";
            this.Text = "Place Advertisement";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.WAISPanel.ResumeLayout(false);
            this.WAISPanel.PerformLayout();
            this.SingleAdvertPanel.ResumeLayout(false);
            this.BundlePanel.ResumeLayout(false);
            this.BundlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox LogoPictureBox;
        private ComboBox AdvertorBundleComboBox;
        private Label WAISlbl;
        private Panel WAISPanel;
        private Panel SingleAdvertPanel;
        private Button NextAdvertBttn;
        private Panel BundlePanel;
        private TextBox txtBundlePrice;
        private Label BundlePricelbl;
        private Button BundleBttn;
        private Label NoItemsLbl;
        private ComboBox comboBox1;
    }
}