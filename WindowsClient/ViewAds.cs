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

//need to add scroll bar

namespace WindowsClient
{
    public partial class ViewAds : UserControl
    {
        private IModel Model;
        private Dog Dog;
        private Accessories access;
        private Food fo;
        private Horse pony;
        private FarmAnimal fA;
        private GenericAnimal gA;
        private Litter lttr;

        public ViewAds(IModel Model, Dog dog)
        {
            InitializeComponent();
            this.Model = Model;
            this.Dog = dog;
        }

        public ViewAds(IModel model, Accessories access)
        {
            Model = model;
            this.access = access;
        }

        public ViewAds(IModel model, Food fo)
        {
            Model = model;
            this.fo = fo;
        }

        public ViewAds(IModel model, Horse pony)
        {
            Model = model;
            this.pony = pony;
        }

        public ViewAds(IModel model, FarmAnimal fA)
        {
            Model = model;
            this.fA = fA;
        }

        public ViewAds(IModel model, GenericAnimal gA)
        {
            Model = model;
            this.gA = gA;
        }

        public ViewAds(IModel model, Litter lttr)
        {
            Model = model;
            this.lttr = lttr;
        }

        public void SetLabel(String FirstName, String LastName,String Email)
        {
           label1.Text = FirstName;
           label2.Text = LastName;
           label3.Text = Email;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAdForm viewAd = new ViewAdForm(Model,Dog);
            viewAd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
