using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class IndividualAnimalAdvert : Form
    {
        public IndividualAnimalAdvert(UserIndex userIndex)
        {
            InitializeComponent();
            loaddata();
            showdata();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds; int rno = 0;
        MemoryStream ms;
        byte[] photo_aray;

        void loaddata()
        {
            
            adapter = new SqlDataAdapter("select animalname,age,price,description from animal", con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            ds = new DataSet();
            adapter.Fill(ds, "animal");
        }
        void showdata()
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtName.Text = ds.Tables[0].Rows[rno][0].ToString();
                txtAge.Text = ds.Tables[0].Rows[rno][1].ToString();
                txtPrice.Text = ds.Tables[0].Rows[rno][2].ToString();
                txtDescription.Text = ds.Tables[0].Rows[rno][3].ToString();
            }
            else
                MessageBox.Show("No Records");
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            Advertisement advert;


            switch (advert.getClass())
            {
                case "Generic":
                    GenericAdvert generic = new GenericAdvert(advert);
                    generic.Show();
                    break;
                case "Dog":
                    DogAdvert dog = new DogAdvert(advert);
                    dog.Show();
                    break;
                case "Horse":
                    HorseAdvert horse = new HorseAdvert(advert);
                    horse.Show();
                    break;
                case "Farm":
                    FarmAdvert farm = new FarmAdvert(advert);
                    farm.Show();
                    break;
                case "Accesory":
                    AccessoryAdvert accessory = new AccessoryAdvert(advert);
                    accessory.Show();
                    break;
                case "Food":
                    FoodAdvert food = new FoodAdvert(advert);
                    food.Show();
                    break;
                case "Litter":
                    LitterAdvert litter = new LitterAdvert(advert);
                    litter.Show();
                    break;
                case "Bundle":
                    BundleAdvert bundle = new BundleAdvert(advert);
                    bundle.Show();
                    break;
                default:
                    MessageBox.Show("Error :(");
                    break;


            }
        }


































            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void IndividualAnimalAdvert_Load(object sender, EventArgs e)
        {

        }
    }
}
