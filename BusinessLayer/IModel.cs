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
        bool addNewUser(string email, string password, string firstname, string lastname,bool verified, string userType);

        //bool addNewAdvert(string advertid, string title, string description, string price, string quantity, string selleremail);
        bool addNewAccessoriesAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string accessid, string animaltype,string accesscategory, string accesssubcat);
        bool addNewFoodAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string foodID, string animaltype,string details);
        bool addNewDogAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string animalid, string animalname, string animaltype, int age, bool islitter, string dogid,bool purebreed, string breedone, string breedtwo);
        bool addNewHorseAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string animalid, string animalname, string animaltype, int age, bool islitter, string horseid,string purpose, string size, bool broken, string breed);
        bool addNewFarmAnimalAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string animalid, string animalname, string animaltype, int age, bool islitter, string farmid,string purpose);
        bool addNewGenericAnimalAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string animalid, string animalname, string animaltype, int age, bool islitter, string gaID, string animalID, string detailone, string detailtwo, string detailthree);
        bool addNewLitterAdvert(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, string animalid, string animalname, string animaltype, int age, bool islitter, string litterid, int littersize);
        bool addNewBundle(string bundleID, string advertid, double bundleprice, int bundlesize);
        BusinessEntities.User CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        string getUserTypeForCurrentuser();
        string getUserNameCurrentuser();
        bool login(string email, string password);
        bool EmailPresent(string email);
        public void verifyUser(string email);
        void tearDown();
        System.Collections.ArrayList UserList { get; }
        System.Collections.ArrayList AdvertList { get; set; }
    }
}
