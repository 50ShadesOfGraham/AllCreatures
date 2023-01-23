using BusinessLayer;
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
    public partial class HorseAdvert : Form
    {
        private Horse Advertisement;
        private IModel Model;
        public HorseAdvert(IModel _model)
        {
            InitializeComponent();
            Model = _model;
        }
        public HorseAdvert(Horse advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }

        private void HorseAdvert_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Advertisement.Title;
            txtName.Text = Advertisement.AnimalName;
            txtGender.Text = Advertisement.Gender;
            txtAge.Text = Advertisement.Age.ToString();
            txtPrice.Text = Advertisement.Price.ToString();
            txtDescription.Text = Advertisement.Description;
            txtPurpose.Text = Advertisement.Purpose;
            txtBroken.Text = Advertisement.Broken.ToString();
            txtSize.Text = Advertisement.Size.ToString();
            txtBreed.Text = Advertisement.Breed;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            PaymentDetails paymentDetails = new PaymentDetails(Model);
            Hide();
            paymentDetails.Show();
        }
    }
}
