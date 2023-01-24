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

        private void ProcessAllControls<T>(Control rootControl, Action<T> action) where T : Control
        {
            foreach (T childControl in rootControl.Controls.OfType<T>())
            {
                action(childControl);
            }
            foreach (Control childControl in rootControl.Controls)
            {
                ProcessAllControls<T>(childControl, action);
            }
        }
        private void NotificationContainer_Load(object sender, EventArgs e)
        {
 
            Button bttn = new Button();
            TextBox txt = new TextBox();
            this.Controls.Add(bttn);
            this.Controls.Add(txt);
            txt.Dock = DockStyle.Top;
            bttn.Dock = DockStyle.Top;
            bttn.Visible = true;
            bttn.Text = "Button";
            bttn.Height = 84;

        
   
            txt.Visible = true;
            
            txt.Multiline = true;
            txt.Height = 152;
            txt.Width = 892;
            txt.Text = "Hello World";
        }

        public void OpenTextBox(Button bttn, TextBox txt)
        {
            
        }

        public void ClickedButton(object sender,EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
        }
    }
}
