﻿using BusinessLayer;
using BusinessEntities;
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
    public partial class UserNotifications : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion
        public UserNotifications(IModel model)
        {
            InitializeComponent();
            this.Model = model;
        }

        private void NotificationFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserNotifications_Load(object sender, EventArgs e)
        {
            int count = 0;
            NotificationFlowLayoutPanel.Controls.Clear();
            foreach (Notifications u in Model.NotificationList)
            {
                if(Model.CurrentUser.Email.Trim().Equals(u.UserEmail.Trim()))
                {
                    Notification notification = new Notification(NotificationFlowLayoutPanel);
                    notification.SetHeader(u.Title.Trim(),Convert.ToString(u.Messagetime));
                    notification.SetMessage(u.Title.Trim());
                    NotificationFlowLayoutPanel.Controls.Add(notification);
                }
            }

            MessageBox.Show("Number of Notifications:" + count);
        }
    }
}