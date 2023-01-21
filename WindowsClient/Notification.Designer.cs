namespace WindowsClient
{
    partial class Notification
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
            this.NotificationHeaderBttn = new System.Windows.Forms.Button();
            this.HeaderFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.HeaderFlowLayoutPanel.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotificationHeaderBttn
            // 
            this.NotificationHeaderBttn.AutoSize = true;
            this.NotificationHeaderBttn.BackColor = System.Drawing.Color.White;
            this.NotificationHeaderBttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NotificationHeaderBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.NotificationHeaderBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificationHeaderBttn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NotificationHeaderBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.NotificationHeaderBttn.Location = new System.Drawing.Point(3, 3);
            this.NotificationHeaderBttn.Name = "NotificationHeaderBttn";
            this.NotificationHeaderBttn.Padding = new System.Windows.Forms.Padding(6);
            this.NotificationHeaderBttn.Size = new System.Drawing.Size(1122, 120);
            this.NotificationHeaderBttn.TabIndex = 0;
            this.NotificationHeaderBttn.Text = "button1";
            this.NotificationHeaderBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationHeaderBttn.UseVisualStyleBackColor = false;
            this.NotificationHeaderBttn.Click += new System.EventHandler(this.NotificationHeaderBttn_Click);
            // 
            // HeaderFlowLayoutPanel
            // 
            this.HeaderFlowLayoutPanel.AutoSize = true;
            this.HeaderFlowLayoutPanel.Controls.Add(this.NotificationHeaderBttn);
            this.HeaderFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderFlowLayoutPanel.Name = "HeaderFlowLayoutPanel";
            this.HeaderFlowLayoutPanel.Size = new System.Drawing.Size(1128, 126);
            this.HeaderFlowLayoutPanel.TabIndex = 3;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.White;
            this.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.MessageTextBox.Location = new System.Drawing.Point(0, 0);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.Size = new System.Drawing.Size(1128, 225);
            this.MessageTextBox.TabIndex = 2;
            // 
            // MessagePanel
            // 
            this.MessagePanel.AutoSize = true;
            this.MessagePanel.Controls.Add(this.MessageTextBox);
            this.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagePanel.Location = new System.Drawing.Point(0, 126);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(1128, 225);
            this.MessagePanel.TabIndex = 4;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.HeaderFlowLayoutPanel);
            this.Name = "Notification";
            this.Size = new System.Drawing.Size(1128, 351);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.HeaderFlowLayoutPanel.ResumeLayout(false);
            this.HeaderFlowLayoutPanel.PerformLayout();
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button NotificationHeaderBttn;
        private FlowLayoutPanel HeaderFlowLayoutPanel;
        private TextBox MessageTextBox;
        private Panel MessagePanel;
    }
}
