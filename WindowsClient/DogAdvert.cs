using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections;
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
    public partial class DogAdvert : Form
    {
        private Dog Advertisement;
        private IModel Model;
        public DogAdvert(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;
        }
        public DogAdvert(Dog advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }

        private void DogAdvert_Load(object sender, EventArgs e)
        {
            foreach (Dog doggo in Model.AdvertList.OfType<Dog>())
            {
                if (doggo.AdvertID.Equals(doggo))
                {
                    lblTitle.Text = Advertisement.Title;
                    txtName.Text = Advertisement.AnimalName;
                    txtGender.Text = Advertisement.Gender;
                    txtAge.Text = Advertisement.Age.ToString();
                    txtPrice.Text = Advertisement.Price.ToString();
                    txtDescription.Text = Advertisement.Description;
                    txtPurebreed.Text = Advertisement.Purebreed.ToString();
                    txtBreedOne.Text = Advertisement.BreedOne;
                    txtBreedTwo.Text = Advertisement.BreedTwo;
                }
            }
            
           
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            PaymentDetails paymentDetails = new PaymentDetails(Model);
            Hide();
            paymentDetails.Show();
        }
    }
}
