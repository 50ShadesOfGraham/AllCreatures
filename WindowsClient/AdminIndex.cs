using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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

            //View report by Anna
            ViewReportflowLayoutPanel.Visible = false;
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

        private void verifyAdvertisementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verifyAdvertisements verifyAds = new verifyAdvertisements(Model);
            verifyAds.Show();
        }

        private void displayUsers_Click(object sender, EventArgs e)
        {
            DisplayUsers displayUsers = new DisplayUsers(Model);
            displayUsers.Show();
        }
        //ANNA (direct user to create admin form)
        private void createAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAdmin ca = new CreateAdmin(Model);
            ca.Show();
        }

        private void NavBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void viewReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //View report Panel by Anna
            ViewReportflowLayoutPanel.Visible = true;

            if (ViewReportflowLayoutPanel.Visible == true)
            {
                FlowLayout.Controls.Clear();
                foreach (User u in Model.UserList)
                {
                   // Model.filterAds(u);
                    ViewReportedUser vru = new ViewReportedUser(Model);
                    vru.SetLabel(u.Email, u.Password, u.UserType);
                    FlowLayout.Controls.Add(vru);
                }
            }
        }

        private void ViewReportPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.Text = "Click Here";
            this.linkLabel1.AutoSize = true;


            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }
    }
}
