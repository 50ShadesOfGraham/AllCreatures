using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Xceed.Wpf.AvalonDock.Controls;

namespace WindowsClient
{
    public partial class CreateSingleAdvertisement : Form
    {

        private IModel Model;
        private bool isBundle;
        private int NoItems;
        private Bundle bundle;
        public CreateSingleAdvertisement(IModel _model, Bundle bundle, bool isBundle)
        {
            InitializeComponent();
            this.Model = _model;
            this.isBundle = isBundle;
            this.bundle = bundle;
            if (isBundle.Equals(false)) { NoItems = 1; }
            if (isBundle.Equals(true) && bundle.ItemNoThree.Equals(0))
            {
                NoItems = 2;
            } else if (isBundle.Equals(true) && bundle.ItemNoThree != 0)
            {
                NoItems = 3;
            }

        }
        private void FoodPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AnimalCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AnimalCatComboBox.SelectedIndex.Equals(0))
            {
                AnimalTypeComboBox.Items.Clear();
                AnimalTypeComboBox.Items.Add("Dog");
                AnimalTypeComboBox.Items.Add("Cat");
                AnimalTypeComboBox.Items.Add("Fish");
                AnimalTypeComboBox.Items.Add("Hamster");
                AnimalTypeComboBox.Items.Add("Rabbit");
            }
            else if (AnimalCatComboBox.SelectedIndex.Equals(1))
            {
                AnimalTypeComboBox.Items.Clear();
                AnimalTypeComboBox.Items.Add("Horse");
                AnimalTypeComboBox.Items.Add("Chicken");
                AnimalTypeComboBox.Items.Add("Cow");
                AnimalTypeComboBox.Items.Add("Pig");
                AnimalTypeComboBox.Items.Add("Sheep");
                AnimalTypeComboBox.Items.Add("Goat");
            }
            else if (AnimalCatComboBox.SelectedIndex.Equals(2))
            {
                AnimalTypeComboBox.Items.Clear();
                AnimalTypeComboBox.Items.Add("Snake");
                AnimalTypeComboBox.Items.Add("Lizard");
                AnimalTypeComboBox.Items.Add("Turtle");
                AnimalTypeComboBox.Items.Add("Turtoise");
            }
            else if (AnimalCatComboBox.SelectedIndex.Equals(3))
            {
                AnimalTypeComboBox.Items.Clear();
                AnimalTypeComboBox.Items.Add("Dogs");
                AnimalTypeComboBox.Items.Add("Cats");
                LitterPanel.Visible = true;
                DogPanel.Visible = false;
                HorsePanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
                AccessPanel.Visible = false;
                FoodPanel.Visible = false;
            }
        }

        private void CreateSingleAdvertisement_Load(object sender, EventArgs e)
        {
            GeneralAdvertPanel.Visible = true;

            HorseGenderComboBox.SelectedText = "Male";
            HorseBreedComboBox.SelectedText = "Arabian horse";
            
            AnimalPanel.Visible = false;
            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            AnimalCatPanel.Visible = true;
            AnimalTypePanel.Visible = true;
            SpecifyPanel.Visible = false;

            DogPanel.Visible = false;
            DogisPurebreedPanel.Visible = true;
            HorsePanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
            IsPurebreedPanel.Visible = true;
        }

        private void AdvertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AdvertComboBox.SelectedItem.Equals("Animal"))
            {
                AnimalPanel.Visible = true;
                AccessPanel.Visible = false;
                FoodPanel.Visible = false;
            }
            else if(AdvertComboBox.SelectedItem.Equals("Food"))
            {
                AnimalPanel.Visible = false;
                AccessPanel.Visible = false;
                FoodPanel.Visible = true;
            }
            else if(AdvertComboBox.SelectedItem.Equals("Accessories"))
            {
                AnimalPanel.Visible = false;
                AccessPanel.Visible = true;
                FoodPanel.Visible = false;
            }
        }
        public byte[] ConvertImageToByte(System.Drawing.Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
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

        private void AccessCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AccessCatComboBox.SelectedItem.Equals("Health"))
            {
                AccessTypeComboBox.Items.Clear();
                AccessTypeComboBox.Items.Add("Supplements");
                AccessTypeComboBox.Items.Add("Medication");
                AccessTypeComboBox.Items.Add("Other");
            }
            else if(AccessCatComboBox.SelectedItem.Equals(" Bedding"))
            {
                AccessTypeComboBox.Items.Clear();
                AccessTypeComboBox.Items.Add("Tanks and Enclosures");
                AccessTypeComboBox.Items.Add("Kennels");
                AccessTypeComboBox.Items.Add("Small Animals");
                AccessTypeComboBox.Items.Add("Other");
            }
            else if(AccessCatComboBox.SelectedItem.Equals(" Cleaning"))
            {
                AccessTypeComboBox.Items.Clear();
                AccessTypeComboBox.Items.Add("Tanks and Enclosures");
                AccessTypeComboBox.Items.Add("Shampoos");
                AccessTypeComboBox.Items.Add("Other");
            }
            else if(AccessCatComboBox.SelectedItem.Equals(" Other"))
            {
                AccessTypeComboBox.Items.Clear();
                AccessTypeComboBox.Items.Add("Horse Riding");
                AccessTypeComboBox.Items.Add("Aquariums");
                AccessTypeComboBox.Items.Add("Clothing");
            }
        }

        private void AccessConfirmBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int AdvertID = 0;
                if(isBundle.Equals(false)) 
                {
                    do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                }
                else
                {
                    if(NoItems.Equals(3))
                    {
                        AdvertID = bundle.ItemNoThree;
                    }
                    else if(NoItems.Equals(2))
                    {
                        AdvertID = bundle.ItemNoTwo;
                    }
                    else if(NoItems.Equals(1))
                    {
                        AdvertID = bundle.ItemNoOne;
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
                //AccessTypeComboBox this.HorseBreedComboBox.GetItemText(this.HorseBreedComboBox.SelectedItem);
                string AccessCat = this.AccessCatComboBox.GetItemText(this.AccessCatComboBox.SelectedItem);
                string AccessSubCat = this.AccessTypeComboBox.GetItemText(this.AccessTypeComboBox.SelectedItem);
                if(Model.addNewAccessoriesAdvert(AdvertID,Model.CurrentUser.Email,TitleTxt.Text,DescriptionTxt.Text,Convert.ToDouble(PriceTxt.Text),false,"Available",ImageOne,
                    ImageTwo,ImageThree,AccessCat,AccessSubCat))
                {
                    string message = "Item #" + AdvertID + " has been added to our system. " +
                    "Admin must verify item before advertisement is made public";
                    string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                    int notifID = 0;
                    do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
                    if(isBundle.Equals(true) && NoItems.Equals(1))
                    {
                        //Create Bundle
                        //Model.addNewBundle(bundle.BundleID,bundle.ItemOne,bundle.ItemTwo,bundle.ItemThree,bundle.Price){ }
                        Close();
                    }
                    else if(isBundle.Equals(true) && NoItems > 1)
                    {
                        NoItems--;
                        ResetForm(this); //Resetting back to original state
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

        private void FoodConfirmBttn_Click(object sender, EventArgs e)
        {
            try
            {
                //if(isBundle.Equals(true)) { }
                Random rnd = new Random();
                int AdvertID = 0;
                do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
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
                string AnimalType = this.AnimalFoodTypeComboBox.GetItemText(this.AnimalFoodTypeComboBox.SelectedItem);
                if (Model.addNewFoodAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne,
                    ImageTwo, ImageThree, AnimalType, DetailTxt.Text))
                {
                    string message = "Item #" + AdvertID + " has been added to our system. " +
                    "Admin must verify item before advertisement is made public";
                    string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                    int notifID = 0;
                    do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
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

        private void BreedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AnimalTypeComboBox.SelectedItem.Equals("Cat"))
            {
                BreedComboBox.Items.Clear();
                BreedOneComboBox.Items.Clear();
                BreedTwoComboBox.Items.Clear();

                BreedComboBox.Items.Add("Devon Rex");
                BreedOneComboBox.Items.Add("Devon Rex");
                BreedTwoComboBox.Items.Add("Devon Rex");
                BreedComboBox.Items.Add("Abyssinian");
                BreedOneComboBox.Items.Add("Abyssinian");
                BreedTwoComboBox.Items.Add("Abyssinian");
                BreedComboBox.Items.Add("Sphynx");
                BreedOneComboBox.Items.Add("Sphynx");
                BreedTwoComboBox.Items.Add("Sphynx");
                BreedComboBox.Items.Add("Scottish Fold");
                BreedOneComboBox.Items.Add("Scottish Fold");
                BreedTwoComboBox.Items.Add("Scottish Fold");

                BreedComboBox.Items.Add("American Shorthair");
                BreedOneComboBox.Items.Add("American Shorthair");
                BreedTwoComboBox.Items.Add("American Shorthair");
                BreedComboBox.Items.Add("Maine Coon");
                BreedOneComboBox.Items.Add("Maine Coon");
                BreedTwoComboBox.Items.Add("Maine Coon");
                BreedComboBox.Items.Add("Persian");
                BreedOneComboBox.Items.Add("Persian");
                BreedTwoComboBox.Items.Add("Persian");
                BreedComboBox.Items.Add("British Shorthair");
                BreedOneComboBox.Items.Add("British Shorthair");
                BreedTwoComboBox.Items.Add("British Shorthair");

                BreedComboBox.Items.Add("Other");
                BreedOneComboBox.Items.Add("Other");
                BreedTwoComboBox.Items.Add("Other");

            }
            else if(AnimalTypeComboBox.SelectedItem.Equals("Dog"))
            {
                BreedComboBox.Items.Clear();
                BreedOneComboBox.Items.Clear();
                BreedTwoComboBox.Items.Clear();

                BreedComboBox.Items.Add("Golden Retriever");
                BreedOneComboBox.Items.Add("Golden Retriever");
                BreedTwoComboBox.Items.Add("Golden Retriever");
                BreedComboBox.Items.Add("Labrador");
                BreedOneComboBox.Items.Add("Labrador");
                BreedTwoComboBox.Items.Add("Labrador");
                BreedComboBox.Items.Add("French Bulldog");
                BreedOneComboBox.Items.Add("French Bulldog");
                BreedTwoComboBox.Items.Add("French Bulldog");
                BreedComboBox.Items.Add("German Shepherd");
                BreedOneComboBox.Items.Add("German Shepherd");
                BreedTwoComboBox.Items.Add("German Shepherd");

                BreedComboBox.Items.Add("Dachshund");
                BreedOneComboBox.Items.Add("Dachshund");
                BreedTwoComboBox.Items.Add("Dachshund");
                BreedComboBox.Items.Add("Newfoundland");
                BreedOneComboBox.Items.Add("Newfoundland");
                BreedTwoComboBox.Items.Add("Newfoundland");
                BreedComboBox.Items.Add("Boxer");
                BreedOneComboBox.Items.Add("Boxer");
                BreedTwoComboBox.Items.Add("Boxer");
                BreedComboBox.Items.Add("Terrier");
                BreedOneComboBox.Items.Add("Terrier");
                BreedTwoComboBox.Items.Add("Terrier");

                BreedComboBox.Items.Add("Other");
                BreedOneComboBox.Items.Add("Other");
                BreedTwoComboBox.Items.Add("Other");
            }
        }

        private void LitterYesRadBttn_CheckedChanged(object sender, EventArgs e)
        {
            IsPurebreedPanel.Visible = true;
            NotPurebreedPanel.Visible = false;
        }

        private void LitterNoRadBttn_CheckedChanged(object sender, EventArgs e)
        {
            IsPurebreedPanel.Visible = false;
            NotPurebreedPanel.Visible = true;
        }

        private void LitterConfirmBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int AdvertID = 0;
                do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
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
                string LitterBreed = this.DogBreedComboBox.GetItemText(this.DogBreedComboBox.SelectedItem);
                string LitterBreedOne = this.BreedOneComboBox.GetItemText(this.BreedOneComboBox.SelectedItem);
                string LitterBreedTwo = this.BreedTwoComboBox.GetItemText(this.BreedTwoComboBox.SelectedItem);
                if (LitterYesRadBttn.Checked)
                {
                    if (Model.addNewLitterAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne,
                        ImageTwo, ImageThree, AnimalType, Convert.ToInt32(LitterSizeTxt.Text), Convert.ToInt32(LitterAgeTxt.Text), true, LitterBreed, ""))
                    {
                        string message = "Item #" + AdvertID + " has been added to our system. " +
                        "Admin must verify item before advertisement is made public";
                        string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                        int notifID = 0;
                        do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
                    }
                }

                if (LitterNoRadBttn.Checked)
                {
                    if (Model.addNewLitterAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne,
                        ImageTwo, ImageThree, AnimalType, Convert.ToInt32(LitterSizeTxt.Text), Convert.ToInt32(LitterAgeTxt.Text), false, LitterBreedOne, LitterBreedTwo))
                    {
                        string message = "Item #" + AdvertID + " has been added to our system. " +
                        "Admin must verify item before advertisement is made public";
                        string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                        int notifID = 0;
                        do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
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

        private void FarmAnimalConfirmBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int AdvertID = 0;
                do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
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
                       ImageTwo, ImageThree, AnimalType,FANameTxt.Text, Convert.ToInt32(FAAgeTxt.Text),FarmGender, FAPurposeTxt.Text))
                {
                    string message = "Item #" + AdvertID + " has been added to our system. " +
                    "Admin must verify item before advertisement is made public";
                    string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                    int notifID = 0;
                    do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
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

        private void GenericAnimalConfirmBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int AdvertID = 0;
                do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
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

                string animaltype = "";
                if(SpecifyAnimalTxtBx != null) 
                { 
                    animaltype= SpecifyAnimalTxtBx.Text;
                }
                else 
                {  
                    animaltype = this.AnimalTypeComboBox.GetItemText(this.AnimalTypeComboBox.SelectedItem.ToString()); 
                }

                string GAGender = this.GAGenderComboBox.GetItemText(this.GAGenderComboBox.SelectedItem.ToString());
                
                if(Model.addNewGenericAnimalAdvert(AdvertID,Model.CurrentUser.Email,TitleTxt.Text,DescriptionTxt.Text,Convert.ToDouble(PriceTxt.Text),false,"Available",ImageOne,ImageTwo,ImageThree,
                    animaltype,GANameTxt.Text,Convert.ToInt32(GAAgeTxt.Text),GAGender,DetailOneTxt.Text,DetailTwoTxt.Text,DetailThreeTxt.Text))
                {
                    string message = "Item #" + AdvertID + " has been added to our system. " +
                       "Admin must verify item before advertisement is made public";
                    string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                    int notifID = 0;
                    do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
                    //System.Windows.MessageBox.Show(message);
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

        private void HorseConfirmBttn_Click(object sender, EventArgs e)
        {
            try
            {
                 Random rnd = new Random();
                 int AdvertID = 0;
                 do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                byte[] ImageOne = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                byte[] ImageTwo = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                byte[] ImageThree = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                if (ImageTwoPictureBx.Image == null && ImageThreePictureBx.Image == null)
                {
                    ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                }
                else if(ImageTwoPictureBx.Image == null)
                {
                    ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
                    ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);
                }
                else if(ImageThreePictureBx.Image == null)
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
                        do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
                        //System.Windows.MessageBox.Show(message);
                    }
                
                
            }catch(Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
               
                System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
            }
            
        }

        private void DogPurebreedYesRadBttn_CheckedChanged(object sender, EventArgs e)
        {
            if(DogPurebreedYesRadBttn.Checked)
            {
                DogisPurebreedPanel.Visible = true;
                DogIsNotPurebreedPanel.Visible = false;
            }
        }

        private void DogPurebreedNoBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (DogPurebreedNoBttn.Checked)
            {
                DogisPurebreedPanel.Visible = false;
                DogIsNotPurebreedPanel.Visible = true;
            }
        }

        private void DogConfirmBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int AdvertID = 0;
                do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
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

                string DogPurebreed = this.DogBreedComboBox.GetItemText(this.DogBreedComboBox.SelectedItem);
                string DogBreedOne = this.DogBreedOneComboBox.GetItemText(this.DogBreedOneComboBox.SelectedItem);
                string DogBreedTwo = this.DogBreedTwoComboBox.GetItemText(this.DogBreedTwoComboBox.SelectedItem);
                string DogGender = this.DogGenderComboBox.GetItemText(this.DogGenderComboBox.SelectedItem);
                if(DogPurebreedYesRadBttn.Checked == true)
                {
                    if(Model.addNewDogAdvert(AdvertID,Model.CurrentUser.Email,TitleTxt.Text,DescriptionTxt.Text,Convert.ToDouble(PriceTxt.Text),false,"Available",ImageOne,ImageTwo,ImageThree,
                        DogNameTxt.Text,DogGender,true,DogPurebreed,""))
                    {
                        string message = "Item #" + AdvertID + " has been added to our system. " +
                       "Admin must verify item before advertisement is made public";
                        string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                        int notifID = 0;
                        do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
                    }
                }

                if (DogPurebreedNoBttn.Checked == true)
                {
                    if (Model.addNewDogAdvert(AdvertID, Model.CurrentUser.Email, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "Available", ImageOne, ImageTwo, ImageThree,
                        DogNameTxt.Text, DogGender, false, DogBreedOne, DogBreedTwo))
                    {
                        string message = "Item #" + AdvertID + " has been added to our system. " +
                       "Admin must verify item before advertisement is made public";
                        string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                        int notifID = 0;
                        do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                        if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
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

        private void AnimalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AnimalCatComboBox.SelectedIndex.Equals(0) && AnimalTypeComboBox.SelectedIndex.Equals(0))
            {
                DogPanel.Visible = true;
                HorsePanel.Visible = false;
                LitterPanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
            }
            else if(AnimalCatComboBox.SelectedIndex.Equals(1) && AnimalTypeComboBox.SelectedIndex.Equals(0))
            {
                DogPanel.Visible = false;
                HorsePanel.Visible = true;
                LitterPanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
            }
            else if(AnimalCatComboBox.SelectedIndex.Equals(1) && AnimalTypeComboBox.SelectedIndex > 0)
            {
                DogPanel.Visible = false;
                HorsePanel.Visible = false;
                LitterPanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                FarmAnimalPanel.Visible = true;
            }
            else if(AnimalCatComboBox.SelectedIndex.Equals(3))
            {
                DogPanel.Visible = false;
                HorsePanel.Visible = false;
                LitterPanel.Visible = true;
                GenericAnimalPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
            }
            else
            {
                DogPanel.Visible = false;
                HorsePanel.Visible = false;
                LitterPanel.Visible = false;
                GenericAnimalPanel.Visible = true;
                FarmAnimalPanel.Visible = false;
            }
        }

        public static void ResetForm(CreateSingleAdvertisement advertForm)
        {
            //Clearing General Advertisement 
            advertForm.TitleTxt = null; 
            advertForm.DescriptionTxt = null;
            advertForm.AdvertComboBox.SelectedIndex = 0;
            advertForm.PriceTxt= null;
            advertForm.ImageOnePictureBx.Image = null;
            advertForm.ImageTwoPictureBx.Image = null;
            advertForm.ImageThreePictureBx.Image = null;
            //Clearing Animal
            advertForm.AnimalCatComboBox.SelectedIndex = 0;
            advertForm.AnimalTypeComboBox.SelectedIndex = 0;
            advertForm.SpecifyAnimalTxtBx = null;
            //Clearing Horse
            advertForm.HorseNameTxt= null;
            advertForm.HorseAgeTxt= null;
            advertForm.HorseGenderComboBox.SelectedIndex = 0;
            advertForm.HorseSizeTxt= null;
            advertForm.BrokenYesRadBttn.Checked= false;
            advertForm.BrokenNoRadBttn.Checked = false;
            advertForm.HorseBreedComboBox.SelectedIndex= 0;
            advertForm.HorsePurposeTxt = null;
            //Clearing Dog
            advertForm.DogNameTxt = null;
            advertForm.DogAgeTxt= null;
            advertForm.DogGenderComboBox.SelectedIndex = 0;
            advertForm.DogPurebreedYesRadBttn.Checked = false;
            advertForm.DogPurebreedYesRadBttn.Checked = false;
            advertForm.DogBreedComboBox.SelectedIndex = 0;
            advertForm.DogBreedOneComboBox.SelectedIndex = 0;
            advertForm.DogBreedTwoComboBox.SelectedIndex = 0;
            //Clearing Generic Animal
            advertForm.GANameTxt = null;
            advertForm.GAAgeTxt = null;
            advertForm.GAGenderComboBox.SelectedIndex = 0;
            advertForm.DetailOneTxt= null;
            advertForm.DetailTwoTxt= null;
            advertForm.DetailThreeTxt= null;
            //Clearing Farm Animal
            advertForm.FANameTxt= null;
            advertForm.FAAgeTxt= null;
            advertForm.FAGenderComboBox.SelectedIndex = 0;
            advertForm.FAPurposeTxt= null;
            //Clearing Litter
            advertForm.LitterSizeTxt = null;
            advertForm.LitterYesRadBttn.Checked= false;
            advertForm.LitterNoRadBttn.Checked = false;
            advertForm.LitterAgeTxt = null;
            advertForm.BreedComboBox.SelectedIndex = 0;
            advertForm.BreedOneComboBox.SelectedIndex = 0;
            advertForm.BreedTwoComboBox.SelectedIndex = 0;
            //Clearing Food
            advertForm.AnimalFoodTypeComboBox.SelectedIndex = 0;
            advertForm.DetailTxt= null;
            //Clearing Accessories
            advertForm.AccessCatComboBox.SelectedIndex = 0;
            advertForm.AccessTypeComboBox.SelectedIndex = 0;
            //Clearing Panels Back To Original State
            advertForm.GeneralAdvertPanel.Visible = true;
            advertForm.HorseGenderComboBox.SelectedText = "Male";
            advertForm.HorseBreedComboBox.SelectedText = "Arabian horse";
            advertForm.AnimalPanel.Visible = false;
            advertForm.FoodPanel.Visible = false;
            advertForm.AccessPanel.Visible = false;
            advertForm.AnimalCatPanel.Visible = true;
            advertForm.AnimalTypePanel.Visible = true;
            advertForm.SpecifyPanel.Visible = false;
            advertForm.DogPanel.Visible = false;
            advertForm.DogisPurebreedPanel.Visible = true;
            advertForm.HorsePanel.Visible = false;
            advertForm.GenericAnimalPanel.Visible = false;
            advertForm.FarmAnimalPanel.Visible = false;
            advertForm.LitterPanel.Visible = false;
            advertForm.IsPurebreedPanel.Visible = true;
        }
    }
}
