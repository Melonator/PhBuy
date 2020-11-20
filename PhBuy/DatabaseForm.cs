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


            Profiles.DataSource = null; //empty table
            
        }

        private void tableDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = "";
            //Load the table here once the user selects something in the dropdown
            switch (tableDropDown.Text)
            {
                case "Seller":
                    {
                        queryString = "SELECT * FROM Seller;";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        Seller.DataSource = table;
                        Seller.BringToFront();
                    }
                    break;
                case "Products":
                    {
                        queryString = "SELECT * FROM Products;";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        Products.DataSource = table;
                        Products.BringToFront();
                    }
                    break;
                case "Customer":
                    {
                        queryString = "SELECT * FROM Customer;";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        Customer.DataSource = table;
                        Customer.BringToFront();
                    }
                    break;
                case "Orders":
                    {
                        queryString = "SELECT * FROM Orders;";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        Orders.DataSource = table;
                        Orders.BringToFront();
                    }
                    break;
                case "Profiles":
                    {
                        queryString = "SELECT * FROM Profiles;";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        Profiles.DataSource = table;
                        Profiles.BringToFront();
                    }
                    break;
            }

            SqlCommand command = new SqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
