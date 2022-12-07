namespace WindowsClient
{
    partial class PlaceAdvertisement
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TitleTextBx = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBx = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBx = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.SubmitAdBttn = new System.Windows.Forms.Button();
            this.CancelBttn = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.QuantityTextBx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(25, 303);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(72, 28);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Title : ";
            // 
            // TitleTextBx
            // 
            this.TitleTextBx.Location = new System.Drawing.Point(103, 303);
            this.TitleTextBx.Name = "TitleTextBx";
            this.TitleTextBx.Size = new System.Drawing.Size(557, 31);
            this.TitleTextBx.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.DescriptionLabel.Location = new System.Drawing.Point(48, 501);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(132, 28);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description :";
            // 
            // DescriptionTextBx
            // 
            this.DescriptionTextBx.Location = new System.Drawing.Point(103, 542);
            this.DescriptionTextBx.Multiline = true;
            this.DescriptionTextBx.Name = "DescriptionTextBx";
            this.DescriptionTextBx.Size = new System.Drawing.Size(557, 148);
            this.DescriptionTextBx.TabIndex = 3;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.ForeColor = System.Drawing.Color.White;
            this.PriceLabel.Location = new System.Drawing.Point(82, 371);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(70, 28);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price :";
            // 
            // PriceTextBx
            // 
            this.PriceTextBx.Location = new System.Drawing.Point(158, 371);
            this.PriceTextBx.Name = "PriceTextBx";
            this.PriceTextBx.Size = new System.Drawing.Size(150, 31);
            this.PriceTextBx.TabIndex = 5;
            this.PriceTextBx.TextChanged += new System.EventHandler(this.PriceTextBx_TextChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuantityLabel.ForeColor = System.Drawing.Color.White;
            this.QuantityLabel.Location = new System.Drawing.Point(48, 434);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(106, 28);
            this.QuantityLabel.TabIndex = 6;
            this.QuantityLabel.Text = "Quantity :";
            // 
            // SubmitAdBttn
            // 
            this.SubmitAdBttn.BackColor = System.Drawing.Color.White;
            this.SubmitAdBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitAdBttn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitAdBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.SubmitAdBttn.Location = new System.Drawing.Point(133, 769);
            this.SubmitAdBttn.Name = "SubmitAdBttn";
            this.SubmitAdBttn.Size = new System.Drawing.Size(191, 98);
            this.SubmitAdBttn.TabIndex = 8;
            this.SubmitAdBttn.Text = "Submit";
            this.SubmitAdBttn.UseVisualStyleBackColor = false;
            this.SubmitAdBttn.Click += new System.EventHandler(this.SubmitAdBttn_Click);
            // 
            // CancelBttn
            // 
            this.CancelBttn.BackColor = System.Drawing.Color.White;
            this.CancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBttn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.CancelBttn.Location = new System.Drawing.Point(437, 769);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(191, 98);
            this.CancelBttn.TabIndex = 9;
            this.CancelBttn.Text = "Cancel";
            this.CancelBttn.UseVisualStyleBackColor = false;
            this.CancelBttn.Click += new System.EventHandler(this.CancelBttn_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::WindowsClient.Properties.Resources.LogoWhiteSignIn;
            this.LogoBox.Location = new System.Drawing.Point(206, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(318, 226);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 10;
            this.LogoBox.TabStop = false;
            // 
            // QuantityTextBx
            // 
            this.QuantityTextBx.Location = new System.Drawing.Point(160, 434);
            this.QuantityTextBx.Name = "QuantityTextBx";
            this.QuantityTextBx.Size = new System.Drawing.Size(128, 31);
            this.QuantityTextBx.TabIndex = 11;
            // 
            // PlaceAdvertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 905);
            this.Controls.Add(this.QuantityTextBx);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.CancelBttn);
            this.Controls.Add(this.SubmitAdBttn);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceTextBx);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DescriptionTextBx);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleTextBx);
            this.Controls.Add(this.TitleLbl);
            this.MaximumSize = new System.Drawing.Size(822, 961);
            this.Name = "PlaceAdvertisement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Advertisement";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLbl;
        private TextBox TitleTextBx;
        private Label DescriptionLabel;
        private TextBox DescriptionTextBx;
        private Label PriceLabel;
        private TextBox PriceTextBx;
        private Label QuantityLabel;
        private Button SubmitAdBttn;
        private Button CancelBttn;
        private PictureBox LogoBox;
        private TextBox QuantityTextBx;
    }
}