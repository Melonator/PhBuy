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
    public partial class Register : Form
    {
        public string connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

        public Register()
        {
            InitializeComponent();
        }
        #region Events

        private void registerButton_Click(object sender, EventArgs e)
        {
            int EntryStatus = AreEntriesValid();

            if (EntryStatus == 0)
            {
                RegisterUser(nameTextBox.Text, passTextBox.Text); //Valid Entries
                MessageBox.Show("Yay!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (EntryStatus == 1) MessageBox.Show("Please type a different name", "User already exists!", MessageBoxButtons.OK, MessageBoxIcon.Error); //User already exists
            else if (EntryStatus == 2) MessageBox.Show("Please type matching passwords", "Passwords do not match!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Passwords do not match
            else if (EntryStatus == 3) MessageBox.Show("Please fill in all the textboxes", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Error); //Textbox are empty
        }

        #endregion

        #region Helper Functions

        private int AreEntriesValid()
        {
            string username = nameTextBox.Text;
            string password = passTextBox.Text;
            string cPassword = confirmTextBox.Text;

            SqlConnection myConnection = new SqlConnection(connectionString);
            if (username != string.Empty && password != string.Empty && cPassword != string.Empty)
            {
                if (isMatch(password, cPassword)) //The passwords msut be matching
                {
                    

                    //Query based on the textbox
                    string queryString = "SELECT Name FROM Profiles WHERE Name = @Name;";
                    SqlCommand oCmd = new SqlCommand(queryString, myConnection);
                    SqlParameter param = new SqlParameter { ParameterName = "@Name", Value = username };
                    oCmd.Parameters.Add(param);
                    myConnection.Open();
                    SqlDataReader oReader = oCmd.ExecuteReader();
                   
                    while (oReader.Read())
                    {
                        if (oReader["Name"].ToString() == username)
                        {
                            myConnection.Close();
                            return 1; //Username exists
                        }
                    }
                }

                else
                {
                    //Passwords do not match
                    myConnection.Close();
                    return 2;
                }
            }

            //Textbox is empty
            else
            {
                myConnection.Close();
                return 3;
            }

            //Entries are valid
            return 0;
        }

        private bool isMatch(string one, string two)
        {
            return one == two;
        }

        private void RegisterUser(string name, string password)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            //Add new entries
            string queryString = "INSERT INTO Profiles VALUES(@ID, @Name, @Password);";

            myConnection.Open();
            SqlParameter param1 = new SqlParameter() { ParameterName = "@ID", Value = GenerateID() };
            SqlParameter param2 = new SqlParameter() { ParameterName = "@Name", Value = name };
            SqlParameter param3 = new SqlParameter() { ParameterName = "@Password", Value = password };

            SqlCommand cmd = new SqlCommand(queryString, myConnection);
            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);

            cmd.ExecuteNonQuery();
            myConnection.Close();

        }

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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
