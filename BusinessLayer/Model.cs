using DataAccessLayer;
using BusinessEntities;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BusinessLayer
{
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;  // Model object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the Model singleton creation. ie in GetInstance () method
        #endregion
        #region Instance Attribures
        private IDataLayer dataLayer;
        private BusinessEntities.User currentUser;
        private ArrayList userList;
        #endregion
        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }
        public BusinessEntities.User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }


        public ArrayList UserList
        {
            get
            {
                return userList;
            }
            //set
            //{
            //}
        }
        #endregion

        #region Constructors/Destructors
        public static IModel GetInstance(IDataLayer _DataLayer) // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (modelSingletonInstance == null)
                {
                    modelSingletonInstance = new Model(_DataLayer);
                }
                return modelSingletonInstance;
            }
        }
        private Model(IDataLayer _DataLayer)  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            userList = new ArrayList();
            dataLayer = _DataLayer;
            userList = dataLayer.getAllUsers(); // setup Models userList so we can login
        }

        ~Model()
        {
            tearDown();
        }
        #endregion
        public Boolean login(String name, String password)
        {

            foreach (BusinessEntities.User user in userList)
            {
                if (name == user.FirstName && password == user.Password)
                {
                    CurrentUser = user;
                    return true;
                }
            }
            return false;
        }
        public Boolean addNewUser(string firstname, string lastname, string password, string userType, string email)
        {
            try
            {
                IUser user = UserCreator.GetUser(firstname,lastname, password, userType,email); 
                UserList.Add(user);                            
                DataLayer.addNewUserToDB(firstname, lastname, password, userType, email); 
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public String getUserTypeForCurrentuser()
        {
            return currentUser.UserType;
        }

        public void tearDown()
        {
            DataLayer.closeConnection();
        }
    }

}
