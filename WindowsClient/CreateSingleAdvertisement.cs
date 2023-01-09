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
        public CreateSingleAdvertisement()
        {
            InitializeComponent();
        }

        private void FoodPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
                GenericAnimalPanel.Visible = false;
            }
        }
    }
}
