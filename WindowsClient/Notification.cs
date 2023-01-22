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
        public static bool open = false;
        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        { 
            this.Height = 121;
        }

        public void SetHeader(string text, string textTwo)
        {
            NotificationHeaderBttn.Text = text;
            NotificationHeaderBttn.Text += "\t\t " + textTwo;
        }

        public void SetMessage(string text)
        {
            MessageTextBox.Text = text;
        }

        private void NotificationHeaderBttn_Click(object sender, EventArgs e)
        {
            if(!open)
            {
                this.Height = 412;
                open = true;
            }
            else
            {
                this.Height = 121;
                open = false;
            }
        }
    }
}
