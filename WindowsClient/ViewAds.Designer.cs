namespace WindowsClient
{
    partial class ViewAds
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ViewBttn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SELbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StatusLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(319, 13);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(63, 25);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "label1";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Location = new System.Drawing.Point(446, 132);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(59, 25);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "label3";
            // 
            // ViewBttn
            // 
            this.ViewBttn.BackColor = System.Drawing.Color.White;
            this.ViewBttn.Location = new System.Drawing.Point(3, 0);
            this.ViewBttn.Name = "ViewBttn";
            this.ViewBttn.Size = new System.Drawing.Size(748, 262);
            this.ViewBttn.TabIndex = 6;
            this.ViewBttn.UseVisualStyleBackColor = false;
            this.ViewBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 256);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SELbl
            // 
            this.SELbl.AutoSize = true;
            this.SELbl.BackColor = System.Drawing.Color.Transparent;
            this.SELbl.Location = new System.Drawing.Point(338, 74);
            this.SELbl.Name = "SELbl";
            this.SELbl.Size = new System.Drawing.Size(110, 25);
            this.SELbl.TabIndex = 8;
            this.SELbl.Text = "Seller Email: ";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.PriceLbl.Location = new System.Drawing.Point(338, 132);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(88, 25);
            this.PriceLbl.TabIndex = 9;
            this.PriceLbl.Text = "Price :   € ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(338, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status : ";
            // 
            // UserLinkLabel
            // 
            this.UserLinkLabel.AutoSize = true;
            this.UserLinkLabel.Location = new System.Drawing.Point(454, 74);
            this.UserLinkLabel.Name = "UserLinkLabel";
            this.UserLinkLabel.Size = new System.Drawing.Size(90, 25);
            this.UserLinkLabel.TabIndex = 11;
            this.UserLinkLabel.TabStop = true;
            this.UserLinkLabel.Text = "linkLabel1";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(446, 183);
            this.StatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(59, 25);
            this.StatusLbl.TabIndex = 12;
            this.StatusLbl.Text = "label3";
            // 
            // ViewAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.UserLinkLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.SELbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.ViewBttn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAds";
            this.Size = new System.Drawing.Size(748, 262);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLbl;
        private Label PriceLabel;
        private Button ViewBttn;
        private PictureBox pictureBox1;
        private Label SELbl;
        private Label PriceLbl;
        private Label label4;
        private LinkLabel UserLinkLabel;
        private Label StatusLbl;
    }
}
