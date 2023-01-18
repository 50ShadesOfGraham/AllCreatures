using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class UserCreator
    {
        private static User user = null;
        private static PaymentDetails paymentDetails = null;

        public static User GetUser(string email, string firstname, string lastname, string password,bool verified, string userType)
        {
            if (user != null)
            {
                return user;
            }
            else
            {
                return new User(email, firstname, lastname, password,verified, userType);
            }
        }
        public static void SetUser(User aUser)  
        {
            user = aUser;
        }

        public static PaymentDetails GetPaymentDetails(string email, string paymenttype, string cardholdername, string cardnumber, string cvc )
        {
            if (paymentDetails != null)
            {
                return paymentDetails;
            }
            else
            {
                return new PaymentDetails(email,paymenttype,cardholdername,cardnumber,cvc);
            }
        }
        public static void SetPaymentDetails(PaymentDetails aPaymentDetails)
        {
            paymentDetails= aPaymentDetails;
        }
            
    }
}
