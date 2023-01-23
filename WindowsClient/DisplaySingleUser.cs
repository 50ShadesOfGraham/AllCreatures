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

namespace WindowsClient
{
    public partial class DisplaySingleUser : Form
    {
        IModel Model;
        public DisplaySingleUser(IModel Model)
        {
            InitializeComponent();
           this.Model = Model;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplaySingleUser_Load(object sender, EventArgs e)
        {
            
            
            foreach (User user in Model.UserList)
            {
              //  if(user.Email.s)
                txtFname.Text = user.FirstName;
                txtLname.Text = user.LastName;

            }



        }

        private void btnBan_Click(object sender, EventArgs e)
        {

        }
    }
}
