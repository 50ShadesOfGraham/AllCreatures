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
    public partial class CreateSingleAdvertisement : Form
    {

        private IModel Model;
        public CreateSingleAdvertisement(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }
        private void FoodPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AnimalCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AnimalCatComboBox.SelectedItem.Equals("Other"))
            {
                AnimalTypePanel.Visible = false;
                SpecifyPanel.Visible = true;
                GenericAnimalPanel.Visible = true;
            }
            else
            {
                AnimalTypePanel.Visible = true;
                SpecifyPanel.Visible = false;
                if()
            }
        }

        private void CreateSingleAdvertisement_Load(object sender, EventArgs e)
        {
            GeneralAdvertPanel.Visible = true;
            
            AnimalPanel.Visible = false;
            FoodPanel.Visible = false;
            AccessPanel.Visible = false;

            AnimalCatPanel.Visible = true;
            AnimalTypePanel.Visible = true;
            SpecifyPanel.Visible = false;

            DogPanel.Visible = false;
            HorsePanel.Visible = false;
            GenericAnimalPanel.Visible = false;
            FarmAnimalPanel.Visible = false;
            LitterPanel.Visible = false;
        }
    }
}
