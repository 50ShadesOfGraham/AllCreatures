using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class User : IUser
    {
        #region Instance Properties
        private string firstname;
        private string lastname;
        private string password;
        private bool verified;
        private string userType;
        private string email;
        #endregion
        #region Instance Properties
        public string FirstName
        {
            get
            {
                return firstname; ;
            }
            set
            {
                firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname; ;
            }
            set
            {
                lastname = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string UserType
        {
            get
            {
                return userType;
            }
            set
            {
                userType = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public bool Verified
        {
            get { return verified; }
            set { verified = value; }
        }
        #endregion
        #region Constructors
        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(string email, string firstname, string lastname, string password,bool verified, string userType)
        {
            this.email = email;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.verified = verified;
            this.userType = userType;
        }
        #endregion
    }
}
