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
        private string accesscategory;
        private string accesscubcategory;
        #endregion
        #region Instance Properties
        public string AccessCategory
        {
            get { return accesscategory; }
            set { accesscategory = value; }
        }
        public string AccessSubCategory
        {
            get { return accesscubcategory; }
            set { AccessSubCategory = value; }
        }
        #endregion
        #region Constructor
        public Accessories()
        {
            throw new System.NotImplementedException();
        }
        public Accessories(string accesscategory, string accesscubcategory)
        {
            this.accesscategory = accesscategory;
            this.accesscubcategory = accesscubcategory;
        }
        public Accessories(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string accesscategory, string accesscubcategory) 
            : base(advertid,selleremail,title,description,price,verified,status)
        {
            this.accesscategory = accesscategory;
            this.accesscubcategory = accesscubcategory;
        }
        public Accessories(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string accesscategory, string accesscubcategory)
            : base(advertid, selleremail, title, description, price, verified, status,imageone,imagetwo,imagethree)
        {
            this.accesscategory = accesscategory;
            this.accesscubcategory = accesscubcategory;
        }

        #endregion
    }
}
