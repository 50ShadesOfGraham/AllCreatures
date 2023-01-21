﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class User : IUser
    {
        #region Instance Properties
        //Personal Details
        private string firstname;
        private string lastname;
        private string password;
        private bool verified;
        private string userType;
        private string email;
        //Address Details
        private string address1;
        private string address2;
        private string address3;
        private string county;
        private string eircode;
        //Payment Details
        private string nameofcard;
        private string cardnumber;
        private string expirydate;
        //Security Details
        private string securityquestion;
        private string securityanswer;
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
        public string County
        {
            get { return county; }
            set { county = value; }
        }
        public string Eircode
        {
            get { return eircode; }
            set { eircode = value; }
        }
        public string NameofCard
        {
            get { return nameofcard; }
            set { nameofcard = value; }
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
        public string SecurityQuestion
        {
            get { return securityquestion; }
            set { securityquestion = value; }
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
        //Address
        public User(string email, string firstname, string lastname, string password, bool verified, string userType,string addressOne,string addressTwo,string addressThree,string county,string eircode)
        {
            this.email = email;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.verified = verified;
            this.userType = userType;
            this.address1 = addressOne;
            this.address2 = addressTwo;
            this.address3 = addressThree;
            this.county = county;
            this.eircode = eircode;
        }
        public User(string email, string firstname, string lastname, string password, bool verified, string userType, string addressOne, string addressTwo, string addressThree, string county, string eircode,string cardname,string cardNo,string exdate)
        {
            this.email = email;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.verified = verified;
            this.userType = userType;
            this.address1 = addressOne;
            this.address2 = addressTwo;
            this.address3 = addressThree;
            this.county = county;
            this.eircode = eircode;
            this.nameofcard = cardname;
            this.cardnumber= cardNo;
            this.expirydate = exdate;
        }
        public User(string email, string firstname, string lastname, string password, bool verified, 
            string userType, string addressOne, string addressTwo, string addressThree, string county, 
            string eircode, string cardname, string cardNo, string exdate,string question,string answer)
        {
            this.email = email;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.verified = verified;
            this.userType = userType;
            this.address1 = addressOne;
            this.address2 = addressTwo;
            this.address3 = addressThree;
            this.county = county;
            this.eircode = eircode;
            this.nameofcard = cardname;
            this.cardnumber = cardNo;
            this.expirydate = exdate;
            this.securityquestion = question;
            this.securityanswer= answer;
        }
        #endregion
    }
}
