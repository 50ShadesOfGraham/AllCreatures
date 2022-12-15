using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;
using DataAccessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using User = BusinessEntities.User;

namespace WindowsClient
{

    public partial class verifyUser : Form
    {
        private IModel Model;
        bool userAccepted = false;

        public verifyUser(IModel model)
        {
            InitializeComponent();
            this.Model = model;
            //ArrayList unverifiedUsers = new ArrayList();
            bool pendingVerify = true;
            //while (pendingVerify == true)
            //{
                foreach (User user in Model.UserList)
            {
                if (user.Verified == false)
                {
                        txtFirstName.Text = user.FirstName;
                        txtLastName.Text = user.LastName;
                        txtEmail.Text = user.Email;
                    
                }
            }
            
                if (userAccepted == true)
                    {
                //change the verified to 1
                Model.verifyUser(txtEmail.Text);
                        //pendingVerify = false;
                        MessageBox.Show("User Verified");
                    }
            

            //}
        }

        private void verifyUser_Load(object sender, EventArgs e)
        {
        }

        //test image upload stuff - to be confirmed once the lads figure how they want to store images.
        public static void UploadUserImage(string path, SqlConnection connection)
        {
            using (var command = connection.CreateCommand())
            {
                Image img = Image.FromFile(path);
                MemoryStream tmpStream = new MemoryStream();
                img.Save(tmpStream, ImageFormat.Png); // change to other format
                tmpStream.Seek(0, SeekOrigin.Begin);
                byte[] imgBytes = new byte[2000000]; //200000 is the max size in bytes
                tmpStream.Read(imgBytes, 0, 2000000);

                command.CommandText = "INSERT INTO images(payload) VALUES (:payload)";
                IDataParameter par = command.CreateParameter();
                par.ParameterName = "payload";
                par.DbType = DbType.Binary;
                par.Value = imgBytes;
                command.Parameters.Add(par);
                command.ExecuteNonQuery();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void descriptionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttlLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttlLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new UserRejectReason())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val = form.RejectReason;
                   /* for (int i = 0; i < Model.UserList.Count; i++)
                    {
                        string user = (string)Model.UserList[i];
                        user = user.Replace("\0", "");
                        Model.UserList[i] = user;
                    }
                   */
                }
            }
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
                    //userAccepted = true;
                    Model.verifyUser(txtEmail.Text);
                    //pendingVerify = false;
                    //MessageBox.Show("User Verified");
        }
    }
}
