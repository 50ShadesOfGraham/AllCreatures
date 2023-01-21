using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Accessories : Advertisement
    {
        #region Instance Properties
        private int accessoriesID;
        private string accesscategory;
        private string subaccesscategory;
        #endregion
        #region Instance Properties
        public string AccessCategory
        {
            get { return accesscategory; }
            set { accesscategory = value; }
        }
        public string SubAccessCategory
        {
            get { return subaccesscategory; }
            set { subaccesscategory = value; }
        }
        public int AccessoriesID
        {
            get { return accessoriesID; }
            set { accessoriesID = value; }
        }
        #endregion
        #region Constructor
        public override string GetAdvertisementType()
        {
            return "Accessories";
        }
        public Accessories() 
        {
            throw new System.NotImplementedException();
        }
        public Accessories(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string accesscategory, string subaccesscategory)
            : base(advertid, selleremail, title, description, price, verified, status, imageone, imagetwo, imagethree)
        {
            this.accessoriesID = advertid;
            this.accesscategory = accesscategory;
            this.subaccesscategory = subaccesscategory;
        }
        public Accessories(int advertid, string selleremail, string title, string description, double price, bool verified, string status,string accesscategory,string subaccesscategory)
           : base(advertid, selleremail, title, description, price, verified, status)
        {
            this.accessoriesID= advertid;
            this.accesscategory = accesscategory;
            this.subaccesscategory = subaccesscategory;
        }
        #endregion
    }
}
