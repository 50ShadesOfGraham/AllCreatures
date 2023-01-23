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
using System.Data.SqlClient;


namespace WindowsClient
{
    public partial class FarmAdvert : Form
    {
        private FarmAnimal Advertisement;
        private IModel Model;

        public FarmAdvert(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;
        }
        public FarmAdvert(FarmAnimal advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }

        private void FarmAdvert_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT title,name,gender,age,price,description,purpose from FarmAnimalAdvertisement WHERE FarmAnimalID = @FarmAnimalID");
            cmd.Parameters.AddWithValue("@FarmAnimalID", 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblTitle.Text = dr.GetValue(0).ToString();
                txtName.Text = dr.GetValue(1).ToString();
                txtGender.Text = dr.GetValue(2).ToString();  
                txtAge.Text = dr.GetValue(3).ToString();
                txtPrice.Text = dr.GetValue(4).ToString();
                txtDescription.Text = dr.GetValue(5).ToString();
                txtPurpose.Text = dr.GetValue(6).ToString();
            }

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            PaymentDetails paymentDetails = new PaymentDetails(Model);
            Hide();
            paymentDetails.Show();
        }
    }
}
