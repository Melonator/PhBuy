using System;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class SellerRegisterForm : Form
	{
		private const string ConnectionString =
			"Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

		private readonly int _id;
		private int _contact;
		private string _description;
		private string _link;
		private string _location;
		private string _name;
		private byte[] _sellerCover;
		private byte[] _sellerImage;
		private string _sellerImageLocation;
		private string _type;

		public SellerRegisterForm(int id)
		{
			_id = id;
			InitializeComponent();
		}

		#region Helper Functions

		public void SetImage()
		{
			var stream = new MemoryStream();
			sellerBackground.Image.Save(stream, ImageFormat.Jpeg);
			_sellerCover = stream.ToArray();

			if (_sellerImageLocation == null)
			{
				sellerPicture.Image.Save(stream, ImageFormat.Jpeg);
				_sellerImage = stream.ToArray();
			}
		}

		#endregion

		private void backButton_Click(object sender, EventArgs e)
		{
			//switch page
			registerPages.PageIndex--;
		}

		#region Events

		private void nextButton1_Click(object sender, EventArgs e)
		{
			if (nameTextBox.Text == string.Empty || locationTextBox.Text == string.Empty ||
			    descriptionTextBox.Text == string.Empty) return;
			//Set Values
			_name = nameTextBox.Text;
			_location = locationTextBox.Text;
			_description = descriptionTextBox.Text;
			//Switch Page
			registerPages.PageIndex++;
		}

		private void nextButton2_Click(object sender, EventArgs e)
		{
			if (contactTextBox.Text == string.Empty || linkTextBox.Text == string.Empty ||
			    typeDropDown.Text == string.Empty) return;
			//Set Values
			_contact = int.Parse(contactTextBox.Text);
			_link = linkTextBox.Text;
			_type = typeDropDown.Text;
			//Switch Page
			registerPages.PageIndex++;
		}

		private void uploadPhotoButton_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog {Title = "Choose your product image"};
			if (dlg.ShowDialog() != DialogResult.OK) return;
			_sellerImageLocation = dlg.FileName;
			sellerPicture.ImageLocation = _sellerImageLocation;
		}

		private void uploadBackgroundButton_Click(object sender, EventArgs e)
		{
			var form = new CoverForm(this);
			form.Show();
		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			var queryString =
				"INSERT INTO Seller VALUES(@ID, @Name, @Contact, @Pic, @Background, @Link, @Description, @Location);" +
				"INSERT INTO SellerTypes VALUES (@SellerID, @Type)";
			var myConnection = new SqlConnection(ConnectionString);
			myConnection.Open();
			var param1 = new SqlParameter {ParameterName = "@ID", Value = _id};
			var param2 = new SqlParameter {ParameterName = "@Name", Value = _name};
			var param3 = new SqlParameter {ParameterName = "@Contact", Value = _contact};
			var param4 = new SqlParameter {ParameterName = "@Link", Value = _link};
			var param5 = new SqlParameter {ParameterName = "@Pic", Value = _sellerImage};
			var param6 = new SqlParameter {ParameterName = "@Background", Value = _sellerCover};
			var param7 = new SqlParameter {ParameterName = "@Description", Value = _description};
			var param8 = new SqlParameter {ParameterName = "@Type", Value = _type};
			var param9 = new SqlParameter {ParameterName = "@SellerID", Value = _id};
			var param10 = new SqlParameter {ParameterName = "@Location", Value = _location};
			var cmd = new SqlCommand(queryString, myConnection);

			cmd.Parameters.Add(param1);
			cmd.Parameters.Add(param2);
			cmd.Parameters.Add(param3);
			cmd.Parameters.Add(param4);
			cmd.Parameters.Add(param5);
			cmd.Parameters.Add(param6);
			cmd.Parameters.Add(param7);
			cmd.Parameters.Add(param8);
			cmd.Parameters.Add(param9);
			cmd.Parameters.Add(param10);
			cmd.ExecuteNonQuery();
			myConnection.Close();
		}

		#endregion
	}
}