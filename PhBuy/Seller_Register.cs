using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class Seller_Register : Form
    {
        private string connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";
        private string name;
        private string location;
        private string description;
        private string link;
        private string type;
        private string sellerImageLocation;
        private byte[] sellerImage;
        private byte[] sellerCover;
        private int contact;
        private int ID;
        
        public Seller_Register(int id)
        {
            ID = id;
            InitializeComponent();
            sellerImageLocation = sellerPicture.ImageLocation;
        }

        #region Events

        private void nextButton1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != string.Empty && locationTextBox.Text 
                != string.Empty && descriptionTextBox.Text != string.Empty)
            {
                //Set Values
                name = nameTextBox.Text;
                location = locationTextBox.Text;
                description = descriptionTextBox.Text;
                //Switch Page
                registerPages.PageIndex = 1;
            }
        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            if (contactTextBox.Text != string.Empty && linkTextBox.Text != string.Empty 
                && typeDropDown.Text != string.Empty)
            {
                //Set Values
                contact = int.Parse(contactTextBox.Text);
                link = linkTextBox.Text;
                type = typeDropDown.Text;
                //Switch Page
                registerPages.PageIndex = 2;
            }
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose your product image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sellerImageLocation = dlg.FileName.ToString();
                sellerPicture.ImageLocation = sellerImageLocation;
            }
        }

        private void uploadBackgroundButton_Click(object sender, EventArgs e)
        {
            CoverForm form = new CoverForm(this);
            form.Location = new Point(1000, 268);
            form.Show();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {         
            string queryString = "INSERT INTO Seller VALUES(@ID, @Name, @Contact, @Pic, @Background, @Link, @Description, @Location);" +
                "INSERT INTO SellerTypes VALUES (@SellerID, @Type)";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlParameter param1 = new SqlParameter() { ParameterName = "@ID", Value = ID };
            SqlParameter param2 = new SqlParameter() { ParameterName = "@Name", Value = name };
            SqlParameter param3 = new SqlParameter() { ParameterName = "@Contact", Value = contact };
            SqlParameter param4 = new SqlParameter() { ParameterName = "@Link", Value = link };
            SqlParameter param5 = new SqlParameter() { ParameterName = "@Pic", Value = sellerImage };
            SqlParameter param6 = new SqlParameter() { ParameterName = "@Background", Value = sellerCover };
            SqlParameter param7 = new SqlParameter() { ParameterName = "@Description", Value = description };
            SqlParameter param8 = new SqlParameter() { ParameterName = "@Type", Value = type };
            SqlParameter param9 = new SqlParameter() { ParameterName = "@SellerID", Value = ID };
            SqlParameter param10 = new SqlParameter() { ParameterName = "@Location", Value = location };
            SqlCommand cmd = new SqlCommand(queryString, myConnection);

            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            cmd.Parameters.Add(param4);
            cmd.Parameters.Add(param5);
            cmd.Parameters.Add(param6);
            cmd.Parameters.Add(param7);
            cmd.Parameters.Add(param8);
            cmd.Parameters.Add(param9);
            cmd.Parameters.Add(param10);
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        #endregion

        #region Helper Functions
        public void SetImage()
        {
            MemoryStream stream = new MemoryStream();
            sellerBackground.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            sellerCover = stream.ToArray();

            FileStream fs = new FileStream(sellerImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            sellerImage = br.ReadBytes((int)fs.Length);
        }
        #endregion
    }
}
