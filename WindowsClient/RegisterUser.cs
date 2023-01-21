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

namespace WindowsClient
{
    public partial class RegisterUser : Form
    {
        #region Instance Attributes
        private IModel Model;
        private string addressthree;
        private bool oneShow;
        private bool twoShow;
        #endregion 
        public RegisterUser(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;    
        }

        private void RegisterBttn_Click(object sender, EventArgs e)
        {
            if(Model.EmailPresent(Emailtxt.Text.Trim()))
            {
                MessageBox.Show("Email Already Exists\nPlease Try Again");
                Emailtxt.Text = "";
            }
            else
            {
                string County = this.CountyComboBox.GetItemText(this.CountyComboBox.SelectedItem);
                string securityQ = this.SecurityQComboBox.GetItemText(this.SecurityQComboBox.SelectedItem);
 
                if (Model.addNewUserUpdate(Emailtxt.Text, FirstNametxt.Text, LastNametxt.Text, Passwordtxt.Text, false, "User", AddressOneTxtBx.Text, AddressTwoTxtBx.Text, addressthree, County, EircodeTxtBx.Text,
                    CardHolderTxt.Text, CardNumberTxt.Text, ExpiryDateTxt.Text, CVSTxt.Text, securityQ, SecurityAnswerTxt.Text))
                {
                    MessageBox.Show("Registration Successful");
                    Model.login(Emailtxt.Text.Trim(), Passwordtxt.Text.Trim());
                    string message = "Welcome to ACGS " + Model.CurrentUser.FirstName.Trim() + " !";
                    string notificationtitle = "You Have Limited Access Until An Admin Verifies Your Account";
                    int notifID = 0;
                    Random rnd = new Random();
                    do { notifID = rnd.Next(0, 99999); } while (Model.NotifIDPresent(notifID));
                    
                    if (Model.addNewNotification(notifID.ToString(), message, notificationtitle, DateTime.Now, false, Model.CurrentUser.Email)) { }
                    switch (Model.getUserTypeForCurrentuser().Trim())
                    {
                        case "User":
                            UserIndex userview = new UserIndex(Model); // All forms get passed the formContainer and a reference to the model object. 
                            this.Text = this.Text + "-User";
                            userview.Dock = DockStyle.Fill;
                            userview.Show();
                            Hide();
                            break;
                        case "Admin":
                            MessageBox.Show(Model.getUserNameCurrentuser().Trim() + " is an admin!");
                            Hide();
                            break;
                    }
                }

            }
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
            Passwordtxt.PasswordChar = '*';
            PasswordTwotxt.PasswordChar = '*';
            GeneralInfoPanel.Visible = true;
            AddressPanel.Visible = false;
            PaymentPanel.Visible = false;
            SecurityPanel.Visible = false;
        }

        private void ShowOneBttn_Click(object sender, EventArgs e)
        {
            if(oneShow)
            {
                this.Text = "Hide";
                Passwordtxt.PasswordChar = '\0';
                oneShow = false;
            }
            else
            {
                this.Text = "Show";
                Passwordtxt.PasswordChar = '*';
                oneShow = true;
            }
        }

        private void ShowTwoBttn_Click(object sender, EventArgs e)
        {
            if (twoShow)
            {
                this.Text = "Hide";
                Passwordtxt.PasswordChar = '\0';
                twoShow = false;
            }
            else
            {
                this.Text = "Show";
                Passwordtxt.PasswordChar = '*';
                twoShow = true;
            }
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            Hide();
            SignIn newsignIn = new SignIn(Model);
            newsignIn.Show();
        }

        private void GeneralNextBttn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(FirstNametxt.Text))
            {
                MessageBox.Show("Please Enter First Name");
            }
            else if(string.IsNullOrEmpty(LastNametxt.Text))
            {
                MessageBox.Show("Please Enter Last Name");
            }
            else if(string.IsNullOrEmpty(Emailtxt.Text))
            {
                MessageBox.Show("Please Enter Email Address");
            }
            else if(string.IsNullOrEmpty(Passwordtxt.Text))
            {
                MessageBox.Show("Please Enter Password");
            }
            else if(string.IsNullOrEmpty(PasswordTwotxt.Text))
            {
                MessageBox.Show("Please Confirm Password");
            }
            else if(Passwordtxt.Text != PasswordTwotxt.Text)
            {
                MessageBox.Show("Passwords Don't Match");
            }
            else
            {
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = true;
                PaymentPanel.Visible = false;
                SecurityPanel.Visible = false;
            }
        }

        private void AddressNxtBttn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AddressOneTxtBx.Text))
            {
                MessageBox.Show("Please Enter Address Line One");
            }
            else if (string.IsNullOrEmpty(AddressTwoTxtBx.Text))
            {
                MessageBox.Show("Please Enter Address Line Two");
            }
            else if (string.IsNullOrEmpty(CountyComboBox.Text))
            {
                MessageBox.Show("Please Choose A County");
            }
            else if (string.IsNullOrEmpty(EircodeTxtBx.Text))
            {
                MessageBox.Show("Please Enter EirCode");
            }
            else
            {
                if(string.IsNullOrEmpty(AddressThreeTxtBx.Text))
                {
                    addressthree = " ";
                }
                else
                {
                    addressthree = AddressThreeTxtBx.Text;
                }

                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = true;
                SecurityPanel.Visible = false;
            }
        }

        private void AddressBackBttn_Click(object sender, EventArgs e)
        {
            GeneralInfoPanel.Visible = true;
            AddressPanel.Visible = false;
            PaymentPanel.Visible = false;
            SecurityPanel.Visible = false;
        }

        private void PaymentBackBttn_Click(object sender, EventArgs e)
        {
            GeneralInfoPanel.Visible = false;
            AddressPanel.Visible = true;
            PaymentPanel.Visible = false;
            SecurityPanel.Visible = false;
        }

        private void BackSecurityBttn_Click(object sender, EventArgs e)
        {
            GeneralInfoPanel.Visible = false;
            AddressPanel.Visible = false;
            PaymentPanel.Visible = true;
            SecurityPanel.Visible = false;
        }

        private void PaymentNextBttn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CardHolderTxt.Text))
            {
                MessageBox.Show("Please Enter Cardholder Name");
            }
            else if(string.IsNullOrEmpty(CardNumberTxt.Text))
            {
                MessageBox.Show("Please Enter Card Number");
            }
            else if(string.IsNullOrEmpty(ExpiryDateTxt.Text))
            {
                MessageBox.Show("Please Enter Expiry Date");
            }
            else if(string.IsNullOrEmpty(CVSTxt.Text))
            {
                MessageBox.Show("Please Enter CVS");
            }
            else
            {
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = false;
                SecurityPanel.Visible = true;
            }
        }
    }
}
