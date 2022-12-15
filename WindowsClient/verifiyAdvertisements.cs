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
                
                
                    foreach (GenericAnimal advertisement in model.AdvertList)
                    {
                        listAdverts.Items.Add(advertisement1.AdvertID);
                    }
               
            }
            
        }

        private void listAdverts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmail.Text = listAdverts.SelectedItem.ToString();
            foreach (Advertisement genericAnimal in model.AdvertList)
            {
                foreach (GenericAnimal genericAdvert in model.AdvertList)
                {
                    if (genericAnimal.SellerEmail == txtEmail.Text)
                       /* txtDescription.Text = genericAdvert.Description;
                        txtAge.Text = Convert.ToString(genericAdvert.Age);
                        txtDetail1.Text = genericAdvert.DetailOne;
                        txtPrice.Text = Convert.ToString((double)genericAdvert.Price);*/
                       txtGender.Text = genericAnimal.SellerEmail;
                }
                
                    

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
