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
            this.Text = Model.getUserNameCurrentuser() + " Notifications";
        }

        private void NotificationContainer_Load(object sender, EventArgs e)
        {
            List<Notifications> sortedDates = new List<Notifications>();

            sortedDates = Model.NotificationList.OrderBy(x => x.Messagetime).ToList();

            foreach (Notifications n in sortedDates) 
            {
                SingleNotification notif = new SingleNotification(n);
                notif.Show();

                this.Controls.Add(notif);
            }
        }
    }
}
