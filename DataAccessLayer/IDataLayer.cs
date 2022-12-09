using System;
using BusinessEntities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void addNewUserToDB(string email, string firstname, string lastname, string password, bool verified, string usertype);
        public void addNewAdvertToDB(string advertid, string title, string description, string price, string quantity, string selleremail);
        void closeConnection();
        System.Data.SqlClient.SqlConnection getConnection();
        System.Collections.ArrayList getAllUsers();
        System.Collections.ArrayList getAllAdvertisements();
        void openConnection();
    }
}
