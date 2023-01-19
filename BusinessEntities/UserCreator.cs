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

        public static User GetUser(string email, string firstname, string lastname, string password, bool verified, string userType, string address1, string address2, string address3, string county, string eircode)
        {
            if (user != null)
            {
                return user;
            }
            else
            {
                return new User(email, firstname, lastname, password, verified, userType, address1, address2, address3, county, eircode);
            }
        }
        public static void SetUser(User aUser)  
        {
            user = aUser;
        }
    }
}
