using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Dog : Animal
    {
        #region Instance Properties
        private bool purebreed;
        private string breedone;
        private string breedtwo;
        #endregion
        #region Instance Properties
        public bool Purebreed
        {
            get { return purebreed; }
            set { purebreed = value; }
        }
        public string BreedOne
        {
            get { return breedone; }
            set { breedone = value; }
        }
        public string BreedTwo
        {
            get { return breedtwo; }
            set { breedtwo = value; }
        }
        #endregion
        #region Constructor
        public Dog()
        {
            throw new System.NotImplementedException();
        }
        public Dog(bool purebreed, string breedone, string breedtwo)
        {
            this.purebreed = purebreed;
            this.breedone = breedone;
            this.breedtwo = breedtwo;
        }

        public Dog(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animalname, string animaltype, int age, string gender, bool purebreed, string breedone, string breedtwo)
            : base(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, animalname, animaltype, age, gender)
        {
            this.purebreed = Purebreed;
            this.breedone = BreedOne;
            this.breedtwo = BreedTwo;
        }
        public Dog(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animalname, string animaltype, int age, string gender, bool purebreed, string breedone, string breedtwo)
            : base(advertid, selleremail, title, description, price, verified, status, animalname, animaltype, age, gender)
        {
            this.purebreed = Purebreed;
            this.breedone = BreedOne;
            this.breedtwo = BreedTwo;
        }
        #endregion
    }
}
