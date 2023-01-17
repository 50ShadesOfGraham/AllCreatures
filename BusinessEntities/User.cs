using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class User : IUser
    {
        #region Instance Properties
        private string firstname;
        private string lastname;
        private string password;
        private bool verified;
        private string userType;
        private string email;
        #endregion
        #region Instance Properties
        public string FirstName
        {
            get
            {
                return firstname; ;
            }
            set
            {
                firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname; ;
            }
            set
            {
                lastname = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string UserType
        {
            get
            {
                return userType;
            }
            set
            {
                userType = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public bool Verified
        {
            get { return verified; }
            set { verified = value; }
        }
        #endregion
        #region Constructors
        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(string email, string firstname, string lastname, string password,bool verified, string userType)
        {
            this.email = email;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.verified = verified;
            this.userType = userType;
        }
        #endregion
    }
}
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
namespace WindowsClient
{

    public partial class verifiyAdvertisements : Form
    {
        IModel model;
        public verifiyAdvertisements(IModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void verifiyAdvertisements_Load(object sender, EventArgs e)
        {



        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            foreach (Advertisement advertisement1 in model.AdvertList)
            {

                /* listAdverts.Items.Add(advertisement1.Price);*/

                foreach (GenericAnimal advertisement in model.AdvertList)
                {
                    listAdverts.Items.Add(advertisement.AnimalName);
                }

            }

        }

        private void listAdverts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmail.Text = listAdverts.SelectedItem.ToString();
            foreach (Advertisement genericAnimal in model.AdvertList)
            {
                // txtEmail.Text = genericAnimal.SellerEmail;
                txtTitle.Text = genericAnimal.Title;
                txtDescription.Text = genericAnimal.Description;

                MessageBox.Show(genericAnimal.Title, genericAnimal.Description);

                txtPrice.Text = Convert.ToString(genericAnimal.Price);

                foreach (GenericAnimal genericAdvert in model.AdvertList)
                {
                    if (genericAdvert.AnimalName == txtEmail.Text)
                    {
                        txtAge.Text = Convert.ToString(genericAdvert.Age);
                        // txtGender.Text = genericAdvert.Gender;
                        txtAnimalType.Text = genericAdvert.AnimalName;
                        txtDetail1.Text = genericAdvert.DetailOne;
                        txtDetail2.Text = genericAdvert.DetailTwo;
                        txtDetail3.Text = genericAdvert.DetailThree;

                    }
                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
