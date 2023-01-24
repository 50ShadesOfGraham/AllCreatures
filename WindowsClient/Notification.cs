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
    public partial class Notification : UserControl
    {
        private bool open = false;
        Notifications notif;
        public Notification(Notifications notif)
        {
            InitializeComponent();
            this.notif = notif;
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            NotifHide();
            NotifTitleBttn.Text = notif.Title;
            MessageTxt.Text = notif.Message;
        }

        private void NotifTitleBttn_Click(object sender, EventArgs e)
        {
            if(open)
            {
                NotifShow();
                open = false;
            }
            else
            {
                NotifHide();
                open = true;
            }
        }

        public void NotifHide()
        {
            this.Height = 87;
        }
        public void NotifShow()
        {
            this.Height = 352;
        }
    }
}
