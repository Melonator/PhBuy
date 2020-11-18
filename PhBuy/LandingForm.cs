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
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        #region Events
        private void registerButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!AreEntriesValid())
            {
                MessageBox.Show("Please Register", "Non Existent User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("You may now rest", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Helper Functions

        private bool AreEntriesValid()
        {
            string username = nameTextBox.Text;
            string password = passTextBox.Text;

            string connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";
            SqlConnection myConnection = new SqlConnection(connectionString);

            if (username != string.Empty && password != string.Empty)
            {
                //Query based on the textbox
                string queryString = "SELECT * FROM Profiles WHERE Name = @Name;";
                SqlCommand oCmd = new SqlCommand(queryString, myConnection);
                SqlParameter param = new SqlParameter { ParameterName = "@Name", Value = username };
                oCmd.Parameters.Add(param);
                myConnection.Open();
                SqlDataReader oReader = oCmd.ExecuteReader();
                //Return true if the entries are valid else false
                while (oReader.Read())
                {
                    if (oReader["Name"].ToString() == username && oReader["Password"].ToString() == password)
                    {
                        myConnection.Close();
                        return true;
                    }
                }
            }

            myConnection.Close();
            return false;
        }

        #endregion
    }
}
