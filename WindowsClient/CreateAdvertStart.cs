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
            CreateSingleAdvertisement advertisement = new CreateSingleAdvertisement(Model);
            advertisement.Show();
        }

        private void BundleBttn_Click(object sender, EventArgs e)
        {

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
