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
        void addNewUserToDB(string email, string firstname, string lastname, string password, bool verified, string usertype,string address1, string address2, string address3,
            string county, string eircode);
        void addUserPaymentDetailsToDB(string email, string paymenttype, string cardnumber, string cardholdername, int cvc);
        public void addNewBundleToDB(string bundleID, string advertid, double bundleprice,int bundlesize);
        public void addNewAdvertToDB(string advertid, string selleremail, double price, string description, bool verified,string status, string adverttype, string title);
        public void addNewAccessoriesToDB(string accessid, string animaltype, string advertid, string accesscategory, string accesssubcat);
        public void addNewFoodToDB(string foodID,string animaltype, string advertid,string details);
        public void addNewAnimalToDB(string animalid,string advertid,string animalname,string animaltype,int age,bool islitter);
        public void addNewDogToDB(string dogid, string animalid, bool purebreed, string breedone, string breedtwo);
        public void addNewHorseToDB(string horseid, string animalid, string purpose, string size, bool broken, string breed);
        public void addNewFarmAnimalToDB(string farmid, string animalid, string purpose);
        public void addNewGenericAnimalToDB(string gaID, string animalID, string detailone, string detailtwo, string detailthree);
        public void addNewLitterToDB(string litterid, int littersize, string animalid);
        //New Insert Functions
        public void insertDogAdvertisement(Dog dog);
        public void insertGenericAnimalAdvertisement(GenericAnimal generic_animal);
        public void insertLitterAdvertisement(Litter litter);
        public void insertHorseAdvertisement(Horse horse);
        public void insertFarmAnimalAdvertisement(FarmAnimal farmanimal);
        public void insertFoodAdvertisement(Food food);
        public void insertAccessoriesAdvertisement(Accessories access);
        public bool banUserInDB(BusinessEntities.User user);
        public void verifyUser(User user);
        void closeConnection();
        System.Data.SqlClient.SqlConnection getConnection();
        List<User> getAllUsers();
        List<Advertisement> getAllAdvertisements();
        void openConnection();
        
    }
}
