namespace WindowsClient
{
    partial class CreateSingleAdvertisement
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
            this.IntroPanel = new System.Windows.Forms.Panel();
            this.FileUploadPanel = new System.Windows.Forms.Panel();
            this.FoodPanel = new System.Windows.Forms.Panel();
            this.AccessPanel = new System.Windows.Forms.Panel();
            this.AnimalCatTypePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnimalCatTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IntroPanel
            // 
            this.IntroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IntroPanel.Location = new System.Drawing.Point(0, 0);
            this.IntroPanel.Name = "IntroPanel";
            this.IntroPanel.Size = new System.Drawing.Size(1198, 45);
            this.IntroPanel.TabIndex = 16;
            // 
            // FileUploadPanel
            // 
            this.FileUploadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileUploadPanel.Location = new System.Drawing.Point(0, 45);
            this.FileUploadPanel.Name = "FileUploadPanel";
            this.FileUploadPanel.Size = new System.Drawing.Size(1198, 84);
            this.FileUploadPanel.TabIndex = 17;
            // 
            // FoodPanel
            // 
            this.FoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoodPanel.Location = new System.Drawing.Point(0, 129);
            this.FoodPanel.Name = "FoodPanel";
            this.FoodPanel.Size = new System.Drawing.Size(1198, 94);
            this.FoodPanel.TabIndex = 18;
            // 
            // AccessPanel
            // 
            this.AccessPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccessPanel.Location = new System.Drawing.Point(0, 223);
            this.AccessPanel.Name = "AccessPanel";
            this.AccessPanel.Size = new System.Drawing.Size(1198, 78);
            this.AccessPanel.TabIndex = 19;
            // 
            // AnimalCatTypePanel
            // 
            this.AnimalCatTypePanel.Controls.Add(this.panel1);
            this.AnimalCatTypePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnimalCatTypePanel.Location = new System.Drawing.Point(0, 301);
            this.AnimalCatTypePanel.Name = "AnimalCatTypePanel";
            this.AnimalCatTypePanel.Size = new System.Drawing.Size(1198, 62);
            this.AnimalCatTypePanel.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(433, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 150);
            this.panel1.TabIndex = 21;
            // 
            // CreateSingleAdvertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1198, 578);
            this.Controls.Add(this.AnimalCatTypePanel);
            this.Controls.Add(this.AccessPanel);
            this.Controls.Add(this.FoodPanel);
            this.Controls.Add(this.FileUploadPanel);
            this.Controls.Add(this.IntroPanel);
            this.MinimumSize = new System.Drawing.Size(916, 620);
            this.Name = "CreateSingleAdvertisement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Advertisement";
            this.Load += new System.EventHandler(this.CreateSingleAdvertisement_Load);
            this.AnimalCatTypePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel AnimalPanel;
        private Panel SpecifyPanel;
        private Label SpecifyLbl;
        private TextBox SpecifyAnimalTxtBx;
        private Label TypeOfAnimallbl;
        private Label AnimalCatLbl;
        private ComboBox AnimalCatComboBox;
        private Panel LitterPanel;
        private Button LitterConfirmBttn;
        private Panel FarmAnimalPanel;
        private Button FarmAnimalConfirmBttn;
        private Panel DogPanel;
        private Button DogConfirmBttn;
        private ComboBox BreedTwoComboBox;
        private ComboBox BreedOneComboBox;
        private Label BreedTwoLbl;
        private Label BreedOneLbl;
        private Panel IsPurebreedPanel;
        private ComboBox BreedComboBox;
        private Label BreedLbl;
        private Panel LitterHeaderPanel;
        private Label NoLitterLbl;
        private RadioButton LitterNoRadBttn;
        private TextBox LitterSizeTxt;
        private RadioButton LitterYesRadBttn;
        private Label PurebreedLbl;
        private TextBox LitterAgeTxt;
        private Label LitterAgeLbl;
        private ComboBox FAGenderComboBox;
        private TextBox FAPurposeTxt;
        private TextBox FAAgeTxt;
        private TextBox FANameTxt;
        private Label FAPurposeLbl;
        private Label FAGenderLbl;
        private Label FAAgeLbl;
        private Label FANameLbl;
        private Label DogAgeLbl;
        private Label DogNameLbl;
        private Panel DogIsNotPurebreedPanel;
        private ComboBox DogBreedTwoComboBox;
        private ComboBox DogBreedOneComboBox;
        private Label DogBreedTwoLbl;
        private Label DogBreedOneLbl;
        private Panel DogisPurebreedPanel;
        private ComboBox DogBreedComboBox;
        private Label DogBreedLbl;
        private Panel DogHeaderPanel;
        private RadioButton DogPurebreedNoBttn;
        private RadioButton DogPurebreedYesRadBttn;
        private TextBox DogAgeTxt;
        private TextBox DogNameTxt;
        private Label DogPurebreedLbl;
        private ComboBox DogGenderComboBox;
        private Label DogGenderLbl;
        private ComboBox AnimalTypeComboBox;
        private Panel LitterPurebreedPanel;
        private PictureBox pictureBox7;
        private Button BackBttn;
        private PictureBox pictureBox6;
        private Button DogBackBttn;
        private PictureBox pictureBox4;
        private Button AnimalHeaderBackBttn;
        private PictureBox pictureBox2;
        private Button LitterBackBttn;
        private Panel LitterNotPurebreedPanel;
        private Panel TypeAnimalPanel;
        private Panel AnimalTypePanel;
        private Panel AnimalCatPanel;
        private Panel GenericAnimalPanel;
        private Button GABackBttn;
        private PictureBox pictureBox5;
        private TextBox DetailThreeTxt;
        private TextBox DetailTwoTxt;
        private TextBox DetailOneTxt;
        private ComboBox GAGenderComboBox;
        private TextBox GAAgeTxt;
        private TextBox GANameTxt;
        private Label DetailThreeLbl;
        private Label DetailTwoLbl;
        private Label DetailOneLbl;
        private Label GAGenderLbl;
        private Label GAAgeLbl;
        private Label GANameLbl;
        private Button GenericAnimalConfirmBttn;
        private Panel HorsePanel;
        private Button HorseBackBttn;
        private PictureBox pictureBox3;
        private TextBox HorsePurposeTxt;
        private ComboBox HorseBreedComboBox;
        private RadioButton BrokenNoRadBttn;
        private RadioButton BrokenYesRadBttn;
        private TextBox HorseSizeTxt;
        private ComboBox HorseGenderComboBox;
        private TextBox HorseAgeTxt;
        private TextBox HorseNameTxt;
        private Label HorsePurposeLbl;
        private Label HorseBreedLbl;
        private Label BrokenLbl;
        private Label HorseSizeLbl;
        private Label HorseGenderLbl;
        private Label HorseAgeLbl;
        private Label HorseNameLbl;
        private Button HorseConfirmBttn;
        private Panel IntroPanel;
        private Panel FileUploadPanel;
        private Panel FoodPanel;
        private Panel AccessPanel;
        private Panel AnimalCatTypePanel;
        private Panel panel1;
    }
}