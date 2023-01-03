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
        #endregion
        #region Instance Properties
        public int LitterSize
        {
            get { return littersize; }
            set { littersize = value; }
        }
        #endregion
        #region Constructor
        public Litter(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animalname, string animaltype, int age, string gender, int littersize)
            : base(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree, animalname, animaltype, age, gender)
        {
            this.littersize = littersize;
        }
        //without images
        public Litter(int advertid, string selleremail, string title, string description, double price, bool verified, string status,string animalname, string animaltype, int age, string gender,int littersize)
            : base(advertid, selleremail, title, description, price, verified, status,animalname, animaltype, age, gender)
        {
            this.littersize = littersize;
        }
        #endregion
    }
}
