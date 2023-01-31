using BusinessEntities;
using BusinessLayer;
using Microsoft.VisualBasic;
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
    //not yet view reported user
    //only display "User" (might solved after the reported db is solved)
    //verified the report
    //only delete the selected user account. 

    public partial class ViewReportedUser : UserControl
    {
        private IModel Model;
        public ViewReportedUser(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        //public void SetLabel(String reportUser, String reason, DateTime dateTime)
        //{
        //    label1.Text = reportUser;  
        //    label2.Text = reason;   
        //    label3.Text = dateTime.ToString();  
        //}

        public void SetLabel(String Email, String Password, String UserType)
        {
            label1.Text = Email;
            label2.Text = Password;
            label3.Text = UserType;
            label4.Text = "Not Yet Verify";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, EventArgs e)
        {

        }

        //delete account button click 
        private void button1_Click(object sender, EventArgs e)
        {
            string message, title, defaultValue;
            object myValue;

            //Set prompt
            message = "Please input the email of the deleted user account.";

            //Set title
            title = "Delete User Account.";

            //Set default value.
            defaultValue = "Please input here...";

            //Display Message,title, and default value
            myValue = Interaction.InputBox(message, title, defaultValue);

            //If user has clicked Cancel, set myValue to defaultValue
            if ((string)myValue == "")
            {
                myValue = defaultValue;
                Microsoft.VisualBasic.Interaction.MsgBox("Miss click?",
                    MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "C# MsgBox");
            }
            else
            {
                Interaction.MsgBox("Hello," + myValue.ToString() + "!"
                    + Environment.NewLine + "Nice to meet you!",
                    MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "C# MsgBox");
            }

            //foreach (User u in Model.UserList)
            //{
            //    if (u.Email == listBoxUsers.SelectedItem.ToString())
            //    {
            //        u.Email = textBoxEmail.Text;
            //        u.UserType = textBoxUT.Text;
            //        Model.editUser(u);
            //    }
            //}
            //textBoxEmail.Text = "";
            //textBoxUT.Text = "";
        }

        //verified button
        private void button2_Click(object sender, EventArgs e)
        {
            if (label4.Text.ToString() == "Report verifies")
            {
                MessageBox.Show("This report already verified!");
            }
            else
            {
                MessageBox.Show("Do You Want To Verifies this Report?");

                label4.Text = "Report verified";
                label4.Text.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
    
        }

        private void ViewReportedUser_Load(object sender, EventArgs e)
        {
          
        }
    }
}
