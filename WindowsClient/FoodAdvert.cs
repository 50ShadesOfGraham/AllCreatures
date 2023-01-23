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
using System.Data.SqlClient;


namespace WindowsClient
{
    public partial class FoodAdvert : Form
    {
        private Food Advertisement;
        private IModel Model;
        public FoodAdvert(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;
        }
        public FoodAdvert(Food advert)
        {
            InitializeComponent();
            Advertisement = advert;
        }

        private void FoodAdvert_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT title,price,description,details from FoodAdvertisement WHERE FoodID = @FoodID");
            cmd.Parameters.AddWithValue("@FoodID", 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblTitle.Text = dr.GetValue(0).ToString();
                txtPrice.Text = dr.GetValue(1).ToString();
                txtDescription.Text = dr.GetValue(2).ToString();
                txtDetails.Text = dr.GetValue(3).ToString();
            }

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            PaymentDetails paymentDetails = new PaymentDetails(Model);
            Hide();
            paymentDetails.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM AccessoriesAdvertisement,Bundle,DogAdvertisement,FarmAnimalAdvertisement,FoodAdvertisement,GenericAnimalAdvertisement,HorseAdvertisement";
            query += " WHERE Title LIKE '%'" + searchBox.Text.Trim() + "'%'";


            //FlowLayout.Controls.Clear();  

            //foreach (User u in Model.UserList)
            //{
            //    ViewAds ads = new ViewAds(query);
            //    ads.SetLabel(u.FirstName, u.LastName, u.Email, u.Password, u.UserType); //function
            //    FlowLayout.Controls.Add(ads);
            //}

        }
    }
}
