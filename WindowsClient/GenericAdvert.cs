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
using BusinessEntities;
namespace WindowsClient
{
    public partial class GenericAdvert : Form
    {
        

        private GenericAnimal Advertisement;
        public GenericAdvert(GenericAnimal advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }
        

        private void GenericAdvert_Load(object sender, EventArgs e)
        {

            lblTitle.Text = Advertisement.Title;
            txtName.Text = Advertisement.AnimalName;
            txtGender.Text = Advertisement.Gender;
            txtAge.Text = Advertisement.Age.ToString();
            txtPrice.Text = Advertisement.Price.ToString();
            txtDescription.Text = Advertisement.Description;
            txtExtra1.Text = Advertisement.DetailOne;
            txtExtra2.Text = Advertisement.DetailTwo;
            txtExtra3.Text = Advertisement.DetailThree;
           

        }
    }
}
