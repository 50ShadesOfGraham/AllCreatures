using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public interface IModel
    {
        bool addNewUser(string firstname, string lastname, string password, string userType, string email);
        BusinessEntities.User CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        string getUserTypeForCurrentuser();
        bool login(string name, string password);
        void tearDown();
        System.Collections.ArrayList UserList { get; }
    }
}
