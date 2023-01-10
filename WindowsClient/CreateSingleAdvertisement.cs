﻿using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class CreateSingleAdvertisement : Form
    {

        private IModel Model;
        public CreateSingleAdvertisement(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }
        private void FoodPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AnimalCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AnimalCatComboBox.SelectedItem.Equals("Other"))
            {
                AnimalTypePanel.Visible = false;
                SpecifyPanel.Visible = true;
                GenericAnimalPanel.Visible = true;
            }
            else
            {
                AnimalTypePanel.Visible = true;
                SpecifyPanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                if(AnimalCatComboBox.SelectedItem.Equals("House Pet"))
                {
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Dog");
                    AnimalTypeComboBox.Items.Add("Cat");
                    AnimalTypeComboBox.Items.Add("Fish");
                    AnimalTypeComboBox.Items.Add("Hamster");
                    AnimalTypeComboBox.Items.Add("Rabbit");
                }
                else if(AnimalCatComboBox.SelectedItem.Equals("Farm Animal"))
                {
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Horse");
                    AnimalTypeComboBox.Items.Add("Chicken");
                    AnimalTypeComboBox.Items.Add("Cow");
                    AnimalTypeComboBox.Items.Add("Pig");
                    AnimalTypeComboBox.Items.Add("Sheep");
                    AnimalTypeComboBox.Items.Add("Goat");
                }
                else if(AnimalCatComboBox.SelectedItem.Equals("Reptiles"))
                {
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Snake");
                    AnimalTypeComboBox.Items.Add("Lizard");
                    AnimalTypeComboBox.Items.Add("Turtle");
                    AnimalTypeComboBox.Items.Add("Turtoise");
                }
                else if(AnimalCatComboBox.SelectedItem.Equals("Litter"))
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
        }

        private void CreateSingleAdvertisement_Load(object sender, EventArgs e)
        {
            GeneralAdvertPanel.Visible = true;
            
            AnimalPanel.Visible = false;
            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            AnimalCatPanel.Visible = true;
            AnimalTypePanel.Visible = true;
            SpecifyPanel.Visible = false;

            DogPanel.Visible = false;
            HorsePanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
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

        private void AnimalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AnimalTypeComboBox.SelectedItem.Equals("Dog"))
            {
                DogPanel.Visible = true;
                HorsePanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                FarmAnimalPanel.Visible= false;
                LitterPanel.Visible= false;
                FoodPanel.Visible= false;
                AccessPanel.Visible= false;
            }
            else if(AnimalTypeComboBox.SelectedItem.Equals("Horse"))
            {
                DogPanel.Visible = false;
                HorsePanel.Visible = true;
                GenericAnimalPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
                LitterPanel.Visible = false;
                FoodPanel.Visible = false;
                AccessPanel.Visible = false;
            }else if(AnimalTypeComboBox.SelectedItem != "Horse" && AnimalCatComboBox.SelectedItem.Equals("Farm Animal"))
            {
                DogPanel.Visible = false;
                HorsePanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                FarmAnimalPanel.Visible = true;
                LitterPanel.Visible = false;
                FoodPanel.Visible = false;
                AccessPanel.Visible = false;
            }else if(AnimalTypeComboBox.SelectedItem != "Dog")
            {
                DogPanel.Visible = false;
                HorsePanel.Visible = false;
                GenericAnimalPanel.Visible = true;
                FarmAnimalPanel.Visible = false;
                LitterPanel.Visible = false;
                FoodPanel.Visible = false;
                AccessPanel.Visible = false;
            }
        }
        public byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void UploadOneBttn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*jpeg;|*jpg)|*.jpg|*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageOnePictureBx.Image = Image.FromFile(ofd.FileName);
                    ConfirmationOnePictureBx.Image = Properties.Resources.ImageConfirmation;
                    ConfirmationOnePictureBx.Refresh();
                    ConfirmationOnePictureBx.Visible = true;
                }
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
            if(AccessCatComboBox.SelectedItem.Equals(" Health"))
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
    }
}
