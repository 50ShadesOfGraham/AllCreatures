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

            }catch(System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                return false;
            }
        }

        public Boolean addNewUser(string email, string firstname, string lastname, string password, bool verified, string userType)
        {
            try
            {
                User user = UserCreator.GetUser(email, firstname, lastname, password, verified, userType);
                UserList.Add(user);
                DataLayer.addNewUserToDB(email, firstname, lastname, password, verified, userType);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewAccessoriesAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title,byte[] newimage, int accessid, string animaltype, string accesscategory, string accesssubcat)
        {
            try
            {
                //DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title, newimage);
                //DataLayer.addNewAccessoriesToDB(accessid, animaltype, advertid, accesscategory, accesssubcat);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewFoodAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, byte[] newimage, int foodID, string animaltype, string details)
        {
            try
            {
               // DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title,newimage);
                //DataLayer.InsertImageToDB(newimage);
                //DataLayer.addNewFoodToDB(foodID, animaltype, advertid, details);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewDogAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, byte[] newimage, int animalid, string animalname, string animaltype, int age, bool islitter, int dogid, bool purebreed, string breedone, string breedtwo)
        {
            try
            {
                //DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title, newimage);
               // DataLayer.addNewAnimalToDB(animalid, advertid, animalname, animaltype, age, islitter);
               // DataLayer.addNewDogToDB(dogid, animalid, purebreed, breedone, breedtwo);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewHorseAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone,byte[] imagetwo,byte[] imagethree, string animalname, int age, string gender, string size, bool broken, string breed, string purpose)
        { 
            try
            {
                //DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title, newimage);
               // DataLayer.addNewAnimalToDB(animalid, advertid, animalname, animaltype, age, islitter);
                DataLayer.addNewHorseToDB(advertid,selleremail,title,description,price,verified,status,imageone,imagetwo,imagethree,animalname,age,gender,size,broken,breed,purpose);
                return true;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show("Model Layer: " + excep.Message);
                return false;
            }
        }

        public Boolean addNewFarmAnimalAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title,byte[] newimage, int animalid, string animalname, string animaltype, int age, bool islitter, int farmid, string purpose)
        {
            try
            {
               // DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title, newimage);
               // DataLayer.addNewAnimalToDB(animalid, advertid, animalname, animaltype, age, islitter);
               // DataLayer.addNewFarmAnimalToDB(farmid, animalid, purpose);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewGenericAnimalAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title,byte[] newimage, int animalid, string animalname, string animaltype, int age, bool islitter, int gaID, int animalID, string detailone, string detailtwo, string detailthree)
        {
            try
            {
                //DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title, newimage);
                //DataLayer.addNewAnimalToDB(animalid, advertid, animalname, animaltype, age, islitter);
                //DataLayer.addNewGenericAnimalToDB(gaID,animalID,detailone, detailtwo, detailthree);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewLitterAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title,byte[] newimage, int animalid, string animalname, string animaltype, int age, bool islitter, int litterid, int littersize)
        {
            try
            {
                //DataLayer.addNewAdvertToDB(advertid, selleremail, price, description, verified, status, adverttype, title, newimage);
               // DataLayer.addNewAnimalToDB(animalid, advertid, animalname, animaltype, age, islitter);
               // DataLayer.addNewLitterToDB(litterid, littersize, animalid);
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
                //DataLayer.addNewBundleToDB(bundleID, ItemOne_advertid,ItemTwo_advertid, ItemThree_advertid,bundleprice);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public Boolean addNewDog(Dog dog)
        {
            try
            {
                DataLayer.InsertDogAdvertisement(dog);
                return true;
            }
            catch(System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewHorse(Horse horse)
        {
            try
            {
                DataLayer.InsertHorseAdvertisement(horse);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewGenericAnimal(GenericAnimal genericAnimal)
        {
            try
            {
                DataLayer.InsertGenericAnimalAdvertisement(genericAnimal);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewFarmAnimal(FarmAnimal farmAnimal)
        {
            try
            {
                DataLayer.InsertFarmAnimalAdvertisement(farmAnimal);
                return true;
            }
            catch(System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewLitter(Litter litter)
        {
            try
            {
                DataLayer.InsertLitterAdvertisement(litter);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewFood(Food food)
        {
            try
            {
                DataLayer.InsertFoodAdvertisement(food);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewAccessories(Accessories accessory)
        {
            try
            {
                DataLayer.InsertAccessoriesAdvertisement(accessory);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public Boolean addNewBundle(Bundle bundle)
        {
            try
            {
                DataLayer.InsertBundle(bundle);
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
            foreach(Advertisement advert in advertList)
            {
                if(advert.AdvertID.Equals(number)) { return true; }
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
    }
}

