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
    public partial class Form_LandingPage : Form
    {
        private IModel Model;
        public Form_LandingPage(IModel Model)
        {
            InitializeComponent();
            this.Model= Model;
            this.TopLevel = false;
        }

        private void PlaceAdvertBttn_Click(object sender, EventArgs e)
        {
            CreateAdvertStart createAd = new CreateAdvertStart(Model);
            createAd.Show();
        }

        private void SellLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAdvertStart createAd = new CreateAdvertStart(Model);
            createAd.Show();
        }
    }
}
