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

//need to add scroll bar

namespace WindowsClient
{
    public partial class ViewAds : UserControl
    {
        private IModel Model;
        private Advertisement advert;
        public ViewAds(IModel Model, Advertisement advert)
        {
            InitializeComponent();
            this.Model = Model;
            this.advert = advert;
        }


        public void SetLabel(String Title, String SellerEmail, String Price, String Status )
        {
            this.TitleLbl.Text = Title;
            this.UserLinkLabel.Text = SellerEmail;
            this.PriceLbl.Text = Price;
            this.StatusLbl.Text = Status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ViewAdForm viewAd = new ViewAdForm(Model,advert);
            //viewAd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
