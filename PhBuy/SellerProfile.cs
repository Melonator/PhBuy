using PhBuyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class SellerProfile : Form
    {
        private Seller _currentSeller;
        private MemoryStream _stream;
        private MainForm _mainForm;
        private PhBuyContext _data = new PhBuyContext();
        private bool uploadCover = false;
        private bool uploadPhoto = false;
        public SellerProfile(MainForm m, Seller s)
        {
            _currentSeller = s;
            _mainForm = m;
            InitializeComponent();
        }

        private void SellerProfile_Load(object sender, EventArgs e)
        {
            _stream = new MemoryStream(_currentSeller.Picture);
            sellerPictureBox.Image = Image.FromStream(_stream);
            _stream = new MemoryStream(_currentSeller.Background);
            sellerBackgroundPictureBox.Image = Image.FromStream(_stream);
            _stream.Close();
            nameTextBox.Text = _currentSeller.Name;
            contactTextBox.Text = _currentSeller.Contact;
            descriptionTextBox.Text = _currentSeller.Descrption;
            List<Products> p = _data.Products.Where(i => i.SellerId == _currentSeller.Id).ToList();
            productsLabel.Text = $"{p.Count}>";
            ratingLabel.Text = _currentSeller.Rating.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _currentSeller = _data.Seller.Where(i => i.Id == _currentSeller.Id).FirstOrDefault();
            _currentSeller.Name = nameTextBox.Text;
            _currentSeller.Contact = contactTextBox.Text;
            _currentSeller.Descrption = descriptionTextBox.Text;
            _stream = new MemoryStream();
            if (uploadPhoto)
            {
                sellerPictureBox.Image.Save(_stream, ImageFormat.Jpeg);
                _currentSeller.Picture = _stream.ToArray();
            }

            if (uploadCover)
            {
                sellerBackgroundPictureBox.Image.Save(_stream, ImageFormat.Jpeg);
                _currentSeller.Background = _stream.ToArray();
            }

            uploadCover = false;
            uploadPhoto = false;
            _data.SaveChanges();
            _mainForm.ReloadData("Seller", (int)_currentSeller.Id);
        }

        private void sellerPictureBox_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog { Title = "Choose your shop image" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            sellerPictureBox.ImageLocation = dlg.FileName;
            uploadPhoto = true;
        }

        private void sellerBackgroundPictureBox_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog { Title = "Choose your shop background" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            sellerBackgroundPictureBox.ImageLocation = dlg.FileName;
            uploadPhoto = false;
        }
    }
}
