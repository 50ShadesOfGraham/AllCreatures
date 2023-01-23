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
    public partial class DisplayUsers : Form
    {
        #region Instance Attributes
        //private ACGSContainer container;
        private IModel Model;
        #endregion
        public DisplayUsers(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            /*flowLayoutPanel1.Controls.Clear();
            foreach (User u in Model.UserList)
            {
                DisplayUserControl1 _users = new DisplayUserControl1(Model);
                _users.SetLabel(u.FirstName, u.LastName, u.Email); //function
                flowLayoutPanel1.Controls.Add(_users);
            }
*/
            foreach (User user in Model.UserList)
            {
                listUsers.Items.Add(user.Email);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void DisplayUsers_Load(object sender, EventArgs e)
        {

        }

        private void listUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmail.Text = listUsers.SelectedItem.ToString();
            foreach (User u in Model.UserList)
            {
                if (u.Email == txtEmail.Text)
                {
                    txtEmail.Text = u.Email;
                    txtFname.Text = u.FirstName;
                    txtLname.Text = u.LastName;
                    txtAddr1.Text = u.Address1;
                    txtAddr2.Text = u.Address2;
                    txtAddr3.Text = u.Address3;
                    txtCounty.Text = u.County;
                    txtEircode.Text = u.Eircode;
                    lblUserType.Text = u.UserType;
                    if(u.Verified == true)
                    {
                        lblVerified.Text = "Verified";
                    }
                    else
                    {
                        lblVerified.Text = "Unverified";
                    }
                }
            }
/*            txtEmail.Text = listUsers.SelectedItem.ToString();
            foreach (UserAddress user in Model.UserAddressList)
            {
                if (user.Email == txtEmail.Text)
                {
                    txtAddr1.Text = user.Address1;
                    txtAddr2.Text = user.Address2;
                    txtAddr3.Text = user.Address3;
                    txtEircode.Text = user.EirCode;

                }
            }
*/

        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            foreach(User user in Model.UserList)
            {
                if(user.Email == listUsers.SelectedItem.ToString())
                {
                    user.UserType = "Banned";
                    Model.banUserInDB(user);
                    MessageBox.Show("Success");
                }
            }

        }
    }
}
