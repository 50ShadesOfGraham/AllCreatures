using BusinessEntities;
using BusinessLayer;
using System.Drawing;
namespace WindowsClient
{
    public partial class verifyAdvertisements : Form
    {
        IModel model;
        public verifyAdvertisements(BusinessLayer.IModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void AdCatComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AdCatComboBx.SelectedIndex == 0) //Animal   
            {
                panelAnimalsBtn.Visible = true;
                panelDog.Visible = false;
                panelfoodBtn.Visible = false;
                panelAssBtn.Visible = false;
                panelAnimalsDisp.Visible = true;
                panelAccess.Visible = false;
                panelFood.Visible = false;
                panelHorse.Visible = false;
                panelLitter.Visible = false;
            }
            else if (AdCatComboBx.SelectedIndex == 1) //Food
            {
                panelfoodBtn.Visible = true;
                panelAnimalsDisp.Visible = false;
                panelAnimalsBtn.Visible = false;
                panelAssBtn.Visible = false;
                panelAccess.Visible = false;
                panelFood.Visible = true;
                panelDog.Visible = false;
                panelHorse.Visible = false;
                panelGeneric.Visible = false;
                panelLitter.Visible = false;
            }
            else if (AdCatComboBx.SelectedIndex == 2)//Accessories
            {
                panelAssBtn.Visible = true;
                panelAnimalsDisp.Visible = false;
                panelAnimalsBtn.Visible = false;
                panelfoodBtn.Visible = false;
                panelAccess.Visible = true;
                panelFood.Visible = false;
                panelDog.Visible = false;
                panelHorse.Visible = false;
                panelGeneric.Visible = false;
                panelLitter.Visible = false;
            }
        }

        private void verifyAdvertisements_Load(object sender, EventArgs e)
        {
            panelHorse.Visible = false;
            panelDog.Visible = false;
            panelAnimalsBtn.Visible = false;
            panelAssBtn.Visible = false;
            panelfoodBtn.Visible = false;
            panelAccess.Visible = false;
            panelGeneric.Visible = false;
            panelLitter.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            foreach (Animal advertisement in model.AdvertList.OfType<Animal>())
            {
                /*  listboxAni.Items.Add(advertisement.Title);*/


                listboxAni.Items.Add(advertisement.Title);


                /*foreach(Dog dog in model.AdvertList)
                {
                    listboxAni.Items.Add(dog.AnimalName);
                }*/
            }
        }

        private void listboxAni_DoubleClick(object sender, EventArgs e)
        {
            /* PictureBoxImage.Image = GetImage(); */

            txtTitle.Text = listboxAni.SelectedItem.ToString();


            
                foreach (Animal animal in model.AdvertList.OfType<Animal>())
                {
                    if (animal.Title == txtTitle.Text)
                    {
                        txtTitle.Text = animal.Title;
                        txtDescription.Text = animal.Description;
                        txtVerified.Text = animal.Verified.ToString();
                        txtPrice.Text = animal.Price.ToString();
                        txtStat.Text = animal.Status.ToString();
                        txtAnimalType.Text = animal.AnimalType;
                        txtName.Text = animal.AnimalName;
                        txtAge.Text = animal.Age.ToString();
                        txtGender.Text = animal.Gender;
                        panelDog.Visible = false;
                        panelHorse.Visible = false;
                        panelLitter.Visible = false;
                    lbluserEmail.Text = animal.SellerEmail;
                   /*     //pictureBox = animal.ImageOne;
                    byte[] imagedata = animal.ImageOne;
                    using (MemoryStream ms = new MemoryStream(imagedata))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox.Image = image;
                        
                    }
                    if (imagedata != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imagedata))
                        {
                            Image image = Image.FromStream(ms);
                            pictureBox.Image = image;
                        }
                    }*/


                    /*foreach (Animal animal1 in model.AdvertList)
                    {
                        txtAnimalType.Text=animal1.AnimalType.ToString();
                        txtName.Text=animal1.AnimalName;
                        txtGender.Text=animal1.Gender;

                    }*/

                    if (animal is Horse horse)
                        {
                            txtGender.Text = horse.Gender;
                            panelHorse.Visible = true;
                            txthSize.Text = horse.Size;
                            txtHBreed.Text = horse.Breed;
                            txtHBroken.Text = horse.Broken.ToString();
                            txtHPurpose.Text = horse.Purpose;
                            panelGeneric.Visible = false;
                            panelLitter.Visible = false;
                    }

                        if (animal is Dog dog)
                        {
                            txtBreed.Text = dog.Purebreed.ToString();
                            panelDog.Visible = true;
                            panelGeneric.Visible = false;
                            panelLitter.Visible = false;
                        if (dog.Purebreed == false)
                        {
                            txtDogBreed1.Text = dog.BreedOne;
                            txtDogBreed2.Text = dog.BreedTwo;
                        }
                        txtDogBreed1.Text = dog.BreedOne;
                    }
                        if (animal is GenericAnimal generic)
                        {
                            panelGeneric.Visible = true;

                            txtDetail1.Text = generic.DetailOne;
                            txtDetail2.Text = generic.DetailTwo;
                            txtDetail3.Text = generic.DetailThree;
                            panelLitter.Visible = false;

                    }
                    if (animal is Litter litter)
                        {
                        panelGeneric.Visible = false;
                        txtLitterBr1.Text = litter.BreedOne;
                        txtLitterBr2.Text = litter.BreedTwo;
                        txtLitterPure.Text = litter.Purebreed.ToString() ;
                        txtLitterSize.Text = litter.LitterSize.ToString();
                        panelLitter.Visible = true;
                        }
                    }

                }
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (AdCatComboBx.SelectedIndex == 0)
            {
                foreach (Advertisement advertisement in model.AdvertList)
                {
                    if (advertisement.Title == listboxAni.SelectedItem.ToString())
                    {
                        advertisement.Verified = true;
                        if (advertisement is Dog dog)
                        {
                            model.verifyAdvertisement(dog);
                        }
                        if (advertisement is Horse horse)
                        {
                            model.verifyAdvertisement(horse);
                        }
                        if (advertisement is FarmAnimal farmAnimal)
                        {
                            model.verifyAdvertisement(farmAnimal);
                        }
                        if (advertisement is Litter litter)
                        {
                            model.verifyAdvertisement(litter);
                        }
                        if (advertisement is GenericAnimal generic)
                        {
                            model.verifyAdvertisement(generic);
                        }
                        //break;

                    }

                }
            }
            else if (AdCatComboBx.SelectedIndex == 1)
            {
                foreach (Food food1 in model.AdvertList.OfType<Food>())
                {
                    if (food1.Title == listBoxFood.SelectedItem.ToString())
                    {
                        food1.Verified = true;
                        model.verifyAdvertisement(food1);
                        break;
                    }
                }

            }
            else if (AdCatComboBx.SelectedIndex == 2)
            {
                foreach (Accessories accessories1 in model.AdvertList.OfType<Accessories>())
                {
                    if (accessories1.Title == listBoxAssess.SelectedItem.ToString())
                    {
                        accessories1.Verified = true;
                        model.verifyAdvertisement(accessories1);
                        break;
                    }

                }
            }



            MessageBox.Show("Sucessfully verifed Advertisement");

        }

        private void listboxAni_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private void btnAssess_Click(object sender, EventArgs e)
         {
             foreach(Accessories advertisement in model.AdvertList.OfType<Accessories>())
             {
                     listBoxAssess.Items.Add(advertisement.Title);
             }
         }

         private void btnFood_Click(object sender, EventArgs e)
         {

            foreach (Food advertisement in model.AdvertList.OfType<Food>())
            {
                listBoxFood.Items.Add(advertisement.Title);
            }
        }

        private void listBoxAssess_DoubleClick(object sender, EventArgs e)
        {
            txtTitle.Text = listBoxAssess.SelectedItem.ToString();

            foreach (Advertisement advertisement in model.AdvertList.OfType<Accessories>())
            {
                if (advertisement.Title == txtTitle.Text)
                {

                    txtTitle.Text = advertisement.Title;
                    txtDescription.Text = advertisement.Description;
                    txtVerified.Text = advertisement.Verified.ToString();
                    txtPrice.Text = advertisement.Price.ToString();
                    txtStat.Text = advertisement.Status.ToString();
                    lbluserEmail.Text = advertisement.SellerEmail;
                    /*txtType.Text = advertisement.animalType*/ //Animal type missing from class
                    if (advertisement is Accessories accessories)
                    {
                        //txtType.Text = accessories.details
                        txtAccessCat.Text = accessories.AccessCategory.ToString();
                        txtSubCat.Text = accessories.SubAccessCategory.ToString();
                       
                    }
                }



            }
        }

        private void listBoxFood_DoubleClick(object sender, EventArgs e)
        {
            txtTitle.Text = listBoxFood.SelectedItem.ToString();
            foreach (Advertisement advertisement in model.AdvertList)
            {
                if (advertisement.Title == txtTitle.Text)
                {
                    txtTitle.Text = advertisement.Title;
                    txtDescription.Text = advertisement.Description;
                    txtVerified.Text = advertisement.Verified.ToString();
                    txtPrice.Text = advertisement.Price.ToString();
                    txtStat.Text = advertisement.Status.ToString();
                    

                    if (advertisement is Food food)
                    {
                        txtType.Text = food.AnimalType;
                        txtDetail1.Text = food.Details;
                        lbluserEmail.Text = advertisement.SellerEmail;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listboxAni.Items.Clear();
            listBoxAssess.Items.Clear();
            listBoxFood.Items.Clear();
            txtDetail1.Clear();
            txtDetail2.Clear();
            txtDetail3.Clear();
            txtDescription.Clear();
            txtAge.Clear();
            txtAnimalType.Clear();
            txtBreed.Clear();
            txtAccessCat.Clear();
            txtName.Clear();
            txtVerified.Clear();
            txtType.Clear();
            txthSize.Clear();
            txtHBreed.Clear();
            txtHBroken.Clear();
            txtHPurpose.Clear();
            txtTitle.Clear();
            txtPrice.Clear();
            txtStat.Clear();
            txtGender.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AdCatComboBx.SelectedIndex == 0)
            {
                foreach (Advertisement advertisement in model.AdvertList.OfType<Animal>())
                {

                    if (advertisement.Title == listboxAni.SelectedItem.ToString())
                    {
                        if (advertisement is Dog dog)
                        {
                            model.deleteAdvertisement(dog);
                            listboxAni.Items.Remove(listboxAni.SelectedItem);
                            MessageBox.Show(dog.Title + " Was deleted");
                            break;

                        }
                       if (advertisement is Horse horse)
                        {
                            model.deleteAdvertisement(horse);
                            listboxAni.Items.Remove(listboxAni.SelectedItem);
                            MessageBox.Show(horse.Title + " Was deleted");
                            break;
                        }
                         if (advertisement is GenericAnimal genericAdvert)
                        {
                            model.deleteAdvertisement(genericAdvert);
                            listboxAni.Items.Remove(listboxAni.SelectedItem);
                            MessageBox.Show(genericAdvert.Title + " Was deleted");
                            break;
                        }
                         if (advertisement is FarmAnimal farm)
                        {
                            model.deleteAdvertisement(farm);
                            listboxAni.Items.Remove(listboxAni.SelectedItem);
                            MessageBox.Show(farm.Title + " Was deleted");
                            break;
                        }
                         if (advertisement is FarmAnimal farmAnimal)
                        {
                            model.deleteAdvertisement(farmAnimal);
                            listboxAni.Items.Remove(listboxAni.SelectedItem);
                            MessageBox.Show(farmAnimal.Title + " Was deleted");
                            break;
                        }
                       if (advertisement is Litter litter)
                        {
                            model.deleteAdvertisement(litter);
                            listboxAni.Items.Remove(listboxAni.SelectedItem);
                            MessageBox.Show(litter.Title + " Was deleted");
                            break;
                        }
                        /* model.deleteAdvertisement(advertisement);
                         listboxAni.Items.Remove(listboxAni.SelectedItem);
                         break;
                         MessageBox.Show("Success");*/
                    }
                }
               /* if (MessageBox.Show("Delete " + listboxAni.SelectedItem.ToString() + " ? ", "Are you sure !", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;*/

                //}


            }
            if (AdCatComboBx.SelectedIndex == 1)
            {
                foreach(Food food in model.AdvertList.OfType<Food>()) 
                {
                    model.deleteAdvertisement(food);
                    listBoxFood.Items.Remove(listBoxFood.SelectedItem);
                    MessageBox.Show(food.Title + " Was deleted");
                    break;
                }
            }
            if (AdCatComboBx.SelectedIndex == 2)
            {
                foreach(Accessories accessories in model.AdvertList.OfType<Accessories>()) 
                {
                    model.deleteAdvertisement(accessories);
                    listBoxAssess.Items.Remove(listBoxAssess.SelectedItem);
                    MessageBox.Show(accessories.Title + " Was deleted");
                    break;
                }
            }

            //private void panelGeneric_Paint(object sender, PaintEventArgs e)
            //{
            //    //
            //}
        }

       /* private void btnAssess_Click(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {

        }*/
    }
}
