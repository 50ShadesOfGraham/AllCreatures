using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class FarmAnimal : Animal
    {
        #region Instance Properties
        private string purpose;
        #endregion
        #region Instance Properties
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
        #endregion
        #region Constructor
        public FarmAnimal()
        {
            throw new System.NotImplementedException();
        }
        //With Images
        public FarmAnimal(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animalname, string animaltype, int age, string gender, string purpose)
            : base(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, animalname, animaltype, age, gender)
        {
            this.purpose= purpose;
        }
        public FarmAnimal(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animalname, string animaltype, int age, string gender, string purpose)
            : base(advertid, selleremail, title, description, price, verified, status, animalname, animaltype, age, gender)
        {
            this.purpose = purpose;
        }
        #endregion
    }
}
