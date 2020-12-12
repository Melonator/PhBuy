using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace PhBuy
{
	public partial class LandingForm : Form
	{
		private const string ConnectionString =
			"Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";


		public LandingForm()
		{
			InitializeComponent();
		}

		#region Events

		private void registerButton_Click(object sender, EventArgs e)
		{
			var register = new Register(this);
			register.Show();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Login();
		}

		#endregion

		#region Helper Functions

		private bool AreEntriesValid()
		{
			var username = nameTextBox.Text;
			var password = passTextBox.Text;
			var myConnection = new SqlConnection(ConnectionString);

			if (username != string.Empty && password != string.Empty)
			{
				//Query based on the textbox
				var queryString = "SELECT * FROM Profiles WHERE Name = @Name;";
				var oCmd = new SqlCommand(queryString, myConnection);
				var param = new SqlParameter {ParameterName = "@Name", Value = username};
				oCmd.Parameters.Add(param);
				myConnection.Open();
				var oReader = oCmd.ExecuteReader();
				//Return true if the entries are valid else false
				while (oReader.Read())
                {
					if (oReader["Name"].ToString() == username)
					{
						if (oReader["Password"].ToString() == password)
						{
							myConnection.Close();
							return true;
						}
						bunifuSnackbar1.Show(this, "Incorrect Username/Password!", BunifuSnackbar.MessageTypes.Error);
						return false;
					}
				}
				bunifuSnackbar1.Show(this, "Account does not exist!", BunifuSnackbar.MessageTypes.Error);
			}
			else bunifuSnackbar1.Show(this, "Please enter a Username and Password!", BunifuSnackbar.MessageTypes.Error);
			myConnection.Close();
			return false;
		}

		private int GetUserId()
		{
			var id = 0;
			var myConnection = new SqlConnection(ConnectionString);
			myConnection.Open();
			var queryString = "SELECT * FROM Profiles WHERE Name = @Name;";
			var param = new SqlParameter {ParameterName = "@Name", Value = nameTextBox.Text};
			var oCmd = new SqlCommand(queryString, myConnection);
			oCmd.Parameters.Add(param);
			var oReader = oCmd.ExecuteReader();
			//Return true if the entries are valid else false
			while (oReader.Read()) id = (int) float.Parse(oReader["ID"].ToString());
			myConnection.Close();
			return id;
		}

		private void Login()
        {
			if (AreEntriesValid())
			{
				var form = new CustomerSellerForm(nameTextBox.Text, GetUserId());
				form.Show();
				bunifuSnackbar1.Show(form, "Successfully Logged In!", BunifuSnackbar.MessageTypes.Success);
				Hide();
			}
		}

        #endregion
    }
}