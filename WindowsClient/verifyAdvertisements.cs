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
            }
            else if(AdCatComboBx.SelectedIndex == 1)
            {
                panelfoodBtn.Visible = true;
                panelAnimalsDisp.Visible = false;
                panelAnimalsBtn.Visible = false;
                panelAssBtn.Visible = false;
                panelAccess.Visible = false;
            }
            else if(AdCatComboBx.SelectedIndex == 2)
            {
                panelAssBtn.Visible = true;
                panelAnimalsDisp.Visible = false;
                panelAnimalsBtn.Visible = false;
                panelfoodBtn.Visible = false;
                panelAccess.Visible = true;
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
            foreach(Advertisement advertisement in model.AdvertList)
            {
                /*  listboxAni.Items.Add(advertisement.Title);*/

                foreach (Animal horse in model.AdvertList)
                {
                    listboxAni.Items.Add(horse.Title);
                }

                /*foreach(Dog dog in model.AdvertList)
                {
                    listboxAni.Items.Add(dog.AnimalName);
                }*/
            }
        }

        private void listboxAni_DoubleClick(object sender, EventArgs e)
        {
            txtTitle.Text=listboxAni.SelectedItem.ToString();   
         
            foreach(Advertisement animal in model.AdvertList)
            {
                if(animal.Title == txtTitle.Text)
                {
                    txtTitle.Text=animal.Title;
                    txtDescription.Text=animal.Description;
                    txtVerified.Text = animal.Verified.ToString();
                    txtPrice.Text=animal.Price.ToString();
                    txtStat.Text=animal.Status.ToString();

                
                    /*foreach (Animal animal1 in model.AdvertList)
                    {
                        txtAnimalType.Text=animal1.AnimalType.ToString();
                        txtName.Text=animal1.AnimalName;
                        txtGender.Text=animal1.Gender;
                        
                    }*/
                    

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
            foreach(Advertisement advertisement in model.AdvertList)
            {
                foreach(Accessories accessories in model.AdvertList)
                {
                    listBoxAssess.Items.Add(accessories.Title);
                }
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            foreach (Advertisement advertisement in model.AdvertList)
            {
                foreach (Food food in model.AdvertList)
                {
                    listBoxFood.Items.Add(food.Title);
                }
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
