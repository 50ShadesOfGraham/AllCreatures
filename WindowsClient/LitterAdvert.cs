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
using System.Xml.Linq;

namespace WindowsClient
{
    public partial class LitterAdvert : Form
    {
        private Litter Advertisement;
        private IModel Model;
        public LitterAdvert(IModel _model)
        {
            InitializeComponent();
            Model = _model;
        }
        public LitterAdvert(Litter advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }

        private void LitterAdvert_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Advertisement.Title;
            txtAge.Text = Advertisement.Age.ToString();
            txtPrice.Text = Advertisement.Price.ToString();
            txtDescription.Text = Advertisement.Description;
            txtPurebreed.Text = Advertisement.Purebreed.ToString();
            txtBreedOne.Text = Advertisement.BreedOne;
            txtBreedTwo.Text = Advertisement.BreedTwo;
            txtSize.Text = Advertisement.LitterSize.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            PaymentDetails paymentDetails = new PaymentDetails(Model);
            Hide();
            paymentDetails.Show();
        }

        private void pnlLitterAdvert_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
