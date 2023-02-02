using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class VerifiedBannedUsers : Form
    {
        private IModel Model;
        public VerifiedBannedUsers(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;

        }

        

        private void VerifiedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("SELECT useremail from Users WHERE Verified = @Verified");
            //cmd.Parameters.AddWithValue("@Verified", 1);
            //SqlDataReader dr = cmd.ExecuteReader();

            
            //foreach (User user in Model.UserList)
            //{
            //    while (dr.Read())
            //    {
            //        VerifiedList.Items.Add(user.Email);
            //    }
            //}

            List<User> user = Model.UserList;
            foreach (User u in user.OfType<User>())
            {
                if (u.Verified == true)
                {
                    
                    VerifiedList.Items.Add(u.Email);
                }
            }

           
        }


        private void BannedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("SELECT useremail from Users WHERE usertype = @usertype");
            //cmd.Parameters.AddWithValue("@usertype", "banned");
            //SqlDataReader dr = cmd.ExecuteReader();


            //foreach (User user in Model.UserList)
            //{
            //    while (dr.Read())
            //    {
            //        VerifiedList.Items.Add(user.Email);
            //    }
            //}

            List<User> user = Model.UserList;
            foreach (User u in user.OfType<User>())
            {
                if (u.Verified == false)
                {

                    VerifiedList.Items.Add(u.Email);
                }
            }
        }





    }
}
