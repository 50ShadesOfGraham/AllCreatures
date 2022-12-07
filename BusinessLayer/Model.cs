using BusinessEntities;
using DataAccessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    //Eddies First Comment
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;
        static readonly object padlock = new object();
        #endregion
        #region Instance Attribures
        private IDataLayer dataLayer;
        private User currentUser;
        private ArrayList userList;
        private ArrayList advertList;
        #endregion
        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }


        public ArrayList UserList
        {
            get
            {
                return userList;
            }
            //set
            //{
            //}
        }

        public ArrayList AdvertList
        {
            get
            {
                return advertList;
            }
            //set
            //{
            //}
        }
        #endregion
        //Eddies Class Comment
        //Graham's First Comment
        //Darragh's First Comment
        #region Constructors/Destructors
        public static IModel GetInstance(IDataLayer _DataLayer) // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (modelSingletonInstance == null)
                {
                    modelSingletonInstance = new Model(_DataLayer);
                }
                return modelSingletonInstance;
            }
        }
        private Model(IDataLayer _DataLayer)  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            userList = new ArrayList();
            dataLayer = _DataLayer;
            userList = dataLayer.getAllUsers(); // setup Models userList so we can login

            advertList = new ArrayList();
            dataLayer.getAllAdvertisements();
        }

        ~Model()
        {
            tearDown();
        }
        #endregion
        public Boolean login(string email, string password)
        {
            foreach (User user in userList)
            {
                String DBUserEmail = user.Email.Trim();
                String DBUserPassword = user.Password.Trim();
                MessageBox.Show("DBUserEmail: " + DBUserEmail);

                if (email.Equals(DBUserEmail) && password.Equals(DBUserPassword))
                {
                    CurrentUser = user;
                    return true;
                }
            }
            return false;
        }

        public Boolean addNewUser(string email, string firstname, string lastname, string password, string userType)
        {
            try
            {
                IUser user = UserCreator.GetUser(email, firstname, lastname, password, userType);
                UserList.Add(user);
                DataLayer.addNewUserToDB(email, firstname, lastname, password, userType);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewAdvert(string advertid, string title, string description, string price, string quantity, string selleremail)
        {
            try
            {
                IAdvertisement ad = AdvertisementCreator.GetAdvert(advertid, title, description, price, quantity, selleremail);
                AdvertList.Add(ad);
                DataLayer.addNewAdvertToDB(advertid, title, description, price, quantity, selleremail);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }



        public String getUserTypeForCurrentuser()
        {
            return currentUser.UserType;
        }

        public String getUserNameCurrentuser()
        {
            return currentUser.FirstName;
        }

        public Boolean EmailPresent(string Email)
        {
            string EmailTrim = Email.Trim();

            foreach (User user in userList)
            {
                string DBEmail = user.Email.Trim();

                if (DBEmail.Equals(EmailTrim)) { return true; }
            }
            return false;
        }

        public void tearDown()
        {
            DataLayer.closeConnection();
        }
    }
}

