using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Food : Advertisement
    {
        #region Instance Properties
        private string animaltype;
        private string details;
        #endregion
        #region Instance Properties
        public string AnimalType
        {
            get { return animaltype; }
            set { animaltype = value; }
        }
        public string Details
        {
            get { return details; }
            set { details = value; }
        }
        #endregion
        #region Constructor
        public Food()
        {
            throw new System.NotImplementedException();
        }
        public Food(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree,string animaltype, string details)
        : base(advertid,selleremail,title,description,price,verified,status,imageone,imagetwo, imagethree)
        {
            this.animaltype= animaltype;
            this.details = details;
        }
        public Food(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animaltype, string details)
        : base(advertid, selleremail, title, details, price, verified, status)
        {
            this.animaltype = animaltype;
            this.details = details;
        }
        #endregion

    }
}
