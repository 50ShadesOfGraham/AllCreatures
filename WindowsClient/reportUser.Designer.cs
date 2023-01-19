namespace WindowsClient
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
            this.ttlLabel = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::WindowsClient.Properties.Resources.LogoWhiteThumbnail;
            this.LogoBox.Location = new System.Drawing.Point(11, 12);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(120, 127);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 2;
            this.LogoBox.TabStop = false;
            // 
            // ttlLabel
            // 
            this.ttlLabel.AutoSize = true;
            this.ttlLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ttlLabel.ForeColor = System.Drawing.Color.White;
            this.ttlLabel.Location = new System.Drawing.Point(189, 30);
            this.ttlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ttlLabel.Name = "ttlLabel";
            this.ttlLabel.Size = new System.Drawing.Size(176, 28);
            this.ttlLabel.TabIndex = 123;
            this.ttlLabel.Text = "UserName(email)";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(396, 34);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(163, 24);
            this.txtUser.TabIndex = 124;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 24);
            this.textBox1.TabIndex = 125;
            // 
            // reportUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ttlLabel);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.LogoBox);
            this.Name = "reportUser";
            this.Text = "reportUser";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LogoBox;
        private Label ttlLabel;
        private TextBox txtUser;
        private TextBox textBox1;
    }
}