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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NotifTitleBttn
            // 
            this.NotifTitleBttn.Location = new System.Drawing.Point(3, 3);
            this.NotifTitleBttn.Name = "NotifTitleBttn";
            this.NotifTitleBttn.Size = new System.Drawing.Size(908, 81);
            this.NotifTitleBttn.TabIndex = 0;
            this.NotifTitleBttn.Text = "button1";
            this.NotifTitleBttn.UseVisualStyleBackColor = true;
            this.NotifTitleBttn.Click += new System.EventHandler(this.NotifTitleBttn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(908, 258);
            this.textBox1.TabIndex = 1;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NotifTitleBttn);
            this.Name = "Notification";
            this.Size = new System.Drawing.Size(914, 352);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NotifTitleBttn;
        private TextBox textBox1;
    }
}
