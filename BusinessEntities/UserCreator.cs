using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class UserCreator
    {
        private static IUser user = null;

        public static IUser GetUser(string email, string password, string firstname, string lastname,bool verified, string userType)
        {
            if (user != null)
            {
                return user;
            }
            else
            {
                return new User(email, password, firstname, lastname,verified, userType);
            }
        }
        public static void SetUser(IUser aUser)  
        {
            user = aUser;
        }
    }
}
