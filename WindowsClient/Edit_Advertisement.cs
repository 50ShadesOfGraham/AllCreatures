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
    public partial class Edit_Advertisement : Form
    {
        private Advertisement advert;
        private IModel Model;
        public Edit_Advertisement(IModel Model,Advertisement advert)
        {
            InitializeComponent();
            this.Model = Model;
            this.advert = advert;
        }

        private void Edit_Advertisement_Load(object sender, EventArgs e)
        {
            FoodPanel.Visible = false;
            AccessPanel.Visible = false;
            AnimalPanel.Visible = false;
            TitleTxtBox.Text = advert.Title.Trim();
            PriceTxtBx.Text = advert.Price.ToString();
            DescriptionTxtBx.Text = advert.Description.Trim();
            switch(advert.GetClass().Trim())
            {
                case "Food":
                    FoodPanel.Visible = true;
                    break;
                case "Accessories":
                    AccessPanel.Visible = true;
                    break;
                default:
                    AnimalPanel.Visible = true;
                    break;
            }
        }
    }
}
