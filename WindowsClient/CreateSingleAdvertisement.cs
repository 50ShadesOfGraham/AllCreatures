using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Xceed.Wpf.AvalonDock.Controls;

namespace WindowsClient
{
    public partial class CreateSingleAdvertisement : Form
    {

        private IModel Model;
        private bool isBundle;
        private int NoItems;
        private double BundlePrice;
        private int BundleID;
        private int ItemNoOne;
        private int ItemNoTwo;
        private int ItemNoThree;
        public CreateSingleAdvertisement(IModel _model,int BundleID, int ItemOne, int ItemTwo, int ItemThree, bool isBundle, double BundlePrice,int NoItems)
        {
            InitializeComponent();
            this.Model = _model;
            this.isBundle = isBundle;
            this.BundleID = BundleID;
            this.ItemNoOne = ItemOne;
            this.ItemNoTwo = ItemTwo;
            this.ItemNoThree = ItemThree;

            if (isBundle.Equals(true))
            {
                this.NoItems = NoItems;
            }
            this.BundlePrice = BundlePrice;
        }

        private void CreateSingleAdvertisement_Load(object sender, EventArgs e)
        {

        }
    }
}
