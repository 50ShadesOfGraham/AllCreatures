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
    public partial class BundleAdvert : Form
    {
        private BundleAdvert Advertisement;
        private IModel Model;
        public BundleAdvert(IModel _model)
        {
            InitializeComponent();  
            Model = _model;
        }
        public BundleAdvert()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            PaymentDetails paymentDetails = new PaymentDetails(Model);
            Hide();
            paymentDetails.Show();
        }
    }
}
