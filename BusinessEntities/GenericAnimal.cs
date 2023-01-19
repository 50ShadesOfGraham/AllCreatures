using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class GenericAnimal : Animal
    {
        #region InstanceProperties
        private int genericID;
        private string detailone;
        private string detailtwo;
        private string detailthree;
        #endregion
        #region InstanceProperties
        public string DetailOne
        {
            get { return detailone; }
            set { detailone = value; }
        }
        public string DetailTwo
        {
            get { return detailtwo; }
            set { detailtwo = value; }
        }
        public string DetailThree
        {
            get { return detailthree; }
            set { detailthree = value; }
        }
        public int GenericID
        {
            get { return genericID; }
            set { genericID = value; }
        }
        #endregion
        #region Constructor
        public GenericAnimal()
        {
            throw new System.NotImplementedException();
        }
        public GenericAnimal(int advertid, string selleremail, string title, string description, double price, bool verified, string status, byte[] imageone, byte[] imagetwo, byte[] imagethree, string animalname, string animaltype, int age, string gender,string detailone,string detailtwo,string detailthree) 
            : base(advertid,selleremail,title,description,price,verified,status,imageone,imagetwo,imagethree,animalname,animaltype,age,gender)
        {
            this.genericID = advertid;
            this.detailone= detailone;
            this.detailtwo= detailtwo;
            this.detailthree= detailthree;
        }
        public GenericAnimal(int advertid, string selleremail, string title, string description, double price, bool verified, string status,string animalname, string animaltype, int age, string gender, string detailone, string detailtwo, string detailthree)
            : base(advertid, selleremail, title, description, price, verified, status,animalname, animaltype, age, gender)
        {
            this.genericID = advertid;
            this.detailone = detailone;
            this.detailtwo = detailtwo;
            this.detailthree = detailthree;
        }
        #endregion
    }
}
