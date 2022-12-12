using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;


namespace BusinessLayer
{
    public interface IModel
    {
        bool addNewUser(string email, string firstname, string lastname, string password,bool verified, string userType);

        bool addNewAdvert(string advertid, string title, string description, string price, string quantity, string selleremail);
        BusinessEntities.User CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        string getUserTypeForCurrentuser();
        string getUserNameCurrentuser();
        bool login(string email, string password);
        bool EmailPresent(string email);
        void tearDown();
        System.Collections.ArrayList UserList { get; }
        System.Collections.ArrayList AdvertList { get; set; }
    }
}
