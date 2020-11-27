using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class SellerRegisterForm : Form
	{
		private const string ConnectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";
		private string _name;
		private string _location;
		private string _description;
		private string _link;
		private string _type;
		private string _sellerImageLocation;
		private byte[] _sellerImage;
		private byte[] _sellerCover;
		private int _contact;
		private readonly int _id;

		public SellerRegisterForm(int id)
		{
			_id = id;
			InitializeComponent();
			_sellerImageLocation = sellerPicture.ImageLocation;
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
			registerPages.PageIndex = 1;
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
			registerPages.PageIndex = 2;
		}

		private void uploadPhotoButton_Click(object sender, EventArgs e)
		{

			OpenFileDialog dlg = new OpenFileDialog { Title = "Choose your product image" };
			if (dlg.ShowDialog() != DialogResult.OK) return;
			_sellerImageLocation = dlg.FileName;
			sellerPicture.ImageLocation = _sellerImageLocation;
		}

		private void uploadBackgroundButton_Click(object sender, EventArgs e)
		{
			CoverForm form = new CoverForm(this) { Location = new Point(1000, 268) };
			form.Show();
		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			string queryString = "INSERT INTO Seller VALUES(@ID, @Name, @Contact, @Pic, @Background, @Link, @Description, @Location);" +
				"INSERT INTO SellerTypes VALUES (@SellerID, @Type)";
			SqlConnection myConnection = new SqlConnection(ConnectionString);
			myConnection.Open();
			SqlParameter param1 = new SqlParameter() { ParameterName = "@ID", Value = _id };
			SqlParameter param2 = new SqlParameter() { ParameterName = "@Name", Value = _name };
			SqlParameter param3 = new SqlParameter() { ParameterName = "@Contact", Value = _contact };
			SqlParameter param4 = new SqlParameter() { ParameterName = "@Link", Value = _link };
			SqlParameter param5 = new SqlParameter() { ParameterName = "@Pic", Value = _sellerImage };
			SqlParameter param6 = new SqlParameter() { ParameterName = "@Background", Value = _sellerCover };
			SqlParameter param7 = new SqlParameter() { ParameterName = "@Description", Value = _description };
			SqlParameter param8 = new SqlParameter() { ParameterName = "@Type", Value = _type };
			SqlParameter param9 = new SqlParameter() { ParameterName = "@SellerID", Value = _id };
			SqlParameter param10 = new SqlParameter() { ParameterName = "@Location", Value = _location };
			SqlCommand cmd = new SqlCommand(queryString, myConnection);

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

		#region Helper Functions
		public void SetImage()
		{
			MemoryStream stream = new MemoryStream();
			sellerBackground.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
			_sellerCover = stream.ToArray();

			FileStream fs = new FileStream(_sellerImageLocation, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);
			_sellerImage = br.ReadBytes((int)fs.Length);
		}
        #endregion
    }
}
