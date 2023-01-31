using BusinessEntities;
using System.Data;
using System.Data.SqlClient;
using MessageBox = System.Windows.Forms.MessageBox;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using User = BusinessEntities.User;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing.Drawing2D;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class DataLayer : IDataLayer
    {
        #region Instance Attributes
        private SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;
        int maxUsers;
        int maxAdverts;
        int maxReports;
        SqlCommandBuilder cb;
        #endregion
        #region Static Attributes
        private static IDataLayer dataLayerSingletonInstance;
        static readonly object padlock = new object();
        #endregion
        #region Constructors
        public static IDataLayer GetInstance()
        {
            lock (padlock)
            {
                if (dataLayerSingletonInstance == null)
                {
                    dataLayerSingletonInstance = new DataLayer();
                }
                return dataLayerSingletonInstance;
            }
        }
        private DataLayer()
        {
            openConnection();
        }
        #endregion
        public void openConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=Team7ACGS;Integrated Security=True";
            try
            {
                con.Open();
                MessageBox.Show("Database Open");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                Environment.Exit(0); //Force the application to close
            }
        }
        public void closeConnection()
        {
            con.Close();
        }
        public SqlConnection getConnection()
        {
            return con;
        }
        public List<User> getAllUsers()
        {
            List<User> UserList = new List<User>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                maxUsers = ds.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < maxUsers; i++)
                {
                    DataRow dRow = ds.Tables["UsersData"].Rows[i];
                    User user = UserCreator.GetUserUpdate(dRow.ItemArray.GetValue(0).ToString(),
                                                          dRow.ItemArray.GetValue(1).ToString(),
                                                          dRow.ItemArray.GetValue(2).ToString(),
                                                          dRow.ItemArray.GetValue(3).ToString(),
                                                          Convert.ToBoolean(dRow.ItemArray.GetValue(4)),
                                                          dRow.ItemArray.GetValue(5).ToString(),
                                                          dRow.ItemArray.GetValue(6).ToString(),
                                                          dRow.ItemArray.GetValue(7).ToString(),
                                                          dRow.ItemArray.GetValue(8).ToString(),
                                                          dRow.ItemArray.GetValue(9).ToString(),
                                                          dRow.ItemArray.GetValue(10).ToString(),
                                                          dRow.ItemArray.GetValue(11).ToString(),
                                                        dRow.ItemArray.GetValue(12).ToString(),
                                                        dRow.ItemArray.GetValue(13).ToString(),
                                                        dRow.ItemArray.GetValue(14).ToString(),
                                                        dRow.ItemArray.GetValue(15).ToString(),
                                                        dRow.ItemArray.GetValue(16).ToString());
                    UserList.Add(user);
                }


            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                System.Windows.MessageBox.Show("Datalayer: User" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return UserList;
        }
        public void getAllDogAdvertisements(ref List<Advertisement> advertisements)
        {
            
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From DogAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdvertData");
                maxAdverts = ds.Tables["AdvertData"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["AdvertData"].Rows[i];
                    Dog newDog = AdvertisementCreator.GetDog(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                             dRow.ItemArray.GetValue(1).ToString(),
                                                                             dRow.ItemArray.GetValue(2).ToString(),
                                                                             dRow.ItemArray.GetValue(3).ToString(),
                                                                             Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                             Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                             dRow.ItemArray.GetValue(6).ToString(),
                                                                             dRow.ItemArray.GetValue(10).ToString(),
                                                                             Convert.ToInt32(dRow.ItemArray.GetValue(11)),
                                                                             dRow.ItemArray.GetValue(12).ToString(),
                                                                             Convert.ToBoolean(dRow.ItemArray.GetValue(13)),
                                                                             dRow.ItemArray.GetValue(14).ToString(),
                                                                             dRow.ItemArray.GetValue(15).ToString()
                                                                             );

                    advertisements.Add(newDog);
                    //MessageBox.Show("Dog: " + newDog.AdvertID + " successfully added");
                }
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void getAllHorseAdvertisements(ref List<Advertisement> advertisements)        
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From HorseAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdvertData");
                maxAdverts = ds.Tables["AdvertData"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["AdvertData"].Rows[i];
                    Horse horse = AdvertisementCreator.GetHorse(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                             dRow.ItemArray.GetValue(1).ToString(),
                                                                             dRow.ItemArray.GetValue(2).ToString(),
                                                                             dRow.ItemArray.GetValue(3).ToString(),
                                                                             Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                             Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                             dRow.ItemArray.GetValue(6).ToString(),
                                                                             dRow.ItemArray.GetValue(10).ToString(),
                                                                             Convert.ToInt32(dRow.ItemArray.GetValue(11)),
                                                                             dRow.ItemArray.GetValue(12).ToString(),
                                                                             dRow.ItemArray.GetValue(13).ToString(),
                                                                             Convert.ToBoolean(dRow.ItemArray.GetValue(14)),
                                                                             dRow.ItemArray.GetValue(15).ToString(),
                                                                             dRow.ItemArray.GetValue(16).ToString()
                                                                             );

                    advertisements.Add(horse);
                    //MessageBox.Show("Horse: " + horse.AdvertID + " successfully added");
                }
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void getAllFarmAnimalAdvertisements(ref List<Advertisement> advertisements)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From FarmAnimalAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdvertData");
                maxAdverts = ds.Tables["AdvertData"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["AdvertData"].Rows[i];
                    FarmAnimal farmAnimal = AdvertisementCreator.GetFarmAnimal(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                             dRow.ItemArray.GetValue(1).ToString(),
                                                                             dRow.ItemArray.GetValue(2).ToString(),
                                                                             dRow.ItemArray.GetValue(3).ToString(),
                                                                             Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                             Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                             dRow.ItemArray.GetValue(6).ToString(),
                                                                             dRow.ItemArray.GetValue(11).ToString(),
                                                                             dRow.ItemArray.GetValue(10).ToString(),
                                                                             Convert.ToInt32(dRow.ItemArray.GetValue(12)),
                                                                             dRow.ItemArray.GetValue(13).ToString(),
                                                                             dRow.ItemArray.GetValue(14).ToString()
                                                                             );

                    advertisements.Add(farmAnimal);
                    //MessageBox.Show("Farm Animal: " + farmAnimal.AdvertID + " successfully added");
                }
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void getAllGenericAnimalAdvertisements(ref List<Advertisement> advertisements)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From GenericAnimalAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdvertData");
                maxAdverts = ds.Tables["AdvertData"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["AdvertData"].Rows[i];
                    GenericAnimal genricAnimal = AdvertisementCreator.GetGenericAnimal(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                                         dRow.ItemArray.GetValue(1).ToString(),
                                                                                         dRow.ItemArray.GetValue(2).ToString(),
                                                                                         dRow.ItemArray.GetValue(3).ToString(),
                                                                                         Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                                         Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                                         dRow.ItemArray.GetValue(6).ToString(),
                                                                                         dRow.ItemArray.GetValue(11).ToString(),
                                                                                         dRow.ItemArray.GetValue(10).ToString(),
                                                                                         Convert.ToInt32(dRow.ItemArray.GetValue(12)),
                                                                                         dRow.ItemArray.GetValue(13).ToString(),
                                                                                         dRow.ItemArray.GetValue(14).ToString(),
                                                                                         dRow.ItemArray.GetValue(15).ToString(),
                                                                                         dRow.ItemArray.GetValue(16).ToString()
                                                                             );

                    advertisements.Add(genricAnimal);
                    //MessageBox.Show("Farm Animal: " + genricAnimal.AdvertID + " successfully added");
                }
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void getAllLitterAdvertisements(ref List<Advertisement> advertisements)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From LitterAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdvertData");
                maxAdverts = ds.Tables["AdvertData"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["AdvertData"].Rows[i];
                    Litter litter = AdvertisementCreator.GetLitter(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                   dRow.ItemArray.GetValue(1).ToString(),
                                                                   dRow.ItemArray.GetValue(2).ToString(),
                                                                   dRow.ItemArray.GetValue(3).ToString(),
                                                                   Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                   Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                   dRow.ItemArray.GetValue(6).ToString(),
                                                                   "MULTI",
                                                                   dRow.ItemArray.GetValue(10).ToString(),
                                                                   Convert.ToInt32(dRow.ItemArray.GetValue(12)),
                                                                   "MULTI",
                                                                   Convert.ToInt32(dRow.ItemArray.GetValue(11)),
                                                                   Convert.ToBoolean(dRow.ItemArray.GetValue(13)),
                                                                   dRow.ItemArray.GetValue(14).ToString(),
                                                                   dRow.ItemArray.GetValue(15).ToString()
                                                                    );

                    advertisements.Add(litter);
                    //MessageBox.Show("Litter: " + litter.AdvertID + " successfully added");
                }
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void getAllFoodAdvertisements(ref List<Advertisement> advertisements)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From FoodAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdvertData");
                maxAdverts = ds.Tables["AdvertData"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["AdvertData"].Rows[i];
                    Food food = AdvertisementCreator.GetFood(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                   dRow.ItemArray.GetValue(1).ToString(),
                                                                   dRow.ItemArray.GetValue(2).ToString(),
                                                                   dRow.ItemArray.GetValue(3).ToString(),
                                                                   Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                   Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                   dRow.ItemArray.GetValue(6).ToString(),
                                                                   dRow.ItemArray.GetValue(10).ToString(),
                                                                   dRow.ItemArray.GetValue(11).ToString()
                                                                   );

                    advertisements.Add(food);
                    //MessageBox.Show("Food: " + food.AdvertID + " successfully added");
                }
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void getAllAccessoriesAdvertisements(ref List<Advertisement> advertisements)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From AccessoriesAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdvertData");
                maxAdverts = ds.Tables["AdvertData"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["AdvertData"].Rows[i];
                    Accessories accessories = AdvertisementCreator.GetAccessories(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                                  dRow.ItemArray.GetValue(1).ToString(),
                                                                                  dRow.ItemArray.GetValue(2).ToString(),
                                                                                  dRow.ItemArray.GetValue(3).ToString(),
                                                                                  Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                                  Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                                  dRow.ItemArray.GetValue(6).ToString(),
                                                                                  dRow.ItemArray.GetValue(10).ToString(),
                                                                                  dRow.ItemArray.GetValue(11).ToString()
                                                                                  );

                    advertisements.Add(accessories);
                    //MessageBox.Show("Litter: " + accessories.AdvertID + " successfully added");
                }
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public List<Advertisement> getAllAdvertisements()
        {
            List<Advertisement> AdvertList= new List<Advertisement>();
            try
            {
                getAllDogAdvertisements(ref AdvertList);
                getAllHorseAdvertisements(ref AdvertList);
                getAllFarmAnimalAdvertisements(ref AdvertList);
                getAllGenericAnimalAdvertisements(ref AdvertList);
                getAllLitterAdvertisements(ref AdvertList);
                getAllFoodAdvertisements(ref AdvertList);
                getAllAccessoriesAdvertisements(ref AdvertList);
            }
            catch(Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                System.Windows.MessageBox.Show("Form:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return AdvertList;
        }
        public List<Notifications> getAllNotifications()
        {
            List<Notifications> NotificationList = new List<Notifications>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Notifications";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "NotificationsData");
                maxAdverts = ds.Tables["NotificationsData"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["NotificationsData"].Rows[i];
                    Notifications notification = NotificationsCreator.GetNotification(dRow.ItemArray.GetValue(0).ToString(),
                                                                                      dRow.ItemArray.GetValue(1).ToString(),
                                                                                      dRow.ItemArray.GetValue(2).ToString(),
                                                                                      Convert.ToDateTime(dRow.ItemArray.GetValue(3)),
                                                                                      Convert.ToBoolean(dRow.ItemArray.GetValue(4)),
                                                                                      dRow.ItemArray.GetValue(5).ToString());
                    NotificationList.Add(notification);
                    //MessageBox.Show("Notification: " + notification.Title);
                    //MessageBox.Show("NL: " + NotificationList.Count);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show("Notifications: " + excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return NotificationList;
        }
        public void addNewUserToDB(string email, string firstname, string lastname, string password, string usertype, string address1, string address2, string address3,
            string county, string eircode)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Users";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                maxAdverts = ds.Tables["UsersData"].Rows.Count;
                DataRow dRow = ds.Tables["UsersData"].NewRow();
                dRow[0] = email;
                dRow[1] = firstname;
                dRow[2] = lastname;
                dRow[3] = password;
                dRow[4] = usertype;
                dRow[5] = address1;
                dRow[6] = address2;
                dRow[7] = address3;
                dRow[8] = county;
                dRow[9] = eircode;
                //Darragh
                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
                //eddie
            }
        }
        public void addNewUserToDBUpdate(string email, string firstname, string lastname, string password, bool verified, string userType, string address1, string address2, string address3, string county, string eircode,
            string cardholder, string cardnumber, string expirydate, string cvs, string question, string answer)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Users";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                maxAdverts = ds.Tables["UsersData"].Rows.Count;
                DataRow dRow = ds.Tables["UsersData"].NewRow();
                dRow[0] = email;
                dRow[1] = password;
                dRow[2] = firstname;
                dRow[3] = lastname;
                dRow[4] = verified;
                dRow[5] = userType;
                dRow[6] = address1;
                dRow[7] = address2;
                dRow[8] = address3;
                dRow[9] = county;
                dRow[10] = eircode;
                dRow[11] = cardholder;
                dRow[12] = cardnumber;
                dRow[13] = expirydate;
                dRow[14] = question;
                dRow[15] = answer;
                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
                //eddie
            }
        }
        public void addNewAccessoriesToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string accesscategory, string accesssubcat)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From AccessoriesAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AccessData");
                maxAdverts = ds.Tables["AccessData"].Rows.Count;
                DataRow dRow = ds.Tables["AccessData"].NewRow();
                dRow[0] = advertid;
                dRow[1] = selleremail;
                dRow[2] = title;
                dRow[3] = description;
                dRow[4] = price;
                dRow[5] = verified;
                dRow[6] = status;
                dRow[7] = imageone;
                dRow[8] = imagetwo;
                dRow[9] = imagethree;
                dRow[10] = accesscategory;
                dRow[11] = accesssubcat;
                ds.Tables["AccessData"].Rows.Add(dRow);
                da.Update(ds, "AccessData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewFoodToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string details)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From FoodAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "FoodData");
                maxAdverts = ds.Tables["FoodData"].Rows.Count;
                DataRow dRow = ds.Tables["FoodData"].NewRow();
                dRow[0] = advertid;
                dRow[1] = selleremail;
                dRow[2] = title;
                dRow[3] = description;
                dRow[4] = price;
                dRow[5] = verified;
                dRow[6] = status;
                dRow[7] = imageone;
                dRow[8] = imagetwo;
                dRow[9] = imagethree;
                dRow[10] = animaltype;
                dRow[11] = details;
                ds.Tables["FoodData"].Rows.Add(dRow);
                da.Update(ds, "FoodData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewDogToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string dogname,int age, string gender, bool purebreed, string breedone, string breedtwo)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From DogAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "DogData");
                maxAdverts = ds.Tables["DogData"].Rows.Count;
                DataRow dRow = ds.Tables["DogData"].NewRow();
                dRow[0] = advertid;
                dRow[1] = selleremail;
                dRow[2] = title;
                dRow[3] = description;
                dRow[4] = price;
                dRow[5] = verified;
                dRow[6] = status;
                dRow[7] = imageone;
                dRow[8] = imagetwo;
                dRow[9] = imagethree;
                dRow[10] = dogname;
                dRow[11] = age;
                dRow[12] = gender;
                dRow[13] = purebreed;
                dRow[14] = breedone;
                dRow[15] = breedtwo;
                ds.Tables["DogData"].Rows.Add(dRow);
                da.Update(ds, "DogData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewHorseToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status,byte[] imageone, byte[] imagetwo,byte[] imagethree, string animalname, int age, string gender, string size, bool broken, string breed, string purpose)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From HorseAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "HorseData");
                maxAdverts = ds.Tables["HorseData"].Rows.Count;
                DataRow dRow = ds.Tables["HorseData"].NewRow();
                dRow[0] = advertid;
                dRow[1] = selleremail;
                dRow[2] = title;
                dRow[3] = description;
                dRow[4] = price;
                dRow[5] = verified;
                dRow[6] = status;
                dRow[7] = imageone;
                dRow[8] = imagetwo;
                dRow[9] = imagethree;
                dRow[10] = animalname;
                dRow[11] = age;
                dRow[12] = gender;
                dRow[13] = size;
                dRow[14] = broken;
                dRow[15] = breed;
                dRow[16] = purpose;
                ds.Tables["HorseData"].Rows.Add(dRow);
                da.Update(ds, "HorseData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show("Data Layer: " + excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        
        public void addNewFarmAnimalToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree,string animaltype,string animalname,int age,string gender,string purpose)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From FarmAnimalAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "FarmData");
                maxAdverts = ds.Tables["FarmData"].Rows.Count;
                DataRow dRow = ds.Tables["FarmData"].NewRow();
                dRow[0] = advertid;
                dRow[1] = selleremail;
                dRow[2] = title;
                dRow[3] = description;
                dRow[4] = price;
                dRow[5] = verified;
                dRow[6] = status;
                dRow[7] = imageone;
                dRow[8] = imagetwo;
                dRow[9] = imagethree;
                dRow[10] = animaltype;
                dRow[11] = animalname;
                dRow[12] = age;
                dRow[13] = gender;
                dRow[14] = purpose;
                ds.Tables["FarmData"].Rows.Add(dRow);
                da.Update(ds, "FarmData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewGenericAnimalToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, string animalname, int age, string gender, string detailone, string detailtwo, string detailthree)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From GenericAnimalAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GAData");
                maxAdverts = ds.Tables["GAData"].Rows.Count;
                DataRow dRow = ds.Tables["GAData"].NewRow();
                dRow[0] = advertid;
                dRow[1] = selleremail;
                dRow[2] = title;
                dRow[3] = description;
                dRow[4] = price;
                dRow[5] = verified;
                dRow[6] = status;
                dRow[7] = imageone;
                dRow[8] = imagetwo;
                dRow[9] = imagethree;
                dRow[10] = animaltype;
                dRow[11] = animalname;
                dRow[12] = age;
                dRow[13] = gender;
                dRow[14] = detailone;
                dRow[15] = detailtwo;
                dRow[16] = detailthree;
                ds.Tables["GAData"].Rows.Add(dRow);
                da.Update(ds, "GAData");
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                System.Windows.MessageBox.Show("Datalayer: User" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
        }
        public void addNewLitterToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animaltype, int size, int age, bool purebreed, string breedone, string breedtwo)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From LitterAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "LitterData");
                maxAdverts = ds.Tables["LitterData"].Rows.Count;
                DataRow dRow = ds.Tables["LitterData"].NewRow();
                dRow[0] = advertid;
                dRow[1] = selleremail;
                dRow[2] = title;
                dRow[3] = description;
                dRow[4] = price;
                dRow[5] = verified;
                dRow[6] = status;
                dRow[7] = imageone;
                dRow[8] = imagetwo;
                dRow[9] = imagethree;
                dRow[10] = animaltype;
                dRow[11] = size;
                dRow[12] = age;
                dRow[13] = purebreed;
                dRow[14] = breedone;
                dRow[15] = breedtwo;
                ds.Tables["LitterData"].Rows.Add(dRow);
                da.Update(ds, "LitterData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewBundleToDB(int bundleID, int ItemOne_advertid, int ItemTwo_advertid, int ItemThree_advertid, double bundleprice)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Bundle";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "BundleData");
                maxAdverts = ds.Tables["BundleData"].Rows.Count;
                DataRow dRow = ds.Tables["BundleData"].NewRow();
                dRow[0] = bundleID;
                dRow[1] = ItemOne_advertid;
                dRow[2] = ItemTwo_advertid;
                dRow[3] = ItemThree_advertid;
                dRow[4] = bundleprice;
                ds.Tables["BundleData"].Rows.Add(dRow);
                da.Update(ds, "BundleData");
            }
            catch(System.Exception excep) 
            {
                if(con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewUserToDB(string email, string firstname, string lastname, string password, bool verified, string usertype)
        {
            throw new NotImplementedException();
        }

        public void addNewNotification(string notificationid, string title, string message, DateTime messagetime, bool messageread, string useremail)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Notifications";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "NotificationsData");
                maxAdverts = ds.Tables["NotificationsData"].Rows.Count;
                DataRow dRow = ds.Tables["NotificationsData"].NewRow();
                dRow[0] = notificationid;
                dRow[1] = title;
                dRow[2] = message;
                dRow[3] = messagetime;
                dRow[4] = messageread;
                dRow[5] = useremail;
                ds.Tables["NotificationsData"].Rows.Add(dRow);
                da.Update(ds, "NotificationsData");
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                System.Windows.MessageBox.Show("Datalayer:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void UpdateUser(string currentEmail, string password, string firstName, string lastName, bool verified, string UserType, string addressOne, string addressTwo, string addressThree, string County, string eirCode, string cardHolder, string carNumb, string expDate, string Cvs)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(currentEmail);
                if(findRow != null)
                {
                    findRow[1] = password;
                    findRow[2] = firstName;
                    findRow[3] = lastName;
                    findRow[4] = verified;
                    findRow[5] = UserType;
                    findRow[6] = addressOne;
                    findRow[7] = addressTwo;
                    findRow[8] = addressThree;
                    findRow[9] = County;
                    findRow[10] = eirCode;
                    findRow[11] = cardHolder;
                    findRow[12] = carNumb;
                    findRow[13] = expDate;
                    findRow[16] = Cvs;
                }
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                System.Windows.MessageBox.Show("Datalayer:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void UpdateAccessAdvert(int advertid, string title, string description, double price, string accesscategory, string accesssubcat)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From AccessoriesAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "AccessData");
                DataRow findRow = ds.Tables["AccessData"].Rows.Find(advertid);
                if (findRow != null)
                {
                    findRow[2] = title;
                    findRow[3] = description;
                    findRow[4] = price;
                    findRow[5] = false;
                    findRow[10] = accesscategory;
                    findRow[11] = accesssubcat;
                }
                da.Update(ds, "AccessData");
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                System.Windows.MessageBox.Show("Datalayer:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void UpdateFoodAdvert(int advertid, string title, string description, double price, string animaltype, string moredetails)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From FoodAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "FoodData");
                DataRow findRow = ds.Tables["FoodData"].Rows.Find(advertid);
                if (findRow != null)
                {
                    findRow[2] = title;
                    findRow[3] = description;
                    findRow[4] = price;
                    findRow[5] = false;
                    findRow[10] = animaltype;
                    findRow[11] = moredetails;
                }
                da.Update(ds, "FoodData");
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                System.Windows.MessageBox.Show("Datalayer:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void UpdateDogAdvert(int advertid, string title, string description, double price, string dogname, int dogage, string doggender, bool purebreed, string breedone, string breedtwo)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From DogAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "DogData");
                DataRow findRow = ds.Tables["DogData"].Rows.Find(advertid);
                if (findRow != null)
                {
                    findRow[2] = title;
                    findRow[3] = description;
                    findRow[4] = price;
                    findRow[5] = false;
                    findRow[10] = dogname;
                    findRow[11] = dogage;
                    findRow[12] = doggender;
                    findRow[13] = purebreed;
                    findRow[14] = breedone;
                    findRow[15] = breedtwo;

                }
                da.Update(ds, "DogData");
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                System.Windows.MessageBox.Show("Datalayer:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void UpdateHorseadvert(int advertid, string title, string description, double price, string horsename, int horseage, string horsegender,string size, bool broken, string breed, string purpose)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From HorseAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "HorseData");
                DataRow findRow = ds.Tables["HorseData"].Rows.Find(advertid);
                if (findRow != null)
                {
                    findRow[2] = title;
                    findRow[3] = description;
                    findRow[4] = price;
                    findRow[5] = false;
                    findRow[10] = horsename;
                    findRow[11] = horseage;
                    findRow[12] = horsegender;
                    findRow[13] = size;
                    findRow[14] = broken;
                    findRow[15] = breed;
                    findRow[16] = purpose;
                }
                da.Update(ds, "HorseData");
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                System.Windows.MessageBox.Show("Datalayer:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void UpdateFarmAnimalAdvert(int advertid, string title, string description, double price, string FAName, int age, string gender, string purpose)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From FarmAnimalAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "FAData");
                DataRow findRow = ds.Tables["FAData"].Rows.Find(advertid);
                if (findRow != null)
                {
                    findRow[2] = title;
                    findRow[3] = description;
                    findRow[4] = price;
                    findRow[5] = false;
                    findRow[11] = FAName;
                    findRow[12] = age;
                    findRow[13] = gender;
                    findRow[14] = purpose;

                }
                da.Update(ds, "FAData");
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                System.Windows.MessageBox.Show("Datalayer:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void UpdateGenericAnimalAdvert(int advertid, string title, string description, double price, string name, int age, string gender, string detailone, string detailtwo, string detailthree)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From GenericAnimalAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "GAData");
                DataRow findRow = ds.Tables["GAData"].Rows.Find(advertid);
                if (findRow != null)
                {
                    findRow[2] = title;
                    findRow[3] = description;
                    findRow[4] = price;
                    findRow[5] = false;
                    findRow[11] = name;
                    findRow[12] = age;
                    findRow[13] = gender;
                    findRow[14] = detailone;
                    findRow[15] = detailtwo;
                    findRow[16] = detailthree;
                }
                da.Update(ds, "GAData");
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                System.Windows.MessageBox.Show("Datalayer:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void UpdateLitterAdvert(int advertid, string title, string description, double price, int littersize, int age, bool purebreed, string breedone, string breedtwo)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From LitterAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "LitterData");
                DataRow findRow = ds.Tables["LitterData"].Rows.Find(advertid);
                if (findRow != null)
                {
                    findRow[2] = title;
                    findRow[3] = description;
                    findRow[4] = price;
                    findRow[5] = false;
                    findRow[11] = littersize;
                    findRow[12] = age;
                    findRow[13] = purebreed;
                    findRow[14] = breedone;
                    findRow[15] = breedtwo;

                }
                da.Update(ds, "LitterData");
            }
            catch (System.Exception excep)
            {
                var st = new StackTrace(excep, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                System.Windows.MessageBox.Show("Datalayer:" + excep.Message + "\n Line : " + line.ToString());
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public bool verifyAdvertisement(Advertisement advertisement)
        {
            //throw new NotImplementedException();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Advertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(advertisement.AdvertID);
                if (findRow != null) 
                {
                    findRow[5] = advertisement.Verified;
                }
                da.Update(ds, "AdsData");
            }catch(System.Exception excep) 
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }

        public bool verifyAdvertisement(Dog dog)
        {
            //throw new NotImplementedException();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From DogAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(dog.DogId);
                if (findRow != null)
                {
                    findRow[5] = dog.Verified;
                }
                da.Update(ds, "AdsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }

        public bool verifyAdvertisement(Horse horse)
        {
            //throw new NotImplementedException();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From HorseAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(horse.HorseId);
                if (findRow != null)
                {
                    findRow[5] = horse.Verified;
                }
                da.Update(ds, "AdsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }

        public bool verifyAdvertisement(GenericAnimal generic)
        {

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From GenericAnimaladvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(generic.GenericID);
                if (findRow != null)
                {
                    findRow[5] = generic.Verified;
                }
                da.Update(ds, "AdsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }


        public bool verifyAdvertisement(FarmAnimal farmAnimal)
        {

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From FarmAnimaladvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(farmAnimal.FarmId);
                if (findRow != null)
                {
                    findRow[5] = farmAnimal.Verified;
                }
                da.Update(ds, "AdsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }


        public bool verifyAdvertisement(Litter litter)
        {

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Litteradvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(litter.LitterId);
                if (findRow != null)
                {
                    findRow[5] = litter.Verified;
                }
                da.Update(ds, "AdsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }

        public bool verifyAdvertisement(Accessories accessories)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From AccessoriesAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(accessories.AccessoriesID);
                if (findRow != null)
                {
                    findRow[5] = accessories.Verified;
                }
                da.Update(ds, "AdsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }

        public bool verifyAdvertisement(Food food)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From FoodAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(food.FoodId);
                if (findRow != null)
                {
                    findRow[5] = food.Verified;
                }
                da.Update(ds, "AdsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }

        public bool deleteAdvertisement(Advertisement advertisement)
        {

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Advertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(advertisement.AdvertID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "AdsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;

        }

        public bool deleteAdvertisement(Dog dog)
        {

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From DogAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(dog.DogId);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "AdsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;

        }

        public bool deleteAdvertisement(Horse horse)
        {

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From HorseAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(horse.HorseId);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "AdsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;

        }

        public bool banUserInDB(User user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.Email);
                if (findRow != null)
                {
                    findRow[5] = user.UserType;

                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;

        }

        public void addNewUserToDB(string email, string firstname, string lastname, string password, bool verified, string usertype, string address1, string address2, string address3, string county, string eircode)
        {
            throw new NotImplementedException();
        }

        public void addNewReportS(string reportUser, string reason, DateTime dateTime, string description, int reportId)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Reports";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "reporData");
                maxReports = ds.Tables["reporData"].Rows.Count;
                DataRow dRow = ds.Tables["reporData"].NewRow();

                dRow[0] = reportUser;
                dRow[1] = reason;
                dRow[2] = dateTime;
                dRow[3] = description;
                dRow[4] = reportId;
                ds.Tables["reporData"].Rows.Add(dRow);
                da.Update(ds, "reporData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public List<Report> getAllReports()
        {
            List<Report> reportList = new List<Report>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Reports";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "reporData");
                maxReports = ds.Tables["reporData"].Rows.Count;
                for (int i = 0; i < maxReports; i++)
                {
                    DataRow dRow = ds.Tables["reporData"].Rows[i];
                    Report report = ReportCreator.GetReport(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        Convert.ToDateTime(dRow.ItemArray.GetValue(2).ToString()),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()));

                    reportList.Add(report);

                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return reportList;
        }

        public bool deleteAdvertisement(Accessories accessories)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From AccessoriesAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(accessories.AccessoriesID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "AdsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }

        public bool deleteAdvertisement(FarmAnimal farmAnimal)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From FarmAnimalAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(farmAnimal.FarmId);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "AdsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }

        public bool deleteAdvertisement(Litter litter)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From LitterAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(litter.LitterId);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "AdsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }

        public bool deleteAdvertisement(GenericAnimal genericAnimal)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From GenericAnimalAdvertisement";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdsData");
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(genericAnimal.GenericID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "AdsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                System.Windows.Forms.Application.Exit();
            }
            return true;
        }
    }
}
