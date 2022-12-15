using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Animal : Advertisement
    {
        #region Instance Properties
        private string animalname;
        private string animaltype;
        private int age;
        private string gender;
        #endregion
        #region Instance Properties
        public string AnimalName
        {
            get { return animalname; }  
            set { animalname = value; }
        }
        public string AnimalType
        {
            get { return animaltype; }
            set { animaltype = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return Gender; }
            set { Gender = value; }
        }
        #endregion
        #region Constructor
        public Animal()
        {
            throw new System.NotImplementedException();
        }
        public Animal(string animalname,string animaltype,int age, string gender)
        {
            this.animalname = animalname;
            this.animaltype = animaltype;
            this.age = age;
            this.gender = gender;
        }
        public Animal(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree,string animalname, string animaltype, int age, string gender) : base(advertid,selleremail,title,description,price,verified,status,imageone,imagetwo,imagethree)
        {
            this.animalname = animalname;
            this.animaltype = animaltype;
            this.age = age;
            this.gender = gender;
        }
        public Animal(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animalname, string animaltype, int age, string gender) : base(advertid, selleremail, title, description, price, verified, status)
        {
            this.animalname = animalname;
            this.animaltype = animaltype;
            this.age = age;
            this.gender = gender;
        }
        public Animal(Animal animal,Advertisement advert) : base(advert)
        {
            this.animaltype=animal.AnimalType;
            this.animalname=animal.AnimalName;
            this.age = animal.Age;
            this.gender = animal.Gender;
        }
        #endregion
    }
}
