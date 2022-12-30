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
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(4)),
                                                        dRow.ItemArray.GetValue(5).ToString());
                    UserList.Add(user);
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
            return UserList;
        }
        public List<Advertisement> getAllAdvertisements()
        {
            List<Advertisement> AdvertList = new List<Advertisement>();
            
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
                                                                             (byte[])dRow.ItemArray.GetValue(7),
                                                                             (byte[])dRow.ItemArray.GetValue(8),
                                                                             (byte[])dRow.ItemArray.GetValue(9),
                                                                             dRow.ItemArray.GetValue(10).ToString(),
                                                                             "Dog",
                                                                             Convert.ToInt32(dRow.ItemArray.GetValue(11)),
                                                                             dRow.ItemArray.GetValue(12).ToString(),
                                                                             Convert.ToBoolean(dRow.ItemArray.GetValue(13)),
                                                                             dRow.ItemArray.GetValue(14).ToString(),
                                                                             dRow.ItemArray.GetValue(15).ToString()
                                                                             );                                                   
                                                             
                    AdvertList.Add(newDog);
                    MessageBox.Show("Dog: " + newDog.AdvertID + " successfully added");
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
                    MessageBox.Show("NL: " + NotificationList.Count);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show("Notifications: " + excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return NotificationList;
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
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
                //eddie
            }
        }
        public void InsertDogAdvertisement(Dog dog)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From DogAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "DogAdData");
                maxAdverts = ds.Tables["DogAdData"].Rows.Count;
                DataRow dRow = ds.Tables["DogAdData"].NewRow();
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
                dRow[11] = dog.Age;
                dRow[12] = dog.Gender;
                dRow[13] = dog.Purebreed;
                dRow[13] = dog.BreedOne;
                dRow[14] = dog.BreedTwo;
                ds.Tables["DogAdData"].Rows.Add(dRow);
                da.Update(ds, "DogAdData");
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
        public void InsertImageToDB(byte[] image)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Insert into Advertisement(ImageOne) values(@image)"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.ExecuteNonQuery();
                }
            }catch(System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
        }

        public void addNewAdvertToDB(int advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title, byte[] newimage)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Advertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdvertData");
                maxAdverts = ds.Tables["AdvertData"].Rows.Count;
                DataRow dRow = ds.Tables["AdvertData"].NewRow();
                dRow[0] = advertid;
                dRow[1] = selleremail;
                dRow[2] = price;
                dRow[3] = description;
                dRow[4] = verified;
                dRow[5] = status;
                dRow[6] = newimage;
                dRow[9] = adverttype;
                dRow[10] = title;
                ds.Tables["AdvertData"].Rows.Add(dRow);
                da.Update(ds, "AdvertData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewAccessoriesToDB(int accessid, string animaltype, int advertid, string accesscategory, string accesssubcat)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Accessories";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AccessData");
                maxAdverts = ds.Tables["AccessData"].Rows.Count;
                DataRow dRow = ds.Tables["AccessData"].NewRow();
                dRow[0] = accessid;
                dRow[1] = animaltype;
                dRow[2] = advertid;
                dRow[3] = accesscategory;
                dRow[4] = accesssubcat;
                ds.Tables["AccessData"].Rows.Add(dRow);
                da.Update(ds, "AccessData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewFoodToDB(int foodID, string animaltype, int advertid, string details)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Food";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "FoodData");
                maxAdverts = ds.Tables["FoodData"].Rows.Count;
                DataRow dRow = ds.Tables["FoodData"].NewRow();
                dRow[0] = foodID;
                dRow[1] = animaltype;
                dRow[2] = advertid;
                dRow[3] = details;
                ds.Tables["FoodData"].Rows.Add(dRow);
                da.Update(ds, "FoodData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewAnimalToDB(int animalid, int advertid, string animalname, string animaltype, int age, bool islitter)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Animal";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AnimalData");
                maxAdverts = ds.Tables["AnimalData"].Rows.Count;
                DataRow dRow = ds.Tables["AnimalData"].NewRow();
                dRow[0] = animalid;
                dRow[1] = advertid;
                dRow[2] = animalname;
                dRow[3] = animaltype;
                dRow[4] = age;
                dRow[5] = islitter;
                ds.Tables["AnimalData"].Rows.Add(dRow);
                da.Update(ds, "AnimalData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewDogToDB(int dogid, int animalid, bool purebreed, string breedone, string breedtwo)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Dog";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "DogData");
                maxAdverts = ds.Tables["DogData"].Rows.Count;
                DataRow dRow = ds.Tables["DogData"].NewRow();
                dRow[0] = dogid;
                dRow[1] = animalid;
                dRow[2] = purebreed;
                dRow[3] = breedone;
                dRow[4] = breedtwo;
                ds.Tables["DogData"].Rows.Add(dRow);
                da.Update(ds, "DogData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public void addNewHorseToDB(int horseid, int animalid, string purpose, string size, bool broken, string breed)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Horse";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "HorseData");
                maxAdverts = ds.Tables["HorseData"].Rows.Count;
                DataRow dRow = ds.Tables["HorseData"].NewRow();
                dRow[0] = horseid;
                dRow[1] = animalid;
                dRow[2] = purpose;
                dRow[3] = size;
                dRow[4] = broken;
                dRow[5] = breed;
                ds.Tables["HorseData"].Rows.Add(dRow);
                da.Update(ds, "HorseData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewFarmAnimalToDB(int farmid, int animalid, string purpose)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From FarmAnimal";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "FarmData");
                maxAdverts = ds.Tables["FarmData"].Rows.Count;
                DataRow dRow = ds.Tables["FarmData"].NewRow();
                dRow[0] = farmid;
                dRow[1] = animalid;
                dRow[2] = purpose;
                ds.Tables["FarmData"].Rows.Add(dRow);
                da.Update(ds, "FarmData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewGenericAnimalToDB(int gaID, int animalID, string detailone, string detailtwo, string detailthree)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From GenericAnimal";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GAData");
                maxAdverts = ds.Tables["GAData"].Rows.Count;
                DataRow dRow = ds.Tables["GAData"].NewRow();
                dRow[0] = gaID;
                dRow[1] = animalID;
                dRow[2] = detailone;
                dRow[3] = detailtwo;
                dRow[4] = detailthree;
                ds.Tables["GAData"].Rows.Add(dRow);
                da.Update(ds, "GAData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewLitterToDB(int litterid, int littersize, int animalid)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Litter";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "LitterData");
                maxAdverts = ds.Tables["LitterData"].Rows.Count;
                DataRow dRow = ds.Tables["LitterData"].NewRow();
                dRow[0] = litterid;
                dRow[1] = littersize;
                dRow[2] = animalid;
                ds.Tables["LitterData"].Rows.Add(dRow);
                da.Update(ds, "LitterData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void InsertThreeBundle(Bundle bundle)
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
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void InsertTwoBundle(Bundle bundle) 
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
                dRow[4] = bundle.Price;
                ds.Tables["BundleData"].Rows.Add(dRow);
                da.Update(ds, "BundleData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
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
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
    }
}
