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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Controls.Primitives;

namespace ACGS
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
                if (Model.addNewUser(FirstNametxt.Text,LastNametxt.Text,PasswordOnetxt.Text,"User", Emailtxt.Text))
                {
                    MessageBox.Show("User created");
                    FirstNametxt.Text = "";
                    LastNametxt.Text = "";
                    PasswordOnetxt.Text = "";
                    PasswordTwotxt.Text = "";
                    Emailtxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Registration Failed!");
                }
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Closed");
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }
    }
}
