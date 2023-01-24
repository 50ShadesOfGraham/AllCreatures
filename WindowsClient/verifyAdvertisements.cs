using BusinessEntities;
using BusinessLayer;

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
            if(AdCatComboBx.SelectedIndex == 0) 
            {
                panelAnimalsBtn.Visible = true;
                panelDog.Visible = false;
                panelfoodBtn.Visible = false;
                panelAssBtn.Visible = false;
                panelAnimalsDisp.Visible = true;
                panelAccess.Visible = false;
                panelFood.Visible = false;
                panelHorse.Visible = false;
                panelverifyAcc.Visible = false;
            }
            else if(AdCatComboBx.SelectedIndex == 1)
            {
                panelfoodBtn.Visible = true;
                panelAnimalsDisp.Visible = false;
                panelAnimalsBtn.Visible = false;
                panelAssBtn.Visible = false;
                panelAccess.Visible = false;
                panelFood.Visible = true;
                panelDog.Visible = false;
                panelHorse.Visible = false;
                panelverifyAcc.Visible = false;
            }
            else if(AdCatComboBx.SelectedIndex == 2)
            {
                panelAssBtn.Visible = true;
                panelAnimalsDisp.Visible = false;
                panelAnimalsBtn.Visible = false;
                panelfoodBtn.Visible = false;
                panelAccess.Visible = true;
                panelFood.Visible = false;
                panelDog.Visible = false;
                panelHorse.Visible = false;
                panelverifyAcc.Visible = false;
            }
        }

        private void verifyAdvertisements_Load(object sender, EventArgs e)
        {
            panelHorse.Visible = false;
            panelDog.Visible = false;
            panelAnimalsBtn.Visible = false;
            panelAssBtn.Visible = false;
            panelfoodBtn.Visible= false;
            panelAccess.Visible = false;
            panelGeneric.Visible = false;
            panelverifyAcc.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            foreach(Animal advertisement in model.AdvertList.OfType<Animal>())
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

            txtTitle.Text=listboxAni.SelectedItem.ToString();

          

            foreach (Animal animal in model.AdvertList.OfType<Animal>())
            {
                //MessageBox.Show(animal.Title);
                if(animal.Title == txtTitle.Text)
                {
                    txtTitle.Text=animal.Title;
                    txtDescription.Text=animal.Description;
                    txtVerified.Text = animal.Verified.ToString();
                    txtPrice.Text=animal.Price.ToString();
                    txtStat.Text=animal.Status.ToString();
                   txtAnimalType.Text=animal.AnimalType;
                    txtName.Text=animal.AnimalName;
                    txtAge.Text=animal.Age.ToString();
                    txtGender.Text=animal.Gender;
                    panelDog.Visible = false;
                    panelHorse.Visible = false;

                    /*foreach (Animal animal1 in model.AdvertList)
                    {
                        txtAnimalType.Text=animal1.AnimalType.ToString();
                        txtName.Text=animal1.AnimalName;
                        txtGender.Text=animal1.Gender;
                        
                    }*/

                    if (animal is Horse horse)
                    {
                        txtGender.Text=horse.Gender;
                        panelHorse.Visible = true;
                        txthSize.Text = horse.Size;
                        txtHBreed.Text = horse.Breed;
                        txtHBroken.Text =horse.Broken.ToString();
                        txtHPurpose.Text = horse.Purpose;

                    }

                    if (animal is Dog dog)
                    {
                        txtBreed.Text = dog.Purebreed.ToString();
                        panelDog.Visible = true;
                    }
                    if(animal is GenericAnimal generic)
                    {
                        panelGeneric.Visible = true;
                        
                        txtDetail1.Text = generic.DetailOne;
                        txtDetail2.Text = generic.DetailTwo;
                        txtDetail3.Text = generic.DetailThree;
                        
                    }

                }
                
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            panelverifyAcc.Visible = false;
            foreach (Advertisement advertisement in model.AdvertList)
            {
               

                if (advertisement.Title == listboxAni.SelectedItem.ToString())
                {
                    advertisement.Verified = true;
                    if (advertisement is Dog dog)
                    {
                        model.verifyAdvertisement(dog);
                    }
                    else if (advertisement is Horse horse)
                    {
                        model.verifyAdvertisement(horse);
                    }
                    else if (advertisement is FarmAnimal farmAnimal)
                    {
                        model.verifyAdvertisement(farmAnimal);
                    }
                    else if (advertisement is Litter litter)
                    {
                        model.verifyAdvertisement(litter);
                    }
                    else if (advertisement is GenericAnimal generic)
                    {
                        model.verifyAdvertisement(generic);
                    }
                    break;

                }
                
                //
                //if (advertisement.Title == listBoxFood.SelectedItem.ToString())
                //{
                //    advertisement.Verified = true;
                //    if (advertisement is Food food)
                //    {
                //        model.verifyAdvertisement(food);
                //    }
                //    break;
                //}

        }
            MessageBox.Show("Success");

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
                /*foreach (Food food in model.AdvertList)
                {
                    
                }*/
            }
        }

        private void listBoxAssess_DoubleClick(object sender, EventArgs e)
        {
            txtTitle.Text=listBoxAssess.SelectedItem.ToString();
            panelverifyAcc.Visible = true;
            foreach (Advertisement
                advertisement in model.AdvertList.OfType<Accessories>())
            {
                if (advertisement.Title == txtTitle.Text)
                {
                    
                    txtTitle.Text = advertisement.Title;
                    txtDescription.Text = advertisement.Description;
                    txtVerified.Text = advertisement.Verified.ToString();
                    txtPrice.Text = advertisement.Price.ToString();
                    txtStat.Text = advertisement.Status.ToString();
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
                   
                    if(advertisement is Food food) 
                    {
                        txtType.Text = food.AnimalType;
                        txtDetail1.Text = food.Details;
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
            foreach (Advertisement advertisement in model.AdvertList.OfType<Animal>())
            {
                

                if (advertisement.Title == listboxAni.SelectedItem.ToString())
                {
                    /* if(advertisement is Dog dog) 
                      {
                          model.deleteAdvertisement(dog);
                          listboxAni.Items.Remove(listboxAni.SelectedItem);
                          MessageBox.Show(dog.AnimalName);
                          break;

                      }*/
                    if (advertisement is Horse horse)
                    {
                        model.deleteAdvertisement(horse);
                        listboxAni.Items.Remove(listboxAni.SelectedItem);
                        MessageBox.Show(horse.AnimalName);
                        break;

                    }
                    if (advertisement is GenericAnimal genericAnimal)
                    {
                        model.deleteAdvertisement(genericAnimal);
                        listboxAni.Items.Remove(listboxAni.SelectedItem);
                        MessageBox.Show(genericAnimal.AnimalName);
                        break;
                    }
                    if (advertisement is FarmAnimal farmAnimal)
                    {
                        model.deleteAdvertisement(farmAnimal);
                        listboxAni.Items.Remove(listboxAni.SelectedItem);
                        MessageBox.Show(farmAnimal.AnimalName);
                        break;
                    } 
                    if (advertisement is Litter litter)
                    {
                        model.deleteAdvertisement(litter);
                        listboxAni.Items.Remove(listboxAni.SelectedItem);
                        MessageBox.Show(litter.AnimalName);
                        break;
                    }
                    
                    /* model.deleteAdvertisement(advertisement);
                     listboxAni.Items.Remove(listboxAni.SelectedItem);
                     break;
                     MessageBox.Show("Success");*/
                }
               /* if (MessageBox.Show("Delete " + listboxAni.SelectedItem.ToString() + " ? ", "Are you sure !", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;*/

            }
         
                
        }

        private void panelGeneric_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                foreach (Advertisement ad in model.AdvertList.OfType<Accessories>())
            {
                if (ad.Title == listBoxAssess.SelectedItem.ToString())
                {
                    ad.Verified = true;
                    if (ad is Accessories accessories)
                    {
                        model.verifyAdvertisement(accessories);
                    }
                    break;
                }
            }

        }
    }
}
