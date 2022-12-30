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
        //Advertisements being added to the DB 
        public void addNewAdvertToDB(int advertid, string selleremail, double price, string description, bool verified,string status, string adverttype, string title, byte[] newimage);
        public void addNewAccessoriesToDB(int accessid, string animaltype, int advertid, string accesscategory, string accesssubcat);
        public void addNewFoodToDB(int foodID,string animaltype, int advertid,string details);
        public void addNewAnimalToDB(int animalid,int advertid,string animalname,string animaltype,int age,bool islitter);
        public void addNewDogToDB(int dogid, int animalid, bool purebreed, string breedone, string breedtwo);
        public void addNewHorseToDB(int horseid, int animalid, string purpose, string size, bool broken, string breed);
        public void addNewFarmAnimalToDB(int farmid, int animalid, string purpose);
        public void addNewGenericAnimalToDB(int gaID, int animalID, string detailone, string detailtwo, string detailthree);
        public void addNewLitterToDB(int litterid, int littersize, int animalid);
        public void InsertImageToDB(byte[] image);
        public void addNewNotification(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail);
        public void InsertDogAdvertisement(Dog dog);
        public void InsertHorseAdvertisement(Horse dog);
        public void InsertAdvertisement(Dog dog);
        public void InsertThreeBundle(Bundle bundle);
        public void InsertTwoBundle(Bundle bundle);
        void closeConnection();
        System.Data.SqlClient.SqlConnection getConnection();
        List<User> getAllUsers();
        List<Advertisement> getAllAdvertisements();
        List<Notifications> getAllNotifications();
        void openConnection();
        
    }
}
