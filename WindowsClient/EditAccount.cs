using BusinessLayer;
using Microsoft.IdentityModel.Tokens;
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
    public partial class EditAccount : Form
    {
        private IModel Model;
        private bool PersonalShow = false;
        private bool AddressShow = false;
        private bool PaymentShow = false;
        public EditAccount(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }
        public void Alert(string message, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(message, type);
        }
        private void GeneralInfoPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            HeaderPanel.Visible = true;
            AddressBttnPanel.Visible = true;
            PaymentBttnPanel.Visible = true;

            GeneralInfoPanel.Visible = false;
            AddressPanel.Visible = false;
            PaymentPanel.Visible = false;
            //Personal Details Loaded
            FirstNametxt.Text = Model.CurrentUser.FirstName.Trim();
            LastNametxt.Text = Model.CurrentUser.LastName.Trim();
            //Address Details Loaded
            AddressOneTxtBx.Text = Model.CurrentUser.Address1.Trim();
            AddressTwoTxtBx.Text = Model.CurrentUser.Address2.Trim();
            AddressThreeTxtBx.Text = Model.CurrentUser.Address3.Trim();
            CountyComboBox.SelectedValue = Model.CurrentUser.County.Trim();
            EircodeTxtBx.Text = Model.CurrentUser.Eircode.Trim();
            //Payment Details
            CardHolderTxt.Text = Model.CurrentUser.CardHolder.Trim();
            CardNumberTxt.Text = Model.CurrentUser.CardNumber.Trim();
            ExpiryDateTxt.Text = Model.CurrentUser.ExpiryDate.Trim();
        }

        private void GeneralInfoBttn_Click(object sender, EventArgs e)
        {
            if(PersonalShow)
            {
                GeneralInfoBttn.Text = "- Personal Details";
                PersonalShow = false;
                GeneralInfoPanel.Visible = true;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = false;
            }
            else
            {
                GeneralInfoBttn.Text = "+ Personal Details";
                PersonalShow = true;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = false;
            }
        }

        private void AddressBttn_Click(object sender, EventArgs e)
        {
            if (AddressShow)
            {
                AddressBttn.Text = "- Address Details";
                AddressShow = false;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = true;
                PaymentPanel.Visible = false;
            }
            else
            {
                AddressBttn.Text = "+ Address Details";
                AddressShow = true;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = false;
            }
        }

        private void PaymentBttn_Click(object sender, EventArgs e)
        {
            if (PaymentShow)
            {
                PaymentBttn.Text = "- Payment Details";
                PaymentShow = false;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = true;
            }
            else
            {
                PaymentBttn.Text = "+ Payment Details";
                PaymentShow = true;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = false;
            }
        }

        private void UpdatePersonalBttn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Passwordtxt.Text))
            {
                MessageBox.Show("Enter Old Password");
            }
            else if(string.IsNullOrEmpty(Passwordtxt.Text) && string.IsNullOrEmpty(PasswordTwotxt.Text))
            {
                MessageBox.Show("Enter Old Password and New Password");
            }
            else if(string.IsNullOrEmpty(PasswordTwotxt.Text))
            {
                MessageBox.Show("Enter New Password");
            }
            
            if(Passwordtxt.Text.Equals(Model.CurrentUser.Password.Trim()))
            {
                if(Model.UpdateUser(Model.CurrentUser.Email.Trim(),PasswordTwotxt.Text,FirstNametxt.Text,LastNametxt.Text,
                    Model.CurrentUser.Verified,Model.CurrentUser.UserType,Model.CurrentUser.Address1,Model.CurrentUser.Address2,Model.CurrentUser.Address3,
                    Model.CurrentUser.County,Model.CurrentUser.Eircode,Model.CurrentUser.CardHolder,Model.CurrentUser.CardNumber,Model.CurrentUser.ExpiryDate,Model.CurrentUser.CVS
                    )) 
                {
                    this.Alert("Personal Details Updated", Form_Alert.enmType.Success);
                    GeneralInfoBttn.Text = "+ Personal Details";
                    PersonalShow = true;
                    GeneralInfoPanel.Visible = false;
                    AddressPanel.Visible = false;
                    PaymentPanel.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password, Please Enter Your Old Password");
            }
              
        }

        private void UpdateAddressBttn_Click(object sender, EventArgs e)
        {
            string county = this.CountyComboBox.GetItemText(this.CountyComboBox.SelectedItem);
            if (Model.UpdateUser(Model.CurrentUser.Email.Trim(),Model.CurrentUser.Password,Model.CurrentUser.FirstName, Model.CurrentUser.LastName,
                Model.CurrentUser.Verified, Model.CurrentUser.UserType, AddressOneTxtBx.Text, AddressTwoTxtBx.Text, AddressThreeTxtBx.Text,
                county, EircodeTxtBx.Text, Model.CurrentUser.CardHolder, Model.CurrentUser.CardNumber, Model.CurrentUser.ExpiryDate, Model.CurrentUser.CVS
                ))
            {
                this.Alert("Address Details Updated", Form_Alert.enmType.Success);
                AddressBttn.Text = "+ Address Details";
                AddressShow = true;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = false;
            }
        }
        //Update Payment
        private void button1_Click(object sender, EventArgs e)
        {
            if (Model.UpdateUser(Model.CurrentUser.Email.Trim(), Model.CurrentUser.Password, Model.CurrentUser.FirstName, Model.CurrentUser.LastName,
                Model.CurrentUser.Verified, Model.CurrentUser.UserType, Model.CurrentUser.Address1, Model.CurrentUser.Address2, Model.CurrentUser.Address3,
                Model.CurrentUser.County,Model.CurrentUser.Eircode, CardHolderTxt.Text,CardNumberTxt.Text, ExpiryDateTxt.Text, CVSTxt.Text
                ))
            {
                this.Alert("Payment Details Updated", Form_Alert.enmType.Success);
                PaymentBttn.Text = "+ Payment Details";
                PaymentShow = true;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = false;
            }
        }

        private void CancelPersonalBttn_Click(object sender, EventArgs e)
        {
            //Personal Details Loaded
            FirstNametxt.Text = Model.CurrentUser.FirstName.Trim();
            LastNametxt.Text = Model.CurrentUser.LastName.Trim();
            Passwordtxt.Text = string.Empty;
            PasswordTwotxt.Text = string.Empty;
            PasswordTwotxt.Text = string.Empty;
            GeneralInfoPanel.Visible = false;
        }

        private void CancelAddressBttn_Click(object sender, EventArgs e)
        {
            AddressOneTxtBx.Text = Model.CurrentUser.Address1.Trim();
            AddressTwoTxtBx.Text = Model.CurrentUser.Address2.Trim();
            AddressThreeTxtBx.Text = Model.CurrentUser.Address3.Trim();
            CountyComboBox.SelectedValue = Model.CurrentUser.County.Trim();
            EircodeTxtBx.Text = Model.CurrentUser.Eircode.Trim();
            AddressPanel.Visible = false;
        }

        private void CancelPaymentBttn_Click(object sender, EventArgs e)
        {
            CardHolderTxt.Text = Model.CurrentUser.CardHolder.Trim();
            CardNumberTxt.Text = Model.CurrentUser.CardNumber.Trim();
            ExpiryDateTxt.Text = Model.CurrentUser.ExpiryDate.Trim();
            CVSTxt.Text = string.Empty;
            PaymentPanel.Visible = false;
        }
    }
}
