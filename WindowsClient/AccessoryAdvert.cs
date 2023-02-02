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
using BusinessLayer;

namespace WindowsClient
{
    public partial class AccessoryAdvert : Form
    {
        private Accessories Accessories;
        private IModel Model;

       

        public AccessoryAdvert(IModel _model, Accessories accessories)
        {
            InitializeComponent();
            this.Model = _model;
            this.Accessories = accessories;
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


        private void Search(string search)
        {
            
            List<Advertisement> advertisements = Model.AdvertList;
            foreach (Dog dog in advertisements.OfType<Dog>())
            {
                if (dog.Title.ToLower().Contains(search.ToLower()))
                {
                    MessageBox.Show("Advertisement:" + dog.AdvertID);
                    ViewAds ads = new ViewAds(Model, dog);
                    ads.SetLabel(dog.Title, dog.SellerEmail, dog.Price.ToString()); //function
                    
                }
            }
            foreach (Accessories access in advertisements.OfType<Accessories>())
            {
                if (access.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                    ViewAds ads = new(Model, access);
                    ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                    
                }
            }
            foreach (Food fo in advertisements.OfType<Food>())
            {
                if (fo.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + fo.AdvertID);
                    ViewAds ads = new ViewAds(Model, fo);
                    ads.SetLabel(fo.Title, fo.SellerEmail, fo.Price.ToString()); //function
                    
                }
            }

            foreach (Horse pony in advertisements.OfType<Horse>())
            {
                if (pony.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + pony.AdvertID);
                    ViewAds ads = new ViewAds(Model, pony);
                    ads.SetLabel(pony.Title, pony.SellerEmail, pony.Price.ToString()); //function
                    
                }
            }
            foreach (FarmAnimal FA in advertisements.OfType<FarmAnimal>())
            {
                if (FA.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + FA.AdvertID);
                    ViewAds ads = new ViewAds(Model, FA);
                    ads.SetLabel(FA.Title, FA.SellerEmail, FA.Price.ToString()); //function
                    
                }
            }
            foreach (GenericAnimal GA in advertisements.OfType<GenericAnimal>())
            {
                if (GA.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    
                }
            }
            foreach (Litter lttr in advertisements.OfType<Litter>())
            {
                if (lttr.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + lttr.AdvertID);
                    ViewAds ads = new ViewAds(Model, lttr);
                    ads.SetLabel(lttr.Title, lttr.SellerEmail, lttr.Price.ToString()); //function
                    
                }
            }
        }

            private void searchBtn_Click(object sender, EventArgs e)
            {
                string search = searchBox.Text.Trim();
                Search(search);


            }
        
    }
}
