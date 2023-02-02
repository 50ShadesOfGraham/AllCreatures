using BusinessEntities;
using BusinessLayer;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

//need to add scroll bar

namespace WindowsClient
{
    public partial class ViewAds : UserControl
    {
        private int AdvertID;
        private IModel Model;
        private Dog Dog;
        private bool dogFound;
        private Horse horse;
        private bool horseFound;
        private FarmAnimal farmAnimal;
        private bool farmAnimalFound;
        private GenericAnimal genericAnimal;
        private bool genericAnimalFound;
        private Litter litter;
        private bool litterFound;
        private Food food;
        private bool foodFound;
        private Accessories accessories;
        private bool accessoriesFound;
        private Advertisement advertisement;

        public ViewAds(IModel Model, int advertID)
        {
            InitializeComponent();
            this.Model = Model;
            this.AdvertID = advertID;
            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AdvertID.Equals(advertID))
                {
                    accessories = access;
                    accessoriesFound = true;
                }
            }
            foreach (Food fo in Model.AdvertList.OfType<Food>())
            {
                if (fo.AdvertID.Equals(advertID))
                {
                    food = fo;
                    foodFound = true;
                }
            }
           
            foreach (Horse pony in Model.AdvertList.OfType<Horse>())
            {
                if (pony.AdvertID.Equals(advertID))
                {
                    horse = pony;
                    horseFound = true;
                }
            }
            foreach (FarmAnimal FA in Model.AdvertList.OfType<FarmAnimal>())
            {
                if (FA.AdvertID.Equals(advertID))
                {
                    farmAnimal = FA;
                    farmAnimalFound = true;
                }
            }
            foreach (GenericAnimal GA in Model.AdvertList.OfType<GenericAnimal>())
            {
                if (GA.AdvertID.Equals(advertID))
                {
                    genericAnimal = GA;
                    genericAnimalFound = true;
                }
            }
            foreach (Litter lttr in Model.AdvertList.OfType<Litter>())
            {
                if (lttr.AdvertID.Equals(advertID))
                {
                    litter = lttr;
                    litterFound = true;
                }
            }
        }

        public ViewAds(IModel model, Dog dog)
        {
            InitializeComponent();
            Model = model;
            this.Dog = dog;
            this.dogFound = true;
        }

        public ViewAds(IModel model, Accessories access)
        {
            InitializeComponent();
            Model = model;
            this.accessories = access;
            this.accessoriesFound= true;
        }

        public ViewAds(IModel model, Food food)
        {
            InitializeComponent();
            Model = model;
            this.food = food;
            this.foodFound= true;
        }

        public ViewAds(IModel model, Horse horse)
        {
            InitializeComponent();
            Model = model;
            this.horse = horse;
            this.horseFound= true;
        }

        public ViewAds(IModel model, FarmAnimal fA)
        {
            InitializeComponent();
            Model = model;
            this.farmAnimal = fA;
            this.farmAnimalFound = true;
        }

        public ViewAds(IModel model, GenericAnimal GA)
        {
            InitializeComponent();
            Model = model;
            this.genericAnimal = GA;
            genericAnimalFound = true;

        }

        //public ViewAds(IModel model, Advertisement advert)
        //{
        //    InitializeComponent();
        //    Model = model;
        //    this.advertisement = advert;
            
        //}

        public ViewAds(IModel model, Litter litter)
        {
            InitializeComponent();
            Model = model;
            this.litter = litter;
            this.litterFound= true;
            
        }

       

        public void SetLabel(String Title, String SellerEmail,String Price)
        {
           label1.Text = Title;
           label2.Text = SellerEmail;
           label3.Text = Price;

        }
       

        private void button1_Click(object sender, EventArgs e)
        {



            if (accessoriesFound)
            {
                AccessoryAdvert accessoryAdvert = new AccessoryAdvert(Model, accessories);
                accessoryAdvert.Show();
            }
            else if (foodFound)
            {
                FoodAdvert foodAdvert = new FoodAdvert(Model, food);
                foodAdvert.Show();
            }
            else if (dogFound)
            {
                DogAdvert dogAdvert = new DogAdvert(Model, Dog);
                dogAdvert.Show();

            }
            else if (horseFound)
            {

                HorseAdvert horseAdvert = new HorseAdvert(Model, horse);
                horseAdvert.Show();

            }
            else if (farmAnimalFound)
            {
                FarmAdvert farmAdvert = new FarmAdvert(Model, farmAnimal);
                farmAdvert.Show();

            }
            else if (genericAnimalFound)
            {
                GenericAdvert genericAdvert = new GenericAdvert(Model, genericAnimal);
                genericAdvert.Show();

            }
            else if (litterFound)
            {

                //LitterAdvert litterAdvert = LitterAdvert(Model, litter);
                //litterAdvert.Show();
            }




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}
