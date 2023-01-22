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
    public partial class reportUser : Form
    {
        IModel model;
        public reportUser(IModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if(model.addNewReportS(txtUser.Text, listboxReason.Text, DateTime.Now, txtDescR.Text))
            {
                MessageBox.Show("Report Submitted");
            }
            
        }
    }
}
