namespace WindowsClient
{
    partial class ViewMyPurchase
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelAdsTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(37, 40);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(50, 20);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "label1";
            // 
            // labelAdsTitle
            // 
            this.labelAdsTitle.AutoSize = true;
            this.labelAdsTitle.Location = new System.Drawing.Point(130, 46);
            this.labelAdsTitle.Name = "labelAdsTitle";
            this.labelAdsTitle.Size = new System.Drawing.Size(50, 20);
            this.labelAdsTitle.TabIndex = 1;
            this.labelAdsTitle.Text = "label2";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(238, 23);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(50, 20);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "label3";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(503, 49);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 20);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "label4";
            // 
            // ViewMyPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAdsTitle);
            this.Controls.Add(this.labelNumber);
            this.Name = "ViewMyPurchase";
            this.Size = new System.Drawing.Size(596, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNumber;
        private Label labelAdsTitle;
        private Label labelDescription;
        private Label labelPrice;
    }
}
