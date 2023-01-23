using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace WindowsClient
{
    public partial class GenericAdvert : Form
    {
  

        private GenericAnimal Advertisement;
        private IModel Model;
        public GenericAdvert(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;
        }
        public GenericAdvert(GenericAnimal advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }
        

        private void GenericAdvert_Load(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand ("SELECT title,name,gender,age,price,description,detailsone,detailstwo,detailsthree from GenericAnimalAdvertisement WHERE GenericAnimalID = @GenericAnimalID");
            cmd.Parameters.AddWithValue("@GenericAnimalID", 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblTitle.Text = dr.GetValue(0).ToString();
                txtName.Text = dr.GetValue(1).ToString();
                txtGender.Text = dr.GetValue(2).ToString();
                txtAge.Text = dr.GetValue(3).ToString();
                txtPrice.Text = dr.GetValue(4).ToString();
                txtDescription.Text = dr.GetValue(5).ToString();
                txtExtra1.Text = dr.GetValue(6).ToString();
                txtExtra2.Text = dr.GetValue(7).ToString();
                txtExtra3.Text = dr.GetValue(8).ToString();
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
