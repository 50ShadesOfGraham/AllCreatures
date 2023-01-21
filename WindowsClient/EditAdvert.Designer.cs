namespace WindowsClient
{
    partial class EditAdvert
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
            this.AdvertPictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.PriceTxt = new System.Windows.Forms.Label();
            this.StatusTxt = new System.Windows.Forms.Label();
            this.ViewAdvertBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdvertPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AdvertPictureBox
            // 
            this.AdvertPictureBox.Location = new System.Drawing.Point(19, 15);
            this.AdvertPictureBox.Name = "AdvertPictureBox";
            this.AdvertPictureBox.Size = new System.Drawing.Size(281, 260);
            this.AdvertPictureBox.TabIndex = 0;
            this.AdvertPictureBox.TabStop = false;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(355, 26);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(63, 25);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "label1";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLbl.Location = new System.Drawing.Point(355, 95);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(84, 25);
            this.PriceLbl.TabIndex = 2;
            this.PriceLbl.Text = "Price :  €";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLbl.Location = new System.Drawing.Point(344, 169);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(75, 25);
            this.StatusLbl.TabIndex = 3;
            this.StatusLbl.Text = "Status :";
            // 
            // PriceTxt
            // 
            this.PriceTxt.AutoSize = true;
            this.PriceTxt.Location = new System.Drawing.Point(445, 95);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(59, 25);
            this.PriceTxt.TabIndex = 4;
            this.PriceTxt.Text = "label1";
            // 
            // StatusTxt
            // 
            this.StatusTxt.AutoSize = true;
            this.StatusTxt.Location = new System.Drawing.Point(445, 169);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(59, 25);
            this.StatusTxt.TabIndex = 5;
            this.StatusTxt.Text = "label2";
            // 
            // ViewAdvertBttn
            // 
            this.ViewAdvertBttn.BackColor = System.Drawing.Color.Transparent;
            this.ViewAdvertBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAdvertBttn.Location = new System.Drawing.Point(3, 0);
            this.ViewAdvertBttn.Name = "ViewAdvertBttn";
            this.ViewAdvertBttn.Size = new System.Drawing.Size(792, 287);
            this.ViewAdvertBttn.TabIndex = 6;
            this.ViewAdvertBttn.UseVisualStyleBackColor = false;
            this.ViewAdvertBttn.Click += new System.EventHandler(this.ViewAdvertBttn_Click_1);
            // 
            // EditAdvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.AdvertPictureBox);
            this.Controls.Add(this.ViewAdvertBttn);
            this.Name = "EditAdvert";
            this.Size = new System.Drawing.Size(795, 287);
            this.Load += new System.EventHandler(this.EditAdvert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdvertPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox AdvertPictureBox;
        private Label TitleLbl;
        private Label PriceLbl;
        private Label StatusLbl;
        private Label PriceTxt;
        private Label StatusTxt;
        private Button ViewAdvertBttn;
    }
}
