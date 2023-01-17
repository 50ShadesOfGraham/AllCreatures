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
        public FlowLayoutPanel FlowLayoutPanel;
        public Notification(FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            this.FlowLayoutPanel = flowLayoutPanel;
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            this.Width = FlowLayoutPanel.Width;
            NotificationHeaderBttn.Size = new Size(FlowLayoutPanel.Width, 120);
            MessageTextBox.Width = this.Width;
            this.Height = 121;
        }

        public void SetHeader(string text, string textTwo)
        {
            NotificationHeaderBttn.Text = text;
            NotificationHeaderBttn.Text += "\t\t\t\t " + textTwo;
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
