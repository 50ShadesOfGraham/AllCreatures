using BusinessEntities;
using Microsoft.VisualBasic.Logging;

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Windows.Controls;
using System.Windows.Documents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using User = BusinessEntities.User;
using System.Diagnostics.Metrics;

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
                                                        dRow.ItemArray.GetValue(5).ToString(),
                                                        dRow.ItemArray.GetValue(6).ToString(),
                                                        dRow.ItemArray.GetValue(7).ToString(),
                                                        dRow.ItemArray.GetValue(8).ToString(),
                                                        dRow.ItemArray.GetValue(9).ToString(),
                                                        dRow.ItemArray.GetValue(10).ToString());
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
            string sql = "";
            try
            {
                ds = new DataSet();
                sql = "SELECT * From DogAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "DogAdvert");
                maxAdverts = ds.Tables["DogAdvert"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["DogAdvert"].Rows[i];
                    Dog advert = AdvertisementCreator.GetDog(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                dRow.ItemArray.GetValue(1).ToString(),
                                                                dRow.ItemArray.GetValue(2).ToString(),
                                                                dRow.ItemArray.GetValue(3).ToString(),
                                                                Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                dRow.ItemArray.GetValue(6).ToString(),
                                                                dRow.ItemArray.GetValue(10).ToString(),
                                                                "Dog",
                                                                Convert.ToInt32(dRow.ItemArray.GetValue(11)),
                                                                dRow.ItemArray.GetValue(12).ToString(),
                                                                Convert.ToBoolean(dRow.ItemArray.GetValue(13)),
                                                                dRow.ItemArray.GetValue(14).ToString(),
                                                                dRow.ItemArray.GetValue(15).ToString());
                        AdvertList.Add(advert);
                }
                ds = new DataSet();
                sql = "SELECT * From HorseAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "HorseAdvert");
                maxAdverts = ds.Tables["HorseAdvert"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["HorseAdvert"].Rows[i];
                    Horse advert = AdvertisementCreator.GetHorse(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                dRow.ItemArray.GetValue(1).ToString(),
                                                                dRow.ItemArray.GetValue(2).ToString(),
                                                                dRow.ItemArray.GetValue(3).ToString(),
                                                                Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                dRow.ItemArray.GetValue(6).ToString(),
                                                                dRow.ItemArray.GetValue(10).ToString(),
                                                                "Horse",
                                                                Convert.ToInt32(dRow.ItemArray.GetValue(11)),
                                                                dRow.ItemArray.GetValue(12).ToString(),
                                                                dRow.ItemArray.GetValue(13).ToString(),
                                                                Convert.ToBoolean(dRow.ItemArray.GetValue(14)),
                                                                dRow.ItemArray.GetValue(15).ToString(),
                                                                dRow.ItemArray.GetValue(16).ToString());
                    AdvertList.Add(advert);
                }
                ds = new DataSet();
                sql = "SELECT * From FarmAnimalAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "FarmAdvert");
                maxAdverts = ds.Tables["FarmAdvert"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["FarmAdvert"].Rows[i];
                    FarmAnimal advert = AdvertisementCreator.GetFarmAnimal(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                dRow.ItemArray.GetValue(1).ToString(),
                                                                dRow.ItemArray.GetValue(2).ToString(),
                                                                dRow.ItemArray.GetValue(3).ToString(),
                                                                Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                dRow.ItemArray.GetValue(6).ToString(),
                                                                dRow.ItemArray.GetValue(10).ToString(),
                                                                dRow.ItemArray.GetValue(11).ToString(),
                                                                Convert.ToInt32(dRow.ItemArray.GetValue(12)),
                                                                dRow.ItemArray.GetValue(13).ToString(),
                                                                dRow.ItemArray.GetValue(14).ToString());
                  
                    AdvertList.Add(advert);
                }
                ds = new DataSet();
                sql = "SELECT * From GenericAnimalAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GAAdvert");
                maxAdverts = ds.Tables["GAAdvert"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["GAAdvert"].Rows[i];
                    GenericAnimal advert = AdvertisementCreator.GetGenericAnimal(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                                dRow.ItemArray.GetValue(1).ToString(),
                                                                                dRow.ItemArray.GetValue(2).ToString(),
                                                                                dRow.ItemArray.GetValue(3).ToString(),
                                                                                Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                                Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                                dRow.ItemArray.GetValue(6).ToString(),
                                                                                dRow.ItemArray.GetValue(10).ToString(),
                                                                                dRow.ItemArray.GetValue(11).ToString(),
                                                                                Convert.ToInt32(dRow.ItemArray.GetValue(12)),
                                                                                dRow.ItemArray.GetValue(13).ToString(),
                                                                                dRow.ItemArray.GetValue(14).ToString(),
                                                                                dRow.ItemArray.GetValue(15).ToString(),
                                                                                dRow.ItemArray.GetValue(16).ToString());

                    AdvertList.Add(advert);
                }
                ds = new DataSet();
                sql = "SELECT * From LitterAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "LitterAdvert");
                maxAdverts = ds.Tables["LitterAdvert"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["LitterAdvert"].Rows[i];
                    Litter advert = AdvertisementCreator.GetLitter(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                                dRow.ItemArray.GetValue(1).ToString(),
                                                                                dRow.ItemArray.GetValue(2).ToString(),
                                                                                dRow.ItemArray.GetValue(3).ToString(),
                                                                                Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                                Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                                dRow.ItemArray.GetValue(6).ToString(),
                                                                                "NoName",
                                                                                 dRow.ItemArray.GetValue(10).ToString(),
                                                                                Convert.ToInt32(dRow.ItemArray.GetValue(11)),
                                                                                "MULTI",
                                                                                Convert.ToInt32(dRow.ItemArray.GetValue(12)),
                                                                                Convert.ToBoolean(dRow.ItemArray.GetValue(13)),
                                                                                dRow.ItemArray.GetValue(14).ToString(),
                                                                                dRow.ItemArray.GetValue(15).ToString());

                    AdvertList.Add(advert);
                }
                ds = new DataSet();
                sql = "SELECT * From FoodAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "FoodAdvert");
                maxAdverts = ds.Tables["FoodAdvert"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["FoodAdvert"].Rows[i];
                    Food advert = AdvertisementCreator.GetFood(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                                dRow.ItemArray.GetValue(1).ToString(),
                                                                                dRow.ItemArray.GetValue(2).ToString(),
                                                                                dRow.ItemArray.GetValue(3).ToString(),
                                                                                Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                                Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                                dRow.ItemArray.GetValue(6).ToString(),
                                                                                dRow.ItemArray.GetValue(10).ToString(),
                                                                                dRow.ItemArray.GetValue(11).ToString());

                    AdvertList.Add(advert);
                }
                ds = new DataSet();
                sql = "SELECT * From AccessoriesAdvertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AccessAdvert");
                maxAdverts = ds.Tables["AccessAdvert"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["AccessAdvert"].Rows[i];
                    Accessories advert = AdvertisementCreator.GetAccessories(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                                dRow.ItemArray.GetValue(1).ToString(),
                                                                                dRow.ItemArray.GetValue(2).ToString(),
                                                                                dRow.ItemArray.GetValue(3).ToString(),
                                                                                Convert.ToDouble(dRow.ItemArray.GetValue(4)),
                                                                                Convert.ToBoolean(dRow.ItemArray.GetValue(5)),
                                                                                dRow.ItemArray.GetValue(6).ToString(),
                                                                                dRow.ItemArray.GetValue(10).ToString(),
                                                                                dRow.ItemArray.GetValue(11).ToString());

                    AdvertList.Add(advert);
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

        public void addUserPaymentDetailsToDB(string email, string paymenttype, string cardnumber, string cardholdername, int cvc)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From UserPayment";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                maxAdverts = ds.Tables["UsersData"].Rows.Count;
                DataRow dRow = ds.Tables["UsersData"].NewRow();
                dRow[0] = email;
                dRow[1] = paymenttype;
                dRow[2] = cardnumber;
                dRow[3] = cardholdername;
                dRow[4] = cvc;

                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close

            }
        }

        public void addNewUserToDB(string email, string firstname, string lastname, string password, string usertype,string address1, string address2, string address3,
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
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
                //eddie
            }
        }

        public void addNewAdvertToDB(string advertid, string selleremail, double price, string description, bool verified, string status, string adverttype, string title)
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
        public void addNewAccessoriesToDB(string accessid, string animaltype, string advertid, string accesscategory, string accesssubcat)
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
        public void addNewFoodToDB(string foodID, string animaltype, string advertid, string details)
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
        public void addNewAnimalToDB(string animalid, string advertid, string animalname, string animaltype, int age, bool islitter)
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
        public void addNewDogToDB(string dogid, string animalid, bool purebreed, string breedone, string breedtwo)
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

        public void addNewHorseToDB(string horseid, string animalid, string purpose, string size, bool broken, string breed)
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
        public void addNewFarmAnimalToDB(string farmid, string animalid, string purpose)
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
        public void addNewGenericAnimalToDB(string gaID, string animalID, string detailone, string detailtwo, string detailthree)
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
        public void addNewLitterToDB(string litterid, int littersize, string animalid)
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
        public void addNewBundleToDB(string bundleID, string advertid, double bundleprice, int bundlesize)
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
                dRow[1] = advertid;
                dRow[2] = bundleprice;
                dRow[3] = bundlesize;
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
        public void addNewUserToDB(string email, string firstname, string lastname, string password, bool verified, string usertype,string address1,string address2,string address3,string county,string eircode)
        {
            throw new NotImplementedException();
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
                Application.Exit();
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
                Application.Exit();
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
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public void insertHorseAdvertisement(Horse horse)
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
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public void insertFarmAnimalAdvertisement(FarmAnimal farmAnimal)
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
                dRow[10] = farmAnimal.AnimalName;
                dRow[11] = farmAnimal.Age;
                dRow[12] = farmAnimal.Gender;
                dRow[13] = farmAnimal.Purpose;
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

        public void insertFoodAdvertisement(Food food)
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
        }

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
                dRow[11] = accessories.AccessSubCategory;
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

      
        
        public void verifyUser(User user)
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
    }
}
