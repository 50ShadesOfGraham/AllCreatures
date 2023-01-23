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
using System.Data.SqlClient;

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
            SqlCommand cmd = new SqlCommand("SELECT title,name,gender,age,price,description,purpose,broken,size,breed from HorseAdvertisement WHERE HorseID = @HorseID");
            cmd.Parameters.AddWithValue("@HorseID", 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblTitle.Text = dr.GetValue(0).ToString();
                txtName.Text = dr.GetValue(0).ToString();
                txtGender.Text = dr.GetValue(0).ToString();
                txtAge.Text = dr.GetValue(0).ToString();
                txtPrice.Text = dr.GetValue(0).ToString();
                txtDescription.Text = dr.GetValue(0).ToString();
                txtPurpose.Text = dr.GetValue(0).ToString();
                txtBroken.Text = dr.GetValue(0).ToString();
                txtSize.Text = dr.GetValue(0).ToString();
                txtBreed.Text = dr.GetValue(0).ToString();
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
