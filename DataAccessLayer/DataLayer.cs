using BusinessEntities;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MessageBox = System.Windows.Forms.MessageBox;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Net.NetworkInformation;
using System.Reflection;
using Microsoft.VisualBasic.Logging;
using System.Security.Policy;
using System.Windows.Forms;

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
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
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
                    User user = UserCreator.GetUser(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
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
                                                        dRow.ItemArray.GetValue(15).ToString());
                    UserList.Add(user);
                }




            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
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
                }
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
                }
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
                }
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
                }
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
                }
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
                }
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
        public void getAllAccessoryAdvertisements(ref List<Advertisement> advertisements)
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
                }
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
                getAllAccessoryAdvertisements(ref AdvertList);
            }
            catch(Exception excep)
            {
                MessageBox.Show("Notifications: " + excep.Message);
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
        public bool UpdateUser(string currentemail, string email, string firstname, string lastname, string password, string userType, string addressOne, string addressTwo, string addressThree, string county, string eircode)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Users";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                //maxAdverts = ds.Tables["UsersData"].Rows.Count;
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(currentemail.Trim());
                if(findRow != null) 
                {
                    findRow[0] = email;
                    findRow[1] = password;
                    findRow[2] = firstname;
                    findRow[3] = lastname;
                    findRow[6] = addressOne;
                    findRow[7] = addressTwo;
                    findRow[8] = addressThree;
                    findRow[9] = county;
                    findRow[10] = eircode;
                }
                da.Update(ds, "UsersData");
                return true;
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
                //eddie
                return false;
            }
        }
        public void addNewUserToDB(string email, string firstname, string lastname, string password, string usertype)
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

                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
                //eddie
            }
        }
        public void addNewUserToDB(string email, string firstname, string lastname, string password,
            string userType, string addressOne, string addressTwo, string addressThree, string county,
            string eircode, string cardname, string cardNo, string exdate, string question, string answer)
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
                dRow[4] = false;
                dRow[5] = userType;
                dRow[6] = addressOne;
                dRow[7] = addressTwo;
                dRow[8] = addressThree;
                dRow[9] = county;
                dRow[10] = eircode;
                dRow[11] = cardname;
                dRow[12] = cardNo;
                dRow[13] = exdate;
                dRow[14] = question;
                dRow[15] = answer;

                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
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
        public void addNewDogToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string dogname, string gender, bool purebreed, string breedone, string breedtwo)
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
                dRow[11] = gender;
                dRow[12] = purebreed;
                dRow[13] = breedone;
                dRow[14] = breedtwo;
                ds.Tables["DogData"].Rows.Add(dRow);
                da.Update(ds, "DogData");
            }
            catch (System.Exception excep)
            {
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
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
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

        public void addNewNotification(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail)
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
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public void addNewAccessoriesAdvert(Accessories accessories)
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
                dRow[0] = accessories.AdvertID;
                dRow[1] = accessories.SellerEmail;
                dRow[2] = accessories.Title;
                dRow[3] = accessories.Description;
                dRow[4] = accessories.Price;
                dRow[5] = accessories.Verified;
                dRow[6] = accessories.Status;
                dRow[7] = accessories.ImageOne;
                dRow[8] = accessories.ImageTwo;
                dRow[9] = accessories.ImageThree;
                dRow[10] = accessories.AccessCategory;
                dRow[11] = accessories.SubAccessCategory;
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
        public void addNewFoodAdvert(Food food)
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
                dRow[0] = food.AdvertID;
                dRow[1] = food.SellerEmail;
                dRow[2] = food.Title;
                dRow[3] = food.Description;
                dRow[4] = food.Price;
                dRow[5] = food.Verified;
                dRow[6] = food.Status;
                dRow[7] = food.ImageOne;
                dRow[8] = food.ImageTwo;
                dRow[9] = food.ImageThree;
                dRow[10] = food.AnimalType;
                dRow[11] = food.Details;
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
        public void addNewDogAdvert(Dog dog)
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
                dRow[0] = dog.AdvertID;
                dRow[1] = dog.SellerEmail;
                dRow[2] = dog.Title;
                dRow[3] = dog.Description;
                dRow[4] = dog.Price;
                dRow[5] = dog.Verified;
                dRow[6] = dog.Status;
                dRow[7] = dog.ImageOne;
                dRow[8] = dog.ImageTwo;
                dRow[9] = dog.ImageThree;
                dRow[10] = dog.AnimalName;
                dRow[11] = dog.Gender;
                dRow[12] = dog.Purebreed;
                dRow[13] = dog.BreedOne;
                dRow[14] = dog.BreedTwo;
                ds.Tables["DogData"].Rows.Add(dRow);
                da.Update(ds, "DogData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewHorseAdvert(Horse horse)
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
                dRow[0] = horse.AdvertID;
                dRow[1] = horse.SellerEmail;
                dRow[2] = horse.Title;
                dRow[3] = horse.Description;
                dRow[4] = horse.Price;
                dRow[5] = horse.Verified;
                dRow[6] = horse.Status;
                dRow[7] = horse.ImageOne;
                dRow[8] = horse.ImageTwo;
                dRow[9] = horse.ImageThree;
                dRow[10] = horse.AnimalName;
                dRow[11] = horse.Age;
                dRow[12] = horse.Gender;
                dRow[13] = horse.Size;
                dRow[14] = horse.Broken;
                dRow[15] = horse.Breed;
                dRow[16] = horse.Purpose;
                ds.Tables["HorseData"].Rows.Add(dRow);
                da.Update(ds, "HorseData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewGenericAnimalAdvert(GenericAnimal genericAnimal)
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
                dRow[0] = genericAnimal.AdvertID;
                dRow[1] = genericAnimal.SellerEmail;
                dRow[2] = genericAnimal.Title;
                dRow[3] = genericAnimal.Description;
                dRow[4] = genericAnimal.Price;
                dRow[5] = genericAnimal.Verified;
                dRow[6] = genericAnimal.Status;
                dRow[7] = genericAnimal.ImageOne;
                dRow[8] = genericAnimal.ImageTwo;
                dRow[9] = genericAnimal.ImageThree;
                dRow[10] = genericAnimal.AnimalType;
                dRow[11] = genericAnimal.AnimalName;
                dRow[12] = genericAnimal.Age;
                dRow[13] = genericAnimal.Gender;
                dRow[14] = genericAnimal.DetailOne;
                dRow[15] = genericAnimal.DetailTwo;
                dRow[16] = genericAnimal.DetailThree;
                ds.Tables["GAData"].Rows.Add(dRow);
                da.Update(ds, "GAData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewFarmAnimalAdvert(FarmAnimal farmAnimal)
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
                dRow[0] = farmAnimal.AdvertID;
                dRow[1] = farmAnimal.SellerEmail;
                dRow[2] = farmAnimal.Title;
                dRow[3] = farmAnimal.Description;
                dRow[4] = farmAnimal.Price;
                dRow[5] = farmAnimal.Verified;
                dRow[6] = farmAnimal.Status;
                dRow[7] = farmAnimal.ImageOne;
                dRow[8] = farmAnimal.ImageTwo;
                dRow[9] = farmAnimal.ImageThree;
                dRow[10] = farmAnimal.AnimalType;
                dRow[11] = farmAnimal.AnimalName;
                dRow[12] = farmAnimal.Age;
                dRow[13] = farmAnimal.Gender;
                dRow[14] = farmAnimal.Purpose;
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
        public void addNewLitterAdvert(Litter litter)
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
                dRow[0] = litter.AdvertID;
                dRow[1] = litter.SellerEmail;
                dRow[2] = litter.Title;
                dRow[3] = litter.Description;
                dRow[4] = litter.Price;
                dRow[5] = litter.Verified;
                dRow[6] = litter.Status;
                dRow[7] = litter.ImageOne;
                dRow[8] = litter.ImageTwo;
                dRow[9] = litter.ImageThree;
                dRow[10] = litter.AnimalType;
                dRow[11] = litter.LitterSize;
                dRow[12] = litter.Age;
                dRow[13] = litter.Purebreed;
                dRow[14] = litter.BreedOne;
                dRow[15] = litter.BreedTwo;
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
        public void addNewBundle(Bundle bundle)
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
                dRow[0] = bundle.BundleID;
                dRow[1] = bundle.ItemNoOne;
                dRow[2] = bundle.ItemNoTwo;
                dRow[3] = bundle.ItemNoThree;
                dRow[4] = bundle.Price;
                ds.Tables["BundleData"].Rows.Add(dRow);
                da.Update(ds, "BundleData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                System.Windows.Forms.Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
    }
}
