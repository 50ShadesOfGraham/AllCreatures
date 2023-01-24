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
    public partial class OneNotification : Form
    {
        private Notifications notif;
        public OneNotification(Notifications notif)
        {
            InitializeComponent();
            this.notif = notif;
            this.TopLevel = false;
        }

        private void OneNotification_Load(object sender, EventArgs e)
        {
            
        }
    }
}
