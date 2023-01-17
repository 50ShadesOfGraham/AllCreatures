using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Litter : Animal
    {
        #region Instance Properties
        private int littersize;
        private bool purebreed;
        private string breedone;
        private string breedtwo;
        #endregion
        #region Instance Properties
        public int LitterSize
        {
            get { return littersize; }
            set { littersize = value; }
        }
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
        public Litter()
        {
            throw new System.NotImplementedException();
        }
        public Litter(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animalname, string animaltype, int age, string gender, int littersize, bool purebreed, string breedone, string breedtwo)
            : base(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, animalname, animaltype, age, gender)
        {
            this.littersize = littersize;
            this.purebreed = purebreed;
            this.breedone = breedone;
            this.breedtwo = breedtwo;
        }
        //without images
        public Litter(int advertid, string selleremail, string title, string description, double price, bool verified, string status,string animalname, string animaltype, int age, string gender,int littersize,bool purebreed,string breedone,string breedtwo)
            : base(advertid, selleremail, title, description, price, verified, status,animalname, animaltype, age, gender)
        {
            this.littersize = littersize;
            this.purebreed = purebreed;
            this.breedone = breedone;
            this.breedtwo = breedtwo;
        }
        public override string GetClass()
        {
            return this.AnimalType;
        }
        #endregion
    }
}
