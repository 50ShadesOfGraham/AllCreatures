namespace ACGS
{
    public partial class UIndexForm : Form
    {
        public UIndexForm()
        {
            InitializeComponent();
            CustomizeDesign();
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

            if (AccessPanel.Visible == true)
            {
                AccessPanel.Visible = false;
                HousePetsAccessPanel.Visible = false;
                FarmAccessPanel.Visible = false;
                ReptileAccessPanel.Visible = false; 
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

        private void OtherBttn_Click(object sender, EventArgs e)
        {

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
    }
}