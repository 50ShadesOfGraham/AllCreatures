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
            this.NotifTitleBttn = new System.Windows.Forms.Button();
            this.MessageTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NotifTitleBttn
            // 
            this.NotifTitleBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.NotifTitleBttn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NotifTitleBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.NotifTitleBttn.Location = new System.Drawing.Point(3, 3);
            this.NotifTitleBttn.Name = "NotifTitleBttn";
            this.NotifTitleBttn.Size = new System.Drawing.Size(908, 81);
            this.NotifTitleBttn.TabIndex = 0;
            this.NotifTitleBttn.Text = "button1";
            this.NotifTitleBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotifTitleBttn.UseVisualStyleBackColor = true;
            this.NotifTitleBttn.Click += new System.EventHandler(this.NotifTitleBttn_Click);
            // 
            // MessageTxt
            // 
            this.MessageTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.MessageTxt.Enabled = false;
            this.MessageTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MessageTxt.Location = new System.Drawing.Point(3, 90);
            this.MessageTxt.Multiline = true;
            this.MessageTxt.Name = "MessageTxt";
            this.MessageTxt.Size = new System.Drawing.Size(908, 258);
            this.MessageTxt.TabIndex = 1;
            this.MessageTxt.Text = "Enter Text...";
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.MessageTxt);
            this.Controls.Add(this.NotifTitleBttn);
            this.Name = "Notification";
            this.Size = new System.Drawing.Size(914, 352);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NotifTitleBttn;
        private TextBox MessageTxt;
    }
}
