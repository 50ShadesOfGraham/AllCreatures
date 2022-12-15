using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Advertisement 
    {
        #region Instance Properties
        private int advertid;
        private string selleremail;
        private string title;
        private string description;
        private double price;
        private bool verified;
        private string status;
        private byte[] imageone;
        private byte[] imagetwo;
        private byte[] imagethree;
        #endregion
        #region Instance Properties
        public int AdvertID
        {
            get { return advertid; }
            set { advertid = value; }
        }
        public string SellerEmail
        {
            get { return selleremail; }
            set { selleremail = value; }
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
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool Verified
        {
            get { return verified; }
            set { verified = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public byte[] ImageOne
        {
            get { return imageone; }
            set { imageone = value; }
        }
        public byte[] ImageTwo
        {
            get { return imageone; }
            set { imageone = value; }
        }
        public byte[] ImageThree
        {
            get { return imageone; }
            set { imageone = value; }
        }
        #endregion
        #region Constructors
        public Advertisement()
        {
            throw new System.NotImplementedException();
        }

        public Advertisement(int advertid, string selleremail, string title, string description, double price,bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree)
        {
            this.advertid = AdvertID;
            this.title = Title;
            this.description = Description;
            this.price = Price;
            this.selleremail = SellerEmail;
            this.verified = Verified;
            this.status = Status;
            this.imageone = ImageOne;
            this.imagetwo = ImageTwo;
            this.imagethree = ImageThree;
        }
        public Advertisement(int advertid, string selleremail, string title, string description, double price, bool verified, string status)
        {
            this.advertid = AdvertID;
            this.title = Title;
            this.description = Description;
            this.price = Price;
            this.selleremail = SellerEmail;
            this.verified = Verified;
            this.status = Status;
        }
        public Advertisement(Advertisement advert)
        {
            this.advertid = advert.AdvertID;
            this.title = advert.Title;
            this.description = advert.Description;
            this.price = advert.Price;
            this.selleremail = advert.SellerEmail;
            this.verified = advert.Verified;
            this.status = advert.Status;
        }
        #endregion
    }
}
