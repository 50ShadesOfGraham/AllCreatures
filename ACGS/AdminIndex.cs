using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACGS
{
    public partial class AIndexForm : Form
    {
        public AIndexForm()
        {
            InitializeComponent();
        }

        private void CustomizeDesign()
        {
            AnimalMenu.Visible = false;
            HousePetPanel.Visible = false;
            FarmPanel.Visible = false;
            ReptilesPanel.Visible = false;
            FoodPanel.Visible = false;
            HousePetFoodPanel.Visible = false;
            FarmFoodPanel.Visible = false;
            ReptileFoodPanel.Visible = false;

            AccessPanel.Visible = false;
            HousePetsAccessPanel.Visible = false;
            FarmAccessPanel.Visible = false;
            ReptileAccessPanel.Visible = false;

            UserPanel.Visible = false;

            AdvertisementPanel.Visible = false;

        }

        private void hideSubMenu()
        {
            if (AnimalMenu.Visible == true)
            {
                AnimalMenu.Visible = false;
                HousePetPanel.Visible = false;
                FarmPanel.Visible = false;
                ReptilesPanel.Visible = false;
            }

            if (FoodPanel.Visible == true)
            {
                FoodPanel.Visible = false;
                HousePetFoodPanel.Visible = false;
                FarmFoodPanel.Visible = false;
                ReptileFoodPanel.Visible = false;
            }


            if(AccessPanel.Visible == true)
            {
                AccessPanel.Visible = false;
                HousePetsAccessPanel.Visible = false;
                FarmAccessPanel.Visible = false;
                ReptileAccessPanel.Visible = false;
            }

            
            if(UserPanel.Visible == true)
            {
                UserPanel.Visible = false;
            }

            if(AdvertPanel.Visible == true)
            {
                AdvertPanel.Visible = false;
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


        private void AnimalsBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(AnimalMenu);
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
            showSubMenu(ReptilesPanel);
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
            showSubMenu(ReptilesPanel);
        }

        private void AccessoriesBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(AccessPanel);
        }

        private void HousePetsAccess_Click(object sender, EventArgs e)
        {
            showSubMenu(HousePetsAccessPanel);
        }

        private void FarmAccessBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(FarmAccessPanel);
        }

        private void ReptileAccessBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(ReptileAccessPanel);
        }

        private void UserBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(UserPanel);
        }

        private void AdvertisementsBttn_Click(object sender, EventArgs e)
        {
            showSubMenu(AdvertisementPanel);
        }

        private void AIndexForm_Load(object sender, EventArgs e)
        {

        }

        private void BannedAdvertBttn_Click(object sender, EventArgs e)
        {

        }

        private void AdvertPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
