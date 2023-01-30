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
    public partial class SingleAdvertisement : UserControl
    {
        private IModel Model;
        private Advertisement advert;
        public SingleAdvertisement(IModel Model,Advertisement advert)
        {
            InitializeComponent();
            this.Model = Model;
            this.advert = advert;
        }

        private void SingleAdvertisement_Load(object sender, EventArgs e)
        {
            TitleLbl.Text = advert.Title.Trim();
            PriceLbl.Text= "€ " + advert.Price.ToString().Trim();
            AdvertStatusLbl.Text = advert.Status.Trim();
        }

        private void UpdateBttn_Click(object sender, EventArgs e)
        {
            EditAdvertisement editAdvertisement = new EditAdvertisement(Model, advert.AdvertID);
            editAdvertisement.Show();
        }
    }
}
