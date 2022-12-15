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
    public partial class ViewAdForm : Form
    {
        private IModel Model;
        private Dog advert;
        public ViewAdForm(IModel Model, Dog dog)
        {
            InitializeComponent();
            this.Model = Model;
            this.advert = dog;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewAdForm_Load(object sender, EventArgs e)
        {
            label1.Text = advert.Age.ToString();
        }
    }
}
