using BusinessEntities;
using BusinessLayer;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class CreateOneAdvert : Form
    {
        private IModel Model;
        private bool isBundle;
        private int NoItems;
        private double BundlePrice;
        private int BundleID;
        private int ItemNoOne;
        private int ItemNoTwo;
        private int ItemNoThree;
        public CreateOneAdvert(IModel _model, int BundleID, int ItemOne, int ItemTwo, int ItemThree, bool isBundle, double BundlePrice, int NoItems)
        {
            InitializeComponent();
            this.Model = _model;
            this.isBundle = isBundle;
            this.BundleID = BundleID;
            this.ItemNoOne = ItemOne;
            this.ItemNoTwo = ItemTwo;
            this.ItemNoThree = ItemThree;

            if (isBundle.Equals(true))
            {
                this.NoItems = NoItems;
            }
            this.BundlePrice = BundlePrice;
        }
        public byte[] ConvertImageToByte(System.Drawing.Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public void Alert(string message, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(message, type);
        }
        private void CreateOneAdvert_Load(object sender, EventArgs e)
        {
            IntroPanel.Visible = true;
            FileUploadPanel.Visible = false;
            
            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            TypeAnimalPanel.Visible = false;
            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void IntroNextBttn_Click(object sender, EventArgs e)
        {
            string advertType = this.AdvertTypeComboBox.GetItemText(this.AdvertTypeComboBox.SelectedItem);
            if(string.IsNullOrEmpty(advertType) ) 
            {
                MessageBox.Show("Please Choose An Advert Type");
            }
            else if(string.IsNullOrEmpty(TitleTxt.Text))
            {
                MessageBox.Show("Please Enter Title");
            }
            else if(string.IsNullOrEmpty(PriceTxt.Text))
            {
                MessageBox.Show("Please Enter Price");
            }
            else if(string.IsNullOrEmpty(DescriptionTxt.Text))
            {
                MessageBox.Show("Please Enter Description");
            }
            else
            {
                IntroPanel.Visible = false;
                FileUploadPanel.Visible = true;

                FoodPanel.Visible = false;
                AccessPanel.Visible = false;

                TypeAnimalPanel.Visible = false;
                HorsePanel.Visible = false;
                DogPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                LitterPanel.Visible = false;
            }
        }

        private void FileUploadNextBttn_Click(object sender, EventArgs e)
        {
            string advertType = this.AdvertTypeComboBox.GetItemText(this.AdvertTypeComboBox.SelectedItem);
            if (ImageOnePictureBx.Image == null && ImageTwoPictureBx.Image == null && ImageThreePictureBx.Image == null)
            {
                MessageBox.Show("Please Enter At least One Image");
            }
            else
            {
                IntroPanel.Visible = false;
                FileUploadPanel.Visible = false;
                switch(advertType)
                {
                    case "Animal":
                        FoodPanel.Visible = false;
                        AccessPanel.Visible = false;
                        TypeAnimalPanel.Visible = true;
                        SpecifyPanel.Visible = false;
                        AnimalTypePanel.Visible = true;
                        AnimalCatPanel.Visible = true;
                        HorsePanel.Visible = false;
                        DogPanel.Visible = false;
                        FarmAnimalPanel.Visible = false;
                        GenericAnimalPanel.Visible = false;
                        LitterPanel.Visible = false;
                        break;
                    case "Food":
                        FoodPanel.Visible = true;
                        AccessPanel.Visible = false;
                        TypeAnimalPanel.Visible = false;
                        HorsePanel.Visible = false;
                        DogPanel.Visible = false;
                        FarmAnimalPanel.Visible = false;
                        GenericAnimalPanel.Visible = false;
                        LitterPanel.Visible = false;
                        break;
                    case "Accessories":
                        FoodPanel.Visible = false;
                        AccessPanel.Visible = true;
                        TypeAnimalPanel.Visible = false;
                        HorsePanel.Visible = false;
                        DogPanel.Visible = false;
                        FarmAnimalPanel.Visible = false;
                        GenericAnimalPanel.Visible = false;
                        LitterPanel.Visible = false;
                        break;
                }

            }
        }

        private void FoodConfirmBttn_Click(object sender, EventArgs e)
        {
            string animalfood = this.AnimalFoodTypeComboBox.GetItemText(this.AnimalFoodTypeComboBox.SelectedItem);
            if (string.IsNullOrEmpty(animalfood))
            {
                MessageBox.Show("Please Choose Animal For Food");
            }
            else if(string.IsNullOrEmpty(DetailTxt.Text)) 
            {
                MessageBox.Show("Please Enter Food Details");
            }
            else
            {
                try
                {
                    Random rnd = new Random();
                    int AdvertID = 0;
                    if (isBundle.Equals(false))
                    {
                        do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    }
                    else
                    {
                        if (NoItems.Equals(3))
                        {
                            AdvertID = ItemNoThree;
                        }
                        else if (NoItems.Equals(2))
                        {
                            AdvertID = ItemNoTwo;
                        }
                        else if (NoItems.Equals(1))
                        {
                            AdvertID = ItemNoOne;
                        }
                    }
                    byte[] ImageOne = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageTwo = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageThree = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    if (ImageTwoPictureBx.Image == null && ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                    }
                    else if (ImageTwoPictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    else if (ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                    }
                    else
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }

                    if (Model.addNewFoodAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne,
                        ImageTwo, ImageThree, animalfood, DetailTxt.Text))
                    {
                        System.Windows.Forms.MessageBox.Show("Food Added");
                        string message = "Item #" + AdvertID + " has been added to our system. " +
                        "Admin must verify item before advertisement is made public";
                        string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                        int notifID = 0;
                        do { notifID = rnd.Next(0, 99999); } while (Model.NotifIDPresent(notifID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email))
                        {
                            if (isBundle.Equals(true) && NoItems.Equals(1))
                            {
                                //Create Bundle
                                if (Model.addNewBundle(BundleID, ItemNoOne, ItemNoTwo, ItemNoThree, BundlePrice)) { }
                                Close();
                            }
                            else if (isBundle.Equals(true) && NoItems > 1)
                            {
                                NoItems--;
                                //ResetForm(this); //Resetting back to original state
                            }
                            else if (isBundle.Equals(false))
                            {
                                this.Hide();
                            }
                        }
                    }
                }
                catch (Exception excep)
                {
                    var st = new StackTrace(excep, true);
                    // Get the top stack frame
                    var frame = st.GetFrame(0);
                    // Get the line number from the stack frame
                    var line = frame.GetFileLineNumber();
                    System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                }
            }
        }  

        private void FoodBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = false;
            FileUploadPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = false;
            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void FileUploadBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = true;
            FileUploadPanel.Visible = false;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = false;
            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void UploadOneBttn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ImageOnePictureBx.Image = Image.FromFile(open.FileName);
                ConfirmationOnePictureBx.Image = Properties.Resources.ImageConfirmation;
                ConfirmationOnePictureBx.Refresh();
                ConfirmationOnePictureBx.Visible = true;
            }
        }

        private void UploadTwoBttn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ImageTwoPictureBx.Image = Image.FromFile(open.FileName);
                ConfirmationTwoPictureBx.Image = Properties.Resources.ImageConfirmation;
                ConfirmationTwoPictureBx.Refresh();
                ConfirmationTwoPictureBx.Visible = true;
            }
        }

        private void UploadThreeBttn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ImageThreePictureBx.Image = Image.FromFile(open.FileName);
                ConfirmationThreePictureBx.Image = Properties.Resources.ImageConfirmation;
                ConfirmationThreePictureBx.Refresh();
                ConfirmationThreePictureBx.Visible = true;
            }
        }

        private void AccessBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = false;
            FileUploadPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = false;
            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void AccessCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AccessCat = this.AccessCatComboBox.GetItemText(this.AccessCatComboBox.SelectedItem);
            switch (AccessCat.Trim()) 
            {
                case "Health":
                    AccessTypeComboBox.Items.Clear();
                    AccessTypeComboBox.Items.Add("Supplements");
                    AccessTypeComboBox.Items.Add("Medication");
                    AccessTypeComboBox.Items.Add("Other");
                    break;
                case "Bedding":
                    AccessTypeComboBox.Items.Clear();
                    AccessTypeComboBox.Items.Add("Tanks and Enclosures");
                    AccessTypeComboBox.Items.Add("Kennels");
                    AccessTypeComboBox.Items.Add("Small Animals");
                    AccessTypeComboBox.Items.Add("Other");
                    break;
                case "Cleaning":
                    AccessTypeComboBox.Items.Clear();
                    AccessTypeComboBox.Items.Add("Tanks and Enclosures");
                    AccessTypeComboBox.Items.Add("Shampoos");
                    AccessTypeComboBox.Items.Add("Other");
                    break;
                case "Other":
                    AccessTypeComboBox.Items.Clear();
                    AccessTypeComboBox.Items.Add("Horse Riding");
                    AccessTypeComboBox.Items.Add("Aquariums");
                    AccessTypeComboBox.Items.Add("Clothing");
                    AccessTypeComboBox.Items.Add("Other");
                    break;
            }
        }

        private void AccessConfirmBttn_Click(object sender, EventArgs e)
        {
            string AccessCat = this.AccessCatComboBox.GetItemText(this.AccessCatComboBox.SelectedItem);
            string AccessSubCat = this.AccessTypeComboBox.GetItemText(this.AccessTypeComboBox.SelectedItem);
            if (string.IsNullOrEmpty(AccessCat))
            {
                MessageBox.Show("Please Choose An Accessory Category");
            }
            else if(string.IsNullOrEmpty(AccessSubCat)) 
            {
                MessageBox.Show("Please Choose An Accessory Type");
            }
            else
            {
                try
                {
                    Random rnd = new Random();
                    int AdvertID = 0;
                    if (isBundle.Equals(false))
                    {
                        do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    }
                    else
                    {
                        if (NoItems.Equals(3))
                        {
                            AdvertID = ItemNoThree;
                        }
                        else if (NoItems.Equals(2))
                        {
                            AdvertID = ItemNoTwo;
                        }
                        else if (NoItems.Equals(1))
                        {
                            AdvertID = ItemNoOne;
                        }
                    }
                    byte[] ImageOne = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageTwo = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageThree = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    if (ImageTwoPictureBx.Image == null && ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                    }
                    else if (ImageTwoPictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    else if (ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                    }
                    else
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    if (Model.addNewAccessoriesAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne,
                        ImageTwo, ImageThree, AccessCat, AccessSubCat))
                    {
                        string message = "Item #" + AdvertID + " has been added to our system. " +
                        "Admin must verify item before advertisement is made public";
                        string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                        int notifID = 0;
                        do { notifID = rnd.Next(0, 99999); } while (Model.NotifIDPresent(notifID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email))
                        {
                            if (isBundle.Equals(true) && NoItems.Equals(1))
                            {
                                //Create Bundle
                                if (Model.addNewBundle(BundleID, ItemNoOne, ItemNoTwo, ItemNoThree, BundlePrice)) { }
                                Close();
                            }
                            else if (isBundle.Equals(true) && NoItems > 1)
                            {
                                NoItems--;
                                //ResetForm(this); //Resetting back to original state
                            }
                            else if (isBundle.Equals(false))
                            {
                                Close();
                            }
                        }
                    }
                }
                catch (Exception excep)
                {
                    var st = new StackTrace(excep, true);
                    // Get the top stack frame
                    var frame = st.GetFrame(0);
                    // Get the line number from the stack frame
                    var line = frame.GetFileLineNumber();
                    System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                }
            }
        }

        private void AnimalCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AnimalCategory = this.AnimalCatComboBox.GetItemText(this.AnimalCatComboBox.SelectedItem);
            SpecifyAnimalTxtBx.Enabled = false;
            AnimalTypeComboBox.Enabled = false;
            switch (AnimalCategory.Trim()) 
            {
                case "House Pets":
                    TypeAnimalPanel.Visible = true;
                    SpecifyPanel.Visible = true;
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Dog");
                    AnimalTypeComboBox.Items.Add("Cat");
                    AnimalTypeComboBox.Items.Add("Fish");
                    AnimalTypeComboBox.Items.Add("Hamster");
                    AnimalTypeComboBox.Items.Add("Rabbit");
                    SpecifyAnimalTxtBx.Enabled = false;
                    AnimalTypeComboBox.Enabled = true;
                    break;
                case "Farm Animals":
                    AnimalTypePanel.Visible = true;
                    SpecifyPanel.Visible = true;
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Horse");
                    AnimalTypeComboBox.Items.Add("Chicken");
                    AnimalTypeComboBox.Items.Add("Cow");
                    AnimalTypeComboBox.Items.Add("Pig");
                    AnimalTypeComboBox.Items.Add("Sheep");
                    AnimalTypeComboBox.Items.Add("Goat");
                    SpecifyAnimalTxtBx.Enabled = false;
                    AnimalTypeComboBox.Enabled = true;
                    break;
                case "Reptiles":
                    AnimalTypePanel.Visible = true;
                    SpecifyPanel.Visible = true;
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Snake");
                    AnimalTypeComboBox.Items.Add("Lizard");
                    AnimalTypeComboBox.Items.Add("Turtle");
                    AnimalTypeComboBox.Items.Add("Turtoise");
                    SpecifyAnimalTxtBx.Enabled = false;
                    AnimalTypeComboBox.Enabled = true;
                    break;
                case "Litter":
                    AnimalTypePanel.Visible = true;
                    SpecifyPanel.Visible = true;
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Dogs");
                    AnimalTypeComboBox.Items.Add("Cats");
                    SpecifyAnimalTxtBx.Enabled = false;
                    AnimalTypeComboBox.Enabled = true;
                    break;
                case "Other":
                    SpecifyPanel.Visible = true;
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypePanel.Visible = true;
                    SpecifyAnimalTxtBx.Enabled = true;
                    AnimalTypeComboBox.Enabled = false;
                    break;
            }
        }

        private void TypeAnimalBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = false;
            FileUploadPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = false;
            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void AnimalTypeNextBttn_Click(object sender, EventArgs e)
        {
            string AnimalCategory = this.AnimalCatComboBox.GetItemText(this.AnimalCatComboBox.SelectedItem);
            string AnimalType = "";
            AnimalType = this.AnimalTypeComboBox.GetItemText(this.AnimalTypeComboBox.SelectedItem);
            if (string.IsNullOrEmpty(AnimalCategory))
            {
                MessageBox.Show("Please Choose An Animal Category");
            }
            else if(string.IsNullOrEmpty(SpecifyAnimalTxtBx.Text) && string.IsNullOrEmpty(AnimalType))
            {
                MessageBox.Show("Please Choose An Animal Type");
            }
            else
            {
                if(string.IsNullOrEmpty(AnimalType))
                {
                    AnimalType = SpecifyAnimalTxtBx.Text;
                }
                switch (AnimalCategory.Trim())
                {
                    case "House Pets":
                        if(AnimalType.Equals("Dog"))
                        {
                            IntroPanel.Visible = false;
                            FileUploadPanel.Visible = true;

                            FoodPanel.Visible = false;
                            AccessPanel.Visible = false;
                            TypeAnimalPanel.Visible = false;
                            HorsePanel.Visible = false;
                            DogPanel.Visible = true;
                            FarmAnimalPanel.Visible = false;
                            GenericAnimalPanel.Visible = false;
                            LitterPanel.Visible = false;
                            DogPurebreedYesRadBttn.Checked = true;
                            DogPurebreedNoBttn.Checked = false;
                        }
                        else
                        {
                            IntroPanel.Visible = false;
                            FileUploadPanel.Visible = false;

                            FoodPanel.Visible = false;
                            AccessPanel.Visible = false;
                            TypeAnimalPanel.Visible = false;
                            HorsePanel.Visible = false;
                            DogPanel.Visible = false;
                            FarmAnimalPanel.Visible = false;
                            GenericAnimalPanel.Visible = true;
                            LitterPanel.Visible = false;
                        }
                        break;
                    case "Farm Animals":
                        if(AnimalType.Equals("Horse"))
                        {
                            IntroPanel.Visible = false;
                            FileUploadPanel.Visible = false;

                            FoodPanel.Visible = false;
                            AccessPanel.Visible = false;
                            TypeAnimalPanel.Visible = false;
                            HorsePanel.Visible = true;
                            DogPanel.Visible = false;
                            FarmAnimalPanel.Visible = false;
                            GenericAnimalPanel.Visible = false;
                            LitterPanel.Visible = false;

                            BrokenYesRadBttn.Checked = true;
                            BrokenNoRadBttn.Checked = false;
                        }
                        else
                        {
                            IntroPanel.Visible = false;
                            FileUploadPanel.Visible = false;

                            FoodPanel.Visible = false;
                            AccessPanel.Visible = false;
                            TypeAnimalPanel.Visible = false;
                            HorsePanel.Visible = false;
                            DogPanel.Visible = false;
                            FarmAnimalPanel.Visible = true;
                            GenericAnimalPanel.Visible = false;
                            LitterPanel.Visible = false;
                        }
                        break;
                    case "Litter":
                        if (AnimalType.Equals("Dog"))
                        {
                            IntroPanel.Visible = false;
                            FileUploadPanel.Visible = false;

                            FoodPanel.Visible = false;
                            AccessPanel.Visible = false;
                            TypeAnimalPanel.Visible = false;
                            HorsePanel.Visible = false;
                            DogPanel.Visible = false;
                            FarmAnimalPanel.Visible = false;
                            GenericAnimalPanel.Visible = false;
                            LitterPanel.Visible = true;

                            DogLitterPanel.Visible = true;
                            CatLitterPanel.Visible = false;
                            LitterYesRadBttn.Checked = true;
                            LitterNoRadBttn.Checked = false;
                        }
                        else if (AnimalType.Equals("Cat"))
                        {
                            IntroPanel.Visible = false;
                            FileUploadPanel.Visible = false;

                            FoodPanel.Visible = false;
                            AccessPanel.Visible = false;
                            TypeAnimalPanel.Visible = false;
                            HorsePanel.Visible = false;
                            DogPanel.Visible = false;
                            FarmAnimalPanel.Visible = false;
                            GenericAnimalPanel.Visible = false;
                            LitterPanel.Visible = true;

                            DogLitterPanel.Visible = false;
                            CatLitterPanel.Visible = true;
                            LitterYesRadBttn.Checked = true;
                            LitterNoRadBttn.Checked = false;
                        }
                        break;
                    case "Other":
                        IntroPanel.Visible = false;
                        FileUploadPanel.Visible = false;

                        FoodPanel.Visible = false;
                        AccessPanel.Visible = false;
                        TypeAnimalPanel.Visible = false;
                        HorsePanel.Visible = false;
                        DogPanel.Visible = false;
                        FarmAnimalPanel.Visible = false;
                        GenericAnimalPanel.Visible = true;
                        LitterPanel.Visible = false;
                        break;
                }
            }
        }

        private void HorseBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = false;
            FileUploadPanel.Visible = false;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = true;
            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void HorseConfirmBttn_Click(object sender, EventArgs e)
        {
            string HorseGender = this.HorseGenderComboBox.GetItemText(this.HorseGenderComboBox.SelectedItem);
            string HorseBreed = this.HorseBreedComboBox.GetItemText(this.HorseBreedComboBox.SelectedItem);

            if (string.IsNullOrEmpty(HorseNameTxt.Text))
            {
                MessageBox.Show("Please Enter Horse Name");
            }
            else if(string.IsNullOrEmpty(HorseAgeTxt.Text))
            {
                MessageBox.Show("Please Enter Horse Age");
            }
            else if(string.IsNullOrEmpty(HorseGender))
            {
                MessageBox.Show("Please Choose Horse Gender");
            }
            else if(string.IsNullOrEmpty(HorseBreed))
            {
                MessageBox.Show("Please Choose Horse Breed");
            }
            else if(string.IsNullOrEmpty(HorseSizeTxt.Text))
            {
                MessageBox.Show("Please Enter Horse Size");
            }
            else if(BrokenYesRadBttn.Checked || BrokenNoRadBttn.Checked) 
            {
                MessageBox.Show("Please Check If Horse Is Broken");
            }
            else if(string.IsNullOrEmpty(HorsePurposeTxt.Text))
            {
                MessageBox.Show("Please Enter Purpose");
            }
            else
            {
                try
                {
                    Random rnd = new Random();
                    int AdvertID = 0;
                    if (isBundle.Equals(false))
                    {
                        do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    }
                    else
                    {
                        if (NoItems.Equals(3))
                        {
                            AdvertID = ItemNoThree;
                        }
                        else if (NoItems.Equals(2))
                        {
                            AdvertID = ItemNoTwo;
                        }
                        else if (NoItems.Equals(1))
                        {
                            AdvertID = ItemNoOne;
                        }
                    }
                    byte[] ImageOne = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageTwo = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageThree = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    if (ImageTwoPictureBx.Image == null && ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                    }
                    else if (ImageTwoPictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    else if (ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                    }
                    else
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    string horsebreed = this.HorseBreedComboBox.GetItemText(this.HorseBreedComboBox.SelectedItem);
                    string horsegender = this.HorseGenderComboBox.GetItemText(this.HorseGenderComboBox.SelectedItem);

                    if (Model.addNewHorseAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne, ImageTwo, ImageThree,
                           HorseNameTxt.Text, Convert.ToInt32(HorseAgeTxt.Text), horsegender, HorseSizeTxt.Text, false, horsebreed,
                           HorsePurposeTxt.Text))
                    {
                        string message = "Item #" + AdvertID + " has been added to our system. " +
                       "Admin must verify item before advertisement is made public";
                        string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                        int notifID = 0;
                        do { notifID = rnd.Next(0, 99999); } while (Model.NotifIDPresent(notifID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email))
                        {
                            if (isBundle.Equals(true) && NoItems.Equals(1))
                            {
                                //Create Bundle
                                if (Model.addNewBundle(BundleID, ItemNoOne, ItemNoTwo, ItemNoThree, BundlePrice)) { }
                                Close();
                            }
                            else if (isBundle.Equals(true) && NoItems > 1)
                            {
                                NoItems--;
                                //ResetForm(this); //Resetting back to original state
                            }
                            else if (isBundle.Equals(false))
                            {
                                Close();
                            }
                        }
                        //System.Windows.MessageBox.Show(message);
                    }


                }
                catch (Exception excep)
                {
                    var st = new StackTrace(excep, true);
                    // Get the top stack frame
                    var frame = st.GetFrame(0);
                    // Get the line number from the stack frame
                    var line = frame.GetFileLineNumber();

                    System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                }
            }
        }

        private void DogBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = false;
            FileUploadPanel.Visible = false;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = true;
            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void DogPurebreedYesRadBttn_CheckedChanged(object sender, EventArgs e)
        {
            IntroPanel.Visible = false;
            FileUploadPanel.Visible = false;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = false;
            HorsePanel.Visible = false;
            DogPanel.Visible = true;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;

            IsPurebreedPanel.Visible = true;
            DogIsNotPurebreedPanel.Visible = false;
        }

        private void DogPurebreedNoBttn_CheckedChanged(object sender, EventArgs e)
        {
            IntroPanel.Visible = false;
            FileUploadPanel.Visible = false;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = false;
            HorsePanel.Visible = false;
            DogPanel.Visible = true;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;

            IsPurebreedPanel.Visible = false;
            DogIsNotPurebreedPanel.Visible = true;
        }

        private void DogConfirmBttn_Click(object sender, EventArgs e)
        {
            //string DogBreed = this.DogBreedComboBox.GetItemText(this.DogBreedComboBox.SelectedItem);
            string DogBreedOne = "";
            string DogBreedTwo = "";
            string DogGender = this.DogGenderComboBox.GetItemText(this.DogGenderComboBox.SelectedItem);
            if (string.IsNullOrEmpty(DogNameTxt.Text))
            {
                MessageBox.Show("Please Enter Dog Name");
            }
            else if(string.IsNullOrEmpty(DogAgeTxt.Text))
            {
                MessageBox.Show("Please Enter Dog Age");
            }
            else if(string.IsNullOrEmpty(DogGender))
            {
                MessageBox.Show("Please Enter Dog Gender");
            }
            else if(DogPurebreedYesRadBttn.Checked.Equals(false) && DogPurebreedNoBttn.Checked.Equals(false))
            {
                MessageBox.Show("Please Confirm If Dog Is A Purebreed");
            }
            else
            {
                if(DogPurebreedYesRadBttn.Checked.Equals(true))
                {
                    DogBreedOne = this.DogBreedComboBox.GetItemText(this.DogBreedComboBox.SelectedItem);

                    if(string.IsNullOrEmpty(DogBreedOne))
                    {
                        MessageBox.Show("Please Choose Dog Breed");
                    }
                }
                else if(DogPurebreedNoBttn.Checked.Equals(true))
                {
                    DogBreedOne = this.DogBreedOneComboBox.GetItemText(this.DogBreedOneComboBox.SelectedItem);
                    DogBreedTwo = this.DogBreedTwoComboBox.GetItemText(this.DogBreedTwoComboBox.SelectedItem);

                    if (string.IsNullOrEmpty(DogBreedOne) && string.IsNullOrEmpty(DogBreedTwo))
                    {
                        MessageBox.Show("Please Choose Two Dog Breeds");
                    }
                }
                try
                {
                    Random rnd = new Random();
                    int AdvertID = 0;
                    if (isBundle.Equals(false))
                    {
                        do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    }
                    else
                    {
                        if (NoItems.Equals(3))
                        {
                            AdvertID = ItemNoThree;
                        }
                        else if (NoItems.Equals(2))
                        {
                            AdvertID = ItemNoTwo;
                        }
                        else if (NoItems.Equals(1))
                        {
                            AdvertID = ItemNoOne;
                        }
                    }
                    byte[] ImageOne = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageTwo = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageThree = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    if (ImageTwoPictureBx.Image == null && ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                    }
                    else if (ImageTwoPictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    else if (ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                    }
                    else
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    bool isPurebred = false;
                    if (DogPurebreedYesRadBttn.Checked.Equals(true))
                    {
                        if (Model.addNewDogAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne, ImageTwo, ImageThree,
                            DogNameTxt.Text, Convert.ToInt32(DogAgeTxt.Text), DogGender, true, DogBreedOne, DogBreedTwo))
                        {
                            string message = "Item #" + AdvertID + " has been added to our system. " +
                           "Admin must verify item before advertisement is made public";
                            string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                            int notifID = 0;
                            do { notifID = rnd.Next(0, 99999); } while (Model.NotifIDPresent(notifID));
                            if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email))
                            {
                                if (isBundle.Equals(true) && NoItems.Equals(1))
                                {
                                    //Create Bundle
                                    if (Model.addNewBundle(BundleID, ItemNoOne, ItemNoTwo, ItemNoThree, BundlePrice)) 
                                    {
                                        this.Alert("Bundle Created", Form_Alert.enmType.Success);
                                    }
                                    Close();
                                }
                                else if (isBundle.Equals(true) && NoItems > 1)
                                {
                                    NoItems--;
                                    //ResetForm(this); //Resetting back to original state
                                }
                                else if (isBundle.Equals(false))
                                {
                                    this.Alert("Advertisement Created", Form_Alert.enmType.Success);
                                    Close();
                                }
                            }
                        }
                        else if (DogPurebreedNoBttn.Checked.Equals(true))
                        {
                            if (Model.addNewDogAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne, ImageTwo, ImageThree,
                                 DogNameTxt.Text, Convert.ToInt32(DogAgeTxt.Text), DogGender, true, DogBreedOne, DogBreedTwo))
                            {
                                string message = "Item #" + AdvertID + " has been added to our system. " +
                               "Admin must verify item before advertisement is made public";
                                string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                                int notifID = 0;
                                do { notifID = rnd.Next(0, 99999); } while (Model.NotifIDPresent(notifID));
                                if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email))
                                {
                                    if (isBundle.Equals(true) && NoItems.Equals(1))
                                    {
                                        //Create Bundle
                                        if (Model.addNewBundle(BundleID, ItemNoOne, ItemNoTwo, ItemNoThree, BundlePrice)) 
                                        {
                                            this.Alert("Bundle Created", Form_Alert.enmType.Success);
                                        }
                                        Close();
                                    }
                                    else if (isBundle.Equals(true) && NoItems > 1)
                                    {
                                        NoItems--;
                                        //ResetForm(this); //Resetting back to original state
                                    }
                                    else if (isBundle.Equals(false))
                                    {
                                        this.Alert("Advertisement Created", Form_Alert.enmType.Success);
                                        Close();
                                    }
                                }
                            }

                        }
                    }
                }
                catch (Exception excep)
                {
                    var st = new StackTrace(excep, true);
                    // Get the top stack frame
                    var frame = st.GetFrame(0);
                    // Get the line number from the stack frame
                    var line = frame.GetFileLineNumber();

                    System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                }

            }
        }

        private void FABackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = false;
            FileUploadPanel.Visible = false;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = false;
            HorsePanel.Visible = false;
            DogPanel.Visible = true;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;

            IsPurebreedPanel.Visible = false;
            DogIsNotPurebreedPanel.Visible = true;
        }

        private void FAConfirmBttn_Click(object sender, EventArgs e)
        {
            string FAGender = this.FAGenderComboBox.GetItemText(this.FAGenderComboBox.SelectedItem);
            string FAAnimalType = this.AnimalTypeComboBox.GetItemText(this.AnimalTypeComboBox.SelectedItem);
            if(string.IsNullOrEmpty(FANameTxt.Text))
            {
                MessageBox.Show("Please Enter" + FAAnimalType + "'s Name");
            }
            else if(string.IsNullOrEmpty(FAAgeTxt.Text))
            {
                MessageBox.Show("Please Enter" + FAAnimalType + "'s Age");
            }
            else if (string.IsNullOrEmpty(FAGender))
            {
                MessageBox.Show("Please Enter" + FAAnimalType + "'s Gender");
            }
            else if (string.IsNullOrEmpty(FAPurposeTxt.Text))
            {
                MessageBox.Show("Please Enter" + FAAnimalType + "'s Purpose");
            }
            else
            {
                try
                {
                    Random rnd = new Random();
                    int AdvertID = 0;
                    if (isBundle.Equals(false))
                    {
                        do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    }
                    else
                    {
                        if (NoItems.Equals(3))
                        {
                            AdvertID = ItemNoThree;
                        }
                        else if (NoItems.Equals(2))
                        {
                            AdvertID = ItemNoTwo;
                        }
                        else if (NoItems.Equals(1))
                        {
                            AdvertID = ItemNoOne;
                        }
                    }
                    byte[] ImageOne = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageTwo = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageThree = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    if (ImageTwoPictureBx.Image == null && ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                    }
                    else if (ImageTwoPictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    else if (ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                    }
                    else
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    string AnimalType = this.AnimalTypeComboBox.GetItemText(this.AnimalTypeComboBox.SelectedItem);
                    string FarmGender = this.FAGenderComboBox.GetItemText(this.FAGenderComboBox.SelectedItem);

                    if (Model.addNewFarmAnimalAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne,
                           ImageTwo, ImageThree, AnimalType, FANameTxt.Text, Convert.ToInt32(FAAgeTxt.Text), FarmGender, FAPurposeTxt.Text))
                    {
                        string message = "Item #" + AdvertID + " has been added to our system. " +
                        "Admin must verify item before advertisement is made public";
                        string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                        int notifID = 0;
                        do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email))
                        {
                            if (isBundle.Equals(true) && NoItems.Equals(1))
                            {
                                //Create Bundle
                                if (Model.addNewBundle(BundleID, ItemNoOne, ItemNoTwo, ItemNoThree, BundlePrice)) 
                                {
                                    this.Alert("Bundle Created", Form_Alert.enmType.Success);
                                }
                                Close();
                            }
                            else if (isBundle.Equals(true) && NoItems > 1)
                            {
                                NoItems--;
                                //ResetForm(this); //Resetting back to original state
                            }
                            else if (isBundle.Equals(false))
                            {
                                Close();
                            }
                        }
                    }
                }
                catch (Exception excep)
                {
                    var st = new StackTrace(excep, true);
                    // Get the top stack frame
                    var frame = st.GetFrame(0);
                    // Get the line number from the stack frame
                    var line = frame.GetFileLineNumber();

                    System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                }
            }
        }

        private void GABackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = false;
            FileUploadPanel.Visible = false;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = true;
            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;

            IsPurebreedPanel.Visible = false;
            DogIsNotPurebreedPanel.Visible = false;
        }

        private void GAConfirmBttn_Click(object sender, EventArgs e)
        {
            string AnimalType = "";
            if(string.IsNullOrEmpty(SpecifyAnimalTxtBx.Text))
            {
                AnimalType = this.AnimalTypeComboBox.GetItemText(this.AnimalTypeComboBox.SelectedItem);
            }
            else
            {
                AnimalType = SpecifyAnimalTxtBx.Text;
            }
            string GAGender = this.GAGenderComboBox.GetItemText(this.GAGenderComboBox.SelectedItem);
            string detailTwo = DetailTwoTxt.Text;
            string detailThree = DetailTwoTxt.Text;
            if(string.IsNullOrEmpty(GANameTxt.Text))
            {
                MessageBox.Show("Please Enter " + AnimalType.Trim() + "'s Name");
            }
            else if(string.IsNullOrEmpty(GAAgeTxt.Text))
            {
                MessageBox.Show("Please Enter " + AnimalType.Trim() + "'s Age");
            }
            else if(string.IsNullOrEmpty(GAGender))
            {
                MessageBox.Show("Please Enter " + AnimalType.Trim() + "'s Gender");
            }
            else if(string.IsNullOrEmpty(DetailOneTxt.Text))
            {
                MessageBox.Show("Please Enter At Least One Detail");
            }
            else if(string.IsNullOrEmpty(detailTwo) && string.IsNullOrEmpty(detailThree))
            {
                detailTwo = "";
                detailThree = "";
            }
            else if(string.IsNullOrEmpty(detailTwo))
            {
                detailTwo = "";
            }
            else if(string.IsNullOrEmpty(detailThree))
            {
                detailThree = "";
            }
            else
            {
                try
                {
                    Random rnd = new Random();
                    int AdvertID = 0;
                    if (isBundle.Equals(false))
                    {
                        do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    }
                    else
                    {
                        if (NoItems.Equals(3))
                        {
                            AdvertID = ItemNoThree;
                        }
                        else if (NoItems.Equals(2))
                        {
                            AdvertID = ItemNoTwo;
                        }
                        else if (NoItems.Equals(1))
                        {
                            AdvertID = ItemNoOne;
                        }
                    }
                    byte[] ImageOne = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageTwo = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageThree = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    if (ImageTwoPictureBx.Image == null && ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                    }
                    else if (ImageTwoPictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    else if (ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                    }
                    else
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }

                    if (Model.addNewGenericAnimalAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne, ImageTwo, ImageThree,
                        AnimalType, GANameTxt.Text, Convert.ToInt32(GAAgeTxt.Text), GAGender, DetailOneTxt.Text, DetailTwoTxt.Text, DetailThreeTxt.Text))
                    {
                        string message = "Item #" + AdvertID + " has been added to our system. " +
                           "Admin must verify item before advertisement is made public";
                        string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                        int notifID = 0;
                        do { notifID = rnd.Next(0, 99999); } while (Model.NotifIDPresent(notifID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email))
                        {
                            if (isBundle.Equals(true) && NoItems.Equals(1))
                            {
                                //Create Bundle
                                if (Model.addNewBundle(BundleID, ItemNoOne, ItemNoTwo, ItemNoThree, BundlePrice)) 
                                {
                                    this.Alert("Bundle Created", Form_Alert.enmType.Success);
                                }
                                Close();
                            }
                            else if (isBundle.Equals(true) && NoItems > 1)
                            {
                                NoItems--;
                                //ResetForm(this); //Resetting back to original state
                            }
                            else if (isBundle.Equals(false))
                            {
                                this.Alert("Advertisement Created", Form_Alert.enmType.Success);
                                Close();
                            }
                        }
                        //System.Windows.MessageBox.Show(message);
                    }

                }
                catch (Exception excep)
                {
                    var st = new StackTrace(excep, true);
                    // Get the top stack frame
                    var frame = st.GetFrame(0);
                    // Get the line number from the stack frame
                    var line = frame.GetFileLineNumber();
                    System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                }
            }
        }

        private void LitterBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = false;
            FileUploadPanel.Visible = false;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            TypeAnimalPanel.Visible = true;
            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;

            IsPurebreedPanel.Visible = false;
            DogIsNotPurebreedPanel.Visible = false;
        }

        private void LitterConfirmBttn_Click(object sender, EventArgs e)
        {
            string AnimalType = this.AnimalTypeComboBox.GetItemText(this.AnimalTypeComboBox.SelectedItem);
            string LitterBreedOne = "";
            string LitterBreedTwo = "";
            if (string.IsNullOrEmpty(LitterSizeTxt.Text))
            {
                MessageBox.Show("Please Enter Amount In Litter");
            }
            else if (string.IsNullOrEmpty(LitterAgeTxt.Text))
            {
                MessageBox.Show("Please Enter Age Of Litter");
            }
            else if (LitterYesRadBttn.Checked.Equals(false) && LitterNoRadBttn.Checked.Equals(false))
            {
                MessageBox.Show("Please Enter If Litter Is Purebred");
            }
            else
            {
                if (AnimalType.Trim().Equals("Dog"))
                {
                    switch (LitterYesRadBttn.Checked)
                    {
                        case true:
                            LitterBreedOne = this.DogLPComboBox.GetItemText(this.DogLPComboBox.SelectedItem);
                            LitterBreedTwo = "";
                            if(string.IsNullOrEmpty(LitterBreedOne))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            break;
                        case false:
                            LitterBreedOne = this.DogLNOneComboBox.GetItemText(this.DogLNOneComboBox.SelectedItem);
                            LitterBreedTwo = this.DogLNTwoComboBox.GetItemText(this.DogLNOneComboBox.SelectedItem); ;
                            if (string.IsNullOrEmpty(LitterBreedOne))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            else if(string.IsNullOrEmpty(LitterBreedTwo))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            break;
                    }
                    switch (LitterNoRadBttn.Checked)
                    {
                        case true:
                            LitterBreedOne = this.DogLNOneComboBox.GetItemText(this.DogLNOneComboBox.SelectedItem);
                            LitterBreedTwo = this.DogLNTwoComboBox.GetItemText(this.DogLNOneComboBox.SelectedItem);
                            if (string.IsNullOrEmpty(LitterBreedOne))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            else if (string.IsNullOrEmpty(LitterBreedTwo))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            break;
                        case false:
                            LitterBreedOne = this.DogLPComboBox.GetItemText(this.DogLPComboBox.SelectedItem);
                            LitterBreedTwo = "";
                            if (string.IsNullOrEmpty(LitterBreedOne))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            break;
                    }
                }
                else if (AnimalType.Trim().Equals("Cat"))
                {
                    switch (LitterYesRadBttn.Checked)
                    {
                        case true:
                            LitterBreedOne = this.CatLPComboBox.GetItemText(this.CatLPComboBox.SelectedItem);
                            LitterBreedTwo = "";
                            if (string.IsNullOrEmpty(LitterBreedOne))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            break;
                        case false:
                            LitterBreedOne = this.CatLNOneComboBox.GetItemText(this.CatLNOneComboBox.SelectedItem);
                            LitterBreedTwo = this.CatLNTwoComboBox.GetItemText(this.CatLNOneComboBox.SelectedItem);
                            if (string.IsNullOrEmpty(LitterBreedOne))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            else if (string.IsNullOrEmpty(LitterBreedTwo))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            break;
                    }
                    switch (LitterNoRadBttn.Checked)
                    {
                        case true:
                            LitterBreedOne = this.CatLNOneComboBox.GetItemText(this.CatLNOneComboBox.SelectedItem);
                            LitterBreedTwo = this.CatLNTwoComboBox.GetItemText(this.CatLNOneComboBox.SelectedItem);
                            if (string.IsNullOrEmpty(LitterBreedOne))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            else if (string.IsNullOrEmpty(LitterBreedTwo))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            break;
                        case false:
                            LitterBreedOne = this.CatLPComboBox.GetItemText(this.CatLPComboBox.SelectedItem);
                            LitterBreedTwo = "";
                            if (string.IsNullOrEmpty(LitterBreedOne))
                            {
                                MessageBox.Show("Please Enter Breed");
                            }
                            break;
                    }
                }
                try
                {
                    Random rnd = new Random();
                    int AdvertID = 0;
                    if (isBundle.Equals(false))
                    {
                        do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    }
                    else
                    {
                        if (NoItems.Equals(3))
                        {
                            AdvertID = ItemNoThree;
                        }
                        else if (NoItems.Equals(2))
                        {
                            AdvertID = ItemNoTwo;
                        }
                        else if (NoItems.Equals(1))
                        {
                            AdvertID = ItemNoOne;
                        }
                    }
                    byte[] ImageOne = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageTwo = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    byte[] ImageThree = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                    if (ImageTwoPictureBx.Image == null && ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                    }
                    else if (ImageTwoPictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    else if (ImageThreePictureBx.Image == null)
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                    }
                    else
                    {
                        ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                        ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
                        ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                    }
                    bool isPurebreed = false;
                    if (LitterBreedTwo.Equals("")) { isPurebreed = true; }
                    if (Model.addNewLitterAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne,
                        ImageTwo, ImageThree, AnimalType, Convert.ToInt32(LitterSizeTxt.Text), Convert.ToInt32(LitterAgeTxt.Text), isPurebreed, LitterBreedOne, LitterBreedTwo))
                    {
                        string message = "Item #" + AdvertID + " has been added to our system. " +
                        "Admin must verify item before advertisement is made public";
                        string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                        int notifID = 0;
                        do { notifID = rnd.Next(0, 99999); } while (Model.NotifIDPresent(notifID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email))
                        {
                            if (isBundle.Equals(true) && NoItems.Equals(1))
                            {
                                //Create Bundle
                                if (Model.addNewBundle(BundleID, ItemNoOne, ItemNoTwo, ItemNoThree, BundlePrice)) 
                                {
                                    this.Alert("Bundle Created", Form_Alert.enmType.Success);
                                }
                                Close();
                            }
                            else if (isBundle.Equals(true) && NoItems > 1)
                            {
                                NoItems--;
                                //ResetForm(this); //Resetting back to original state
                            }
                            else if (isBundle.Equals(false))
                            {
                                this.Alert("Advertisement Created", Form_Alert.enmType.Success);
                                Close();
                            }
                        }
                    }
                }
                catch(Exception excep)
                {
                    var st = new StackTrace(excep, true);
                    // Get the top stack frame
                    var frame = st.GetFrame(0);
                    // Get the line number from the stack frame
                    var line = frame.GetFileLineNumber();

                    System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                }

            }
            
        }

        private void PriceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void HorseAgeTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(HorseAgeTxt.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                HorseAgeTxt.Text = HorseAgeTxt.Text.Remove(HorseAgeTxt.Text.Length - 1);
            }
        }

        private void DogAgeTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(DogAgeTxt.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                DogAgeTxt.Text = DogAgeTxt.Text.Remove(DogAgeTxt.Text.Length - 1);
            }
        }

        private void FAAgeTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(FAAgeTxt.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                FAAgeTxt.Text = FAAgeTxt.Text.Remove(FAAgeTxt.Text.Length - 1);
            }
        }

        private void GAAgeTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(GAAgeTxt.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                GAAgeTxt.Text = GAAgeTxt.Text.Remove(GAAgeTxt.Text.Length - 1);
            }
        }

        private void LitterAgeTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(LitterAgeTxt.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                LitterAgeTxt.Text = LitterAgeTxt.Text.Remove(LitterAgeTxt.Text.Length - 1);
            }
        }
    }
}
