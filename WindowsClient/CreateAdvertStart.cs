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
    public partial class CreateAdvertStart : Form
    {
        private IModel Model;
        public CreateAdvertStart(IModel model)
        {
            InitializeComponent();
            this.Model = model;
        }

        private void CreateAdvertStart_Load(object sender, EventArgs e)
        {
            BundlePanel.Visible = false;
            AdvertisementPanel.Visible = false;
        }

        private void AdBundleComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AdBundleComboBx.SelectedIndex == 0)
            {
                AdvertisementPanel.Visible = true;
                BundlePanel.Visible = false;
            }
            else if(AdBundleComboBx.SelectedIndex == 1)
            {
                BundlePanel.Visible = true;

            }
        }

        private void AdvertBttn_Click(object sender, EventArgs e)
        {
        //b   Bundle bundle = new Bundle();
            CreateOneAdvert advertisement = new CreateOneAdvert(Model,0,0,0,0,false,0.00,0);
            advertisement.Show();
            this.Hide();
        }

        private void BundleBttn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int bundleID = 0;
            int ItemOne = 0;
            int ItemTwo = 0;
            int ItemThree = 0;
            do { ItemOne = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(ItemOne));
            do { ItemTwo = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(ItemTwo) && ItemTwo != ItemOne);
            do { ItemThree = rnd.Next(0, 99999); } while (Model.AdvertIDPresent(ItemThree) && ItemThree != ItemOne && ItemThree != ItemTwo);
            //do { bundleID = rnd.Next(0, 99999); } while (Model.BundleIDPresent(bundleID));
            bundleID = rnd.Next(0, 99999);
            if(NoOfItemsComboBx.SelectedIndex.Equals(0))
            {
                CreateOneAdvert _advertisement = new CreateOneAdvert(Model, bundleID, ItemOne, ItemTwo,0,true,Convert.ToDouble(BundlePriceTextBox.Text),2);
                _advertisement.Show();
                this.Hide();
            }

            if(NoOfItemsComboBx.SelectedIndex.Equals(1))
            {
                CreateOneAdvert _advertisement = new CreateOneAdvert(Model, bundleID, ItemOne, ItemTwo, ItemThree, true, Convert.ToDouble(BundlePriceTextBox.Text),3);
                _advertisement.Show();
                this.Hide();
            }
            
        }

        private void NoOfItemsComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BundlePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(BundlePriceTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter A Valid Price");
                BundlePriceTextBox.Text = BundlePriceTextBox.Text.Remove(BundlePriceTextBox.Text.Length - 1);
            }
        }
    }
}
