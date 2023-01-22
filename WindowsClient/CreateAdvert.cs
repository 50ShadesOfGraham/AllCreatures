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
    public partial class CreateAdvert : Form
    {
        private IModel Model;
   
        public CreateAdvert(IModel model)
        {
            InitializeComponent();
            this.Model = model;
        }
        private void CreateAdvert_Load(object sender, EventArgs e)
        {
            
        }

        public byte[] ConvertImageToByte(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
