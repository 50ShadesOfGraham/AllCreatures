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
        private string address1;
        private string address2;
        private string address3;
        private string county;
        private string eircode;
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

      public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }
        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }
        public string Address3
        {
            get { return address3; }
            set { address3 = value; }
        }
        public string County { get { return county; } set { county = value; } }
        public string Eircode
        {
            get { return eircode; }
            set { eircode = value; }
        }
        
        #endregion
        #region Constructors
        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(string email, string firstname,string lastname,
            string password,bool verified, 
            string userType,string address1,
            string address2,string address3,
            string county,string eircode)
        {
            this.email = email;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.verified = verified;
            this.userType = userType;
            this.address1 = address1;
            this.address2 = address2;  
            this.address3 = address3;
            this.county = county;
            this.eircode = eircode;
        }
        #endregion
    }
}
