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
    //only display Ads for the current user 
    //Wait for the login testing first....
    public partial class ViewMyAds : UserControl
    {
        public ViewMyAds()
        {
            InitializeComponent();
        }

        public void SetAdsLabel(String Title, String Description, Double Price)
        {
            label4.Text = Title;
            label5.Text = Description;
            label6.Text = String.Format("Price: €{0}" ,Price);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
