using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class DogAdvert : Form
    {
        private Dog Advertisement;
        private IModel Model;
        public DogAdvert(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;
        }
        public DogAdvert(Dog advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }

        private void DogAdvert_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT title,name,gender,age,price,description,purebreed,breedone,breedtwo from DogAdvertisement WHERE DogID = @DogID");
            cmd.Parameters.AddWithValue("@DogID", 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblTitle.Text = dr.GetValue(0).ToString();
                txtName.Text = dr.GetValue(1).ToString();
                txtGender.Text = dr.GetValue(2).ToString();
                txtAge.Text = dr.GetValue(3).ToString();
                txtPrice.Text = dr.GetValue(4).ToString();
                txtDescription.Text = dr.GetValue(5).ToString();
                txtPurebreed.Text = dr.GetValue(6).ToString();
                txtBreedOne.Text = dr.GetValue(7).ToString();
                txtBreedTwo.Text = dr.GetValue(8).ToString();
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
