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
    public partial class AdminIndex : Form
    {
        #region Instance Attributes
        //private ACGSContainer container;
        private IModel Model;
        #endregion
        public AdminIndex(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
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

        private void AnimalBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(AnimalPanel);
        }

        private void HousePetBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(HousePetPanel);
        }

        private void FarmBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(FarmPanel);
        }

        private void ReptileBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(ReptilePanel);
        }

        private void FoodBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(FoodPanel);
        }

        private void HousePetFoodBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(HousePetFoodPanel);
        }

        private void FarmFoodBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(FarmFoodPanel);
        }

        private void ReptileFoodBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(ReptileFoodPanel);
        }

        private void AccessBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(AccessPanel);
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

        private void UsersBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(UserPanel);
        }

        private void ReportsBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(ReportPanel);
        }

        private void AdminIndex_Load(object sender, EventArgs e)
        {
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
            //Users Panel
            UserPanel.Visible = false;
            //Reports Panel
            ReportPanel.Visible = false;
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
                this.Alert("GoodBye ", Form_Alert.enmType.Leaving);
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

        private void verifyAdvertisementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verifyAdvertisements verifyAds = new verifyAdvertisements(Model);
            verifyAds.Show();
        }

        private void verifyAdsFood_Click(object sender, EventArgs e)
        {
            
        }

        private void verifyAdsAssessories_Click(object sender, EventArgs e)
        {
           
        }

        private void displayUsers_Click(object sender, EventArgs e)
        {
            DisplayUsers displayUsers = new DisplayUsers(Model);
            displayUsers.Show();
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verifiedBannedUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerifiedBannedUsers verifiedBannedUsers = new VerifiedBannedUsers(Model);
            verifiedBannedUsers.Show();
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
            string search = searchTxt.Text.Trim();
            Search(search);







        }
    }
}
