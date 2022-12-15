using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;
namespace WindowsClient
{
  
    public partial class verifiyAdvertisements : Form
    {
        IModel model;
        public verifiyAdvertisements(IModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void verifiyAdvertisements_Load(object sender, EventArgs e)
        {


         
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void descriptionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            foreach(Advertisement advertisement1 in model.AdvertList)
            {

                /* listAdverts.Items.Add(advertisement1.Price);*/

                foreach (GenericAnimal advertisement in model.AdvertList)
                {
                    listAdverts.Items.Add(advertisement.AnimalName);
                }

            }
            
        }

        private void listAdverts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmail.Text = listAdverts.SelectedItem.ToString();
            foreach (Advertisement genericAnimal in model.AdvertList)
            {
                   // txtEmail.Text = genericAnimal.SellerEmail;
                    txtTitle.Text = genericAnimal.Title;
                    txtDescription.Text = genericAnimal.Description;

                    MessageBox.Show(genericAnimal.Title,genericAnimal.Description);
                    
                    txtPrice.Text = Convert.ToString(genericAnimal.Price);
               
                    foreach (GenericAnimal genericAdvert in model.AdvertList)
                {
                    if (genericAdvert.AnimalName == txtEmail.Text)
                    {
                        txtAge.Text = Convert.ToString(genericAdvert.Age);
                        // txtGender.Text = genericAdvert.Gender;
                        txtAnimalType.Text = genericAdvert.AnimalName;
                        txtDetail1.Text = genericAdvert.DetailOne;
                        txtDetail2.Text = genericAdvert.DetailTwo;
                        txtDetail3.Text = genericAdvert.DetailThree;
                        
                    }
                }
                
                    

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
