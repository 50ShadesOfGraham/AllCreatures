﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//need to add scroll bar

namespace WindowsClient
{
    public partial class ViewAds : UserControl
    {
        private string query;

        public ViewAds()
        {
            InitializeComponent();
        }

        public ViewAds(string query)
        {
            this.query = query;
        }

        public void SetLabel(String FirstName, String LastName,String Email, String Password, String UserType)
        {
           label1.Text = FirstName;
           label2.Text = LastName;
           label3.Text = Email;
           label4.Text = Password;
           label5.Text = UserType;
            
        }

        private void ViewAds_Load(object sender, EventArgs e)
        {

        }
    }
}
