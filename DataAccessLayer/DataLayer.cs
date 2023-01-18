using BusinessEntities;
using System.Data;
using System.Data.SqlClient;
using MessageBox = System.Windows.Forms.MessageBox;
using System.IO;
using System.Windows;

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
                    MessageBox.Show("Dog: " + newDog.AdvertID + " successfully added");
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
                    MessageBox.Show("Horse: " + horse.AdvertID + " successfully added");
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
                    MessageBox.Show("Farm Animal: " + farmAnimal.AdvertID + " successfully added");
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
                    MessageBox.Show("Farm Animal: " + genricAnimal.AdvertID + " successfully added");
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
                    MessageBox.Show("Litter: " + litter.AdvertID + " successfully added");
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
                    MessageBox.Show("Food: " + food.AdvertID + " successfully added");
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
                    MessageBox.Show("Litter: " + accessories.AdvertID + " successfully added");
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
                getAllAccessoriesAdvertisements(ref AdvertList);
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
                    MessageBox.Show("NL: " + NotificationList.Count);
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
        public void addNewUserToDB(string email, string firstname, string lastname, string password, bool verified, string usertype,string address1,string address2,string address3,string county,string eircode)
        {
            throw new NotImplementedException();
        }

        
        public bool banUserInDB(BusinessEntities.User user)
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
                System.Windows.Forms.Application.Exit();
            }
            return true;

        }

        public void insertDogAdvertisement(Dog dog)
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
                dRow[10] = dog.AnimalName;
                dRow[11] = dog.Age;
                dRow[12] = dog.Gender;
                dRow[13] = dog.Purebreed;
                dRow[14] = dog.BreedOne;
                dRow[15] = dog.BreedTwo;
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

        public void insertGenericAnimalAdvertisement(GenericAnimal generic_animal)
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
                dRow[0] = generic_animal.AdvertID;
                dRow[1] = generic_animal.SellerEmail;
                dRow[2] = generic_animal.Title;
                dRow[3] = generic_animal.Description;
                dRow[4] = generic_animal.Price;
                dRow[5] = generic_animal.Verified;
                dRow[6] = generic_animal.Status;
                dRow[10] = generic_animal.AnimalType;
                dRow[11] = generic_animal.AnimalName;
                dRow[12] = generic_animal.Age;
                dRow[13] = generic_animal.Gender;
                dRow[14] = generic_animal.DetailOne;
                dRow[15] = generic_animal.DetailTwo;
                dRow[16] = generic_animal.DetailThree;
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

        public void insertLitterAdvertisement(Litter litter)
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
/*
        public void insertHorseAdvertisement(Horse horse)
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
        }*/

       /* public bool verifyAdvertisement(Advertisement advertisement)
        {
            //throw new NotImplementedException();

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
                dRow[10] =  food.AnimalType;
                dRow[11] = food.FoodDetails;
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
        }*/

        public void insertAccessoriesAdvertisement(Accessories accessories)
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

      
        
        public void verifyUser(BusinessEntities.User user)
        {
            try
            {
                ds = new DataSet();
                string userEmail = user.Email;
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.Email);
                if (findRow != null)

                {
                    findRow[4] = 1;

                }
                da.Update(ds, "UsersData"); //adjust Verified from 0 to 1 in DB
                MessageBox.Show("Success");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show("Error with verifying user on DB");
                /*
                   if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
                */
            }
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
                DataRow findRow = ds.Tables["AdsData"].Rows.Find(advertisement.Title);
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

      

        public void addNewNotification(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail)
        {
            throw new NotImplementedException();
        }

        public void addNewUserToDB(string email, string firstname, string lastname, string password, bool verified, string usertype)
        {
            throw new NotImplementedException();
        }

        public bool verifyAdvertisement(Advertisement advertisement)
        {
            throw new NotImplementedException();
        }
    }
}
