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
        private bool show = true;
        public NotificationContainer(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            this.Text = Model.getUserNameCurrentuser().Trim() + " Notifications";

        }
        private void NotificationContainer_Load(object sender, EventArgs e)
        {
            List<Notifications> organisedlist = Model.NotificationList.OrderBy(x => x.Messagetime).ToList();
            foreach(Notifications notif in organisedlist)
            {
                Notification notifCard = new Notification(notif);
                this.Controls.Add(notifCard);
                notifCard.Dock = DockStyle.Top;
            }

        }
    }
}
