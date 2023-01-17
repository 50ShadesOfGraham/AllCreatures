using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class User_Notifications : Form
    {
        private IModel Model;
        public User_Notifications(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            this.TopLevel = false;
        }

        private void User_Notifications_Load(object sender, EventArgs e)
        {
            int count = 0;
            UserFlowLayout.Controls.Clear();
            foreach (Notifications u in Model.NotificationList)
            {
                if (Model.CurrentUser.Email.Trim().Equals(u.UserEmail.Trim()))
                {
                    Notification notification = new Notification(UserFlowLayout);
                    notification.SetHeader(u.Title.Trim(), Convert.ToString(u.Messagetime));
                    notification.SetMessage(u.Title.Trim());
                    UserFlowLayout.Controls.Add(notification);
                }
            }

            MessageBox.Show("Number of Notifications:" + count);
        }

        private void UserFlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
