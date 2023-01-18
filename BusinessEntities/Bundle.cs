using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Bundle
    {
        #region Instance Properties
        private int bundleid;
        private int itemOneNo;
        private int itemTwoNo;
        private int itemThreeNo;
        private double price;
        #endregion
        #region Instance Properties
        public int BundleID
        {
            get { return bundleid; }
            set { bundleid = value; }
        }
        public int ItemNoOne
        {
            get { return itemOneNo; }
            set { itemOneNo = value; }
        }
        public int ItemNoTwo
        {
            get { return itemTwoNo; }
            set { itemTwoNo = value; }
        }
        public int ItemNoThree
        {
            get { return itemThreeNo; }
            set { itemThreeNo = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion
        #region Constructor
        public Bundle() 
        {
            throw new System.NotImplementedException();
        }
        public Bundle(int bundleid, int itemOneNo, int itemTwoNo, int itemThreeNo,double price)
        {
            this.bundleid = bundleid;
            this.itemOneNo = itemOneNo;
            this.itemTwoNo = itemTwoNo;
            this.itemThreeNo = itemThreeNo;
            this.price = price;
        }
        public Bundle(int bundleid, int itemOneNo, int itemTwoNo,double price)
        {
            this.bundleid = bundleid;
            this.itemOneNo = itemOneNo;
            this.itemTwoNo = itemTwoNo;
            this.price = price;
        }
        #endregion
    }
}
