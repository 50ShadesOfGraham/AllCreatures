using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class UserPayment : User
    {
        #region Instance Properties
        private string cardholder;
        private string cardnumber;
        private string expirydate;
        private string cvs;
        #endregion
        #region Instance Properties
        public string CardHolder
        {
            get { return cardholder; }
            set { cardholder = value; }
        }
        public string CardNumber
        { 
            get { return cardnumber; } 
            set { cardnumber = value; } 
        }
        public string ExpiryDate
        {
            get { return expirydate; }
            set { expirydate = value; }
        }
        public string CVS
        {
            get { return cvs; }
            set { cvs = value; }
        }
        public UserPayment()
        {
            throw new System.NotImplementedException();
        }
        public UserPayment(string cardholder, string cardnumber, string expirydate, string cvs)
        {
            this.cardholder = cardholder;
            this.cardnumber = cardnumber;
            this.expirydate = expirydate;
            this.cvs = cvs;
        }
        #endregion
    }
}
