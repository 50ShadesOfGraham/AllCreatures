namespace BusinessEntities
{
    public class PaymentDetails
    {
        #region Instance Properties
        private string paymenttype;
        private string cardholdername;
        private string cardnumber;
        private string cvc;
        #endregion

        public string PaymentType
        {
            get
            {
                return paymenttype;
            }
            set
            {
                paymenttype = value;
            }
        }
        public string CardholderName
        {
            get
            {
                return cardholdername;
            }
            set
            {
                cardholdername = value; 
            }
        }
        public string CardNumber
        {
            get
            {
                return cardnumber;
            }
            set
            {
                cardnumber = value;
            }
        }
        public string CVC
        {
            get
            {
                return cvc;
            }
            set
            {
                cvc = value;
            }
        }






        public PaymentDetails()
        {
            throw new System.NotImplementedException();
        }

        public PaymentDetails( string paymenttype, string cardholdername, string cardnumber, string cvc )
        {
            this.paymenttype = paymenttype;
            this.cardholdername = cardholdername;
            this.cardnumber = cardnumber;
            this.cvc = cvc;
        }
        public PaymentDetails(string email, string paymenttype, string cardholdername, string cardnumber, string cvc)
        {
            this.paymenttype = paymenttype;
            this.cardholdername = cardholdername;
            this.cardnumber = cardnumber;
            this.cvc = cvc;
        }
    }
}