using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Advertisement : IAdvertisement
    {
        #region Instance Properties
        private string advertid;
        private string title;
        private string description;
        private string price;
        private string quantity;
        private string selleremail;
        #endregion
        #region Instance Properties
        public string AdvertID
        {
            get { return advertid; }
            set { advertid = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string SellerEmail
        {
            get { return selleremail; }
            set { selleremail = value; }
        }
        #endregion
        #region Constructors
        public Advertisement()
        {
            throw new System.NotImplementedException();
        }

        public Advertisement(string advertid, string title,  string price, string description, string quantity, string selleremail)
        {
            this.advertid = advertid;
            this.title = title;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
            this.selleremail = selleremail; 
        }
        #endregion
    }
}
