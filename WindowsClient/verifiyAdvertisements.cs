﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;
namespace WindowsClient
{
  
    public partial class verifiyAdvertisements : Form
    {
        IModel model;
        public verifiyAdvertisements(IModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void verifiyAdvertisements_Load(object sender, EventArgs e)
        {


         
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void descriptionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            foreach (Advertisement advertisement in model.AdvertList)
            {
                listAdverts.Items.Add(advertisement.SellerEmail);
            }
        }

        private void listAdverts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmail.Text = listAdverts.SelectedItem.ToString();
            foreach (Advertisement genericAnimal in model.AdvertList)
            {
                if (genericAnimal.SellerEmail == txtName.Text)
                    txtDescription.Text = genericAnimal.Description;

            }
        }
    }
}
