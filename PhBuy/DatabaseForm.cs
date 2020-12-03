using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class DatabaseForm : Form
	{
		private const string ConnectionString =
			"Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

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

			var connection = new SqlConnection(ConnectionString);
			connection.Open();
			var queryString = "SELECT * FROM information_schema.tables;";
			var cmd = new SqlCommand(queryString, connection);
			var oReader = cmd.ExecuteReader();

			while (oReader.Read()) tableDropDown.Items.Add(oReader["TABLE_NAME"].ToString());

			Profiles.DataSource = null; //empty table
			connection.Close();
		}

		private void tableDropDown_SelectedIndexChanged(object sender, EventArgs e)
		{
			var connection = new SqlConnection(ConnectionString);
			connection.Open();
			var queryString = $"SELECT * FROM {tableDropDown.Text}";
			var dataAdapter = new SqlDataAdapter(queryString, connection);
			var table = new DataTable();
			dataAdapter.Fill(table);
			Seller.DataSource = table;
			Seller.BringToFront();
			connection.Close();
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			//Do edits in the database here!
			var connection = new SqlConnection(ConnectionString);
			connection.Open();
			var queryString = $"";
			var cmd = new SqlCommand(queryString, connection);
			cmd.ExecuteNonQuery();
			connection.Close();
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			//Delete the contents of the table selected!

			var connection = new SqlConnection(ConnectionString);
			connection.Open();
			var queryString = $"DELETE FROM {tableDropDown.Text}";
			var cmd = new SqlCommand(queryString, connection);
			cmd.ExecuteNonQuery();
			connection.Close();
		}
	}
}