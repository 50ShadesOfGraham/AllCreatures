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
    public partial class SingleNotification : Form
    {
        private Notifications notif;
        public SingleNotification(Notifications notif)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.notif = notif;
            TitleLbl.BackColor = Color.Transparent;
        }

        private void SingleNotification_Load(object sender, EventArgs e)
        {
            string time = notif.Messagetime.ToString().Trim();
            TitleLbl.Text = notif.Title;
            TimeLbl.Text = time;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TrashBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
