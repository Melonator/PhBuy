using PhBuyModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class SellerRegisterForm : Form
	{
		private const string ConnectionString =
			"Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

		private PhBuyContext _data = new PhBuyContext();
		private List<string> _selectedTypes = new List<string>();
		private readonly int _id;
		private readonly string _userName;
		private string _contact;
		private string _description;
		private string _link;
		private string _location;
		private string _shopName;
		private byte[] _sellerCover;
		private byte[] _sellerImage;
		private string _sellerImageLocation;
		private string _type;

		public SellerRegisterForm(string name, int id)
		{
			_id = id;
			_userName = name;
			InitializeComponent();
		}

		#region Helper Functions

		public void SetImage()
		{
			var stream = new MemoryStream();
			sellerBackground.Image.Save(stream, ImageFormat.Jpeg);
			_sellerCover = stream.ToArray();
			stream = new MemoryStream();
			sellerPicture.Image.Save(stream, ImageFormat.Jpeg);
			_sellerImage = stream.ToArray();
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
			_shopName = nameTextBox.Text;
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
			_contact = contactTextBox.Text;
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
			SetImage();

			var s = new Seller();

			s.Id = _id;
			s.Name = _shopName;
			s.Contact = _contact;
			s.Fblink = _link;
			s.Picture = _sellerImage;
			s.Background = _sellerCover;
			s.Descrption = _description;
			s.Location = _location;

			foreach(var a in _selectedTypes)
            {
				var t = new SellerTypes();
				t.SellerId = _id;
				t.TypeId = (int)GenerateId();
				t.Type = a;
				_data.SellerTypes.Add(t);
			}

			_data.Seller.Add(s);
			_data.SaveChanges();

			var main = new MainForm("Seller", null, s);
			main.Show();
			Hide();
		}

        #endregion

        private void typeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
			SellerTypeControl type = new SellerTypeControl();
			type.Name = typeDropDown.Text;
			type.typeLabel.Text = typeDropDown.Text;
			type.Width = type.typeLabel.Width + 25;
			type.Click += sellerTypeControl_Click;
			type.label1.Click += sellerTypeControl_Click2;
			type.typeLabel.Click += sellerTypeControl_Click2;
			_selectedTypes.Add(type.Name);
			typeFlowLayoutPanel.Controls.Add(type);
		}

		private void sellerTypeControl_Click(object sender, EventArgs e)
		{
			SellerTypeControl t = (SellerTypeControl)sender;
			typeFlowLayoutPanel.Controls.Remove(t);
			_selectedTypes.Remove(t.Name);
		}

		private void sellerTypeControl_Click2(object sender, EventArgs e)
		{
			Label l = (Label)sender;
			SellerTypeControl t = (SellerTypeControl)l.Parent;
			typeFlowLayoutPanel.Controls.Remove(t);
			_selectedTypes.Remove(t.Name);
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
			const string queryString = "SELECT ID FROM Profiles WHERE ID = @ID";

			myConnection.Open();
			var param = new SqlParameter { ParameterName = "@ID", Value = (int)id };
			var cmd = new SqlCommand(queryString, myConnection);
			cmd.Parameters.Add(param);

			var oReader = cmd.ExecuteReader();

			while (oReader.Read())
			{
				if (oReader["ID"].ToString() != id.ToString()) continue;

				myConnection.Close();
				return false;
			}

			myConnection.Close();
			return true;
		}
	}
}