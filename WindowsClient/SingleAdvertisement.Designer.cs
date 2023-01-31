namespace WindowsClient
{
    partial class SingleAdvertisement
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
            this.MyAdvertPictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.UpdateBttn = new System.Windows.Forms.Button();
            this.AdvertStatusLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyAdvertPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MyAdvertPictureBox
            // 
            this.MyAdvertPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MyAdvertPictureBox.Name = "MyAdvertPictureBox";
            this.MyAdvertPictureBox.Size = new System.Drawing.Size(246, 173);
            this.MyAdvertPictureBox.TabIndex = 0;
            this.MyAdvertPictureBox.TabStop = false;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.TitleLbl.Location = new System.Drawing.Point(287, 13);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(69, 30);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "TITLE";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.PriceLbl.Location = new System.Drawing.Point(287, 63);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(65, 28);
            this.PriceLbl.TabIndex = 2;
            this.PriceLbl.Text = "Price ";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.StatusLbl.Location = new System.Drawing.Point(287, 111);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(82, 28);
            this.StatusLbl.TabIndex = 3;
            this.StatusLbl.Text = "Status :";
            // 
            // UpdateBttn
            // 
            this.UpdateBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.UpdateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBttn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBttn.ForeColor = System.Drawing.Color.White;
            this.UpdateBttn.Location = new System.Drawing.Point(691, 29);
            this.UpdateBttn.Name = "UpdateBttn";
            this.UpdateBttn.Size = new System.Drawing.Size(152, 96);
            this.UpdateBttn.TabIndex = 4;
            this.UpdateBttn.Text = "Update";
            this.UpdateBttn.UseVisualStyleBackColor = false;
            this.UpdateBttn.Click += new System.EventHandler(this.UpdateBttn_Click);
            // 
            // AdvertStatusLbl
            // 
            this.AdvertStatusLbl.AutoSize = true;
            this.AdvertStatusLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdvertStatusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.AdvertStatusLbl.Location = new System.Drawing.Point(375, 111);
            this.AdvertStatusLbl.Name = "AdvertStatusLbl";
            this.AdvertStatusLbl.Size = new System.Drawing.Size(79, 28);
            this.AdvertStatusLbl.TabIndex = 5;
            this.AdvertStatusLbl.Text = "STATUS";
            // 
            // SingleAdvertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AdvertStatusLbl);
            this.Controls.Add(this.UpdateBttn);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.MyAdvertPictureBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.Name = "SingleAdvertisement";
            this.Size = new System.Drawing.Size(914, 173);
            this.Load += new System.EventHandler(this.SingleAdvertisement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyAdvertPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox MyAdvertPictureBox;
        private Label TitleLbl;
        private Label PriceLbl;
        private Label StatusLbl;
        private Button UpdateBttn;
        private Label AdvertStatusLbl;
    }
}
