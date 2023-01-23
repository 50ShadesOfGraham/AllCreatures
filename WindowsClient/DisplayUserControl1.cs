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
    public partial class DisplayUserControl1 : UserControl
    {
        IModel Model;
        public DisplayUserControl1(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

     

        public void SetLabel(String FirstName, String LastName, String Email)
        {
            lblFirstName.Text = FirstName;
            lblLastName.Text = LastName;
            lblEmail.Text = Email;
            
        }

        private void DisplayUserControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplaySingleUser displaySingle = new DisplaySingleUser(Model);
            displaySingle.Show();
            Hide();
        }
    }
}
