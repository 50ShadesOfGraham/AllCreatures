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
    public partial class PlaceAdvertisement : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion
        public PlaceAdvertisement(IModel _model)
        {
            InitializeComponent();
            this.Model = _model;
        }

        private void SubmitAdBttn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int m = rnd.Next(800);

            string advertID = Convert.ToString(m);
            string userEmail = Model.CurrentUser.Email.Trim();
            
            
         /*   if (Model.addNewAdvert(advertID, TitleTextBx.Text, DescriptionTextBx.Text, PriceTextBx.Text,QuantityTextBx.Text , userEmail))
            { 
                MessageBox.Show("Advertisement Successful");
                Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }*/
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PriceTextBx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PriceTextBx.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter A Valid Price");
                PriceTextBx.Text = PriceTextBx.Text.Remove(PriceTextBx.Text.Length - 1);
            }
        }
    }
}
