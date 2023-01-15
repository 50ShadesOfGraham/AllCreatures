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

namespace WindowsClient
{
    public partial class CreateSingleAdvertisement : Form
    {

        private IModel Model;
        public CreateSingleAdvertisement(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;
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
            }
        }

        private void UploadTwoBttn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*jpeg;|*jpg)|*.jpg|*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageTwoPictureBx.Image = Image.FromFile(ofd.FileName);
                    ConfirmationTwoPictureBx.Image = Properties.Resources.ImageConfirmation;
                    ConfirmationTwoPictureBx.Refresh();
                    ConfirmationTwoPictureBx.Visible = true;
                }
            }
        }

        private void UploadThreeBttn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*jpeg;|*jpg)|*.jpg|*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageThreePictureBx.Image = Image.FromFile(ofd.FileName);
                    ConfirmationThreePictureBx.Image = Properties.Resources.ImageConfirmation;
                    ConfirmationThreePictureBx.Refresh();
                    ConfirmationThreePictureBx.Visible = true;
                }
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
            Random rnd = new Random();
            int AdvertID = 0;
            do { AdvertID = rnd.Next(0, 99999); } while(Model.AdvertIDPresent(AdvertID));

            byte[] ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
            byte[] ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
            byte[] ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);

            Accessories access = new Accessories(AdvertID,Model.CurrentUser.Email.Trim(),TitleTxt.Text,DescriptionTxt.Text,Convert.ToDouble(PriceTxt.Text),false,"AVAILABLE",
                ImageOne,ImageTwo,ImageThree,AccessCatComboBox.SelectedItem.ToString(),AccessTypeComboBox.SelectedItem.ToString());

            if(Model.addNewAccessories(access)) 
            {
                string message = "Item #" + AdvertID + " has been added to our system. " +
                    "Admin must verify item before advertisement is made public";
                string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                int notifID = 0;
                do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                if (Model.addNewNotification(notifID.ToString(),message,notificationtitle,DateTime.Now,false,Model.CurrentUser.Email)) { }
            }
        }

        private void FoodConfirmBttn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int AdvertID = 0;
            do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));

            byte[] ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
            byte[] ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
            byte[] ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);

            Food food = new Food(AdvertID, Model.CurrentUser.Email.Trim(), TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "AVAILABLE",
                ImageOne, ImageTwo, ImageThree, AnimalFoodTypeComboBox.SelectedItem.ToString(), DetailTxt.Text);

            if (Model.addNewFood(food))
            {
                string message = "Item #" + AdvertID + " has been added to our system. " +
                    "Admin must verify item before advertisement is made public";
                string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                int notifID = 0;
                do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
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
            Random rnd = new Random();
            int AdvertID = 0;
            do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));

            byte[] ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
            byte[] ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
            byte[] ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);

            if (LitterYesRadBttn.Checked)
            {
                Litter litter = new Litter(AdvertID, Model.CurrentUser.Email.Trim(), TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text),
                    false, "AVAILABLE", "MULTI", AnimalTypeComboBox.SelectedItem.ToString(), Convert.ToInt32(LitterAgeTxt.Text),"MULTI",Convert.ToInt32(LitterSizeTxt.Text),
                    true,BreedComboBox.SelectedItem.ToString(),"");

                if(Model.addNewLitter(litter))
                {
                    string message = "Item #" + AdvertID + " has been added to our system. " +
                   "Admin must verify item before advertisement is made public";
                    string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                    int notifID = 0;
                    do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                    if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
                }
            }
            else if(LitterNoRadBttn.Checked)
            {
                Litter litter = new Litter(AdvertID, Model.CurrentUser.Email.Trim(), TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text),
                    false, "AVAILABLE", "MULTI", AnimalTypeComboBox.SelectedItem.ToString(), Convert.ToInt32(LitterAgeTxt.Text), "MULTI", Convert.ToInt32(LitterSizeTxt.Text),
                    false, BreedOneComboBox.SelectedItem.ToString(), BreedTwoComboBox.SelectedItem.ToString());

                if (Model.addNewLitter(litter))
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

        private void FarmAnimalConfirmBttn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int AdvertID = 0;
            do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));

            byte[] ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
            byte[] ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
            byte[] ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);

            FarmAnimal farmAnimal = new FarmAnimal(AdvertID,Model.CurrentUser.Email.Trim(),TitleTxt.Text,DescriptionTxt.Text,
                Convert.ToDouble(PriceTxt.Text),false,"AVAILABLE",FANameTxt.Text,AnimalTypeComboBox.SelectedItem.ToString(),
                Convert.ToInt32(FAAgeTxt.Text),FAGenderComboBox.SelectedItem.ToString(),FAPurposeTxt.Text);

            if (Model.addNewFarmAnimal(farmAnimal))
            {
                string message = "Item #" + AdvertID + " has been added to our system. " +
               "Admin must verify item before advertisement is made public";
                string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                int notifID = 0;
                do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
            }

        }

        private void GenericAnimalConfirmBttn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int AdvertID = 0;
            do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));

            byte[] ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
            byte[] ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
            byte[] ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);

            GenericAnimal genericanimal= new GenericAnimal();

            if(SpecifyAnimalTxtBx.Text != "")
            {
                genericanimal = new GenericAnimal(AdvertID,Model.CurrentUser.Email.Trim(),TitleTxt.Text,DescriptionTxt.Text,Convert.ToDouble(PriceTxt.Text),false,"AVAILABLE",
                    ImageOne,ImageTwo,ImageThree,GANameTxt.Text,SpecifyAnimalTxtBx.Text,Convert.ToInt32(GAAgeTxt),GAGenderComboBox.SelectedItem.ToString(),
                    DetailOneTxt.Text,DetailTwoTxt.Text,DetailThreeTxt.Text);
            }
            else
            {
                genericanimal = new GenericAnimal(AdvertID, Model.CurrentUser.Email.Trim(), TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "AVAILABLE",
                    ImageOne, ImageTwo, ImageThree, GANameTxt.Text,AnimalTypeComboBox.SelectedItem.ToString(), Convert.ToInt32(GAAgeTxt), GAGenderComboBox.SelectedItem.ToString(),
                    DetailOneTxt.Text, DetailTwoTxt.Text, DetailThreeTxt.Text);
            }

            if (Model.addNewGenericAnimal(genericanimal))
            {
                string message = "Item #" + AdvertID + " has been added to our system. " +
               "Admin must verify item before advertisement is made public";
                string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                int notifID = 0;
                do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
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
            Random rnd = new Random();
            int AdvertID = 0;
            do { AdvertID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));

            byte[] ImageOne = ConvertImageToByte(ImageOnePictureBx.Image);
            byte[] ImageTwo = ConvertImageToByte(ImageTwoPictureBx.Image);
            byte[] ImageThree = ConvertImageToByte(ImageThreePictureBx.Image);

            Dog dog = new Dog();

            if(DogPurebreedYesRadBttn.Checked)
            {
                dog = new Dog(AdvertID, Model.CurrentUser.Email.Trim(), TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "AVAILABLE",
                    DogNameTxt.Text, "Dog", Convert.ToInt32(DogAgeTxt.Text), DogGenderComboBox.SelectedItem.ToString(), true, DogBreedComboBox.SelectedItem.ToString(), "");
            }
            if(DogPurebreedNoBttn.Checked)
            {
                dog = new Dog(AdvertID, Model.CurrentUser.Email.Trim(), TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), false, "AVAILABLE",
                    DogNameTxt.Text, "Dog", Convert.ToInt32(DogAgeTxt.Text), DogGenderComboBox.SelectedItem.ToString(), false, DogBreedOneComboBox.SelectedItem.ToString(),DogBreedTwoComboBox.SelectedItem.ToString());
            }

            if(Model.addNewDog(dog))
            {
                string message = "Item #" + AdvertID + " has been added to our system. " +
                "Admin must verify item before advertisement is made public";
                string notificationtitle = "Item #" + AdvertID + " Waiting on Admin Verification";
                int notifID = 0;
                do { notifID = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(AdvertID));
                if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
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
    }
}
