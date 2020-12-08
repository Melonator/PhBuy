using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class MainForm : Form
	{
		//Ill just leave this here
		private const string _connectionString =
			"Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

		private readonly int _id;
		private readonly string _userName;
		public MainForm(string name, int id)
		{
			_id = id;
			_userName = name;
			InitializeComponent();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void bunifuButton5_Click(object sender, EventArgs e)
		{
			var databaseForm = new DatabaseForm();
			databaseForm.Show();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//Determine if the user is a seller or not
			//If seller
			var form2 = new SellerDashBoard() { TopLevel = false };
			form2.Show();
			mainPanel.Controls.Add(form2);

			var form = new SellerPanel(this, _id) { TopLevel = false };
			form.Show();
			sidePanel.Controls.Add(form);
			setInformation();
		}

		private void setInformation()
        {
			int panelDistance = 6;
			userNameLabel.Text = _userName;
			userPhoto.Image = getUserImage();
			userPanel.Location = new Point(bunifuSeparator1.Location.X - panelDistance - userPanel.Width,0);
        }

		private Image getUserImage()
        {
			Image image = null;
			var myConnection = new SqlConnection(_connectionString);
			myConnection.Open();
			var queryString = $"SELECT * FROM Seller WHERE ID = {_id};";
			var oCmd = new SqlCommand(queryString, myConnection);
			var oReader = oCmd.ExecuteReader();
			while (oReader.Read())
            {
				MemoryStream stream = new MemoryStream((byte[])oReader["Picture"]);
				image = Image.FromStream(stream);
			}

			myConnection.Close();
			return image;
		}
    }
}