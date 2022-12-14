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
    public partial class UserRejectReason : Form
    {
        public UserRejectReason()
        {
            InitializeComponent();
        }
        public string RejectReason { get; set; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.RejectReason = txtReason.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
