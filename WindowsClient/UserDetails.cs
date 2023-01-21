using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;

namespace WindowsClient
{
    public partial class UserDetails : Form
    {
        private User User;
        private IModel Model;
        public UserDetails(IModel Model,User User)
        {
            InitializeComponent();
            this.Model = Model;
            this.User = User;   
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            EmailTxtBox.Text = User.Email.Trim();
            FirstNameTxtBx.Text = User.FirstName.Trim();
            LastNameTxtBx.Text = User.LastName.Trim();
            AddressLineOneTxtBx.Text = User.Address1.Trim();
            AddressLineTwoTxtBx.Text = User.Address2.Trim();
            AddressLineThreeTxtBx.Text = User.Address3.Trim();
            CountyComboBox.SelectedText= User.County.Trim();
            EirCodeTxtBx.Text = User.Eircode;
        }

        private void UpdateBttn_Click(object sender, EventArgs e)
        {
            if(OldPasswordTxtBx.Text.Trim().Equals(User.Password.Trim())) 
            {
                //string GAGender = this.GAGenderComboBox.GetItemText(this.GAGenderComboBox.SelectedItem.ToString());
                string county = "";
                if (string.IsNullOrEmpty(CountyComboBox.Text)) { county = "Limerick"; }
                else
                {
                    county = this.CountyComboBox.GetItemText(this.CountyComboBox.SelectedItem.ToString());
                }
                if (Model.updateUserDetails(Model.CurrentUser.Email.Trim(),EmailTxtBox.Text,FirstNameTxtBx.Text,LastNameTxtBx.Text, NewPasswordTxtBx.Text,Model.CurrentUser.UserType.Trim(),
                    AddressLineOneTxtBx.Text,AddressLineTwoTxtBx.Text,AddressLineTwoTxtBx.Text,county,EirCodeTxtBx.Text))
                {
                    MessageBox.Show("Changes Are Successful");
                    Hide();
                }
                else
                {

                }
            }
        }
    }
}
