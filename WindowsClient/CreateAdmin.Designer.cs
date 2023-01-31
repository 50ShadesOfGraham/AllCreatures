namespace WindowsClient
{
    partial class CreateAdmin
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
            this.bbtn = new System.Windows.Forms.Button();
            this.textBoxUT = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.CAbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bbtn
            // 
            this.bbtn.BackColor = System.Drawing.Color.White;
            this.bbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.bbtn.Location = new System.Drawing.Point(650, 379);
            this.bbtn.Name = "bbtn";
            this.bbtn.Size = new System.Drawing.Size(138, 59);
            this.bbtn.TabIndex = 9;
            this.bbtn.Text = "Back";
            this.bbtn.UseVisualStyleBackColor = false;
            this.bbtn.Click += new System.EventHandler(this.bbtn_Click);
            // 
            // textBoxUT
            // 
            this.textBoxUT.Location = new System.Drawing.Point(236, 111);
            this.textBoxUT.Name = "textBoxUT";
            this.textBoxUT.Size = new System.Drawing.Size(244, 27);
            this.textBoxUT.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(236, 12);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(244, 27);
            this.textBoxEmail.TabIndex = 7;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 20;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 12);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(204, 424);
            this.listBoxUsers.TabIndex = 6;
            this.listBoxUsers.DoubleClick += new System.EventHandler(this.listBoxUsers_DoubleClick);
            // 
            // CAbtn
            // 
            this.CAbtn.BackColor = System.Drawing.Color.White;
            this.CAbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CAbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.CAbtn.Location = new System.Drawing.Point(236, 163);
            this.CAbtn.Name = "CAbtn";
            this.CAbtn.Size = new System.Drawing.Size(138, 59);
            this.CAbtn.TabIndex = 5;
            this.CAbtn.Text = "Create Admin";
            this.CAbtn.UseVisualStyleBackColor = false;
            this.CAbtn.Click += new System.EventHandler(this.CAbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBox1.Location = new System.Drawing.Point(236, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreateAdmin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bbtn);
            this.Controls.Add(this.textBoxUT);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.CAbtn);
            this.Name = "CreateAdmin";
            this.Load += new System.EventHandler(this.CreateAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button bbtn;
        private TextBox textBoxUT;
        private TextBox textBoxEmail;
        private ListBox listBoxUsers;
        private Button CAbtn;
        private ComboBox comboBox1;
    }
#endregion
}