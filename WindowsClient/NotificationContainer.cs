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
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class NotificationContainer : Form
    {
        private IModel Model;
        public NotificationContainer(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            this.Text = Model.getUserNameCurrentuser().Trim() + " Notifications";

        }

        private void NotificationContainer_Load(object sender, EventArgs e)
        {
           foreach(Notifications notif in Model.NotificationList)
            {
                Notification m = new Notification();
                m.Width = 892;
                m.SetHeader(notif.Title.Trim(),notif.Messagetime.ToString().Trim());
                panel.Controls.Add(m);
            }
        }
    }
}
