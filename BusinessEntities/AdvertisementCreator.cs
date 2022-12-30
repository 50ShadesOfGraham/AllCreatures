using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class AdvertisementCreator
    {
        private static Advertisement advertisement = null;
        
        private static Dog dog = null;

        private static Animal animal = null;
        public static Advertisement GetAdvert(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree)
        {
            if (advertisement != null)
            {
                return advertisement;
            }
            else
            {
                return new Advertisement(advertid,selleremail,title,description,price,verified,status,imageone,imagetwo,imagethree);
            }
        }
        public static void SetAdvert(Advertisement aAdvert)
        {
            advertisement = aAdvert;
        }
        public static Animal GetAnimal(string animalname, string animaltype, int age, string gender)
        {
            if (animal != null)
            {
                return animal;
            }
            else
            {
                return new Animal(animalname, animaltype, age, gender);
            }
        }

       
        public static Dog GetDog(int advertid, string selleremail, string title, string description, double price, bool verified, string status,byte[] imageone,byte[] imagetwo,byte[] imagethree,string animalname, string animaltype, int age, string gender,bool purebreed, string breedone, string breedtwo)
        {
            if (dog != null)
            {
                return dog;
            }
            else
            {
                return new Dog(advertid,selleremail,title,description,price,verified,status,imageone,imagetwo,imagethree,animalname,animaltype,age,gender, purebreed,breedone,breedtwo);
            }
        }
    }
}
