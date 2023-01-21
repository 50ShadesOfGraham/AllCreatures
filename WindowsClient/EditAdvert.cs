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
    public partial class EditAdvert : UserControl
    {
        private Advertisement advert;
        private IModel Model;
        public EditAdvert(IModel Model,Advertisement advert)
        {
            InitializeComponent();
            this.advert = advert;
            this.Model = Model;
        }

        private void EditAdvert_Load(object sender, EventArgs e)
        {
            
        }

        public void SetLabel(String Title, String Price, String Status)
        {
            this.TitleLbl.Text = Title;
            this.PriceTxt.Text = Price;
            this.StatusTxt.Text = Status;
        }

        private void ViewAdvertBttn_Click(object sender, EventArgs e)
        {

        }

        private void ViewAdvertBttn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
