using BusinessLayer;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class CreateAdmin : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion
        public CreateAdmin(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;
        }

        private void CAbtn_Click(object sender, EventArgs e)
        {
            foreach (User u in Model.UserList)
            {
                if (u.Email == listBoxUsers.SelectedItem.ToString())
                {
                    u.Email = textBoxEmail.Text;
                    u.UserType = textBoxUT.Text;
                    Model.editUser(u);
                }

                if (u.Email == listBoxUsers.SelectedItem.ToString())
                {
                    u.Email = textBoxEmail.Text;
                    u.UserType = textBoxUT.Text;
                }

                else
                {
                    MessageBox.Show("The text box should not be empty!");
                }
            }
            textBoxEmail.Text = "";
            textBoxUT.Text = "";
        }

        private void CreateAdmin_Load(object sender, EventArgs e)
        {
            //only display email from user, not admin, how?
            foreach (User u in Model.UserList)
            {
                listBoxUsers.Items.Add(u.Email);
            }
        }

        private void listBoxUsers_DoubleClick(object sender, EventArgs e)
        {
            //when the following user has been selected.
            textBoxEmail.Text = listBoxUsers.SelectedItem.ToString();

            foreach (User u in Model.UserList)
            {
                if (u.Email == textBoxEmail.Text)
                {
                    textBoxUT.Text = u.UserType;
                }
            }
        }

        private void bbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}