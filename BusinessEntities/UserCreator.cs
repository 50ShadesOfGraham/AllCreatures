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
        public static User GetUser(string email, string firstname, string lastname, string password,bool verified,
            string userType, string addressOne, string addressTwo, string addressThree, string county,
            string eircode, string cardname, string cardNo, string exdate, string question, string answer)
        {
            if (user != null)
            {
                return user;
            }
            else
            {
                return new User(email,firstname,lastname,password,verified,userType,addressOne,addressTwo,addressThree,county,
                eircode,cardname,cardNo,exdate,question,answer);
            }
        }
        public static void SetUser(User aUser)  
        {
            user = aUser;
        }
    }
}
