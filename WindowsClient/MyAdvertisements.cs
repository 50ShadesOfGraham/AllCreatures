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
using BusinessEntities;

namespace WindowsClient
{
    public partial class MyAdvertisements : Form
    {
        private IModel Model;
        public MyAdvertisements(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            this.TopLevel = false;
        }

        private void MyAdvertisements_Load(object sender, EventArgs e)
        {
            foreach(Advertisement u in Model.AdvertList)
            {
                if(u.SellerEmail.Trim().Equals(Model.CurrentUser.Email.Trim()))
                {
                    EditAdvert advert = new EditAdvert(Model, u);
                    advert.SetLabel(u.Title.Trim(),u.Price.ToString(), u.Status.Trim());
                    AdvertFlowLayout.Controls.Add(advert);
                }
            }
        }
    }
}
