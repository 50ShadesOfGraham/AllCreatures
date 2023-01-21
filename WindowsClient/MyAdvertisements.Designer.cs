namespace WindowsClient
{
    partial class MyAdvertisements
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
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.AdvertFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.HeaderPanel.Controls.Add(this.HeaderLbl);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 150);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderLbl.ForeColor = System.Drawing.Color.White;
            this.HeaderLbl.Location = new System.Drawing.Point(211, 56);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(347, 48);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "My Advertisements";
            // 
            // AdvertFlowLayout
            // 
            this.AdvertFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvertFlowLayout.Location = new System.Drawing.Point(0, 150);
            this.AdvertFlowLayout.Name = "AdvertFlowLayout";
            this.AdvertFlowLayout.Size = new System.Drawing.Size(800, 300);
            this.AdvertFlowLayout.TabIndex = 1;
            // 
            // MyAdvertisements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdvertFlowLayout);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyAdvertisements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAdvertisements";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HeaderPanel;
        private Label HeaderLbl;
        private FlowLayoutPanel AdvertFlowLayout;
    }
}