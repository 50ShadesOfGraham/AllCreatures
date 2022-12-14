using BusinessEntities;
using DataAccessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        private List<User> userList;
        private List<Advertisement> advertList;
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


        public List<User> UserList
        {
            get
            {
                return userList;
            }
            set
            {
                userList = value;
            }
        }

        public List<Advertisement> AdvertList
        {
            get
            {
                return advertList;
            }
            set { advertList = value; }
        }

        /*public ArrayList UserAddressList
        {
            get
            {
                return UserAddressList;
            }
            set { UserAddressList = value; }
        }*/
      //  ArrayList IModel.AdvertList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion
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
            userList = new List<User>();
            dataLayer = _DataLayer;
            userList = dataLayer.getAllUsers(); // setup Models userList so we can login

            advertList = new List<Advertisement>();
            dataLayer.getAllAdvertisements();
            advertList = dataLayer.getAllAdvertisements();

            /*UserAddressList = new ArrayList();
            dataLayer.GetUserAddress();
            UserAddressList = dataLayer.GetUserAddress();*/

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

        public Boolean addNewUser(string email, string firstname, string lastname, string password, bool verified,
            string userType,string address1,string address2,string address3,string county,string eircode)
        {
            try
            {
                IUser user = UserCreator.GetUser(email, firstname, lastname, password, verified, userType,address1,address2,address3,county,eircode);
                UserList.Add(user);
                DataLayer.addNewUserToDB(email, firstname, lastname, password, verified, userType,address1,address2,address3,county,eircode);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewAccessoriesAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string accessid, string animaltype, string accesscategory, string accesssubcat)
        {
            try
            {
                DataLayer.addNewAdvertToDB(advertid,selleremail,price,description,verified,status,adverttype,title);
                DataLayer.addNewAccessoriesToDB(accessid, animaltype, advertid, accesscategory, accesssubcat);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewFoodAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string foodID, string animaltype, string details)
        {
            try
            {
                DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title);
                DataLayer.addNewFoodToDB(foodID, animaltype, advertid, details);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewDogAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string animalid, string animalname, string animaltype, int age, bool islitter, string dogid, bool purebreed, string breedone, string breedtwo)
        {
            try
            {
                DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title);
                DataLayer.addNewAnimalToDB(animalid, advertid, animalname, animaltype, age, islitter);
                DataLayer.addNewDogToDB(dogid, animalid, purebreed, breedone, breedtwo);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewHorseAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string animalid, string animalname, string animaltype, int age, bool islitter, string horseid, string purpose, string size, bool broken, string breed)
        {
            try
            {
                DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title);
                DataLayer.addNewAnimalToDB(animalid, advertid, animalname, animaltype, age, islitter);
                DataLayer.addNewHorseToDB(horseid,animalid,purpose,size,broken, breed);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewFarmAnimalAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string animalid, string animalname, string animaltype, int age, bool islitter, string farmid, string purpose)
        {
            try
            {
                DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title);
                DataLayer.addNewAnimalToDB(animalid, advertid, animalname, animaltype, age, islitter);
                DataLayer.addNewFarmAnimalToDB(farmid, animalid, purpose);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewGenericAnimalAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string animalid, string animalname, string animaltype, int age, bool islitter, string gaID, string animalID, string detailone, string detailtwo, string detailthree)
        {
            try
            {
                DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title);
                DataLayer.addNewAnimalToDB(animalid, advertid, animalname, animaltype, age, islitter);
                DataLayer.addNewGenericAnimalToDB(gaID,animalID,detailone, detailtwo, detailthree);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewLitterAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string animalid, string animalname, string animaltype, int age, bool islitter, string litterid, int littersize)
        {
            try
            {
                DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title);
                DataLayer.addNewAnimalToDB(animalid, advertid, animalname, animaltype, age, islitter);
                DataLayer.addNewLitterToDB(litterid, littersize, animalid);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewBundle(string bundleID, string advertid, double bundleprice, int bundlesize)
        {
            try
            {
                DataLayer.addNewBundleToDB(bundleID,advertid,bundleprice,bundlesize);
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

/*
        private bool verified;
        private string userType;
        private string email;
        private string address1;
        private string address2;
        private string address3;
        private string county;
        private string eircode;*/

        public bool addNewUser(string email, string firstname, string lastname, string password,string verified, string userType,string address1,string address2,string address3,string county,string eircode)
        {
            throw new NotImplementedException();
        }

        public bool banUserInDB(IUser user)
        {
            DataLayer.banUserInDB(user);
            return true;
        }
    }
}

