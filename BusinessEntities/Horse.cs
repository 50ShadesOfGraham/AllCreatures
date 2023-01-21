using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Horse : Animal
    {
        #region Instance Properties
        private int horseId;
        private string size;
        private bool broken;
        private string breed;
        private string purpose;
        #endregion
        #region Instance Properties
        public int HorseID
        {
            get { return horseId; }
            set { horseId = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public bool Broken
        {
            get { return broken; }
            set { broken = value; }
        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
        public int HorseId
        {
            get { return horseId; }
            set { horseId= value; }
        }

        #endregion
        #region Constructor
        public Horse()
        {
            throw new System.NotImplementedException();
        }
        public Horse(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animalname,int age, string gender,string size,bool broken,string breed,string purpose)
            : base(advertid, selleremail, title, description, price, verified, status,imageone,imagetwo,imagethree, animalname, "Horse", age, gender)
        {
            this.horseId= advertid;
            this.size = Size;
            this.broken = Broken;
            this.breed = Breed;
            this.purpose = Purpose;
        }
        public Horse(int advertid, string selleremail, string title, string description, double price, bool verified, string status,string animalname, int age, string gender, string size, bool broken, string breed, string purpose)
            : base(advertid, selleremail, title, description, price, verified, status, animalname, "Horse", age, gender)
        {
            this.horseId = advertid;
            this.size = Size;
            this.broken = Broken;
            this.breed = Breed;
            this.purpose = Purpose;
        }
        #endregion
    }
}
