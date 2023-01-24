namespace WindowsClient
{
    partial class Form_LandingPage
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
            this.PlaceAdvertBttn = new System.Windows.Forms.Button();
            this.SellLinkLbl = new System.Windows.Forms.LinkLabel();
            this.ShopLinkLbl = new System.Windows.Forms.LinkLabel();
            this.ShopBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlaceAdvertBttn
            // 
            this.PlaceAdvertBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.PlaceAdvertBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.PlaceAdvertBttn.FlatAppearance.BorderSize = 0;
            this.PlaceAdvertBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaceAdvertBttn.Image = global::WindowsClient.Properties.Resources.Sell;
            this.PlaceAdvertBttn.Location = new System.Drawing.Point(442, 182);
            this.PlaceAdvertBttn.Name = "PlaceAdvertBttn";
            this.PlaceAdvertBttn.Size = new System.Drawing.Size(254, 235);
            this.PlaceAdvertBttn.TabIndex = 1;
            this.PlaceAdvertBttn.UseVisualStyleBackColor = false;
            this.PlaceAdvertBttn.Click += new System.EventHandler(this.PlaceAdvertBttn_Click);
            // 
            // SellLinkLbl
            // 
            this.SellLinkLbl.AutoSize = true;
            this.SellLinkLbl.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SellLinkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.SellLinkLbl.Location = new System.Drawing.Point(536, 420);
            this.SellLinkLbl.Name = "SellLinkLbl";
            this.SellLinkLbl.Size = new System.Drawing.Size(70, 41);
            this.SellLinkLbl.TabIndex = 2;
            this.SellLinkLbl.TabStop = true;
            this.SellLinkLbl.Text = "Sell";
            this.SellLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SellLinkLbl_LinkClicked);
            // 
            // ShopLinkLbl
            // 
            this.ShopLinkLbl.AutoSize = true;
            this.ShopLinkLbl.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShopLinkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ShopLinkLbl.Location = new System.Drawing.Point(149, 420);
            this.ShopLinkLbl.Name = "ShopLinkLbl";
            this.ShopLinkLbl.Size = new System.Drawing.Size(92, 41);
            this.ShopLinkLbl.TabIndex = 3;
            this.ShopLinkLbl.TabStop = true;
            this.ShopLinkLbl.Text = "Shop";
            // 
            // ShopBttn
            // 
            this.ShopBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ShopBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ShopBttn.FlatAppearance.BorderSize = 0;
            this.ShopBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopBttn.Image = global::WindowsClient.Properties.Resources.Shop1;
            this.ShopBttn.Location = new System.Drawing.Point(76, 182);
            this.ShopBttn.Name = "ShopBttn";
            this.ShopBttn.Size = new System.Drawing.Size(254, 235);
            this.ShopBttn.TabIndex = 4;
            this.ShopBttn.UseVisualStyleBackColor = false;
            // 
            // Form_LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 687);
            this.Controls.Add(this.ShopBttn);
            this.Controls.Add(this.ShopLinkLbl);
            this.Controls.Add(this.SellLinkLbl);
            this.Controls.Add(this.PlaceAdvertBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button PlaceAdvertBttn;
        private LinkLabel SellLinkLbl;
        private LinkLabel ShopLinkLbl;
        private Button ShopBttn;
    }
}