using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class LandingForm : Form
	{
		private const string ConnectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

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
				CustomerSellerForm form = new CustomerSellerForm(GetUserId());
				form.Show();
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
			SqlConnection myConnection = new SqlConnection(ConnectionString);

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

		private int GetUserId()
		{
			int id = 0;
			SqlConnection myConnection = new SqlConnection(ConnectionString);
			myConnection.Open();
			string queryString = $"SELECT * FROM Profiles WHERE Name = @Name;";
			SqlParameter param = new SqlParameter() { ParameterName = "@Name", Value = nameTextBox.Text };
			SqlCommand oCmd = new SqlCommand(queryString, myConnection);
			oCmd.Parameters.Add(param);
			SqlDataReader oReader = oCmd.ExecuteReader();
			//Return true if the entries are valid else false
			while (oReader.Read())
			{
				id = (int)float.Parse(oReader["ID"].ToString());
			}
			myConnection.Close();
			return id;
		}

		#endregion
	}
}
