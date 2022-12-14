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
        private string size;
        private bool broken;
        private string breed;
        private string purpose;
        #endregion
        #region Instance Properties
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
        #endregion
        #region Constructor
        public Horse()
        {
            throw new System.NotImplementedException();
        }
        public Horse(string size, bool broken, string breed, string purpose)
        {
            this.size = Size;
            this.broken = Broken;
            this.breed = Breed;
            this.purpose = Purpose;
        }
        public Horse(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animalname, string animaltype, int age, string gender,string size, bool broken, string breed, string purpose)
        : base(advertid,selleremail,title,description,price,verified, status,animalname,animaltype,age,gender)
        {
            this.size = Size;
            this.broken = Broken;
            this.breed = Breed;
            this.purpose = Purpose;
        }


        #endregion
    }
}
