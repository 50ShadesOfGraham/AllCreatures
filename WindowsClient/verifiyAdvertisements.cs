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
            Console.WriteLine("Hello");
           
            foreach (Advertisement advertisement in model.AdvertList)
            {
               // if(advertisement.)
               // titleTxt.Text = advertisement.Title;
                descriptionTxt.Text = advertisement.Description;
               // Console.WriteLine(advertisement.Description);
                priceTxt.Text = advertisement.Price.ToString();
             
             //   quantityTxt.Text = Convert.ToString(advertisement.Quantity);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void descriptionTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
