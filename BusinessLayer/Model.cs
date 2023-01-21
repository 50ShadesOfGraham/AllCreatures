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
        private List<Notifications> notificationList;
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
            //set
            //{
            //}
        }

        public List<Advertisement> AdvertList
        {
            get
            {
                return advertList;
            }
            //set
            //{
            //}
        }
        public List<Notifications> NotificationList
        {
            get
            {
                return notificationList;
            }
            //set
            //{
            //}
        }
        #endregion
        //Eddies Class Comment
        //Graham's First Comment
        //Darragh's First Comment
        //Anna's First Comment
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
            advertList = dataLayer.getAllAdvertisements();

            notificationList = new List<Notifications>();
            notificationList = dataLayer.getAllNotifications();
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

        public Boolean addNewImageToDB(byte[] image)
        {
            try
            {
                // DataLayer.InsertImageToDB(image);
                return true;

            } catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                return false;
            }
        }

        public Boolean addNewUser(string email, string firstname, string lastname, string password, bool verified,
             string userType, string address1, string address2, string address3, string county, string eircode)
        {
            try
            {
                User user = UserCreator.GetUser(email, firstname, lastname, password, verified, userType, address1, address2, address3, county, eircode);
                UserList.Add(user);
                DataLayer.addNewUserToDB(email, firstname, lastname, password, verified, userType, address1, address2, address3, county, eircode);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewUserUpdate(string email, string firstname, string lastname, string password, bool verified, string userType, string address1, string address2, string address3, string county, string eircode,
            string cardholder, string cardnumber, string expirydate, string cvs, string question, string answer)
        {
            try
            {
                User newUser = UserCreator.GetUserUpdate(email, firstname, lastname, password, verified, userType, address1, address2, address3, county, eircode,
                cardholder, cardnumber, expirydate, cvs, question, answer);
                UserList.Add(newUser);
                DataLayer.addNewUserToDBUpdate(email, firstname, lastname, password, verified, userType, address1, address2, address3, county, eircode,
                cardholder, cardnumber, expirydate, cvs, question, answer);
                return true;
            }
            catch(System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewAccessoriesAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string accesscategory, string accesssubcat)
        {
            try
            {
                DataLayer.addNewAccessoriesToDB(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, accesscategory, accesssubcat);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewFoodAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string details)
        {
            try
            {
                DataLayer.addNewFoodToDB(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, animaltype, details);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewDogAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string dogname, string gender, bool purebreed, string breedone, string breedtwo)
        {
            try
            {
                DataLayer.addNewDogToDB(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, dogname, gender, purebreed, breedone, breedtwo);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewHorseAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animalname, int age, string gender, string size, bool broken, string breed, string purpose)
        {
            try
            {
                DataLayer.addNewHorseToDB(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, animalname, age, gender, size, broken, breed, purpose);
                return true;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show("Model Layer: " + excep.Message);
                return false;
            }
        }

        public Boolean addNewFarmAnimalAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string animalname, int age, string gender, string purpose)
        {
            try
            {
                DataLayer.addNewFarmAnimalToDB(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, animaltype, animalname, age, gender, purpose);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewGenericAnimalAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string animalname, int age, string gender, string detailone, string detailtwo, string detailthree)
        {
            try
            {
                DataLayer.addNewGenericAnimalToDB(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, animaltype, animalname, age, gender, detailone, detailtwo, detailthree);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewLitterAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, int size, int age, bool purebreed, string breedone, string breedtwo)
        {
            try
            {
                DataLayer.addNewLitterToDB(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, animaltype, size, age, purebreed, breedone, breedtwo);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewBundle(int bundleID, int ItemOne_advertid, int ItemTwo_advertid, int ItemThree_advertid, double bundleprice)
        {
            try
            {
                DataLayer.addNewBundleToDB(bundleID, ItemOne_advertid, ItemTwo_advertid, ItemThree_advertid, bundleprice);
                MessageBox.Show("Bundle #" + bundleID + " successfully created!");
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewNotification(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail)
        {
            try
            {
                Notifications notification = NotificationsCreator.GetNotification(notificationid, message, title, messagetime, messageread, useremail);
                NotificationList.Add(notification);
                DataLayer.addNewNotification(notificationid, message, title, messagetime, messageread, useremail);
                MessageBox.Show(notification.Message);
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
        public Boolean AdvertIDPresent(int number)
        {
            foreach (Advertisement advert in advertList)
            {
                if (advert.AdvertID.Equals(number)) { return true; }
            }

            return false;
        }
        public Boolean NotifIDPresent(int number)
        {
            foreach (Notifications notif in notificationList)
            {
                if (notif.NotificationID.Equals(number)) { return true; }
            }

            return false;
        }
        public void tearDown()
        {
            DataLayer.closeConnection();
        }

        public bool addNewUser(string email, string firstname, string lastname, string password, string userType)
        {
            throw new NotImplementedException();
        }

        public bool verifyAdvertisement(Advertisement advertisement)
        {
            DataLayer.verifyAdvertisement(advertisement);
            return true;
        }
        public bool verifyAdvertisement(Dog dog)
        {
            DataLayer.verifyAdvertisement(dog);
            return true;
        }
        public bool verifyAdvertisement(Horse horse)
        {
            DataLayer.verifyAdvertisement(horse);
            return true;
        }

        public bool verifyAdvertisement(Food food)
        {
            DataLayer.verifyAdvertisement(food);
            return true;
        }
        public bool verifyAdvertisement(FarmAnimal farmAnimal)
        {
            DataLayer.verifyAdvertisement(farmAnimal);
            return true;
        } 
        public bool verifyAdvertisement(Accessories accessories)
        {
            DataLayer.verifyAdvertisement(accessories);
            return true;
        }

        public bool deleteAdvertisement(Advertisement advertisement)
        {
            DataLayer.deleteAdvertisement(advertisement);
            return true;
        }
        public bool deleteAdvertisement(Dog dog)
        {
            DataLayer.deleteAdvertisement(dog); return true;
        }
        
        public bool deleteAdvertisement(Horse horse)
        {
            DataLayer.deleteAdvertisement(horse); return true;
        }

        public bool banUserInDB(User user)
        {
            DataLayer.banUserInDB(user);
            return true;
        }
    }
}

