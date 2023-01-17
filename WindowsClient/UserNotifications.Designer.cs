namespace WindowsClient
{
    partial class UserNotifications
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
            this.NotificationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // NotificationFlowLayoutPanel
            // 
            this.NotificationFlowLayoutPanel.AutoScroll = true;
            this.NotificationFlowLayoutPanel.AutoSize = true;
            this.NotificationFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.NotificationFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.NotificationFlowLayoutPanel.Name = "NotificationFlowLayoutPanel";
            this.NotificationFlowLayoutPanel.Size = new System.Drawing.Size(950, 663);
            this.NotificationFlowLayoutPanel.TabIndex = 0;
            this.NotificationFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.NotificationFlowLayoutPanel_Paint);
            // 
            // UserNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 663);
            this.Controls.Add(this.NotificationFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserNotifications";
            this.Load += new System.EventHandler(this.UserNotifications_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel NotificationFlowLayoutPanel;
    }
}