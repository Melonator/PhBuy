using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class AddProduct : Form
    {
        private const string ConnectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

        //Product Data
        private int id;
        private int sellerID;
        private string name;
        private double price;
        private int stock;
        private double weight;
        private double length, width, height;
        private string condition;
        private string description;
        private string fdanum;
        private string type;

        //Photos Data
        private string _productCoverLocation;
        private List<byte[]> productImages = new List<byte[]>();

        private string previousLabel = string.Empty;
        private bool hasCover = false;
        private int imageNo = 0;

        //Instance of cover image 
        private ProductImage coverImage = new ProductImage();
        public AddProduct()
        {
            //TODO: Connect all forms and get current ID
            InitializeComponent();
        }

        private void foodtype_Click(object sender, EventArgs e)
        {
            //Set the color of the font to orange when selected
            BunifuImageButton button = (BunifuImageButton)sender; 
            Label label = (Label)Controls.Find($"{button.Name}Label", true).First();
            label.ForeColor = Color.FromArgb(248, 58, 38);
            type = label.Text;

            //Set the previously clicked type to black
            if (previousLabel != string.Empty)
            {
                label = (Label)Controls.Find(previousLabel, true).First();
                label.ForeColor = Color.FromArgb(45, 41, 66);
            }
   
            previousLabel = button.Name + "Label";
        }
        private void nextButton1_Click(object sender, EventArgs e)
        {
            if (fdaTextBox.Text != string.Empty)
            {
                fdanum = fdaTextBox.Text;
            }

            if (type != string.Empty && nameTextBox.Text != string.Empty && descriptionTextBox.Text != string.Empty && nameTextBox.Text.Count() <= 50 && descriptionTextBox.Text.Count() <= 300)
            {
                name = nameTextBox.Text;
                description = descriptionTextBox.Text;
                addProductPages.PageIndex++;
            }

        }
        private void nextButton2_Click(object sender, EventArgs e)
        {
            if (priceTextBox.Text != string.Empty && stockTextBox.Text !=  string.Empty && hasCover)
            {
                price = double.Parse(priceTextBox.Text);
                stock = int.Parse(stockTextBox.Text);
                addProductPages.PageIndex++;
            }
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog { Title = "Choose your product image" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            string imageLoc = dlg.FileName;

            ProductImage p = new ProductImage();

            //Set the properties
            imageNo++;
            p.Name = $"Image {imageNo}";
            p.pictureBox.ImageLocation = imageLoc;
            p.label.Text = $"Image {imageNo}";
            p.Click += ProductImage_Click;
            p.pictureBox.Click += ProductImage_Click2;
            
            imagesPanel.Controls.Add(p);

            FileStream fs = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            productImages.Add(br.ReadBytes((int)fs.Length));

            //Re arrange the buttons
            imagesPanel.Controls.SetChildIndex(addCoverPanel, imagesPanel.Controls.Count);
            imagesPanel.Controls.SetChildIndex(addImagePanel, imagesPanel.Controls.Count - 1);
           
            imageCountLabel.Text = $"Images: {imageNo} / 8"; 
        }

        private void addCoverButton_Click(object sender, EventArgs e)
        {
            //If there is no cover, make a new one. Else use the old
            if (!hasCover)
            {
                hasCover = true;
                OpenFileDialog dlg = new OpenFileDialog { Title = "Choose your product cover image" };
                if (dlg.ShowDialog() != DialogResult.OK) return;
                _productCoverLocation = dlg.FileName; 
                coverImage.Name = "CoverImage";
                coverImage.pictureBox.ImageLocation = _productCoverLocation;
                coverImage.label.Text = $"Cover Image";
                coverImage.label.Location = new Point(-5, 123);
                addCoverButton.Text = "Change Cover";
                imagesPanel.Controls.Add(coverImage);

                //Re arrange the buttons
                imagesPanel.Controls.SetChildIndex(coverImage, 0);
                imagesPanel.Controls.SetChildIndex(addCoverPanel, imagesPanel.Controls.Count);
                imagesPanel.Controls.SetChildIndex(addImagePanel, imagesPanel.Controls.Count - 1);
            }

            else
            {
                OpenFileDialog dlg = new OpenFileDialog { Title = "Choose your product cover image" };
                if (dlg.ShowDialog() != DialogResult.OK) return;
                _productCoverLocation = dlg.FileName;
                coverImage.pictureBox.ImageLocation = _productCoverLocation;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (weightTextBox.Text != string.Empty && lengthTextBox.Text != string.Empty
                && widthTextBox.Text != string.Empty && heightTextBox.Text != string.Empty)
            {
                height = int.Parse(heightTextBox.Text);
                width = int.Parse(widthTextBox.Text);
                length = int.Parse(lengthTextBox.Text);

                if (newRadioButton.Checked) condition = "New";
                else condition = "Used";

                FileStream fs = new FileStream(_productCoverLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] productCover = br.ReadBytes((int)fs.Length);

                int productID = (int)GenerateId();

                //Confirm the stuff
                SqlConnection myConnection = new SqlConnection(ConnectionString);
                //Add new entries
                string queryString = "INSERT INTO Products VALUES(@ProductID, @SellerID, @Name" +
                    ", @Price, @Cover, @Stock, @Weight, @Length, @Width, @Height, @Condition, @Description, @FDANumber, @Type);";

                myConnection.Open();

                //Crap ton of parameters aaaa
                SqlParameter param1 = new SqlParameter() { ParameterName = "@ProductID", Value = productID };
                SqlParameter param2 = new SqlParameter() { ParameterName = "@SellerID", Value = sellerID };
                SqlParameter param3 = new SqlParameter() { ParameterName = "@Name", Value = name };
                SqlParameter param4 = new SqlParameter() { ParameterName = "@Price", Value = price };
                SqlParameter param5 = new SqlParameter() { ParameterName = "@Cover", Value = productCover };
                SqlParameter param6 = new SqlParameter() { ParameterName = "@Stock", Value = stock };
                SqlParameter param7 = new SqlParameter() { ParameterName = "@Weight", Value = weight };
                SqlParameter param8 = new SqlParameter() { ParameterName = "@Length", Value = length };
                SqlParameter param9 = new SqlParameter() { ParameterName = "@Width", Value = Width };
                SqlParameter param10 = new SqlParameter() { ParameterName = "@Height", Value = height };
                SqlParameter param11 = new SqlParameter() { ParameterName = "@Condition", Value = condition };
                SqlParameter param12 = new SqlParameter() { ParameterName = "@Description", Value = description };
                SqlParameter param13 = new SqlParameter() { ParameterName = "@FDANumber", Value = fdanum };
                SqlParameter param14 = new SqlParameter() { ParameterName = "@Type", Value = type };

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
                cmd.Parameters.Add(param11);
                cmd.Parameters.Add(param12);
                cmd.Parameters.Add(param13);
                cmd.Parameters.Add(param14);

                cmd.ExecuteNonQuery();

                myConnection.Close();

                queryString = "INSERT INTO ProductImages VALUES(@ProductID, @Image);";
                InsertImages(queryString, productID);
            }
        }

        //First event when the product form is clicked
        private void ProductImage_Click(object sender, EventArgs e)
        {
            imageNo--;
            imageCountLabel.Text = $"Images: {imageNo} / 8";
            ProductImage p = (ProductImage)sender;
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
            PictureBox p = (PictureBox)sender;
            ProductImage i = (ProductImage)p.Parent;
            imagesPanel.Controls.Remove(imagesPanel.Controls.Find(p.Parent.Name, true).First());
            RenameImages(i.label.Text);
        }

        //Method to rename images in order when deleting
        private void RenameImages(string imageName)
        {
            //Start at the deleted image
            int i = int.Parse(imageName.Split(' ')[1]) - 1;

            for (; i < imageNo; i++)
            {
                ProductImage p;

                //If there is a cover image, move on to the next control
                if(hasCover)
                    p = (ProductImage)imagesPanel.Controls[i + 1];
                else
                    p = (ProductImage)imagesPanel.Controls[i];

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

        private void descriptionTextBox_TextChange(object sender, EventArgs e)
        {
            descCharCountLabel.Text = $"{descriptionTextBox.Text.Count()} / 300";
            //TODO: Notify the user when it is empty or beyond the count
        }

        private void nameTextBox_TextChange(object sender, EventArgs e)
        {
            nameCharCountLabel.Text = $"{nameTextBox.Text.Count()} / 50";
            //TODO: Notify the user when it is empty or beyond the count
        }

        private bool IsIdValid(uint id)
        {
            SqlConnection myConnection = new SqlConnection(ConnectionString);
            string queryString = "SELECT ID FROM Profiles WHERE ID = @ID";

            myConnection.Open();
            SqlParameter param = new SqlParameter() { ParameterName = "@ID", Value = (int)id };
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

        private void InsertImages(string queryString, int productID)
        {
            SqlConnection myConnection = new SqlConnection(ConnectionString);
            myConnection.Open();

            SqlCommand cmd = new SqlCommand(queryString, myConnection);
            SqlParameter param = new SqlParameter();
            SqlParameter param2 = new SqlParameter();
            for(int i = 0; i < productImages.Count; i++)
            {
                param.ParameterName = "@ProductID";
                param.Value = productID;
                param2.ParameterName = "@Image";
                param.Value = productImages[i];

                cmd.Parameters.Add(param);
                cmd.Parameters.Add(param2);
                cmd.ExecuteNonQuery();
            }

            myConnection.Close();
        }
    }
}
