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
        void addNewUserToDB(string email, string firstname, string lastname, string password,
            string userType, string addressOne, string addressTwo, string addressThree, string county,
            string eircode, string cardname, string cardNo, string exdate, string question, string answer);
        public void addNewAccessoriesToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string accesscategory, string accesssubcat);
        public void addNewFoodToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string details);
        public void addNewDogToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree,string dogname,string gender,bool purebreed,string breedone,string breedtwo);
        public void addNewHorseToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status,byte[] imageone,byte[] imagetwo,byte[] imagethree, string animalname, int age, string gender, string size, bool broken, string breed, string purpose);
        public void addNewFarmAnimalToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree,string animaltype,string animalname,int age,string gender,string purpose);
        public void addNewGenericAnimalToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string animalname, int age, string gender, string detailone,string detailtwo,string detailthree);
        public void addNewLitterToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, int size, int age, bool purebreed, string breedone, string breedtwo);
        public void addNewBundleToDB(int bundleID, int ItemOne_advertid, int ItemTwo_advertid, int ItemThree_advertid, double bundleprice);
        public void addNewNotification(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail);
        public bool UpdateUser(string currentemail, string email, string firstname, string lastname, string password, string userType, string addressOne, string addressTwo, string addressThree, string county, string eircode);
        public void addNewAccessoriesAdvert(Accessories accessories);
        public void addNewFoodAdvert(Food food);
        public void addNewDogAdvert(Dog dog);
        public void addNewHorseAdvert(Horse horse);
        public void addNewFarmAnimalAdvert(FarmAnimal farmAnimal);
        public void addNewGenericAnimalAdvert(GenericAnimal genericAnimal);
        public void addNewLitterAdvert(Litter litter);
        public void addNewBundle(Bundle bundle);
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
        public void getAllAccessoryAdvertisements(ref List<Advertisement> advertisements);
        List<Notifications> getAllNotifications();
        void openConnection();
        
    }
}
