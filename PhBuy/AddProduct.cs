using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class AddProduct : Form
    {
        private int id;
        private int sellerID;
        private string name;
        private double price;
        //picture
        private string _sellerCoverLocation;
        private List<byte[]> sellerImages = new List<byte[]>();
        private int stock;
        private double weight;
        private double length, width, height;
        private string condition;
        private string description;
        private string fdanum;
        private string type;

        private string previousLabel = string.Empty;
        private bool hasCover = false;
        private int imageNo = 1;

        private ProductImage p = new ProductImage();

        public AddProduct()
        {
            InitializeComponent();
        }

        private void foodtype_Click(object sender, EventArgs e)
        {
            BunifuImageButton button = (BunifuImageButton)sender; 
            Label label = (Label)Controls.Find($"{button.Name}Label", true).First();
            label.ForeColor = Color.FromArgb(248, 58, 38);
            type = label.Text;

            if (previousLabel != string.Empty)
            {
                label = (Label)Controls.Find(previousLabel, true).First();
                label.ForeColor = Color.FromArgb(45, 41, 66);
            }

            previousLabel = button.Name + "Label";
           
        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            if (priceTextBox.Text != string.Empty && stockTextBox.Text !=  string.Empty)
            {
                addProductPages.PageIndex = 2;
            }
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            string imageLoc = uploadImage();
            ProductImage p = new ProductImage();
            p.Name = $"Image {imageNo}";
            p.pictureBox.ImageLocation = imageLoc;
            p.label.Text = $"Image {imageNo}";
            p.Click += ProductImage_Click;
            p.pictureBox.Click += ProductImage_Click2;
            
            imagesPanel.Controls.Add(p);

            FileStream fs = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            sellerImages.Add(br.ReadBytes((int)fs.Length));

            imagesPanel.Controls.SetChildIndex(addCoverButton, imagesPanel.Controls.Count);
            imagesPanel.Controls.SetChildIndex(addImageButton, imagesPanel.Controls.Count - 1);
            imageCountLabel.Text = $"Images: {imageNo}/8";
            imageNo++;
        }

        private void addCoverButton_Click(object sender, EventArgs e)
        {
           
            if (!hasCover)
            {
                hasCover = true;
                OpenFileDialog dlg = new OpenFileDialog { Title = "Choose your product image" };
                if (dlg.ShowDialog() != DialogResult.OK) return;
                _sellerCoverLocation = dlg.FileName; 
                p.Name = "CoverImage"; 
                p.pictureBox.ImageLocation = _sellerCoverLocation;
                p.label.Text = $"Cover Image";
                p.label.Location = new Point(-5, 123);
                addCoverButton.Text = "Change Cover";
                imagesPanel.Controls.Add(p);

                imagesPanel.Controls.SetChildIndex(addCoverButton, imagesPanel.Controls.Count);
                imagesPanel.Controls.SetChildIndex(addImageButton, imagesPanel.Controls.Count - 1);
            }

            else
            {
                OpenFileDialog dlg = new OpenFileDialog { Title = "Choose your product image" };
                if (dlg.ShowDialog() != DialogResult.OK) return;
                _sellerCoverLocation = dlg.FileName;
                p.pictureBox.ImageLocation = _sellerCoverLocation;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Confirm the stuff
        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            if (fdaTextBox.Text != string.Empty)
            {
                fdanum = fdaTextBox.Text;
            }

            if (type != string.Empty && nameTextBox.Text != string.Empty && descriptionTextBox.Text != string.Empty)
            {
                name = nameTextBox.Text;
                description = descriptionTextBox.Text;
                addProductPages.PageIndex = 1;
            }
        }

        private string uploadImage()
        {
            OpenFileDialog dlg = new OpenFileDialog { Title = "Choose your product image" };
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }

        //First event when the product form is clicked
        private void ProductImage_Click(object sender, EventArgs e)
        {
            imageCountLabel.Text = $"Images: {imageNo}/8";
            ProductImage p = (ProductImage)sender;
            imagesPanel.Controls.Remove(imagesPanel.Controls.Find(p.Name, true).First());
            imageNo--;
        }

        //Second event when the picture in the product image is clicked
        private void ProductImage_Click2(object sender, EventArgs e)
        {
            imageCountLabel.Text = $"Images: {imageNo}/8";
            PictureBox p = (PictureBox)sender;
            imagesPanel.Controls.Remove(imagesPanel.Controls.Find(p.Parent.Name, true).First());
            imageNo--;
        }
    }
}
