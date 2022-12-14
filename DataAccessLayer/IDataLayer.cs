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
        void addNewUserToDB(string email, string password, string firstname, string lastname, bool verified, string usertype);
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
        public void verifyUser(string email);

        void closeConnection();
        System.Data.SqlClient.SqlConnection getConnection();
        System.Collections.ArrayList getAllUsers();
        System.Collections.ArrayList getAllAdvertisements();
        void openConnection();
    }
}
