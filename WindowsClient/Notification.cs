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
        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        { 
            this.Height = 121;
        }

        private void NotifTitleBttn_Click(object sender, EventArgs e)
        {
            if(open)
            {
                this.Height = 352;
                open = false;
            }
            else
            {
                this.Height = 87;
                open = true;
            }
        }
    }
}
