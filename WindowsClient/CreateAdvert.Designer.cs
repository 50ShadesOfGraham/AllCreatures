namespace WindowsClient
{
    partial class CreateAdvert
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
            this.IntroPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // IntroPanel
            // 
            this.IntroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IntroPanel.Location = new System.Drawing.Point(0, 0);
            this.IntroPanel.Name = "IntroPanel";
            this.IntroPanel.Size = new System.Drawing.Size(937, 88);
            this.IntroPanel.TabIndex = 0;
            // 
            // CreateAdvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(937, 1050);
            this.Controls.Add(this.IntroPanel);
            this.Name = "CreateAdvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Advertisement";
            this.Load += new System.EventHandler(this.CreateAdvert_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel IntroPanel;
    }
}