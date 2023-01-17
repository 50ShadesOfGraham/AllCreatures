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
            }
            else if(AdCatComboBx.SelectedIndex == 1)
            {
                panelfoodBtn.Visible = true;
                panelAnimalsDisp.Visible = false;
                panelAnimalsBtn.Visible = false;
                panelAssBtn.Visible = false;
            }
            else if(AdCatComboBx.SelectedIndex == 2)
            {
                panelAssBtn.Visible = true;
                panelAnimalsDisp.Visible = false;
                panelAnimalsBtn.Visible = false;
                panelfoodBtn.Visible = false;
               
            }
        }

        private void verifyAdvertisements_Load(object sender, EventArgs e)
        {
         
            panelAnimalsBtn.Visible = false;
            panelAssBtn.Visible = false;
            panelfoodBtn.Visible= false;
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
                    advertisement.Verified= true;
                    model.verifyAdvertisement(advertisement);
                    MessageBox.Show("Success");
                }
            }
        }
    }
}
