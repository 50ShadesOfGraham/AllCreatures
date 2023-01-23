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
using BusinessLayer;

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

<<<<<<< HEAD
        private void CreateAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing create admin");
=======
        private void verifyAdvertisementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           verifiyAdvertisements verifiyAdvertisements = new verifiyAdvertisements(Model);
            verifiyAdvertisements.Show();
        }

        private void DisplayUsers_Click(object sender, EventArgs e)
        {
            DisplayUsers displayUsers = new DisplayUsers(Model);
            displayUsers.Show();
>>>>>>> e7d557dffeb04aac35ae896ddfa40e116afc6717
        }

        private void verifyUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verifyUser verifyUser = new verifyUser(Model);
            verifyUser.Show();

        }

        private void verifiedBannedUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerifiedBannedUsers verifiedBannedUsers = new VerifiedBannedUsers(Model);
            verifiedBannedUsers.Show();
        }
    }
}
