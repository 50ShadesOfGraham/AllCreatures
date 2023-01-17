using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class AdvertisementCreator
    {        
        private static Dog dog = null;
        private static Horse horse = null;
        private static GenericAnimal genericAnimal = null;
        private static FarmAnimal farmAnimal = null;
        private static Litter litter = null;
        private static Food food = null;
        private static Accessories accessories = null;
        public static Dog GetDog(int advertid, string selleremail, string title, string description, double price, bool verified, string status,string animalname,int age, string gender,bool purebreed, string breedone, string breedtwo)
        {
            if (dog != null)
            {
                return dog;
            }
            else
            {
                return new Dog(advertid,selleremail,title,description,price,verified,status,animalname,"Dog",age,gender, purebreed,breedone,breedtwo);
            }
        }

        public static Horse GetHorse(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animalname, int age, string gender, string size, bool broken, string breed, string purpose)
        {
            if(horse != null)
            {
                return horse;
            }
            else
            {
                return new Horse(advertid, selleremail, title, description, price, verified, status, animalname, age,gender,size,broken,breed,purpose);
            }
        }

        public static GenericAnimal GetGenericAnimal(int advertid, string selleremail, string title, string description, double price, bool verified, string status,string animalname, string animaltype, int age, string gender, string detailone, string detailtwo, string detailthree)
        {
            if (horse != null)
            {
                return genericAnimal;
            }
            else
            {
                return new GenericAnimal(advertid,selleremail,title,description,price,verified,status, animalname,animaltype, age,gender,detailone, detailtwo,detailthree);
            }
        }

        public static FarmAnimal GetFarmAnimal(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animalname, string animaltype, int age, string gender, string purpose)
        {
            if (horse != null)
            {
                return farmAnimal;
            }
            else
            {
                return new FarmAnimal(advertid,selleremail,title, description,price,verified,status,animalname,animaltype,age,gender,purpose);
            }
        }

        public static Litter GetLitter(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animalname, string animaltype, int age, string gender, int littersize, bool purebreed, string breedone, string breedtwo)
        {
            if (litter != null)
            {
                return litter;
            }
            else
            {
                return new Litter(advertid, selleremail, title, description,  price,  verified, status, animalname,animaltype, age, gender,littersize,purebreed,breedone,breedtwo);
            }
        }

        public static Food GetFood(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animaltype, string details)
        {
            if (food != null)
            {
                return food;
            }
            else
            {
                return new Food(advertid,selleremail,title,description,price, verified,  status, animaltype,details);
            }
        }

        public static Accessories GetAccessories(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string accesscategory, string subaccesscategory)
        {
            if (accessories != null)
            {
                return accessories;
            }
            else
            {
                return new Accessories(advertid,selleremail,title,description, price,verified,status,accesscategory,subaccesscategory);
            }
        }
    }
}
