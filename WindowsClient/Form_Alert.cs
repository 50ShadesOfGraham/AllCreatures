using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsClient.Properties;

namespace WindowsClient
{
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
        }

        private void PopupCancelBttn_Click(object sender, EventArgs e)
        {
            timer1.Interval= 1;
            action = enmAction.close;
        }
        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info,
            Leaving
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }

        private void Form_Alert_Load(object sender, EventArgs e)
        {

        }

        private Form_Alert.enmAction action;
        private int x, y;
        //Animation
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X) { this.Left--; }
                    else 
                    { 
                        if(this.Opacity.Equals(1.0))
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity.Equals(0.0))
                    {
                        base.Close();
                    }
                    break;
            }
        }
        //
        public void showAlert(string msg,enmType type)
        {
            Color main = Color.FromArgb(119, 166, 247);
            this.Opacity= 0.00;
            this.StartPosition= FormStartPosition.Manual;
            string fName;
            
            for (int i = 0; i < 10; i++)
            {
                fName = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fName];
                if (i == 0)
                {
                    this.x = 1680;
                    this.y = 1050;
                }
                else
                {
                    if (frm == null)
                    {
                        this.Name = fName;
                        this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                        this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                        this.Location = new Point(this.x, this.y);
                        break;
                    }
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch(type)
            {
                case enmType.Success:
                    this.IconPictureBox.Image = Resources.success;
                    this.BackColor = main;
                    break;
                case enmType.Warning:
                    this.IconPictureBox.Image = Resources.warning;
                    this.BackColor = Color.Gold;
                    break;
                case enmType.Info:
                    this.IconPictureBox.Image= Resources.info;
                    this.BackColor = main;
                    break;
                case enmType.Error:
                    this.IconPictureBox.Image = Resources.error;
                    this.BackColor = Color.Red;
                    break;
                case enmType.Leaving:
                    this.IconPictureBox.Image = Resources.goodbye;
                    this.BackColor = main;
                    break;
            }

            this.MsgLbl.Text = msg;
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start(); 
        }
    }
}
