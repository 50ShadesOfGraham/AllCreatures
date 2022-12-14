using BusinessEntities;
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
    public partial class DogAdvert : Form
    {
        private Dog Advertisement;
        public DogAdvert(Dog advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }

        private void DogAdvert_Load(object sender, EventArgs e)
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
