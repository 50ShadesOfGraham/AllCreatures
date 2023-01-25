using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;


namespace BusinessLayer
{
    public interface IModel
    {
        bool addNewUser(string email, string firstname, string lastname, string password, string userType);
        bool addNewUserUpdate(string email, string firstname, string lastname, string password, bool verified, string userType, string address1, string address2, string address3, string county, string eircode,
            string cardholder, string cardnumber, string expirydate, string cvs, string question, string answer);
        //Eddie - 'addNew' function created to add advertisements to the data layer and returns true if successful
        bool addNewAccessoriesAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string accesscategory, string accesssubcat);
        bool addNewFoodAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string details);
        bool addNewDogAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string dogname,  int age,string gender, bool purebreed, string breedone, string breedtwo);
        bool addNewHorseAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status,byte[] imageone,byte[] imagetwo,byte[] imagethree, string animalname, int age, string gender, string size, bool broken, string breed, string purpose);        
        bool addNewFarmAnimalAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string animalname, int age, string gender, string purpose);
        bool addNewGenericAnimalAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string animalname, int age, string gender, string detailone, string detailtwo, string detailthree);
        bool addNewLitterAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, int size, int age, bool purebreed, string breedone, string breedtwo);
        bool addNewBundle(int bundleID, int ItemOne_advertid, int ItemTwo_advertid, int ItemThree_advertid, double bundleprice);
        bool addNewNotification(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail);        
        BusinessEntities.User CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        string getUserTypeForCurrentuser();
        string getUserNameCurrentuser();
        bool login(string email, string password);
        bool EmailPresent(string email);
        bool AdvertIDPresent(int number);
        bool NotifIDPresent(int number);
        void tearDown();
        List<User> UserList { get; }
        List<Advertisement> AdvertList { get; }
        List<Notifications> NotificationList { get; }
        bool verifyAdvertisement(Advertisement advertisement);
        bool verifyAdvertisement(Dog dog);
        bool verifyAdvertisement(Horse horse);
        bool verifyAdvertisement(Accessories accessories);
        bool verifyAdvertisement(Food food);
        bool verifyAdvertisement(GenericAnimal genericAnimal);
        bool verifyAdvertisement(Litter litter);
        bool verifyAdvertisement(FarmAnimal farmAnimal);
        bool deleteAdvertisement(Advertisement advertisement);
        bool deleteAdvertisement(Horse horse);
        bool deleteAdvertisement(Dog dog);
        bool deleteAdvertisement(Accessories accessories);
        bool deleteAdvertisement(Food food);
        bool deleteAdvertisement(GenericAnimal genericAnimal);
        bool deleteAdvertisement(Litter litter);
        bool deleteAdvertisement(FarmAnimal farmAnimal);
        bool banUserInDB(BusinessEntities.User user);
        bool addNewReportS(string reportUser, string reason, DateTime dateTime, string description);
    }
}
