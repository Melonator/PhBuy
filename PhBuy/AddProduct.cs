using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

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
		private readonly List<byte[]> productImages = new List<byte[]>();
		private int _sellerID;
		private int stock;
		private string type;
		private double weight;

		public AddProduct(int id)
		{
			//TODO: Connect all forms and get current ID
			_sellerID = id;
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
				if (label.Name == "healthLabel") type = "Health & Beauty";
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
				imagesPanel.Controls.SetChildIndex(addImagePanel, imagesPanel.Controls.Count - 1);

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
				imagesPanel.Controls.SetChildIndex(addImagePanel, imagesPanel.Controls.Count - 1);
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
				weight = int.Parse(weightTextBox.Text);
				height = int.Parse(heightTextBox.Text);
				width = int.Parse(widthTextBox.Text);
				length = int.Parse(lengthTextBox.Text);

				if (newRadioButton.Checked) condition = "New";
				else condition = "Used";

				var fs = new FileStream(_productCoverLocation, FileMode.Open, FileAccess.Read);
				var br = new BinaryReader(fs);
				var productCover = br.ReadBytes((int) fs.Length);

				productID = (int) GenerateId();

				//Confirm the stuff
				var myConnection = new SqlConnection(ConnectionString);
				//Add new entries
				var queryString = "INSERT INTO Products VALUES(@ProductID, @SellerID, @Name" +
				                  ", @Price, @Cover, @Stock, @Weight, @Length, @Width, @Height, @Condition, @Description, @FDANumber, @Type);";

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
				cmd.Parameters.Add(param11);
				cmd.Parameters.Add(param12);
				cmd.Parameters.Add(param13);
				cmd.Parameters.Add(param14);

				cmd.ExecuteNonQuery();

				myConnection.Close();

				queryString = "INSERT INTO ProductImages(ProductID, Picture) VALUES(@ProductID, @Image);";
				InsertImages(queryString, productID);
			}
		}

		//First event when the product form is clicked
		private void ProductImage_Click(object sender, EventArgs e)
		{
			imageNo--;
			imageCountLabel.Text = $"Images: {imageNo} / 8";
			var p = (ProductImage) sender;
			imagesPanel.Controls.Remove(imagesPanel.Controls.Find(p.Name, true).First());
			RenameImages(p.label.Text);
		}

		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			addProductPages.PageIndex--;
		}

		//Second event when the picture in the product image is clicked
		private void ProductImage_Click2(object sender, EventArgs e)
		{
			imageNo--;
			imageCountLabel.Text = $"Images: {imageNo} / 8";
			var p = (PictureBox) sender;
			var i = (ProductImage) p.Parent;
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

			var cmd = new SqlCommand(queryString, myConnection);
			var param = new SqlParameter();
			var param2 = new SqlParameter();

			param.ParameterName = "@ProductID";
			param2.ParameterName = "@Image";

			for (var i = 0; i < productImages.Count; i++)
			{
				param.Value = productID;
				param2.Value = productImages[i];

				cmd.Parameters.Add(param);
				cmd.Parameters.Add(param2);
				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
			}

			myConnection.Close();
		}
	}
}