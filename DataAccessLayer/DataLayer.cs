using BusinessEntities;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
                    IUser user = UserCreator.GetUser(dRow.ItemArray.GetValue(0).ToString(),
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
                string sql = "SELECT * From Advertisement";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "AdvertData");
                maxAdverts = ds.Tables["AdvertData"].Rows.Count;
                for (int i = 0; i < maxAdverts; i++)
                {
                    DataRow dRow = ds.Tables["AdvertData"].Rows[i];
                    Advertisement advert = AdvertisementCreator.GetAdvert(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                        dRow.ItemArray.GetValue(5).ToString());
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
        public void addNewUserToDB(string email, string firstname, string lastname, string password, bool verified, string usertype)
        {
            throw new NotImplementedException();
        }
    }
}
