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
    public partial class MyAdvertisements : Form
    {
        private IModel Model;
        public MyAdvertisements(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        private void MyAdvertisements_Load(object sender, EventArgs e)
        {
            foreach (Advertisement ad in Model.AdvertList)
            {
                if(Model.CurrentUser.Email.Trim().Equals(ad.SellerEmail.Trim())) 
                {
                    SingleAdvertisement advert = new SingleAdvertisement(Model, ad);
                    this.Controls.Add(advert);
                    advert.Dock = DockStyle.Top;
                }
            }
        }
    }
}
