using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void addNewUserToDB(string firstname, string lastname, string password, string usertype, string email);
        void closeConnection();
        System.Data.SqlClient.SqlConnection getConnection();
        System.Collections.ArrayList getAllUsers();
        void openConnection();
    }
}
