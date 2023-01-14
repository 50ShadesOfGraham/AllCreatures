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
using System.IO;
using System.Drawing;
using System.Text;

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
                                                                             System.Text.UTF8Encoding.ASCII.GetBytes(dRow.ItemArray.GetValue(6).ToString()),
                                                                             System.Text.UTF8Encoding.ASCII.GetBytes(dRow.ItemArray.GetValue(7).ToString()),
                                                                             System.Text.UTF8Encoding.ASCII.GetBytes(dRow.ItemArray.GetValue(8).ToString()),
                                                                             dRow.ItemArray.GetValue(10).ToString(),
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
        public void InsertHorseAdvertisement(Horse horse)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From HorseAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "HorseAdData");
                maxAdverts = ds.Tables["HorseAdData"].Rows.Count;
                DataRow dRow = ds.Tables["HorseAdData"].NewRow();
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
                dRow[13] = horse.Broken;
                dRow[14] = horse.Breed;
                dRow[15] = horse.Purpose;
                ds.Tables["HorseAdData"].Rows.Add(dRow);
                da.Update(ds, "HorseAdData");
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
        public void InsertGenericAnimalAdvertisement(GenericAnimal genericAnimal)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From GenericAnimalAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GAAdData");
                maxAdverts = ds.Tables["GAAdData"].Rows.Count;
                DataRow dRow = ds.Tables["GAAdData"].NewRow();
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
                dRow[13] = genericAnimal.DetailOne;
                dRow[14] = genericAnimal.DetailTwo;
                dRow[15] = genericAnimal.DetailThree;
                ds.Tables["GAAdData"].Rows.Add(dRow);
                da.Update(ds, "GAAdData");
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
        public void InsertFarmAnimalAdvertisement(FarmAnimal farmAnimal)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From FarmAnimalAdvertisement";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "FAAdData");
                maxAdverts = ds.Tables["FAAdData"].Rows.Count;
                DataRow dRow = ds.Tables["FAAdData"].NewRow();
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
                dRow[13] = farmAnimal.Purpose;
                ds.Tables["FAAdData"].Rows.Add(dRow);
                da.Update(ds, "FAAdData");
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
        public void InsertLitterAdvertisement(Litter litter)
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
                ds.Tables["LitterData"].Rows.Add(dRow);
                da.Update(ds, "LitterData");
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
        public void InsertAccessoriesAdvertisement(Accessories accessory)
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
                dRow[0] = accessory.AdvertID;
                dRow[1] = accessory.SellerEmail;
                dRow[2] = accessory.Title;
                dRow[3] = accessory.Description;
                dRow[4] = accessory.Price;
                dRow[5] = accessory.Verified;
                dRow[6] = accessory.Status;
                dRow[7] = accessory.ImageOne;
                dRow[8] = accessory.ImageTwo;
                dRow[9] = accessory.ImageThree;
                dRow[10] = accessory.AccessCategory;
                dRow[11] = accessory.SubAccessCategory;
                ds.Tables["AccessData"].Rows.Add(dRow);
                da.Update(ds, "AccessData");
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
        public void InsertFoodAdvertisement(Food food)
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
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
                //eddie
            }
        }
        public void InsertBundle(Bundle bundle) 
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
                //eddie
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
        public void addNewHorseToDB(int advertid, string selleremail, string title, string description, double price, bool verified, string status, string animalname, int age, string gender, string size, bool broken, string breed, string purpose)
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
                //dRow[7] = imageone;
                //dRow[8] = imagetwo;
               // dRow[9] = imagethree;
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
