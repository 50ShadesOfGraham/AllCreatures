using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class GenericAdvert : Form
    {
        private GenericAnimal Advertisement;
        public GenericAdvert(GenericAnmal advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }

        private void GenericAdvert_Load(object sender, EventArgs e)
        {
            txtName.Text = Advertisement.animalname;
        }
    }
}
