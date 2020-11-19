using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        private string imgLoc;
        private int contact;
        
        public Seller_Register()
        {
            InitializeComponent();
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
                registerPages.TabIndex = 1;
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
                registerPages.TabIndex = 2;
            }
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose your product image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                sellerPicture.ImageLocation = imgLoc;
            }
        }

        private void uploadBackgroundButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose your product image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                sellerBackground.ImageLocation = imgLoc;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO Seller VALUES(@ID, @Name, @Contact, @Link, @Pic, @Background, @Description, @Type);";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlParameter param1 = new SqlParameter() { ParameterName = "@ID", Value = GenerateID() };
            SqlParameter param2 = new SqlParameter() { ParameterName = "@Name", Value = name };
            SqlParameter param3 = new SqlParameter() { ParameterName = "@Contact", Value = contact };
            SqlParameter param4 = new SqlParameter() { ParameterName = "@Link", Value = link };
            SqlParameter param5 = new SqlParameter() { ParameterName = "@Pic", Value = null };
            SqlParameter param6 = new SqlParameter() { ParameterName = "@Background", Value = null };
            SqlParameter param7 = new SqlParameter() { ParameterName = "@Description", Value = description };
            SqlParameter param8 = new SqlParameter() { ParameterName = "@Link", Value = type };

            SqlCommand cmd = new SqlCommand(queryString, myConnection);
            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            cmd.Parameters.Add(param4);
            cmd.Parameters.Add(param5);
            cmd.Parameters.Add(param6);
            cmd.Parameters.Add(param7);
            cmd.Parameters.Add(param8);
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        #endregion

        #region Helper Functions
        private int GenerateID()
        {
            Random r = new Random();
            int id = 1 + r.Next(2) * 10000 + r.Next(10000);

            //Keep on generating the ID until it is a new one
            while (!IsIDValid(id)) { id = 1 + r.Next(2) * 10000 + r.Next(10000); }

            return id;
        }

        private bool IsIDValid(int id)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            string queryString = "SELECT ID FROM Profiles WHERE ID = @ID";

            myConnection.Open();
            SqlParameter param = new SqlParameter() { ParameterName = "@ID", Value = id };
            SqlCommand cmd = new SqlCommand(queryString, myConnection);
            cmd.Parameters.Add(param);

            SqlDataReader oReader = cmd.ExecuteReader();

            while (oReader.Read())
            {
                if (oReader["ID"].ToString() == id.ToString())
                {
                    myConnection.Close();
                    return false;
                }
            }

            myConnection.Close();
            return true;
        }

        #endregion
    }
}
