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
using System.Windows.Forms.VisualStyles;

namespace WindowsClient
{
    public partial class ViewMyPurchase : UserControl
    {
        #region Instance Attributes
        //private ACGSContainer container;
        private IModel Model;
        #endregion
        public ViewMyPurchase(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        public void SetLabelFromDIffTable(String Title, String Description, Double Price)
        {
            int numOfAds = 0;

            foreach (Advertisement advertisement in Model.AdvertList)
            {
                numOfAds++;
            }

            labelNumber.Text = String.Format("No. {0}", numOfAds);
        }
    }
}
