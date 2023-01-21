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
            this.UserFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // UserFlowLayout
            // 
            this.UserFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.UserFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.UserFlowLayout.Name = "UserFlowLayout";
            this.UserFlowLayout.Size = new System.Drawing.Size(986, 450);
            this.UserFlowLayout.TabIndex = 4;
            this.UserFlowLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.UserFlowLayout_Paint_1);
            // 
            // User_Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.UserFlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1008, 506);
            this.Name = "User_Notifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Notifications";
            this.Load += new System.EventHandler(this.User_Notifications_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel UserFlowLayout;
    }
}