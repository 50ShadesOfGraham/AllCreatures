﻿using BusinessEntities;
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
            int counter = 0;
            foreach(Advertisement dog in Model.AdvertList)
            {
                counter++;
            }

            MessageBox.Show("Number of Ads: " + counter);

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

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Sign Out?",
               "Confirmation", MessageBoxButtons.YesNoCancel
               );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Good Bye, " + Model.getUserNameCurrentuser());
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
            //PlaceAdvertisement placeAd = new PlaceAdvertisement(Model);
            //placeAd.Show();
            CreateAdvertStart createAd = new CreateAdvertStart(Model);
            createAd.Show();
        }

        private void DogBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Dog");
        }

        private void CatBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Cat");
        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Notifications userNotifications = new User_Notifications(Model);
            userNotifications.Dock= DockStyle.Fill;
            userNotifications.Show();
            this.Controls.Add(userNotifications);
        }

        public void GetAdvertisements(String adverttype)
        {
            //FlowLayout.Controls.Clear();

            foreach (Advertisement u in Model.AdvertList)
            {
                //string advertType = u.GetClass().Trim();
                if (u.GetClass().Trim().Equals(adverttype))
                {
                    ViewAds ads = new ViewAds(Model, u);
                    ads.SetLabel(u.Title.Trim(), u.SellerEmail.Trim(), u.Price.ToString().Trim(), u.Status.Trim()); //function
                   // FlowLayout.Controls.Add(ads);
                }
            }
        }

        private void FishBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Fish");
        }

        private void SmallAnimalsBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Small Animals");
        }

        private void BirdsBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Birds");
        }

        private void RabbitBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Rabbit");
        }

        private void HorseBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Horse");
        }

        private void CowBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Cow");
        }

        private void PigBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Pig");
        }

        private void SheepBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Sheep");
            //GetAdvertisements("Goat");
        }

        private void ChickenBttn_Click(object sender, EventArgs e)
        {
            GetAdvertisements("Chicken");
        }
    }
}
