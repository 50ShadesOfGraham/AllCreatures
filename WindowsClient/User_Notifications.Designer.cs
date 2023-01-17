namespace WindowsClient
{
    partial class User_Notifications
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.UserFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(169, 450);
            this.LeftPanel.TabIndex = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(169, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(631, 61);
            this.TopPanel.TabIndex = 3;
            // 
            // UserFlowLayout
            // 
            this.UserFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.UserFlowLayout.Location = new System.Drawing.Point(169, 61);
            this.UserFlowLayout.Name = "UserFlowLayout";
            this.UserFlowLayout.Size = new System.Drawing.Size(631, 389);
            this.UserFlowLayout.TabIndex = 4;
            // 
            // User_Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserFlowLayout);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Notifications";
            this.Text = "User_Notifications";
            this.Load += new System.EventHandler(this.User_Notifications_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel LeftPanel;
        private Panel TopPanel;
        private FlowLayoutPanel UserFlowLayout;
    }
}