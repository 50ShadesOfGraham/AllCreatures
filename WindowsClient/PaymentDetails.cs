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
    public partial class PaymentDetails : Form
    {
        //private PaymentDetails PaymentDetails;
        private IModel Model;
        public PaymentDetails(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;
        }

        private void PaymentDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
