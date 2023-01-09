using BusinessEntities;
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
    public partial class CreateAdvert : Form
    {
        private IModel Model;
   
        public CreateAdvert(IModel model)
        {
            InitializeComponent();
            this.Model = model;
        }

        private void SubmitBttn_Click(object sender, EventArgs e)
        {
            if(AdCatComboBx.SelectedIndex == 0)
            {

            }else if(AdCatComboBx.SelectedIndex == 1)
            {
                Random rnd = new Random();
                int AdvertID = rnd.Next(0, 99999);
                int FoodID = rnd.Next(0, 99999);
                String AnimalType = AnimalTypeComboBox.SelectedItem.ToString();
                byte[] updatedImage = ConvertImageToByte(ImageOnePictureBox.Image);
                if (Model.addNewFoodAdvert(AdvertID,Model.CurrentUser.Email,Convert.ToDouble(PriceTextBox.Text),DescriptionTextBox.Text,false,"Available","Food",AdvertTitleTextBox.Text,updatedImage,FoodID,AnimalType,FoodDetailsTextBox.Text))
                {
                    MessageBox.Show("Food Successfully Added To DB");
                    Hide();
                }
                else
                {
                    MessageBox.Show("Food Fail");
                }

            } else if(AdCatComboBx.SelectedIndex == 2)
            {
                Random rnd = new Random();
                int AdvertID = rnd.Next(0, 99999);
                int AccessID = rnd.Next(0, 99999);
                
                String AccessCat = AccessCatComboBox.SelectedItem.ToString();
                
                String accesssubcategory = AccessTypeComboBox.SelectedItem.ToString();
                // bool addNewAccessoriesAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, int accessid, string animaltype,string accesscategory, string accesssubcat);
                //if (Model.addNewAccessoriesAdvert(AdvertID, Model.CurrentUser.Email, Convert.ToDouble(PriceTextBox.Text), DescriptionTextBox.Text, false, "Available", "Accessories", AdvertTitleTextBox.Text, AccessID, AccessCat, accesssubcategory))
                //{
                  //  MessageBox.Show("Food Successfully Added To DB");
                   // Hide();
              //  }
               // else
                //{
                //    MessageBox.Show("Food Fail");
                //}
            }
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {

        }

        private void CreateAdvert_Load(object sender, EventArgs e)
        {
            FoodPanel.Visible = false;
            AccessoriesPanel.Visible = false;   
            AnimalPanel.Visible = false;
            DogPanel.Visible = false;
            HorsePanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
            ImageUploadPanel.Visible = false;
            SpecifyPanel.Visible = false;
            //AnimalTypePanel.Visible = false;
        }

        private void AnimalCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AnimalCatComboBox.SelectedIndex == 0)
            {
                AnimalTypeComboBox.Items.Clear();
                AnimalTypeComboBox.Items.Add("Dog");
                AnimalTypeComboBox.Items.Add("Cat");
                AnimalTypeComboBox.Items.Add("Fish");
                AnimalTypeComboBox.Items.Add("Bird");
                AnimalTypeComboBox.Items.Add("Guinea Pig");
                AnimalTypeComboBox.Items.Add("Rabbit");
                AnimalTypeSubPanel.Visible = true;
                SpecifyPanel.Visible = false;
            }
            else if(AnimalCatComboBox.SelectedIndex == 1)
            {
                AnimalTypeComboBox.Items.Clear();
                AnimalTypeComboBox.Items.Add("Horse");
                AnimalTypeComboBox.Items.Add("Pig");
                AnimalTypeComboBox.Items.Add("Chicken");
                AnimalTypeComboBox.Items.Add("Cow");
                AnimalTypeSubPanel.Visible = true;
                SpecifyPanel.Visible = false;
            }
            else if(AnimalCatComboBox.SelectedIndex == 2)
            {
                AnimalTypeComboBox.Items.Clear();
                AnimalTypeComboBox.Items.Add("Snake");
                AnimalTypeComboBox.Items.Add("Lizard");
                AnimalTypeComboBox.Items.Add("Turtle");
                AnimalTypeSubPanel.Visible = true;
                SpecifyPanel.Visible = false;
            }
            else if(AnimalCatComboBox.SelectedIndex == 3)
            {
               AnimalTypeSubPanel.Visible = false;
               SpecifyPanel.Visible = true;
            }
        }

        private void AccessCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AccessCatComboBox.SelectedIndex == 0)
            {
                AccessTypeComboBox.Items.Clear();
                AccessTypeComboBox.SelectedIndex = -1;
                AccessTypeComboBox.Items.Add("Supplements");
                AccessTypeComboBox.Items.Add("Medication");
                AccessTypeComboBox.Items.Add("Other");
            }
            else if (AccessCatComboBox.SelectedIndex == 1)
            {
                AccessTypeComboBox.Items.Clear();
                AccessTypeComboBox.SelectedIndex = -1;
                AccessTypeComboBox.Items.Add("Tanks and Enclosures");
                AccessTypeComboBox.Items.Add("Kennels");
                AccessTypeComboBox.Items.Add("Small Animals");
                AccessTypeComboBox.Items.Add("Other");
            }
            else if (AccessCatComboBox.SelectedIndex == 2)
            {
                AccessTypeComboBox.Items.Clear();
                AccessTypeComboBox.SelectedIndex = -1;
                AccessTypeComboBox.Items.Add("Tanks and Enclosures");
                AccessTypeComboBox.Items.Add("Shampoo");
                AccessTypeComboBox.Items.Add("Other");
            }
            else if (AccessCatComboBox.SelectedIndex == 3)
            {
                AccessTypeComboBox.Items.Clear();
                AccessTypeComboBox.SelectedIndex = -1;
                AccessTypeComboBox.Items.Add("Horse Riding");
                AccessTypeComboBox.Items.Add("Clothing");
                AccessTypeComboBox.Items.Add("Aquariums");
            }
        }

        private void AdCatComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AdCatComboBx.SelectedIndex == 0)
            {
                GeneralAdvertPanel.Visible = true;
                AnimalPanel.Visible = true;
                ImageUploadPanel.Visible = true;
                SubmitPanel.Visible = true;
            }
            else if(AdCatComboBx.SelectedIndex == 1)
            {
                GeneralAdvertPanel.Visible = true;
                FoodPanel.Visible = true;
                ImageUploadPanel.Visible = true;
                SubmitPanel.Visible = true;
            }
            else if(AdCatComboBx.SelectedIndex == 2)
            {
                GeneralAdvertPanel.Visible = true;
                AccessoriesPanel.Visible = true;
                ImageUploadPanel.Visible = true;
                SubmitPanel.Visible = true;
            }
        }

        private void AnimalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AdCatComboBx.SelectedIndex == 0)
            {
                if(AnimalTypeComboBox.SelectedIndex == 0 && AnimalCatComboBox.SelectedIndex == 0)
                {
                    DogPanel.Visible = true;
                }
                else if(AnimalTypeComboBox.SelectedIndex == 0 && AnimalCatComboBox.SelectedIndex == 1)
                {
                    HorsePanel.Visible = true;
                }
                else
                {
                    if(AnimalCatComboBox.SelectedIndex == 1 && AnimalTypeComboBox.SelectedIndex != 0)
                    {
                        FarmAnimalPanel.Visible = true;
                    }
                    else
                    {
                        GenericAnimalPanel.Visible = true;
                    }
                }
            }
        }

        private void UploadImageOnBttne_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter= "Image files(*jpeg;|*jpg)|*.jpg|*.jpeg", Multiselect = false})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageOnePictureBox.Image = Image.FromFile(ofd.FileName);
                }

                //Advertisement newAd = new Dog();
                
                //updatedImage = ConvertImageToByte(ImageOnePictureBox.Image);
            }
            
        }

        public byte[] ConvertImageToByte(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void ImageOnePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
