using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class Register : Form
	{
		private const string ConnectionString =
			"Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

		public Register()
		{
			InitializeComponent();
		}

		#region Events

		private void registerButton_Click(object sender, EventArgs e)
		{
			var entryStatus = AreEntriesValid();

			switch (entryStatus)
			{
				case 0:
					RegisterUser(nameTextBox.Text, passTextBox.Text); //Valid Entries
					MessageBox.Show("Yay!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;
				case 1:
					MessageBox.Show("Please type a different name", "User already exists!", MessageBoxButtons.OK,
						MessageBoxIcon.Error); // User already exists
					break;
				case 2:
					MessageBox.Show("Please type matching passwords", "Passwords do not match!", MessageBoxButtons.OK,
						MessageBoxIcon.Error); // Passwords do not match
					break;
				case 3:
					MessageBox.Show("Please fill in all the textboxes", "Empty Textbox", MessageBoxButtons.OK,
						MessageBoxIcon.Error); // Textboxes are empty
					break;
			}
			this.Close();
		}

		#endregion

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		#region Helper Functions

		private int AreEntriesValid()
		{
			var username = nameTextBox.Text;
			var password = passTextBox.Text;
			var cPassword = confirmTextBox.Text;

			var myConnection = new SqlConnection(ConnectionString);
			if (username != string.Empty && password != string.Empty && cPassword != string.Empty)
			{
				if (password == cPassword) // The passwords must be matching
				{
					// Query based on the textbox
					var queryString = "SELECT Name FROM Profiles WHERE Name = @Name;";
					var oCmd = new SqlCommand(queryString, myConnection);
					var param = new SqlParameter {ParameterName = "@Name", Value = username};
					oCmd.Parameters.Add(param);
					myConnection.Open();
					var oReader = oCmd.ExecuteReader();

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
			var myConnection = new SqlConnection(ConnectionString);
			//Add new entries
			var queryString = "INSERT INTO Profiles VALUES(@ID, @Name, @Password);";

			myConnection.Open();
			var param1 = new SqlParameter {ParameterName = "@ID", Value = (int)GenerateId()};
			var param2 = new SqlParameter {ParameterName = "@Name", Value = name};
			var param3 = new SqlParameter {ParameterName = "@Password", Value = password};

			var cmd = new SqlCommand(queryString, myConnection);
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
			var myConnection = new SqlConnection(ConnectionString);
			var queryString = "SELECT ID FROM Profiles WHERE ID = @ID";

			myConnection.Open();
			var param = new SqlParameter {ParameterName = "@ID", Value = (int)id};
			var cmd = new SqlCommand(queryString, myConnection);
			cmd.Parameters.Add(param);

			var oReader = cmd.ExecuteReader();

			while (oReader.Read())
			{
				float ID = float.Parse(oReader["ID"].ToString());

				if ((int)ID != id) continue;

				myConnection.Close();
				return false;
			}

			myConnection.Close();
			return true;
		}

		#endregion
	}
}