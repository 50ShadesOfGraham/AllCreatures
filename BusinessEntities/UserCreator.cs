using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessEntities
{
    public static class UserCreator 
    {
        private static IUser user = null;

        public static IUser GetUser(string firstname, string lastname, string password, string userType, string email)
        {
            if (user != null)  // ie is Factory is primed with an object. 
                return user;
            else
                return new User(firstname,lastname, password, userType, email); // Factory coughs up a regular user (for production code) 
        }
        public static void SetUser(IUser aUser)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            user = aUser;
        }
    }
}
