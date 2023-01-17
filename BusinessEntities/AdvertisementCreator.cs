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
        private static Dog dog = null;
        private static Horse horse = null;
        private static GenericAnimal genericAnimal = null;
        private static FarmAnimal farmAnimal = null;
        private static Litter litter = null;
        private static Food food = null;
        private static Accessories accessories = null;

       
        public static Dog GetDog(int advertid, string selleremail, string title, string description, double price, bool verified, string status,byte[] imageone,byte[] imagetwo, byte[] imagethree,string animalname,int age, string gender,bool purebreed, string breedone, string breedtwo)
        {
            if (dog != null)
            {
                return dog;
            }
            else
            {
                return new Dog(advertid,selleremail,title,description,price,verified,status,imageone,imagetwo,imagethree,animalname,"Dog",age,gender, purebreed,breedone,breedtwo);
            }
        }

        public static Horse GetHorse()
        {
            if(horse != null)
            {
                return horse;
            }
        }
    }
}
