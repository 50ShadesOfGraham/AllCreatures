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
    public partial class verifyAdvertisements : Form
    {
        IModel model;
        public verifyAdvertisements(BusinessLayer.IModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void AdCatComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AdCatComboBx.SelectedIndex == 0) 
            {
                panelAnimalsBtn.Visible = true;
                
                panelfoodBtn.Visible = false;
                panelAssBtn.Visible = false;
                panelAnimalsDisp.Visible = true;
                panelAccess.Visible = false;
                panelFood.Visible = false;
            }
            else if(AdCatComboBx.SelectedIndex == 1)
            {
                panelfoodBtn.Visible = true;
                panelAnimalsDisp.Visible = false;
                panelAnimalsBtn.Visible = false;
                panelAssBtn.Visible = false;
                panelAccess.Visible = false;
                panelFood.Visible = true;
            }
            else if(AdCatComboBx.SelectedIndex == 2)
            {
                panelAssBtn.Visible = true;
                panelAnimalsDisp.Visible = false;
                panelAnimalsBtn.Visible = false;
                panelfoodBtn.Visible = false;
                panelAccess.Visible = true;
                panelFood.Visible = false;
            }
        }

        private void verifyAdvertisements_Load(object sender, EventArgs e)
        {
         
            panelAnimalsBtn.Visible = false;
            panelAssBtn.Visible = false;
            panelfoodBtn.Visible= false;
            panelAccess.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            foreach(Animal advertisement in model.AdvertList.OfType<Animal>())
            {
                /*  listboxAni.Items.Add(advertisement.Title);*/

               
                    listboxAni.Items.Add(advertisement.Title);
                

                /*foreach(Dog dog in model.AdvertList)
                {
                    listboxAni.Items.Add(dog.AnimalName);
                }*/
            }
        }

        private void listboxAni_DoubleClick(object sender, EventArgs e)
        {
            txtTitle.Text=listboxAni.SelectedItem.ToString();   
         
            foreach(Animal animal in model.AdvertList.OfType<Animal>())
            {
                if(animal.Title == txtTitle.Text)
                {
                    txtTitle.Text=animal.Title;
                    txtDescription.Text=animal.Description;
                    txtVerified.Text = animal.Verified.ToString();
                    txtPrice.Text=animal.Price.ToString();
                    txtStat.Text=animal.Status.ToString();
                   txtAnimalType.Text=animal.AnimalType;
                    txtName.Text=animal.AnimalName;
                    txtAge.Text=animal.Age.ToString();
                    txtGender.Text=animal.Gender;


                    /*foreach (Animal animal1 in model.AdvertList)
                    {
                        txtAnimalType.Text=animal1.AnimalType.ToString();
                        txtName.Text=animal1.AnimalName;
                        txtGender.Text=animal1.Gender;
                        
                    }*/
                    
                    
                    
                    if (animal is Dog dog)
                    {
                        txtBreed.Text = dog.Purebreed.ToString();

                    }


                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach(Advertisement advertisement in model.AdvertList)
            {
                if(advertisement.Title == listboxAni.SelectedItem.ToString())
                {
                    advertisement.Verified = true;
                    model.verifyAdvertisement(advertisement);
                    MessageBox.Show("Success");
                }
            }
        }

        private void listboxAni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAssess_Click(object sender, EventArgs e)
        {
            foreach(Advertisement advertisement in model.AdvertList.OfType<Accessories>())
            {
                
                    listBoxAssess.Items.Add(advertisement.Title);
                
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {



            foreach (Food advertisement in model.AdvertList.OfType<Food>())
            {


                listBoxFood.Items.Add(advertisement.Title);
                /*foreach (Food food in model.AdvertList)
                {
                    
                }*/
            }
        }

        private void listBoxAssess_DoubleClick(object sender, EventArgs e)
        {
            txtTitle.Text=listBoxAssess.SelectedItem.ToString();

            foreach (Advertisement advertisement in model.AdvertList)
            {
                if (advertisement.Title == txtTitle.Text)
                {
                    txtTitle.Text = advertisement.Title;
                    txtDescription.Text = advertisement.Description;
                    txtVerified.Text = advertisement.Verified.ToString();
                    txtPrice.Text = advertisement.Price.ToString();
                    txtStat.Text = advertisement.Status.ToString();
                    /*txtType.Text = advertisement.animalType*/ //Animal type missing from class
                    if (advertisement is Accessories accessories)
                    {
                        //txtType.Text = accessories.details
                        txtAccessCat.Text = accessories.AccessCategory.ToString();
                        txtSubCat.Text = accessories.SubAccessCategory.ToString();
                    }
                }
              
               

            }
        }

        private void listBoxFood_DoubleClick(object sender, EventArgs e)
        {
            txtTitle.Text = listBoxFood.SelectedItem.ToString();
            foreach (Advertisement advertisement in model.AdvertList)
            {
                if (advertisement.Title == txtTitle.Text)
                {
                    txtTitle.Text = advertisement.Title;
                    txtDescription.Text = advertisement.Description;
                    txtVerified.Text = advertisement.Verified.ToString();
                    txtPrice.Text = advertisement.Price.ToString();
                    txtStat.Text = advertisement.Status.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
