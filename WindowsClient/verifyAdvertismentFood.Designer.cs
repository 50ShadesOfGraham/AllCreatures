namespace WindowsClient
{
    partial class verifyAdvertismentFood
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
            this.WAYSlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
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
            // WAYSlbl
            // 
            this.WAYSlbl.AutoSize = true;
            this.WAYSlbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WAYSlbl.ForeColor = System.Drawing.Color.White;
            this.WAYSlbl.Location = new System.Drawing.Point(138, 11);
            this.WAYSlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WAYSlbl.Name = "WAYSlbl";
            this.WAYSlbl.Size = new System.Drawing.Size(193, 20);
            this.WAYSlbl.TabIndex = 3;
            this.WAYSlbl.Text = "Advertisement Category : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 23);
            this.textBox1.TabIndex = 5;
            // 
            // verifyAdvertismentFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.WAYSlbl);
            this.Controls.Add(this.LogoBox);
            this.Name = "verifyAdvertismentFood";
            this.Text = "verifyAdvertismentFood";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LogoBox;
        private Label WAYSlbl;
        private TextBox textBox1;
    }
}