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

namespace WindowsClient
{
    public partial class EditAdvertisement : Form
    {
        private int AdvertID;
        private IModel Model;
        private Dog dog;
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
        public void Alert(string message, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(message, type);
        }
        public EditAdvertisement(IModel Model,int advertID)
        {
            InitializeComponent();
            this.Model = Model;
            this.AdvertID = advertID;
            foreach(Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if(access.AdvertID.Equals(advertID)) 
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
            foreach(Dog doggo in Model.AdvertList.OfType<Dog>())
            {
                if(doggo.AdvertID.Equals(advertID))
                {
                    dog = doggo;
                    dogFound = true;
                }
            }
            foreach(Horse pony in Model.AdvertList.OfType<Horse>())
            {
                if(pony.AdvertID.Equals(advertID))
                {
                    horse = pony;
                    horseFound = true;
                }
            }
            foreach(FarmAnimal FA in Model.AdvertList.OfType<FarmAnimal>())
            {
                if(FA.AdvertID.Equals(advertID))
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
            foreach(Litter lttr in Model.AdvertList.OfType<Litter>())
            {
                if(lttr.AdvertID.Equals(advertID))
                {
                    litter = lttr;
                    litterFound = true;
                }
            }
        }

        private void EditAdvertisement_Load(object sender, EventArgs e)
        {
            this.Text = "Edit #" + AdvertID + " Advertisement";
            IntroPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
            if (accessoriesFound)
            {
                Advert_TypeLbl.Text = "Accessories";
                TitleTxt.Text = accessories.Title.Trim();
                PriceTxt.Text = accessories.Price.ToString().Trim();
                DescriptionTxt.Text = accessories.Description.Trim();
                AccessCatComboBox.SelectedItem = accessories.AccessCategory.Trim();
                AccessTypeComboBox.SelectedItem = accessories.SubAccessCategory.Trim();
            }
            else if(foodFound)
            {
                Advert_TypeLbl.Text = "Food";
                TitleTxt.Text = food.Title.Trim();
                PriceTxt.Text = food.Price.ToString().Trim();
                DescriptionTxt.Text = food.Description.Trim();
                AnimalFoodTypeComboBox.SelectedItem = food.AnimalType.Trim();
                DetailTxt.Text = food.Details.Trim();
            }
            else if(dogFound)
            {
                Advert_TypeLbl.Text = "Dog";
                TitleTxt.Text = dog.Title.Trim();
                PriceTxt.Text = dog.Price.ToString().Trim();
                DescriptionTxt.Text = dog.Description.Trim();
                DogNameTxt.Text = dog.AnimalName.Trim();
                DogAgeTxt.Text= dog.Age.ToString().Trim();
                DogGenderComboBox.SelectedItem = dog.Gender.Trim();
                if(dog.Purebreed)
                {
                    DogPurebreedYesRadBttn.Checked = true;
                    IsPurebreedPanel.Visible = true;
                    DogIsNotPurebreedPanel.Visible = false;
                    DogBreedComboBox.SelectedItem = dog.BreedOne.Trim();
                }
                else
                {
                    DogPurebreedNoBttn.Checked = true;
                    IsPurebreedPanel.Visible = false;
                    DogIsNotPurebreedPanel.Visible = true;
                    DogBreedOneComboBox.SelectedItem = dog.BreedOne.Trim();
                    DogBreedTwoComboBox.SelectedItem = dog.BreedTwo.Trim();
                }
            }
            else if(horseFound)
            {
                Advert_TypeLbl.Text = "Horse";
                TitleTxt.Text = horse.Title.Trim();
                PriceTxt.Text = horse.Price.ToString().Trim();
                DescriptionTxt.Text = horse.Description.Trim();
                HorseNameTxt.Text = horse.AnimalName.Trim();
                HorseAgeTxt.Text = horse.Age.ToString().Trim();
                HorseGenderComboBox.SelectedItem = horse.Gender.Trim();
                HorseSizeTxt.Text = horse.Size.Trim();
                HorseBreedComboBox.SelectedItem = horse.Breed.Trim();
                if(horse.Broken.Equals(true))
                {
                    BrokenYesRadBttn.Checked = true;
                    BrokenNoRadBttn.Checked = false;
                }
                else
                {
                    BrokenYesRadBttn.Checked = false;
                    BrokenNoRadBttn.Checked = true;
                }
                HorsePurposeTxt.Text = horse.Purpose.Trim();
            }
            else if(farmAnimalFound)
            {
                Advert_TypeLbl.Text = "Farm Animal";
                TitleTxt.Text = farmAnimal.Title.Trim();
                PriceTxt.Text = farmAnimal.Price.ToString().Trim();
                DescriptionTxt.Text = farmAnimal.Description.Trim();
                FANameTxt.Text = farmAnimal.AnimalName.Trim();
                FAAgeTxt.Text = farmAnimal.Age.ToString().Trim();
                FAGenderComboBox.SelectedItem = farmAnimal.Gender.Trim();
                FAPurposeTxt.Text = farmAnimal.Purpose.Trim();
            }
            else if(genericAnimalFound)
            {
                Advert_TypeLbl.Text = genericAnimal.GetAdvertisementType().Trim();
                TitleTxt.Text = genericAnimal.Title.Trim();
                PriceTxt.Text = genericAnimal.Price.ToString().Trim();
                DescriptionTxt.Text = genericAnimal.Description.Trim();
                GANameTxt.Text = genericAnimal.AnimalName.Trim();
                GAAgeTxt.Text = genericAnimal.Age.ToString().Trim();
                GAGenderComboBox.SelectedItem = genericAnimal.Gender.Trim();
                DetailOneTxt.Text = genericAnimal.DetailOne.Trim();
                DetailTwoTxt.Text = genericAnimal.DetailTwo.Trim();
                DetailThreeTxt.Text= genericAnimal.DetailThree.Trim();
            }
            else if(litterFound)
            {
                Advert_TypeLbl.Text = "Litter of " + litter.GetAdvertisementType().Trim();
                TitleTxt.Text = litter.Title.Trim();
                PriceTxt.Text = litter.Price.ToString().Trim();
                DescriptionTxt.Text = litter.Description.Trim();
                LitterSizeTxt.Text = litter.LitterSize.ToString().Trim();
                LitterAgeTxt.Text= litter.Age.ToString().Trim();
                if(litter.AnimalType.Trim().Equals("Dogs"))
                {
                    CatLPurebredPanel.Visible = false;
                    CatLNotPanel.Visible = false;
                    if(litter.Purebreed)
                    {
                        LitterYesRadBttn.Checked = true;
                        LitterNoRadBttn.Checked = false;
                        DogLPurebredPanel.Visible = true;
                        DogLNotPanel.Visible = false;
                        DogLPComboBox.SelectedItem = litter.BreedOne.Trim();
                    }
                    else
                    {
                        LitterYesRadBttn.Checked = false;
                        LitterNoRadBttn.Checked = true;
                        DogLPurebredPanel.Visible = false;
                        DogLNotPanel.Visible = true;
                        DogLNOneComboBox.SelectedItem = litter.BreedOne.Trim();
                        DogLNTwoComboBox.SelectedItem= litter.BreedTwo.Trim();
                    }
                }
                else if(litter.AnimalType.Trim().Equals("Cats"))
                {
                    DogLPurebredPanel.Visible = false;
                    DogLNotPanel.Visible = false;
                    if (litter.Purebreed)
                    {
                        LitterYesRadBttn.Checked = true;
                        LitterNoRadBttn.Checked = false;
                        CatLPurebredPanel.Visible = true;
                        CatLNotPanel.Visible = false;
                        CatLPComboBox.SelectedItem = litter.BreedOne.Trim();
                    }
                    else
                    {
                        LitterYesRadBttn.Checked = false;
                        LitterNoRadBttn.Checked = true;
                        CatLPurebredPanel.Visible = false;
                        CatLNotPanel.Visible = true;
                        CatLNOneComboBox.SelectedItem = litter.BreedOne.Trim();
                        CatLNTwoComboBox.SelectedItem = litter.BreedTwo.Trim();
                    }
                }
            }
        }

        private void DogPurebreedYesRadBttn_CheckedChanged(object sender, EventArgs e)
        {
            if(DogPurebreedYesRadBttn.Checked)
            {
                IsPurebreedPanel.Visible = true;
                DogIsNotPurebreedPanel.Visible = false;
            }
        }

        private void DogPurebreedNoBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (DogPurebreedNoBttn.Checked)
            {
                IsPurebreedPanel.Visible = false;
                DogIsNotPurebreedPanel.Visible = true;
            }
        }

        private void LitterYesRadBttn_CheckedChanged(object sender, EventArgs e)
        {
            if(LitterYesRadBttn.Checked)
            {
                if(litter.AnimalType.Trim().Equals("Dogs"))
                {
                    DogLPurebredPanel.Visible = true;
                    DogLNotPanel.Visible = false;
                    CatLPurebredPanel.Visible = false;
                    CatLNotPanel.Visible = false;
                }
                else if(litter.AnimalType.Trim().Equals("Cats"))
                {
                    DogLPurebredPanel.Visible = false;
                    DogLNotPanel.Visible = false;
                    CatLPurebredPanel.Visible = true;
                    CatLNotPanel.Visible = false;
                }
            }
        }

        private void LitterNoRadBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (LitterNoRadBttn.Checked)
            {
                if (litter.AnimalType.Trim().Equals("Dogs"))
                {
                    DogLPurebredPanel.Visible = false;
                    DogLNotPanel.Visible = true;
                    CatLPurebredPanel.Visible = false;
                    CatLNotPanel.Visible = false;
                }
                else if (litter.AnimalType.Trim().Equals("Cats"))
                {
                    DogLPurebredPanel.Visible = false;
                    DogLNotPanel.Visible = false;
                    CatLPurebredPanel.Visible = false;
                    CatLNotPanel.Visible = true;
                }
            }
        }

        private void FoodBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IntroNextBttn_Click(object sender, EventArgs e)
        {
            if (foodFound) 
            {
                IntroPanel.Visible = false;
                FoodPanel.Visible = true;
                AccessPanel.Visible = false;
                HorsePanel.Visible = false;
                DogPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                LitterPanel.Visible = false;
            }
            else if(accessoriesFound) 
            {
                IntroPanel.Visible = false;
                FoodPanel.Visible = false;
                AccessPanel.Visible = true;
                HorsePanel.Visible = false;
                DogPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                LitterPanel.Visible = false;
            }
            else if(dogFound) 
            {
                IntroPanel.Visible = false;
                FoodPanel.Visible = false;
                AccessPanel.Visible = false;
                HorsePanel.Visible = false;
                DogPanel.Visible = true;
                FarmAnimalPanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                LitterPanel.Visible = false;
            }
            else if(horseFound) 
            {
                IntroPanel.Visible = false;
                FoodPanel.Visible = false;
                AccessPanel.Visible = false;
                HorsePanel.Visible = true;
                DogPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                LitterPanel.Visible = false;
            }
            else if(farmAnimalFound) 
            {
                IntroPanel.Visible = false;
                FoodPanel.Visible = false;
                AccessPanel.Visible = false;
                HorsePanel.Visible = false;
                DogPanel.Visible = false;
                FarmAnimalPanel.Visible = true;
                GenericAnimalPanel.Visible = false;
                LitterPanel.Visible = false;
            }
            else if(genericAnimalFound) 
            {
                IntroPanel.Visible = false;
                FoodPanel.Visible = false;
                AccessPanel.Visible = false;
                HorsePanel.Visible = false;
                DogPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
                GenericAnimalPanel.Visible = true;
                LitterPanel.Visible = false;
            }
            else if (litterFound) 
            {
                IntroPanel.Visible = false;
                FoodPanel.Visible = false;
                AccessPanel.Visible = false;
                HorsePanel.Visible = false;
                DogPanel.Visible = false;
                FarmAnimalPanel.Visible = false;
                GenericAnimalPanel.Visible = false;
                LitterPanel.Visible = true;
            }
        }

        private void FoodConfirmBttn_Click(object sender, EventArgs e)
        {
            string AnimalType = this.AnimalFoodTypeComboBox.GetItemText(this.AnimalFoodTypeComboBox.SelectedItem);
            if (Model.UpdateFoodAdvert(AdvertID,TitleTxt.Text,DescriptionTxt.Text,Convert.ToDouble(PriceTxt.Text),AnimalType,DetailTxt.Text))
            {
                this.Alert("#" +AdvertID + " Updated", Form_Alert.enmType.Success);
                this.Close();
            }
        }

        private void AccessConfirmBttn_Click(object sender, EventArgs e)
        {
            string AccessCat = this.AccessCatComboBox.GetItemText(this.AccessCatComboBox.SelectedItem);
            string AccessSubCat = this.AccessTypeComboBox.GetItemText(this.AccessTypeComboBox.SelectedItem);
            if(string.IsNullOrEmpty(AccessCat)) 
            { 
                MessageBox.Show("Please Enter An Accessories Category"); 
            }
            else if (string.IsNullOrEmpty(AccessCat)) 
            { 
                MessageBox.Show("Please Enter A Type of Accessories"); 
            }
            else if(Model.UpdateAccessAdvert(AdvertID, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text),AccessCat,AccessSubCat))
            {
                this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                this.Close();
            }

        }

        private void DogConfirmBttn_Click(object sender, EventArgs e)
        {
            string DogGender = this.DogGenderComboBox.GetItemText(this.DogGenderComboBox.SelectedItem);
            if (string.IsNullOrEmpty(DogNameTxt.Text))
            {
                MessageBox.Show("Please Enter Dog Name");
            }
            else if (string.IsNullOrEmpty(DogAgeTxt.Text))
            {
                MessageBox.Show("Please Enter Dog Age");
            }
            else if (string.IsNullOrEmpty(DogGender))
            {
                MessageBox.Show("Please Enter Dog Gender");
            }
            else if (DogPurebreedYesRadBttn.Checked.Equals(false) && DogPurebreedNoBttn.Checked.Equals(false))
            {
                MessageBox.Show("Please Confirm If Dog Is A Purebreed");
            }
            else
            {
                if(DogPurebreedYesRadBttn.Checked)
                {
                    string DogBreedOne = this.DogBreedComboBox.GetItemText(this.DogBreedComboBox.SelectedItem);

                    if (string.IsNullOrEmpty(DogBreedOne))
                    {
                        MessageBox.Show("Please Choose Dog Breed");
                    }
                    else if(Model.UpdateDogAdvert(AdvertID, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), DogNameTxt.Text,Convert.ToInt32(DogAgeTxt.Text),DogGender,
                        true,DogBreedOne,""))
                    {
                        this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                        this.Close();
                    }
                }
                else if(DogPurebreedNoBttn.Checked)
                {
                    string DogBreedOne = this.DogBreedOneComboBox.GetItemText(this.DogBreedOneComboBox.SelectedItem);
                    string DogBreedTwo = this.DogBreedTwoComboBox.GetItemText(this.DogBreedTwoComboBox.SelectedItem);
                    if (string.IsNullOrEmpty(DogBreedOne))
                    {
                        MessageBox.Show("Please Choose Dog Breed");
                    }
                    else if(string.IsNullOrEmpty(DogBreedTwo))
                    {
                        MessageBox.Show("Please Choose Dog Breed");
                    }
                    else if (Model.UpdateDogAdvert(AdvertID, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), DogNameTxt.Text, Convert.ToInt32(DogAgeTxt.Text), DogGender,
                        false, DogBreedOne, DogBreedTwo))
                    {
                        this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                        this.Close();
                    }
                }
            }
        }

        private void FAConfirmBttn_Click(object sender, EventArgs e)
        {
            string FAGender = this.FAGenderComboBox.GetItemText(this.FAGenderComboBox.SelectedItem);
            if (string.IsNullOrEmpty(FANameTxt.Text))
            {
                MessageBox.Show("Please Enter Name");
            }
            else if (string.IsNullOrEmpty(FAAgeTxt.Text))
            {
                MessageBox.Show("Please Enter Age");
            }
            else if (string.IsNullOrEmpty(FAGender))
            {
                MessageBox.Show("Please Enter Gender");
            }
            else if (string.IsNullOrEmpty(FAPurposeTxt.Text))
            {
                MessageBox.Show("Please Enter Purpose");
            }
            else if (Model.UpdateFarmAnimalAdvert(AdvertID, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text),FANameTxt.Text,Convert.ToInt32(FAAgeTxt.Text),
                FAGender,FAPurposeTxt.Text))
            {
                this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                this.Close();
            }
        }

        private void GAConfirmBttn_Click(object sender, EventArgs e)
        {
            string GAGender = this.GAGenderComboBox.GetItemText(this.GAGenderComboBox.SelectedItem);
            if (string.IsNullOrEmpty(GANameTxt.Text))
            {
                MessageBox.Show("Please Enter  Name");
            }
            else if (string.IsNullOrEmpty(GAAgeTxt.Text))
            {
                MessageBox.Show("Please Enter  Age");
            }
            else if (string.IsNullOrEmpty(GAGender))
            {
                MessageBox.Show("Please Enter Gender");
            }
            else if (string.IsNullOrEmpty(DetailOneTxt.Text) && string.IsNullOrEmpty(DetailTwoTxt.Text) && string.IsNullOrEmpty(DetailThreeTxt.Text))
            {
                MessageBox.Show("Please Enter At Least Three Details");
            }
            else if(Model.UpdateGenericAnimalAdvert(AdvertID, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), GANameTxt.Text,
                Convert.ToInt32(GAAgeTxt.Text),GAGender,DetailOneTxt.Text,DetailTwoTxt.Text,DetailThreeTxt.Text))
            {
                this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                this.Close();
            }
        }

        private void LitterConfirmBttn_Click(object sender, EventArgs e)
        {
            if(LitterYesRadBttn.Checked.Equals(false) && LitterNoRadBttn.Checked.Equals(false))
            {
                MessageBox.Show("Is the Litter a Purebreed");
            }
            else
            {
                if (litter.AnimalType.Trim().Equals("Dogs"))
                {
                    if (LitterYesRadBttn.Checked)
                    {
                        string LitterBreedOne = this.DogLPComboBox.GetItemText(this.DogLPComboBox.SelectedItem);
                        if (string.IsNullOrEmpty(LitterSizeTxt.Text))
                        {
                            MessageBox.Show("Please Enter Litter Size");
                        }
                        else if (string.IsNullOrEmpty(LitterAgeTxt.Text))
                        {
                            MessageBox.Show("Please Enter Litter Age");
                        }
                        else if (string.IsNullOrEmpty(LitterBreedOne))
                        {
                            MessageBox.Show("Please Enter A Breed");
                        }
                        else if (Model.UpdateLitterAdvert(AdvertID, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), Convert.ToInt32(LitterSizeTxt.Text),
                            Convert.ToInt32(LitterAgeTxt.Text), true, LitterBreedOne, ""))
                        {
                            this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                            this.Close();
                        }
                    }
                    else if(LitterNoRadBttn.Checked)
                    {
                        string LitterBreedOne = this.DogLNOneComboBox.GetItemText(this.DogLNOneComboBox.SelectedItem);
                        string LitterBreedTwo = this.DogLNTwoComboBox.GetItemText(this.DogLNTwoComboBox.SelectedItem);
                        if (string.IsNullOrEmpty(LitterSizeTxt.Text))
                        {
                            MessageBox.Show("Please Enter Litter Size");
                        }
                        else if (string.IsNullOrEmpty(LitterAgeTxt.Text))
                        {
                            MessageBox.Show("Please Enter Litter Age");
                        }
                        else if (string.IsNullOrEmpty(LitterBreedOne))
                        {
                            MessageBox.Show("Please Enter A Breed");
                        }
                        else if(string.IsNullOrEmpty(LitterBreedTwo))
                        {
                            MessageBox.Show("Please Enter A 2nd Breed");
                        }
                        else if (Model.UpdateLitterAdvert(AdvertID, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), Convert.ToInt32(LitterSizeTxt.Text),
                            Convert.ToInt32(LitterAgeTxt.Text), false, LitterBreedOne, LitterBreedTwo))
                        {
                            this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                            this.Close();
                        }
                    }
                }
                else if (litter.AnimalType.Trim().Equals("Cats"))
                {
                    if (LitterYesRadBttn.Checked)
                    {
                        string LitterBreedOne = this.CatLPComboBox.GetItemText(this.CatLPComboBox.SelectedItem);
                        if (string.IsNullOrEmpty(LitterSizeTxt.Text))
                        {
                            MessageBox.Show("Please Enter Litter Size");
                        }
                        else if (string.IsNullOrEmpty(LitterAgeTxt.Text))
                        {
                            MessageBox.Show("Please Enter Litter Age");
                        }
                        else if (string.IsNullOrEmpty(LitterBreedOne))
                        {
                            MessageBox.Show("Please Enter A Breed");
                        }
                        else if (Model.UpdateLitterAdvert(AdvertID, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), Convert.ToInt32(LitterSizeTxt.Text),
                            Convert.ToInt32(LitterAgeTxt.Text), true, LitterBreedOne, ""))
                        {
                            this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                            this.Close();
                        }
                    }
                    else if (LitterNoRadBttn.Checked)
                    {
                        string LitterBreedOne = this.CatLNOneComboBox.GetItemText(this.CatLNOneComboBox.SelectedItem);
                        string LitterBreedTwo = this.CatLNTwoComboBox.GetItemText(this.CatLNTwoComboBox.SelectedItem);
                        if (string.IsNullOrEmpty(LitterSizeTxt.Text))
                        {
                            MessageBox.Show("Please Enter Litter Size");
                        }
                        else if (string.IsNullOrEmpty(LitterAgeTxt.Text))
                        {
                            MessageBox.Show("Please Enter Litter Age");
                        }
                        else if (string.IsNullOrEmpty(LitterBreedOne))
                        {
                            MessageBox.Show("Please Enter A Breed");
                        }
                        else if (string.IsNullOrEmpty(LitterBreedTwo))
                        {
                            MessageBox.Show("Please Enter A 2nd Breed");
                        }
                        else if (Model.UpdateLitterAdvert(AdvertID, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), Convert.ToInt32(LitterSizeTxt.Text),
                            Convert.ToInt32(LitterAgeTxt.Text), false, LitterBreedOne, LitterBreedTwo))
                        {
                            this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void LitterBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void GABackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void FABackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void DogBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void HorseBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void AccessBackBttn_Click(object sender, EventArgs e)
        {
            IntroPanel.Visible = true;

            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            HorsePanel.Visible = false;
            DogPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }

        private void AccessCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AccessCat = this.AccessCatComboBox.GetItemText(this.AccessCatComboBox.SelectedItem);
            switch (AccessCat.Trim())
            {
                case "Health":
                    AccessTypeComboBox.Items.Clear();
                    AccessTypeComboBox.Items.Add("Supplements");
                    AccessTypeComboBox.Items.Add("Medication");
                    AccessTypeComboBox.Items.Add("Other");
                    break;
                case "Bedding":
                    AccessTypeComboBox.Items.Clear();
                    AccessTypeComboBox.Items.Add("Tanks and Enclosures");
                    AccessTypeComboBox.Items.Add("Kennels");
                    AccessTypeComboBox.Items.Add("Small Animals");
                    AccessTypeComboBox.Items.Add("Other");
                    break;
                case "Cleaning":
                    AccessTypeComboBox.Items.Clear();
                    AccessTypeComboBox.Items.Add("Tanks and Enclosures");
                    AccessTypeComboBox.Items.Add("Shampoos");
                    AccessTypeComboBox.Items.Add("Other");
                    break;
                case "Other":
                    AccessTypeComboBox.Items.Clear();
                    AccessTypeComboBox.Items.Add("Horse Riding");
                    AccessTypeComboBox.Items.Add("Aquariums");
                    AccessTypeComboBox.Items.Add("Clothing");
                    AccessTypeComboBox.Items.Add("Other");
                    break;
            }
        }

        private void HorseConfirmBttn_Click(object sender, EventArgs e)
        {
            string HorseGender = this.HorseGenderComboBox.GetItemText(this.HorseGenderComboBox.SelectedItem);
            string HorseBreed = this.HorseBreedComboBox.GetItemText(this.HorseBreedComboBox.SelectedItem);
            if (string.IsNullOrEmpty(HorseNameTxt.Text))
            {
                MessageBox.Show("Please Enter Horse Name");
            }
            else if (string.IsNullOrEmpty(HorseAgeTxt.Text))
            {
                MessageBox.Show("Please Enter Horse Age");
            }
            else if (string.IsNullOrEmpty(HorseGender))
            {
                MessageBox.Show("Please Choose Horse Gender");
            }
            else if (string.IsNullOrEmpty(HorseBreed))
            {
                MessageBox.Show("Please Choose Horse Breed");
            }
            else if (string.IsNullOrEmpty(HorseSizeTxt.Text))
            {
                MessageBox.Show("Please Enter Horse Size");
            }
            else if (BrokenYesRadBttn.Checked && BrokenNoRadBttn.Checked)
            {
                MessageBox.Show("Please Check If Horse Is Broken");
            }
            else if (string.IsNullOrEmpty(HorsePurposeTxt.Text))
            {
                MessageBox.Show("Please Enter Purpose");
            }
            else if(BrokenYesRadBttn.Checked)
            {
                if(Model.UpdateHorseAdvert(AdvertID,TitleTxt.Text,DescriptionTxt.Text,Convert.ToDouble(PriceTxt.Text),HorseNameTxt.Text,
                    Convert.ToInt32(HorseAgeTxt.Text),HorseGender,HorseSizeTxt.Text,true,HorseBreed,FAPurposeTxt.Text))
                {
                    this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                    this.Close();
                }
            }
            else if(BrokenNoRadBttn.Checked)
            {
                if (Model.UpdateHorseAdvert(AdvertID, TitleTxt.Text, DescriptionTxt.Text, Convert.ToDouble(PriceTxt.Text), HorseNameTxt.Text,
                   Convert.ToInt32(HorseAgeTxt.Text), HorseGender, HorseSizeTxt.Text, false, HorseBreed, FAPurposeTxt.Text))
                {
                    this.Alert("#" + AdvertID + " Updated", Form_Alert.enmType.Success);
                    this.Close();
                }
            }
        }
    }
}
