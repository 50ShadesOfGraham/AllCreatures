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
        public Litter(int littersize, bool purebreed, string breedone, string breedtwo)
        {
            this.littersize = LitterSize;
            this.purebreed = Purebreed;
            this.breedone = BreedOne;
            this.breedtwo = BreedTwo;
        }
        public Litter(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animalname, string animaltype, int age, string gender, int littersize, bool purebreed, string breedone, string breedtwo) 
            : base(advertid, selleremail, title, description, price, verified, status, animalname, animaltype,age,gender)
        {
            this.littersize = LitterSize;
            this.purebreed = Purebreed;
            this.breedone = BreedOne;
            this.breedtwo = BreedTwo;
        }
        #endregion
    }
}
