using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using PhBuyModels;

namespace PhBuy
{
	public partial class AddProduct : Form
	{
		private const string ConnectionString =
			"Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

		//Photos Data
		private string _productCoverLocation;
		private string condition;

		//Instance of cover image 
		private readonly ProductImage coverImage = new ProductImage();
		private string description;
		private string fdanum = string.Empty;
		private bool hasCover;

		//Product Data
		private int productID;
		private int imageNo;
		private double length, width, height;
		private string name;

		private string previousLabel = string.Empty;
		private double price;
		private List<byte[]> productImages = new List<byte[]>();
		private int _sellerID;
		private int stock;
		private string type;
		private double weight;

		private MyProducts _myProducts;
		private MemoryStream _stream;
		private SellerPanel _sellerPanel;
		private Products _editedProduct;

		private bool _edit = false;
		public AddProduct(int id, MyProducts m, SellerPanel p)
		{
			//TODO: Connect all forms and get current ID
			_sellerID = id;
			_myProducts = m;
			_sellerPanel = p;
			InitializeComponent();
		}

		private void foodtype_Click(object sender, EventArgs e)
		{
			//Set the color of the font to orange when selected
			var button = (BunifuImageButton) sender;
			if (previousLabel != $"{button.Name}Label")
			{
				var label = (Label)Controls.Find($"{button.Name}Label", true).First();
				label.ForeColor = Color.FromArgb(248, 58, 38);
				type = label.Text;

				//Quickfix
				if (label.Name == "healthLabel") type = "Health";
				//Set the previously clicked type to black
				if (previousLabel != string.Empty)
				{
					label = (Label)Controls.Find(previousLabel, true).First();
					label.ForeColor = Color.FromArgb(45, 41, 66);
				}

				previousLabel = button.Name + "Label";
			}
		}

		private void nextButton1_Click(object sender, EventArgs e)
		{
			if (fdaTextBox.Text != string.Empty) fdanum = fdaTextBox.Text;

			if (type != null && nameTextBox.Text != string.Empty && descriptionTextBox.Text != string.Empty &&
			    nameTextBox.Text.Count() <= 50 && descriptionTextBox.Text.Count() <= 300)
			{
				name = nameTextBox.Text;
				description = descriptionTextBox.Text;
				addProductPages.PageIndex++;
			}
		}

		private void nextButton2_Click(object sender, EventArgs e)
		{
			if (priceTextBox.Text != string.Empty && stockTextBox.Text != string.Empty && hasCover)
			{
				price = double.Parse(priceTextBox.Text);
				stock = int.Parse(stockTextBox.Text);
				addProductPages.PageIndex++;
			}
		}

		private void addImageButton_Click(object sender, EventArgs e)
		{
			if (productImages.Count <= 8)
			{
				var dlg = new OpenFileDialog { Title = "Choose your product image" };
				if (dlg.ShowDialog() != DialogResult.OK) return;
				var imageLoc = dlg.FileName;

				var p = new ProductImage();

				//Set the properties
				p.Tag = imageNo;
				imageNo++;
				p.Name = $"Image {imageNo}";
				p.pictureBox.ImageLocation = imageLoc;
				p.label.Text = $"Image {imageNo}";
				p.Click += ProductImage_Click;
				p.pictureBox.Click += ProductImage_Click2;

				imagesPanel.Controls.Add(p);

				var fs = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
				var br = new BinaryReader(fs);
				productImages.Add(br.ReadBytes((int)fs.Length));

				//Re arrange the buttons
				imagesPanel.Controls.SetChildIndex(addCoverPanel, imagesPanel.Controls.Count);
				imagesPanel.Controls.SetChildIndex(addImagePanel, imagesPanel.Controls.Count);

				imageCountLabel.Text = $"Images: {imageNo} / 8";
			}
			
            else
            {
				//TODO: Bunifu Snackbar or something notification 
            }
		}

		private void addCoverButton_Click(object sender, EventArgs e)
		{
			//If there is no cover, make a new one. Else use the old
			if (!hasCover)
			{
				hasCover = true;
				var dlg = new OpenFileDialog {Title = "Choose your product cover image"};
				if (dlg.ShowDialog() != DialogResult.OK) return;
				_productCoverLocation = dlg.FileName;
				coverImage.Name = "CoverImage";
				coverImage.pictureBox.ImageLocation = _productCoverLocation;
				coverImage.label.Text = "Cover Photo";
				label3.Text = "Edit Cover";
				coverImage.label.Location = new Point(-5, 100);
				imagesPanel.Controls.Add(coverImage);

				//Re arrange the buttons
				imagesPanel.Controls.SetChildIndex(coverImage, 0);
				imagesPanel.Controls.SetChildIndex(addCoverPanel, imagesPanel.Controls.Count);
				imagesPanel.Controls.SetChildIndex(addImagePanel, imagesPanel.Controls.Count);
			}

			
			else
			{
				var dlg = new OpenFileDialog {Title = "Choose your product cover image"};
				if (dlg.ShowDialog() != DialogResult.OK) return;
				_productCoverLocation = dlg.FileName;
				coverImage.pictureBox.ImageLocation = _productCoverLocation;
			}
		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			if (weightTextBox.Text != string.Empty && lengthTextBox.Text != string.Empty
			                                       && widthTextBox.Text != string.Empty &&
			                                       heightTextBox.Text != string.Empty)
			{
				weight = double.Parse(weightTextBox.Text);
				height = double.Parse(heightTextBox.Text);
				width = double.Parse(widthTextBox.Text);
				length = double.Parse(lengthTextBox.Text);

				if (newRadioButton.Checked) condition = "New";
				else condition = "Used";


				byte[] productCover = null;

				productID = (int) GenerateId();

				//Confirm the stuff
				var myConnection = new SqlConnection(ConnectionString);
				//Add new entries
				var queryString = "INSERT INTO Products VALUES(@ProductID, @SellerID, @Name" +
				                  ", @Price, @Cover, @Stock, @Weight, @Length, @Width, @Height, @Condition, @Description, @FDANumber, @Type);";


				if (_edit)
				{
					queryString = "UPDATE Products SET " +
						"Name = @Name, Price = @Price, Picture = @Cover, " +
						"Stock = @Stock, Weight = @Weight, Length = @Length, " +
						"Width = @Width, Height = @Height, Condition = @Condition, " +
						"Description = @Description, FDA_Number = @FDANumber, Type = @Type " +
						$"WHERE ProductID = {_editedProduct.ProductId}";

					productID = (int)_editedProduct.ProductId;

					_stream = new MemoryStream();
					coverImage.pictureBox.Image.Save(_stream, ImageFormat.Jpeg);
					productCover = _stream.ToArray();
				}

                else
                {
					var fs = new FileStream(_productCoverLocation, FileMode.Open, FileAccess.Read);
					var br = new BinaryReader(fs);
					productCover = br.ReadBytes((int)fs.Length);
				}
				myConnection.Open();

				//Crap ton of parameters aaaa
				var param1 = new SqlParameter {ParameterName = "@ProductID", Value = productID};
				var param2 = new SqlParameter {ParameterName = "@SellerID", Value = _sellerID};
				var param3 = new SqlParameter {ParameterName = "@Name", Value = name};
				var param4 = new SqlParameter {ParameterName = "@Price", Value = price};
				var param5 = new SqlParameter {ParameterName = "@Cover", Value = productCover};
				var param6 = new SqlParameter {ParameterName = "@Stock", Value = stock};
				var param7 = new SqlParameter {ParameterName = "@Weight", Value = weight};
				var param8 = new SqlParameter {ParameterName = "@Length", Value = length};
				var param9 = new SqlParameter {ParameterName = "@Width", Value = width};
				var param10 = new SqlParameter {ParameterName = "@Height", Value = height};
				var param11 = new SqlParameter {ParameterName = "@Condition", Value = condition};
				var param12 = new SqlParameter {ParameterName = "@Description", Value = description};
				var param13 = new SqlParameter {ParameterName = "@FDANumber", Value = fdanum};
				var param14 = new SqlParameter {ParameterName = "@Type", Value = type};

				var cmd = new SqlCommand(queryString, myConnection);

				if (!_edit)
				{
					cmd.Parameters.Add(param1);
					cmd.Parameters.Add(param2);
				}

				cmd.Parameters.Add(param3);
				cmd.Parameters.Add(param4);
				cmd.Parameters.Add(param5);
				cmd.Parameters.Add(param6);
				cmd.Parameters.Add(param7);
				cmd.Parameters.Add(param8);
				cmd.Parameters.Add(param9);
				cmd.Parameters.Add(param10);
				cmd.Parameters.Add(param11);
				cmd.Parameters.Add(param12);
				cmd.Parameters.Add(param13);
				cmd.Parameters.Add(param14);

				cmd.ExecuteNonQuery();

				myConnection.Close();

				queryString = "INSERT INTO ProductImages(ImageID, ProductID, Picture) VALUES(@ImageID, @ProductID, @Image);";

				InsertImages(queryString, productID);

				_myProducts.LoadProducts();
			}

			//Go back to my products after editing
			ClearValues();

			_sellerPanel.sellerDashBoard.sellerTabControl.SelectedIndex = 3;
            
		}

		//First event when the product form is clicked
		private void ProductImage_Click(object sender, EventArgs e)
		{
			imageNo--;
			imageCountLabel.Text = $"Images: {imageNo} / 8";
			var p = (ProductImage) sender;
			imagesPanel.Controls.Remove(imagesPanel.Controls.Find(p.Name, true).First());
			productImages.Remove(GetImageByte(p));
			RenameImages(p.label.Text);
		}

		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			addProductPages.PageIndex--;
		}
		private byte[] GetImageByte(ProductImage p)
        {
			_stream = new MemoryStream();
			p.pictureBox.Image.Save(_stream, ImageFormat.Jpeg);
			return _stream.ToArray();
		}

		//Second event when the picture in the product image is clicked
		private void ProductImage_Click2(object sender, EventArgs e)
		{
			imageNo--;
			imageCountLabel.Text = $"Images: {imageNo} / 8";
			var p = (PictureBox) sender;
			var i = (ProductImage) p.Parent;
			productImages.RemoveAt((int)i.Tag);
			imagesPanel.Controls.Remove(imagesPanel.Controls.Find(p.Parent.Name, true).First());
			RenameImages(i.label.Text);
		}

		//Method to rename images in order when deleting
		private void RenameImages(string imageName)
		{
			//Start at the deleted image
			var i = int.Parse(imageName.Split(' ')[1]) - 1;

			for (; i < imageNo; i++)
			{
				ProductImage p;

				//If there is a cover image, move on to the next control
				if (hasCover)
					p = (ProductImage) imagesPanel.Controls[i + 1];
				else
					p = (ProductImage) imagesPanel.Controls[i];

				p.Name = $"Image {i + 1}";
				p.Tag = i;
				p.label.Text = $"Image {i + 1}";
			}
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
		private void descriptionTextBox_TextChange(object sender, EventArgs e)
		{
			descCharCountLabel.Text = $"{descriptionTextBox.Text.Count()} / 300";
			// TODO: Notify the user when it is empty or beyond the count
		}

        private void backButton_Click(object sender, EventArgs e)
        {
			addProductPages.PageIndex--;
        }

        private void nameTextBox_TextChange(object sender, EventArgs e)
		{
			nameCharCountLabel.Text = $"{nameTextBox.Text.Count()} / 50";
			// TODO: Notify the user when it is empty or beyond the count
		}

		private void InsertImages(string queryString, int productID)
		{
			var myConnection = new SqlConnection(ConnectionString);
			myConnection.Open();

			SqlCommand cmd;
			var param = new SqlParameter();
			var param2 = new SqlParameter();
			var param3 = new SqlParameter();

			if(_edit)
            {
				string queryString2 = $"DELETE FROM ProductImages WHERE ProductID = {productID}";
				cmd = new SqlCommand(queryString2, myConnection);
				cmd.ExecuteNonQuery();
			}

			cmd = new SqlCommand(queryString, myConnection);
			param.ParameterName = "@ProductID";
			param2.ParameterName = "@Image";
			param3.ParameterName = "@ImageID";
			for (var i = 0; i < productImages.Count; i++)
			{
				param.Value = productID;
				param2.Value = productImages[i];
				param3.Value = (int)GenerateId();

				cmd.Parameters.Add(param);
				cmd.Parameters.Add(param2);
				cmd.Parameters.Add(param3);
				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
			}

			myConnection.Close();
		}

		public void SetValues(Products p)
        {
			imageNo = 0;
			previousLabel = p.Type;
			_editedProduct = p;
			_edit = true;
			ClearExcessImages();
			_stream = new MemoryStream(p.Picture);

			//Set Cover
			coverImage.pictureBox.Image = Image.FromStream(_stream);
			coverImage.label.Text = "Cover Photo";
			coverImage.Name = "CoverImage";
			coverImage.label.Location = new Point(-5, 100);
			label3.Text = "Edit Cover";
			hasCover = true;

			imagesPanel.Controls.Add(coverImage);
			imagesPanel.Controls.SetChildIndex(coverImage, 0);

			nameTextBox.Text = p.Name;
			descriptionTextBox.Text = p.Description;
			type = p.Type;
			Label l = (Label)Controls.Find($"{p.Type}Label", true).First();
			l.ForeColor = Color.FromArgb(248, 58, 38);
            fdaTextBox.Text = p.FdaNumber;
			priceTextBox.Text = p.Price.ToString();
			int Stock = (int)p.Stock;
			stockTextBox.Text = Stock.ToString();
			SetImages((int)p.ProductId);

			weightTextBox.Text = p.Weight.ToString();
			lengthTextBox.Text = p.Length.ToString();
			widthTextBox.Text = p.Width.ToString();
			heightTextBox.Text = p.Height.ToString();
		}

        private void Cancel_Click(object sender, EventArgs e)
        {
			ClearValues();
			_sellerPanel.sellerDashBoard.sellerTabControl.SelectedIndex = 3;
		}

		public void ClearValues()
        {
			ClearExcessImages();
			imageNo = 0;
			previousLabel = string.Empty;
			weightTextBox.Text = string.Empty;
			lengthTextBox.Text = string.Empty;
			widthTextBox.Text = string.Empty;
			heightTextBox.Text = string.Empty;
			nameTextBox.Text = string.Empty;
			descriptionTextBox.Text = string.Empty;
			priceTextBox.Text = string.Empty;
			stockTextBox.Text = string.Empty;
			fdaTextBox.Text = string.Empty;
			type = string.Empty;
			hasCover = false;
			productImages.Clear();
			if (_edit) _edit = false;
		}
        private void SetImages(int id)
        {
			PhBuyContext data = new PhBuyContext();

			foreach(var p in data.ProductImages.Where(p => p.ProductId == id))
            {
				_stream = new MemoryStream(p.Picture);
				ProductImage image = new ProductImage();
				image.Tag = imageNo;
				imageNo++;
				image.label.Text = $"Image {imageNo}";
				image.Name = $"Image {imageNo}";
				image.pictureBox.Image = Image.FromStream(_stream);
				image.Click += ProductImage_Click;
				image.pictureBox.Click += ProductImage_Click2;
				imagesPanel.Controls.Add(image);
				imagesPanel.Controls.SetChildIndex(image, imageNo);
				productImages.Add(p.Picture);
			}

			imageCountLabel.Text = $"{imageNo} / 8";
		}

		private void ClearExcessImages()
        {
			if (imagesPanel.Controls.Count > 2)
			{
				int increments = imagesPanel.Controls.Count - 2;
				for (int i = 0; i < increments; i++)
				{
					imagesPanel.Controls.RemoveAt(0);
				}
			}
        }
	}
}