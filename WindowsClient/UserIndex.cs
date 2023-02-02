using BusinessEntities;
using BusinessLayer;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
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
using System.Windows.Input;

namespace WindowsClient
{
    public partial class UserIndex : Form
    {
        #region Instance Attributes
        //private ACGSContainer container;
        private IModel Model;
        #endregion
        public UserIndex(IModel Model)
        {
            InitializeComponent();
            //MdiParent = parent;
            //container = parent;
            this.Model = Model;
        }

        private void UserIndex_Load(object sender, EventArgs e)
        {
            Form_LandingPage intro = new Form_LandingPage(Model);
            FlowLayout.Controls.Add(intro);
            intro.Show();
            //Animal Panel
            AnimalPanel.Visible = false;
            HousePetPanel.Visible = false;
            FarmPanel.Visible = false;
            ReptilePanel.Visible = false;
            //Food Panel
            FoodPanel.Visible = false;
            HousePetFoodPanel.Visible = false;
            FarmFoodPanel.Visible = false;
            ReptileFoodPanel.Visible = false;
            //Accessories Panel
            AccessPanel.Visible = false;
            CleaningPanel.Visible = false;
            BeddingPanel.Visible = false;
            HealthPanel.Visible = false;
            OtherAccessPanel.Visible = false;

            //Product productform = new Product(this, Model) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            
            foreach(User u in Model.UserList)
            {
                Product product = new Product();
                product.SetLabel(u.FirstName);
                //FlowLayout.Controls.Add(product);
                product = new Product();
            }
        }


        private void hideSubMenu()
        {
            if (AnimalPanel.Visible == true)
            {
                AnimalPanel.Visible = false;
                HousePetPanel.Visible = false;
                FarmPanel.Visible = false;
                ReptilePanel.Visible = false;
            }

            if(FoodPanel.Visible == true)
            {
                FoodPanel.Visible = false;
                HousePetFoodPanel.Visible = false;
                FarmFoodPanel.Visible = false;
                ReptileFoodPanel.Visible = false;
            }
        }

        private void showSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                //hideSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }
        public void Alert(string message, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(message, type);
        }

       /* private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Sign Out?",
               "Confirmation", MessageBoxButtons.YesNoCancel
               );

            if (result == DialogResult.Yes)
            {
                this.Alert("GoodBye", Form_Alert.enmType.Leaving);
                Hide();
                SignIn signin = new SignIn(Model);
                signin.Show();
                //System.Windows.Forms.Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Cancel signout");
            }
        }*/

        private void AnimalBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(AnimalPanel);
            //hideSubMenu();
        }

        private void HousePetBttn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(HousePetPanel);
            //CloseOtherSubPanels();
        }

        private void FarmBttn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(FarmPanel);
            //CloseOtherSubPanels();
        }

        private void ReptileBttn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(ReptilePanel);
            //CloseOtherSubPanels();
        }

        private void OtherBttn_Click(object sender, EventArgs e)
        {

        }

        private void ReptileFoodPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FoodBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(FoodPanel);
            //CloseOtherSubPanels();
        }

        private void HousePetFoodBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(HousePetFoodPanel);
            //CloseOtherSubPanels();
        }

        private void FarmFoodBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(FarmFoodPanel);
            //CloseOtherSubPanels();
        }

        private void ReptileFoodBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(ReptileFoodPanel);
            //CloseOtherSubPanels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(AccessPanel);
        }

        private void AccessPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HealthBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(HealthPanel);
        }

        private void BeddingBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(BeddingPanel);
        }

        private void CleaningBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(CleaningPanel);
        }

        private void OtherAccessBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(OtherAccessPanel);
        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void placeAdvertisementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAdvertStart createAd = new CreateAdvertStart(Model);
            createAd.Show();
        }

        private void DogBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            foreach (Dog dog in Model.AdvertList.OfType<Dog>())
            {
                MessageBox.Show("Advertisement:" + dog.AdvertID);
                ViewAds ads = new ViewAds(Model, dog);
                ads.SetLabel(dog.Title, dog.SellerEmail, dog.Price.ToString()); //function
                FlowLayout.Controls.Add(ads);
            }
        }

        private void CatBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "cat";
            foreach (GenericAnimal GA in Model.AdvertList.OfType<GenericAnimal>())
            {
                if (GA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotificationContainer userNotifications = new NotificationContainer(Model);
            userNotifications.Show();
        }

        private void reportUser_Click(object sender, EventArgs e)
        {
            reportUser reportuser = new reportUser(Model);
            reportuser.Show();
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount(Model);
            editAccount.Show();
        }

        private void ReportUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportUser reportuser = new reportUser(Model);
            reportuser.Show();
        }

        private void myAdvertisementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyAdvertisements myadverts = new MyAdvertisements(Model);
            myadverts.Show();
        }

        private void Search(string search)
        {
            FlowLayout.Controls.Clear();
            List<Advertisement> advertisements = Model.AdvertList;
            foreach(Dog dog in advertisements.OfType<Dog>())
            {
                if(dog.Title.ToLower().Contains(search.ToLower()))
                {
                    MessageBox.Show("Advertisement:" + dog.AdvertID);
                    ViewAds ads = new ViewAds(Model, dog);
                    ads.SetLabel(dog.Title, dog.SellerEmail, dog.Price.ToString()); //function
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
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string search = searchBox.Text.Trim();
            Search(search);
            






        }

        private void FishBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "fish";
            foreach (GenericAnimal GA in Model.AdvertList.OfType<GenericAnimal>())
            {
                if (GA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void SmallAnimalsBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "small";
            foreach (GenericAnimal GA in Model.AdvertList.OfType<GenericAnimal>())
            {
                if (GA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void BirdsBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "bird";
            foreach (GenericAnimal GA in Model.AdvertList.OfType<GenericAnimal>())
            {
                if (GA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void RabbitBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "rabbit";
            foreach (GenericAnimal GA in Model.AdvertList.OfType<GenericAnimal>())
            {
                if (GA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void HorseBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            foreach (Horse horse in Model.AdvertList.OfType<Horse>())
            {
                MessageBox.Show("Advertisement:" + horse.AdvertID);
                ViewAds ads = new ViewAds(Model, horse);
                ads.SetLabel(horse.Title, horse.SellerEmail, horse.Price.ToString()); //function
                FlowLayout.Controls.Add(ads);
            }
        }

        private void CowBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "cow";
            foreach (FarmAnimal fA in Model.AdvertList.OfType<FarmAnimal>())
            {
                if (fA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + fA.AdvertID);
                    ViewAds ads = new ViewAds(Model, fA);
                    ads.SetLabel(fA.Title, fA.SellerEmail, fA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void PigBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "pig";
            foreach (FarmAnimal fA in Model.AdvertList.OfType<FarmAnimal>())
            {
                if (fA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + fA.AdvertID);
                    ViewAds ads = new ViewAds(Model, fA);
                    ads.SetLabel(fA.Title, fA.SellerEmail, fA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void SheepBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "sheep";
            foreach (FarmAnimal fA in Model.AdvertList.OfType<FarmAnimal>())
            {
                if (fA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + fA.AdvertID);
                    ViewAds ads = new ViewAds(Model, fA);
                    ads.SetLabel(fA.Title, fA.SellerEmail, fA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void ChickenBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "chicken";
            foreach (FarmAnimal fA in Model.AdvertList.OfType<FarmAnimal>())
            {
                if (fA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + fA.AdvertID);
                    ViewAds ads = new ViewAds(Model, fA);
                    ads.SetLabel(fA.Title, fA.SellerEmail, fA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void SnakeBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "snake";
            foreach (GenericAnimal GA in Model.AdvertList.OfType<GenericAnimal>())
            {
                if (GA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void LizardBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "lizard";
            foreach (GenericAnimal GA in Model.AdvertList.OfType<GenericAnimal>())
            {
                if (GA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void TurtleBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "turtle";
            foreach (GenericAnimal GA in Model.AdvertList.OfType<GenericAnimal>())
            {
                if (GA.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

       // --------------------------------------------------------- FOOD  -----------------------------------------------------------------------
        private void DogFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "dog";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void CatFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "cat";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void FishFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "fish";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void SmallAnimalFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "small";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        //ToolStripmenu names have changed for some strange reason
        //Put code from former stripmenus into new menus -Darragh 

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //report user
            reportUser reportuser = new reportUser(Model);
            reportuser.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //editAccount
            EditAccount editAccount = new EditAccount(Model);
            editAccount.Show();
        }

        private void myAdvertisements_Click(object sender, EventArgs e)
        {
            MyAdvertisements myadverts = new MyAdvertisements(Model);
            myadverts.Show();
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Sign Out?",
               "Confirmation", MessageBoxButtons.YesNoCancel
               );

            if (result == DialogResult.Yes)
            {
                this.Alert("GoodBye", Form_Alert.enmType.Leaving);
                Hide();
                SignIn signin = new SignIn(Model);
                signin.Show();
                //System.Windows.Forms.Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Cancel signout");
            }
        }

        private void placeAdvertisementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CreateAdvertStart createAd = new CreateAdvertStart(Model);
            createAd.Show();
        }

        private void notificationsMenu_Click(object sender, EventArgs e)
        {
            NotificationContainer userNotifications = new NotificationContainer(Model);
            userNotifications.Show();
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {
            
            /*UserIndex userIndex = new UserIndex(Model);
            userIndex.*/
            
        }

        private void BirdFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "bird";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void RabbitFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "rabbit";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void HorseFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "horse";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void CowFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "cat";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void PigFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "pig";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void ChickenFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "chicken";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void SheepFood_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "sheep";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                    ViewAds ads = new ViewAds(Model, food);
                    ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void DryReptileFood_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "reptile";
            string type = "dry";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    if (food.Details.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                        ViewAds ads = new ViewAds(Model, food);
                        ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        private void LiveReptileFood_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "reptile";
            string type = "live";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    if (food.Details.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                        ViewAds ads = new ViewAds(Model, food);
                        ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        private void FrozenReptileFoodBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "reptile";
            string type = "frozen";
            foreach (Food food in Model.AdvertList.OfType<Food>())
            {
                if (food.AnimalType.ToLower().Contains(search.ToLower()))
                {
                    if (food.Details.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + food.AdvertID);
                        ViewAds ads = new ViewAds(Model, food);
                        ads.SetLabel(food.Title, food.SellerEmail, food.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        //-------------------------- Accessories ----------------------------
        private void SupplementsBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "health";
            string type = "supplement";
            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AccessCategory.ToLower().Contains(search.ToLower()))
                {
                    if (access.SubAccessCategory.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                        ViewAds ads = new ViewAds(Model, access);
                        ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        private void MedicationBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "health";
            string type = "medication";
            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AccessCategory.ToLower().Contains(search.ToLower()))
                {
                    if (access.SubAccessCategory.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                        ViewAds ads = new ViewAds(Model, access);
                        ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        private void OtherHealthBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "health";
            string type = "other";
            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AccessCategory.ToLower().Contains(search.ToLower()))
                {
                    if (access.SubAccessCategory.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                        ViewAds ads = new ViewAds(Model, access);
                        ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        private void TanksBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "bedding";
            string type = "tanks";
            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AccessCategory.ToLower().Contains(search.ToLower()))
                {
                    if (access.SubAccessCategory.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                        ViewAds ads = new ViewAds(Model, access);
                        ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        private void KennelsBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "bedding";
            string type = "kennels";
            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AccessCategory.ToLower().Contains(search.ToLower()))
                {
                    if (access.SubAccessCategory.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                        ViewAds ads = new ViewAds(Model, access);
                        ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        private void CagesBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "bedding";
            string type = "cages";
            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AccessCategory.ToLower().Contains(search.ToLower()))
                {
                    if (access.SubAccessCategory.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                        ViewAds ads = new ViewAds(Model, access);
                        ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        private void OtherBeddingBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "bedding";
            string type = "other";
            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AccessCategory.ToLower().Contains(search.ToLower()))
                {
                    if (access.SubAccessCategory.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                        ViewAds ads = new ViewAds(Model, access);
                        ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        private void TankCleaningBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "cleaning";
            string type = "tank";
            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AccessCategory.ToLower().Contains(search.ToLower()))
                {
                    if (access.SubAccessCategory.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                        ViewAds ads = new ViewAds(Model, access);
                        ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }

        private void ShampooBttn_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            string search = "cleaning";
            string type = "shampoo";
            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AccessCategory.ToLower().Contains(search.ToLower()))
                {
                    if (access.SubAccessCategory.ToLower().Contains(type.ToLower()))
                    {
                        System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                        ViewAds ads = new ViewAds(Model, access);
                        ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                        FlowLayout.Controls.Add(ads);
                    }
                }
            }
        }
    }
}
