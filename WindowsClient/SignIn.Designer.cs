namespace WindowsClient
{
    partial class SignIn
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
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.ShowBttn = new System.Windows.Forms.Button();
            this.SignInBttn = new System.Windows.Forms.Button();
            this.RegisterLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CancelBttn = new System.Windows.Forms.Button();
            this.ForgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Emaillbl.ForeColor = System.Drawing.Color.White;
            this.Emaillbl.Location = new System.Drawing.Point(133, 317);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(90, 32);
            this.Emaillbl.TabIndex = 1;
            this.Emaillbl.Text = "Email :";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(229, 320);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(305, 31);
            this.Emailtxt.TabIndex = 2;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Passwordlbl.ForeColor = System.Drawing.Color.White;
            this.Passwordlbl.Location = new System.Drawing.Point(87, 387);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(136, 32);
            this.Passwordlbl.TabIndex = 3;
            this.Passwordlbl.Text = "Password :";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(229, 390);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(305, 31);
            this.Passwordtxt.TabIndex = 4;
            this.Passwordtxt.TextChanged += new System.EventHandler(this.Passwordtxt_TextChanged);
            // 
            // ShowBttn
            // 
            this.ShowBttn.BackColor = System.Drawing.Color.White;
            this.ShowBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ShowBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBttn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ShowBttn.Location = new System.Drawing.Point(540, 390);
            this.ShowBttn.Name = "ShowBttn";
            this.ShowBttn.Size = new System.Drawing.Size(77, 35);
            this.ShowBttn.TabIndex = 5;
            this.ShowBttn.Text = "Show";
            this.ShowBttn.UseVisualStyleBackColor = false;
            this.ShowBttn.Click += new System.EventHandler(this.ShowBttn_Click);
            // 
            // SignInBttn
            // 
            this.SignInBttn.BackColor = System.Drawing.Color.White;
            this.SignInBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBttn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignInBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.SignInBttn.Location = new System.Drawing.Point(162, 518);
            this.SignInBttn.Name = "SignInBttn";
            this.SignInBttn.Size = new System.Drawing.Size(208, 73);
            this.SignInBttn.TabIndex = 6;
            this.SignInBttn.Text = "Sign In";
            this.SignInBttn.UseVisualStyleBackColor = false;
            this.SignInBttn.Click += new System.EventHandler(this.SignInBttn_Click);
            // 
            // RegisterLinkLabel
            // 
            this.RegisterLinkLabel.AutoSize = true;
            this.RegisterLinkLabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterLinkLabel.LinkColor = System.Drawing.Color.White;
            this.RegisterLinkLabel.Location = new System.Drawing.Point(203, 452);
            this.RegisterLinkLabel.Name = "RegisterLinkLabel";
            this.RegisterLinkLabel.Size = new System.Drawing.Size(103, 30);
            this.RegisterLinkLabel.TabIndex = 8;
            this.RegisterLinkLabel.TabStop = true;
            this.RegisterLinkLabel.Text = "Register";
            this.RegisterLinkLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.RegisterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkLabel_LinkClicked);
            // 
            // CancelBttn
            // 
            this.CancelBttn.BackColor = System.Drawing.Color.White;
            this.CancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBttn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.CancelBttn.Location = new System.Drawing.Point(418, 518);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(208, 73);
            this.CancelBttn.TabIndex = 9;
            this.CancelBttn.Text = "&Cancel";
            this.CancelBttn.UseVisualStyleBackColor = false;
            this.CancelBttn.Click += new System.EventHandler(this.CancelBttn_Click);
            // 
            // ForgotPasswordLinkLabel
            // 
            this.ForgotPasswordLinkLabel.AutoSize = true;
            this.ForgotPasswordLinkLabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForgotPasswordLinkLabel.LinkColor = System.Drawing.Color.White;
            this.ForgotPasswordLinkLabel.Location = new System.Drawing.Point(395, 452);
            this.ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel";
            this.ForgotPasswordLinkLabel.Size = new System.Drawing.Size(206, 30);
            this.ForgotPasswordLinkLabel.TabIndex = 10;
            this.ForgotPasswordLinkLabel.TabStop = true;
            this.ForgotPasswordLinkLabel.Text = "Forgot Password?";
            this.ForgotPasswordLinkLabel.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsClient.Properties.Resources.LogoWhiteSignIn;
            this.pictureBox1.Location = new System.Drawing.Point(214, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ForgotPasswordLinkLabel);
            this.Controls.Add(this.CancelBttn);
            this.Controls.Add(this.RegisterLinkLabel);
            this.Controls.Add(this.SignInBttn);
            this.Controls.Add(this.ShowBttn);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Emaillbl);
            this.MaximumSize = new System.Drawing.Size(822, 699);
            this.MinimumSize = new System.Drawing.Size(822, 699);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Emaillbl;
        private TextBox Emailtxt;
        private Label Passwordlbl;
        private TextBox Passwordtxt;
        private Button ShowBttn;
        private Button SignInBttn;
        private LinkLabel RegisterLinkLabel;
        private Button CancelBttn;
        private LinkLabel ForgotPasswordLinkLabel;
        private PictureBox pictureBox1;
    }
}