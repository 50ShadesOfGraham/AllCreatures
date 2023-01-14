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
        //bool addNewAdvert(string advertid, string title, string description, string price, string quantity, string selleremail);
        bool addNewAccessoriesAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title,byte[] newimage, int accessid, string animaltype,string accesscategory, string accesssubcat);
        bool addNewFoodAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, byte[] newimage, int foodID, string animaltype,string details);
        bool addNewDogAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, byte[] newimage, int animalid, string animalname, string animaltype, int age, bool islitter, int dogid,bool purebreed, string breedone, string breedtwo);
        bool addNewHorseAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status,byte[] imageone,byte[] imagetwo,byte[] imagethree, string animalname, int age, string gender, string size, bool broken, string breed, string purpose);        
        bool addNewFarmAnimalAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, byte[] newimage, int animalid, string animalname, string animaltype, int age, bool islitter, int farmid,string purpose);
        bool addNewGenericAnimalAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, byte[] newimage, int animalid, string animalname, string animaltype, int age, bool islitter, int gaID, int animalID, string detailone, string detailtwo, string detailthree);
        bool addNewLitterAdvert(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, byte[] newimage, int animalid, string animalname, string animaltype, int age, bool islitter, int litterid, int littersize);
        bool addNewBundle(int bundleID, int ItemOne_advertid, int ItemTwo_advertid, int ItemThree_advertid, double bundleprice);
        bool addNewNotification(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail);
       // bool addNewImageToDB(byte[] image);

        bool addNewDog(Dog dog);
        bool addNewHorse(Horse horse);
        bool addNewGenericAnimal(GenericAnimal gnericAnimal);
        bool addNewFarmAnimal(FarmAnimal farmAnimal);
        bool addNewLitter(Litter litter);
        bool addNewAccessories(Accessories accessory);
        bool addNewFood(Food food);
        bool addNewBundle(Bundle bundle);

        
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
    }
}
