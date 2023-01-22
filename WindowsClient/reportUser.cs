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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsClient
{
    public partial class reportUser : Form
    {
        IModel model;
        public reportUser(IModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
              /*foreach(User user in model.UserList)
                {
                    if (txtUser.Text != user.Email)
                    {
                        MessageBox.Show("Not a valid Username");
                    }
                    else */
                if (model.addNewReportS(txtUser.Text, comboReason.Text, DateTime.Now, txtDesc.Text))
                    {

                        //
                        //listboxReason.Text = S
                        MessageBox.Show(comboReason.Text);
                        MessageBox.Show("Report Submitted");
                    }
                //}
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
            //MessageBox.Show("Test");
            
        }
    }
}
