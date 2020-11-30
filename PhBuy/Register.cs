using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class Register : Form
	{
		private const string ConnectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

		public Register()
		{
			InitializeComponent();
		}
		#region Events

		private void registerButton_Click(object sender, EventArgs e)
		{
			int entryStatus = AreEntriesValid();

			switch (entryStatus)
			{
				case 0:
					RegisterUser(nameTextBox.Text, passTextBox.Text); //Valid Entries
					MessageBox.Show("Yay!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;
				case 1:
					MessageBox.Show("Please type a different name", "User already exists!", MessageBoxButtons.OK, MessageBoxIcon.Error); // User already exists
					break;
				case 2:
					MessageBox.Show("Please type matching passwords", "Passwords do not match!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Passwords do not match
					break;
				case 3:
					MessageBox.Show("Please fill in all the textboxes", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Error); // Textboxes are empty
					break;
			}
		}

		#endregion

		#region Helper Functions

		private int AreEntriesValid()
		{
			string username = nameTextBox.Text;
			string password = passTextBox.Text;
			string cPassword = confirmTextBox.Text;

			SqlConnection myConnection = new SqlConnection(ConnectionString);
			if (username != string.Empty && password != string.Empty && cPassword != string.Empty)
			{
				if (password == cPassword) // The passwords must be matching
				{
					// Query based on the textbox
					string queryString = "SELECT Name FROM Profiles WHERE Name = @Name;";
					SqlCommand oCmd = new SqlCommand(queryString, myConnection);
					SqlParameter param = new SqlParameter { ParameterName = "@Name", Value = username };
					oCmd.Parameters.Add(param);
					myConnection.Open();
					SqlDataReader oReader = oCmd.ExecuteReader();

					while (oReader.Read())
					{
						if (oReader["Name"].ToString() != username) continue;
						myConnection.Close();
						return 1; // Username exists
					}
				}
				else
				{
					// Passwords do not match
					myConnection.Close();
					return 2;
				}
			}

			// Textbox is empty
			else
			{
				myConnection.Close();
				return 3;
			}

			// Entries are valid
			return 0;
		}

		private void RegisterUser(string name, string password)
		{
			SqlConnection myConnection = new SqlConnection(ConnectionString);
			//Add new entries
			string queryString = "INSERT INTO Profiles VALUES(@ID, @Name, @Password);";

			myConnection.Open();
			SqlParameter param1 = new SqlParameter() { ParameterName = "@ID", Value = GenerateId() };
			SqlParameter param2 = new SqlParameter() { ParameterName = "@Name", Value = name };
			SqlParameter param3 = new SqlParameter() { ParameterName = "@Password", Value = password };

			SqlCommand cmd = new SqlCommand(queryString, myConnection);
			cmd.Parameters.Add(param1);
			cmd.Parameters.Add(param2);
			cmd.Parameters.Add(param3);

			cmd.ExecuteNonQuery();
			myConnection.Close();
		}

		private uint GenerateId()
		{
			uint id;
			// Keep on generating the ID until it is a new one
			do
			{
				id = Get5Digits();
			} while (!IsIdValid(id));
			return id;
		}

		private uint Get5Digits()
		{
			var bytes = new byte[4];
			var rng = RandomNumberGenerator.Create();
			rng.GetBytes(bytes);
			return 10000 + BitConverter.ToUInt32(bytes, 0) % 90000;
		}

		private bool IsIdValid(uint id)
		{
			SqlConnection myConnection = new SqlConnection(ConnectionString);
			string queryString = "SELECT ID FROM Profiles WHERE ID = @ID";

			myConnection.Open();
			SqlParameter param = new SqlParameter() { ParameterName = "@ID", Value = id };
			SqlCommand cmd = new SqlCommand(queryString, myConnection);
			cmd.Parameters.Add(param);

			SqlDataReader oReader = cmd.ExecuteReader();

			while (oReader.Read())
			{
				if (oReader["ID"].ToString() != id.ToString()) continue;

				myConnection.Close();
				return false;
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
