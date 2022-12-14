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
        private string fooddetails;
        #endregion
        #region Instance Properties
        public string AnimalType
        {
            get { return animaltype; }
            set { animaltype = value; }
        }
        public string FoodDetails
        {
            get { return fooddetails; }
            set { fooddetails = value; }
        }
        #endregion
        #region Constructor
        public Food()
        {
            throw new System.NotImplementedException();
        }
        public Food(string animaltype, string fooddetails)
        {
            this.animaltype = AnimalType;
            this.fooddetails = FoodDetails;
        }
        public Food(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animaltype, string fooddetails)
        : base(advertid, selleremail, title, description, price, verified, status)
        {
            this.animaltype = AnimalType;
            this.fooddetails = FoodDetails;
        }
        public Food(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string fooddetails)
        : base(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo,imagethree)
        {
            this.animaltype = AnimalType;
            this.fooddetails = FoodDetails;
        }

        #endregion

    }
}
