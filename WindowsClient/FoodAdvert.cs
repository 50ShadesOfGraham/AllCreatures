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
using System.Xml.Linq;

namespace WindowsClient
{
    public partial class FoodAdvert : Form
    {
        private Food Advertisement;
        public FoodAdvert(Food advert)
        {
            InitializeComponent();
            Advertisement = advert;
        }

        private void FoodAdvert_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Advertisement.Title;
            txtPrice.Text = Advertisement.Price.ToString();
            txtDescription.Text = Advertisement.Description;
            txtDetails.Text = Advertisement.FoodDetails;
        }
    }
}
