namespace WindowsClient
{
    partial class Form_Alert
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
            this.components = new System.ComponentModel.Container();
            this.MsgLbl = new System.Windows.Forms.Label();
            this.PopupCancelBttn = new System.Windows.Forms.Button();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgLbl
            // 
            this.MsgLbl.AutoSize = true;
            this.MsgLbl.Location = new System.Drawing.Point(100, 30);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(167, 30);
            this.MsgLbl.TabIndex = 0;
            this.MsgLbl.Text = "MessageText";
            // 
            // PopupCancelBttn
            // 
            this.PopupCancelBttn.FlatAppearance.BorderSize = 0;
            this.PopupCancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PopupCancelBttn.Image = global::WindowsClient.Properties.Resources.close;
            this.PopupCancelBttn.Location = new System.Drawing.Point(465, 17);
            this.PopupCancelBttn.Name = "PopupCancelBttn";
            this.PopupCancelBttn.Size = new System.Drawing.Size(58, 56);
            this.PopupCancelBttn.TabIndex = 1;
            this.PopupCancelBttn.UseVisualStyleBackColor = true;
            this.PopupCancelBttn.Click += new System.EventHandler(this.PopupCancelBttn_Click);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = global::WindowsClient.Properties.Resources.success;
            this.IconPictureBox.Location = new System.Drawing.Point(12, 7);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(82, 75);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 2;
            this.IconPictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Alert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(535, 94);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.PopupCancelBttn);
            this.Controls.Add(this.MsgLbl);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Alert";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_Alert";
            this.Load += new System.EventHandler(this.Form_Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MsgLbl;
        private Button PopupCancelBttn;
        private PictureBox IconPictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}