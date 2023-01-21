using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class UserSecurity : User
    {
        #region Instance Properties
        private string securityquestion;
        private string securityanswer;
        #endregion
        #region Instance Properties
        public string SecurityQuestion
        {
            get { return securityquestion; } 
            set { securityquestion= value; }
        }
        public string SecurityAnswer
        { 
            get { return securityanswer; } 
            set { securityanswer = value; } 
        }
        #endregion
        public UserSecurity() 
        {
            throw new System.NotImplementedException();
        }
        public UserSecurity(string securityquestion,string securityanswer)
        {
            this.securityquestion= securityquestion;
            this.securityanswer= securityanswer;
        }
    }
}
