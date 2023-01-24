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
        private bool PersonalShow = false;
        private bool AddressShow = false;
        private bool PaymentShow = false;
        public EditAccount()
        {
            InitializeComponent();
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
                GeneralInfoBttn.Text = "- Address Details";
                PersonalShow = false;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = true;
                PaymentPanel.Visible = false;
            }
            else
            {
                GeneralInfoBttn.Text = "+ Address Details";
                PersonalShow = true;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = false;
            }
        }

        private void PaymentBttn_Click(object sender, EventArgs e)
        {
            if (PaymentShow)
            {
                GeneralInfoBttn.Text = "- Address Details";
                PersonalShow = false;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = true;
            }
            else
            {
                GeneralInfoBttn.Text = "+ Address Details";
                PersonalShow = true;
                GeneralInfoPanel.Visible = false;
                AddressPanel.Visible = false;
                PaymentPanel.Visible = false;
            }
        }

        private void UpdatePersonalBttn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAddressBttn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
