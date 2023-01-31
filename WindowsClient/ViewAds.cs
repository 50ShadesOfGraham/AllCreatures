using BusinessEntities;
using BusinessLayer;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//basically to display a breif content of the following ads in order to attract customers to click on it. 
//open button error
//retrive image form database

namespace WindowsClient
{
    public partial class ViewAds : UserControl  
    {
        private IModel Model;
        private Dog Dog;
        private Horse Horse;

        public ViewAds(IModel Model, Dog dog)
        {
            InitializeComponent();
            this.Model = Model;
            this.Dog = dog;
        }

        public ViewAds(IModel Model, Horse horse)
        {
            InitializeComponent();
            this.Model = Model;
            this.Horse = horse;
        }

        //image problem. (3 image in a row?)
        //I will wait for the advert work stable first. 
        public void SetLabel(String Title, String Description, String Status, Double Price, String SellerEmail)
        {
            //ImageConverter Class convert Image object to Byte Array.
            //byte[] bytes = (byte[])(new ImageConverter()).ConvertTo(ImageOne, typeof(byte[]));
            //pictureBox1.Image = Image.FromStream(new MemoryStream(bytes));
            label1.Text = Title;
            label2.Text = Description;
            label3.Text = Status;
            label4.Text = String.Format("Price: €{0}", Price);
            label5.Text = SellerEmail;
        }

        private void openAdsbtn_Click(object sender, EventArgs e)
        {
            //object reference not set to an instance of an object?
            //one error
            //DogAdvert da = new DogAdvert(Model,dog);
            //da.Show();

            //DogAdvert da = new DogAdvert(Model);
            //da.Show();
        }
    }
}


