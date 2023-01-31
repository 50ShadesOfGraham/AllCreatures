﻿using System;
using BusinessEntities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void addNewUserToDB(string email, string firstname, string lastname, string password, bool verified, string userType, string address1, string address2, string address3, string county, string eircode);
        public void addNewUserToDBUpdate(string email, string firstname, string lastname, string password, bool verified, string userType, string address1, string address2, string address3, string county, string eircode,
            string cardholder, string cardnumber, string expirydate, string cvs, string question, string answer);
        public void addNewAccessoriesToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string accesscategory, string accesssubcat);
        public void addNewFoodToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string details);
        public void addNewDogToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree,string dogname,int age,string gender,bool purebreed,string breedone,string breedtwo);
        public void addNewHorseToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status,byte[] imageone,byte[] imagetwo,byte[] imagethree, string animalname, int age, string gender, string size, bool broken, string breed, string purpose);
        public void addNewFarmAnimalToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree,string animaltype,string animalname,int age,string gender,string purpose);
        public void addNewGenericAnimalToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string animalname, int age, string gender, string detailone,string detailtwo,string detailthree);
        public void addNewLitterToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, int size, int age, bool purebreed, string breedone, string breedtwo);
        public void addNewBundleToDB(int bundleID, int ItemOne_advertid, int ItemTwo_advertid, int ItemThree_advertid, double bundleprice);
        public void addNewNotification(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail);
        public void UpdateUser(string currentEmail, string password, string firstName, string lastName, bool verified, string UserType, string addressOne, string addressTwo, string addressThree, string County, string eirCode, string cardHolder, string carNumb, string expDate, string Cvs);
        public void UpdateAccessAdvert(int advertid,string title, string description, double price, string accesscategory, string accesssubcat);
        public void UpdateFoodAdvert(int advertid, string title, string description, double price,string animaltype,string moredetails);
        public void UpdateDogAdvert(int advertid, string title, string description, double price,string dogname,int dogage,string doggender,bool purebreed,string breedone,string breedtwo);
        public void UpdateHorseadvert(int advertid, string title, string description, double price,string horsename,int horseage,string horsegender,string size,bool broken,string breed,string purpose);
        public void UpdateFarmAnimalAdvert(int advertid, string title, string description, double price,string FAName,int age, string gender,string purpose);
        public void UpdateGenericAnimalAdvert(int advertid, string title, string description, double price,string name,int age,string gender,string detailone,string detailtwo,string detailthree);
        public void UpdateLitterAdvert(int advertid, string title, string description, double price,int littersize,int age,bool purebreed,string breedone,string breedtwo);
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
        public bool verifyAdvertisement(Accessories accessories);
        public bool verifyAdvertisement(FarmAnimal farmAnimal);
        public bool verifyAdvertisement(Litter litter);
        public bool verifyAdvertisement(GenericAnimal genericAnimal);
        public bool verifyAdvertisement(Food food);
        public bool deleteAdvertisement(Advertisement advertisement);
        public bool deleteAdvertisement(Dog dog);
        public bool deleteAdvertisement(Horse horse);
        public bool deleteAdvertisement(Accessories accessories);
        public bool deleteAdvertisement(FarmAnimal farmAnimal);
        public bool deleteAdvertisement(Litter litter);
        public bool deleteAdvertisement(GenericAnimal genericAnimal);
        public bool banUserInDB(BusinessEntities.User user);

        //Anna
        bool editUserInDB(BusinessEntities.IUser u);
      //  bool filterAdsByUserEmail(BusinessEntities.IUser u);
       // public bool deleteUserAccount(BusinessEntities.IUser u);

        public void addNewReportS(string reportUser, string reason, DateTime dateTime, string description, int reportId);
        List<Report> getAllReports();
        void openConnection();
       
    }
}
