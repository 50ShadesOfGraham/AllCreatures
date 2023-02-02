using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections;
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
    public partial class DogAdvert : Form 
    {
        private Dog Dog;
        private IModel Model;
        public DogAdvert(IModel _model, Dog dog)
        {
            InitializeComponent();
            this.Model = _model;
            this.Dog = dog;
        }

        

        private void DogAdvert_Load(object sender, EventArgs e)
        {
            
                    lblTitle.Text = Dog.Title;
                    txtName.Text = Dog.AnimalName;
                    txtGender.Text = Dog.Gender;
                    txtAge.Text = Dog.Age.ToString();
                    txtPrice.Text = Dog.Price.ToString();
                    txtDescription.Text = Dog.Description;
                    txtPurebreed.Text = Dog.Purebreed.ToString();
                    txtBreedOne.Text = Dog.BreedOne;
                    txtBreedTwo.Text = Dog.BreedTwo;
               
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            PaymentDetails paymentDetails = new PaymentDetails(Model);
            Hide();
            paymentDetails.Show();
        }

        private void Search(string search)
        {
            FlowLayout.Controls.Clear();
            List<Advertisement> advertisements = Model.AdvertList;
            foreach (Dog dog in advertisements.OfType<Dog>())
            {
                if (dog.Title.ToLower().Contains(search.ToLower()))
                {
                    MessageBox.Show("Advertisement:" + dog.AdvertID);
                    ViewAds ads = new ViewAds(Model, dog);
                    ads.SetLabel(dog.Title, dog.SellerEmail, dog.Price.ToString()); //function
                    pnlDogAdvert.Hide();
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (Accessories access in advertisements.OfType<Accessories>())
            {
                if (access.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                    ViewAds ads = new(Model, access);
                    ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                    pnlDogAdvert.Hide();
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (Food fo in advertisements.OfType<Food>())
            {
                if (fo.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + fo.AdvertID);
                    ViewAds ads = new ViewAds(Model, fo);
                    ads.SetLabel(fo.Title, fo.SellerEmail, fo.Price.ToString()); //function
                    pnlDogAdvert.Hide();
                    FlowLayout.Controls.Add(ads);
                }
            }

            foreach (Horse pony in advertisements.OfType<Horse>())
            {
                if (pony.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + pony.AdvertID);
                    ViewAds ads = new ViewAds(Model, pony);
                    ads.SetLabel(pony.Title, pony.SellerEmail, pony.Price.ToString()); //function
                    pnlDogAdvert.Hide();
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (FarmAnimal FA in advertisements.OfType<FarmAnimal>())
            {
                if (FA.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + FA.AdvertID);
                    ViewAds ads = new ViewAds(Model, FA);
                    ads.SetLabel(FA.Title, FA.SellerEmail, FA.Price.ToString()); //function
                    pnlDogAdvert.Hide();
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (GenericAnimal GA in advertisements.OfType<GenericAnimal>())
            {
                if (GA.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    pnlDogAdvert.Hide();
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (Litter lttr in advertisements.OfType<Litter>())
            {
                if (lttr.Title.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + lttr.AdvertID);
                    ViewAds ads = new ViewAds(Model, lttr);
                    ads.SetLabel(lttr.Title, lttr.SellerEmail, lttr.Price.ToString()); //function
                    pnlDogAdvert.Hide();
                    FlowLayout.Controls.Add(ads);
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
