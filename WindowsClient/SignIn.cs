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
    public partial class SignIn : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion 

        public SignIn(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;
        }
        public void Alert(string message,Form_Alert.enmType type) 
        { 
            Form_Alert frm = new Form_Alert();
            frm.showAlert(message,type);
        }
        private void SignInBttn_Click(object sender, EventArgs e)
        {

            bool validUser = Model.login(Emailtxt.Text.Trim(), Passwordtxt.Text.Trim());
           // bool validUser = true;
            if (validUser)
            {
                this.Alert("Sign In Successful", Form_Alert.enmType.Success);
                Hide();
                //
                //ACGSContainer aCGSContainer = new ACGSContainer(Model);
                //aCGSContainer.Show();
                switch (Model.getUserTypeForCurrentuser().Trim())
                {
                    case "User":
                        UserIndex userview = new UserIndex(Model);
                        userview.Show();
                        break;
                    case "Admin":
                        AdminIndex adminview = new AdminIndex(Model);
                        adminview.Show();
                        break;
                    case "Banned":
                        MessageBox.Show("Error cannot sign in as you are currently banned, Message an Admin for more information at admin@ACGS.ie");
                        SignIn signIn = new SignIn(Model);
                        signIn.Show();
                        break;
                    default:
                        MessageBox.Show("Error::(");
                        break;
                }
            }
            else
            {
                this.Alert("Sign In UnSuccessful", Form_Alert.enmType.Error);
                Hide();
            }
        }

        private void ShowBttn_Click(object sender, EventArgs e)
        {
            if (this.Text == "Show")
            {
                this.Text = "Hide";
                Passwordtxt.PasswordChar = '\0';
            }
            else
            {
                this.Text = "Show";
                Passwordtxt.PasswordChar = '*';
            }
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            RegisterUser regUser = new RegisterUser(Model);
            regUser.Show();
        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            Passwordtxt.PasswordChar = '*';
        }
    }
}
