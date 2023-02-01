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
using System.Data.SqlClient;

namespace WindowsClient
{
    public partial class AccessoryAdvert : Form
    {
        private Accessories Advertisement;
        public AccessoryAdvert(Accessories advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }

        private void AccessoryAdvert_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT title,price,description from AccessoriesAdvertisement WHERE AccessID = @AccessID");
            cmd.Parameters.AddWithValue("@AccessID", 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblTitle.Text = dr.GetValue(0).ToString();
                txtPrice.Text = dr.GetValue(1).ToString();
                txtDescription.Text = dr.GetValue(2).ToString();
            }

        }
    }
}
