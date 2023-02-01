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

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
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
            foreach (Dog u in Model.AdvertList)
            {
                MessageBox.Show("Advertisement:" + u.AdvertID);
                ViewAds ads = new ViewAds(Model,u);
                ads.SetLabel(u.Title, u.SellerEmail, u.Price.ToString()); //function
                FlowLayout.Controls.Add(ads);
            }
        }

        private void CatBttn_Click(object sender, EventArgs e)
        {
            //FlowLayout.Controls.Clear();  //testing git changes

            foreach (User u in Model.UserList)
            {
                //ViewAds ads = new ViewAds();
                //ads.SetLabel(u.FirstName, u.LastName, u.Email, u.Password, u.UserType); //function
                //FlowLayout.Controls.Add(ads);
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT AdvertID FROM AccessoriesAdvertisement,Bundle,DogAdvertisement,FarmAnimalAdvertisement,FoodAdvertisement,GenericAnimalAdvertisement,HorseAdvertisement WHERE Title LIKE '%'" + searchBox.Text.Trim() + "'%'";


            FlowLayout.Controls.Clear();

            //foreach (User u in Model.UserList)
            //{
            //    ViewAds ads = new ViewAds(query);
            //    ads.SetLabel(u.FirstName, u.LastName, u.Email, u.Password, u.UserType); //function
            //    FlowLayout.Controls.Add(ads);
            //}

            foreach (Accessories access in Model.AdvertList.OfType<Accessories>())
            {
                if (access.AdvertID.Equals(query))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + access.AdvertID);
                    ViewAds ads = new ViewAds(Model, access);
                    ads.SetLabel(access.Title, access.SellerEmail, access.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (Food fo in Model.AdvertList.OfType<Food>())
            {
                if (fo.AdvertID.Equals(query))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + fo.AdvertID);
                    ViewAds ads = new ViewAds(Model, fo);
                    ads.SetLabel(fo.Title, fo.SellerEmail, fo.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (Dog doggo in Model.AdvertList.OfType<Dog>())
            {
                if (doggo.AdvertID.Equals(query))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + doggo.AdvertID);
                    ViewAds ads = new ViewAds(Model, doggo);
                    ads.SetLabel(doggo.Title, doggo.SellerEmail, doggo.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (Horse pony in Model.AdvertList.OfType<Horse>())
            {
                if (pony.AdvertID.Equals(query))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + pony.AdvertID);
                    ViewAds ads = new ViewAds(Model, pony);
                    ads.SetLabel(pony.Title, pony.SellerEmail, pony.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (FarmAnimal FA in Model.AdvertList.OfType<FarmAnimal>())
            {
                if (FA.AdvertID.Equals(query))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + FA.AdvertID);
                    ViewAds ads = new ViewAds(Model, FA);
                    ads.SetLabel(FA.Title, FA.SellerEmail, FA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (GenericAnimal GA in Model.AdvertList.OfType<GenericAnimal>())
            {
                if (GA.AdvertID.Equals(query))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + GA.AdvertID);
                    ViewAds ads = new ViewAds(Model, GA);
                    ads.SetLabel(GA.Title, GA.SellerEmail, GA.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
            foreach (Litter lttr in Model.AdvertList.OfType<Litter>())
            {
                if (lttr.AdvertID.Equals(query))
                {
                    System.Windows.Forms.MessageBox.Show("Advertisement:" + lttr.AdvertID);
                    ViewAds ads = new ViewAds(Model, lttr);
                    ads.SetLabel(lttr.Title, lttr.SellerEmail, lttr.Price.ToString()); //function
                    FlowLayout.Controls.Add(ads);
                }
            }
        }
    }
}
