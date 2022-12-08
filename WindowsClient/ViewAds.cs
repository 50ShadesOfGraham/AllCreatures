using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//need to add scroll bar

namespace WindowsClient
{
    public partial class ViewAds : UserControl
    {
        public ViewAds()
        {
            InitializeComponent();
        }


        public void SetLabel(String FirstName, String LastName,String Email, String Password, String UserType)
        {
           label1.Text = FirstName;
           label2.Text = LastName;
           label3.Text = Email;
           label4.Text = Password;
           label5.Text = UserType;
        }


    }
}
