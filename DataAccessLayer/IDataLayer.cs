using System;
using BusinessEntities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void addNewUserToDB(string email, string firstname, string lastname, string password, bool verified, string usertype);
        public void addNewAccessoriesToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string accesscategory, string accesssubcat);
        public void addNewFoodToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string details);
        public void addNewDogToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree,string dogname,string gender,bool purebreed,string breedone,string breedtwo);
        public void addNewHorseToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status,byte[] imageone,byte[] imagetwo,byte[] imagethree, string animalname, int age, string gender, string size, bool broken, string breed, string purpose);
        public void addNewFarmAnimalToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree,string animaltype,string animalname,int age,string gender,string purpose);
        public void addNewGenericAnimalToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string animalname, int age, string gender, string detailone,string detailtwo,string detailthree);
        public void addNewLitterToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, int size, int age, bool purebreed, string breedone, string breedtwo);
        public void addNewBundleToDB(int bundleID, int ItemOne_advertid, int ItemTwo_advertid, int ItemThree_advertid, double bundleprice);
        public void addNewNotification(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail);
        void closeConnection();
        System.Data.SqlClient.SqlConnection getConnection();
        List<User> getAllUsers();
        List<Advertisement> getAllAdvertisements();
        public void getAllDogAdvertisements(ref List<Advertisement> advertisements);
        public void getAllHorseAdvertisements(ref List<Advertisement> advertisements);
        public void getAllFarmAnimalAdvertisements(ref List<Advertisement> advertisements);
        public void getAllGenericAnimalAdvertisements(ref List<Advertisement> advertisements);
        public void getAllLitterAdvertisements(ref List<Advertisement> advertisements);
        public void getAllFoodAdvertisements(ref List<Advertisement> advertisements);
        public void getAllAccessoriesAdvertisements(ref List<Advertisement> advertisements);
        List<Notifications> getAllNotifications();
        public bool verifyAdvertisement(Advertisement advertisement);
        public bool verifyAdvertisement(Dog dog);
        public bool verifyAdvertisement(Horse horse);
        public bool deleteAdvertisement(Advertisement advertisement);
        public bool deleteAdvertisement(Dog dog);
        public bool deleteAdvertisement(Horse horse);
        void openConnection();
       
    }
}
