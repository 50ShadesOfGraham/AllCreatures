using BusinessEntities;
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
    public partial class FarmAdvert : Form
    {
        private FarmAnimal Advertisement;
        public FarmAdvert(FarmAnimal advert)
        {
            InitializeComponent();
            this.Advertisement = advert;
        }

        private void FarmAdvert_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Advertisement.Title;
            txtName.Text = Advertisement.AnimalName;
            txtGender.Text = Advertisement.Gender;
            txtAge.Text = Advertisement.Age.ToString();
            txtPrice.Text = Advertisement.Price.ToString();
            txtDescription.Text = Advertisement.Description;
            txtPurpose.Text = Advertisement.Purpose;
        }
    }
}
