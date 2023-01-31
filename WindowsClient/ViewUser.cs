using BusinessLayer;
using BusinessEntities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using WindowsClient;

namespace WindowsClient
{
    public partial class ViewUser : UserControl
    {
        #region Instance Attributes
        //private ACGSContainer container;
        private IModel Model;

        public ViewUser()
        {
            InitializeComponent();
        }
        #endregion
        public ViewUser(IModel Model)
        {
            this.Model = Model;
        }

        public void SetLabel(String FirstName, String LastName, String Email, String Password, String UserType)
        {
            //don't duplicate the function, but how to access to another class. 
            label1.Text = FirstName;
            label2.Text = LastName;
            label3.Text = Email;
            label4.Text = Password;
            label5.Text = UserType;
        }

        public void EditAdmin(String UserType)
        {
            foreach (User u in Model.UserList)
            {
                Model.editUser(u);
            }
        }
        private void CreateAdmin_Click(object sender, EventArgs e)
        {
            CreateAdmin ca = new CreateAdmin(Model);
            ca.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}