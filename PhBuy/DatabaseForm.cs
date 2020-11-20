using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhBuy
{
    public partial class DatabaseForm : Form
    {
        public static string connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            //Load the dropdown contents based on the tables on the database

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = "SELECT * FROM information_schema.tables;";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader oReader = cmd.ExecuteReader();

            while (oReader.Read())
            {
                tableDropDown.Items.Add(oReader["TABLE_NAME"].ToString());
            }
            
            Profiles.DataSource = null; //empty table
            connection.Close();
        }

        private void tableDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = $"SELECT * FROM {tableDropDown.Text}";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            Seller.DataSource = table;
            Seller.BringToFront();
            connection.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //Do edits in the database here!

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = "";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Delete the contents of the table selected!

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = $"DELETE FROM {tableDropDown.Text}";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
