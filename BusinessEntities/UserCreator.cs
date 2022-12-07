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

        public static IUser GetUser(string email, string firstname, string lastname, string password, string userType)
        {
            if (user != null)
            {
                return user;
            }
            else
            {
                return new User(email, firstname, lastname, password, userType);
            }
        }
        public static void SetUser(IUser aUser)  
        {
            user = aUser;
        }
    }
}
