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

namespace WindowsClient
{
    public partial class RegisterUser : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion 
        public RegisterUser(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;    
        }

        private void RegisterBttn_Click(object sender, EventArgs e)
        {
            if (Model.EmailPresent(Emailtxt.Text.Trim()))
            {
                MessageBox.Show("Email Already Exists\nPlease Try Again");
                Emailtxt.Text = "";
            }
            else
            {
                if (Passwordtxt.Text.Trim() == PasswordTwotxt.Text.Trim())
                {
                    if(Model.addNewUser(Emailtxt.Text,FirstNametxt.Text,LastNametxt.Text,Passwordtxt.Text,false,"User"))
                    {
                        MessageBox.Show("Registration Successful");
                        Model.login(Emailtxt.Text.Trim(), Passwordtxt.Text.Trim());
                        switch (Model.getUserTypeForCurrentuser().Trim())
                        {
                            case "User":
                                UserIndex userview = new UserIndex(Model); // All forms get passed the formContainer and a reference to the model object. 
                                this.Text = this.Text + "-User";
                                userview.Dock = DockStyle.Fill;
                                userview.Show();
                                break;
                            case "Admin":
                                MessageBox.Show(Model.getUserNameCurrentuser().Trim() + " is an admin!");
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Confirm Password");
                    PasswordTwotxt.Text = "";
                }
            }
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
            Passwordtxt.PasswordChar = '*';
            PasswordTwotxt.PasswordChar = '*';
        }

        private void ShowOneBttn_Click(object sender, EventArgs e)
        {
            if(this.Text == "Show")
            {
                this.Text = "Hide";
                Passwordtxt.PasswordChar = '\0';
            }

            if(this.Text == "Hide")
            {
                this.Text = "Show";
                Passwordtxt.PasswordChar = '*';
            }
        }

        private void ShowTwoBttn_Click(object sender, EventArgs e)
        {
            if (this.Text == "Show")
            {
                this.Text = "Hide";
                PasswordTwotxt.PasswordChar = '\0';
            }

            if (this.Text == "Hide")
            {
                this.Text = "Show";
                PasswordTwotxt.PasswordChar = '*';
            }
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
