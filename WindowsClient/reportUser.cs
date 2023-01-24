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

                var check = 0; // check to see if user email is in the list
                foreach (User user in model.UserList)
                {
                    //txtUser.Text = user.Email;
                    
                    if (txtUser.Text.Equals(user.Email.Trim()))
                    {
                        model.addNewReportS(txtUser.Text, comboReason.Text, DateTime.Now, txtDesc.Text);
                        check = 1;
                      //  MessageBox.Show(comboReason.Text);
                        MessageBox.Show("Report Submitted");

                    }

                    //else  //if(txtUser.Text != user.Email)//if (model.addNewReportS(txtUser.Text, comboReason.Text, DateTime.Now, txtDesc.Text))
                    //{
                        
                    //    //
                    //    //listboxReason.Text = S

                    //}

                }
                if(check == 0)
                {
                    MessageBox.Show("Not a valid Username");
                }
               
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
            //MessageBox.Show("Test");
            
        }
    }
}
