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
    public partial class CustomerProfile : Form
    {
        private MemoryStream _stream;
        private PhBuyContext _data = new PhBuyContext();
        private MainForm _mainForm;
        private Customer _customer;

        public CustomerProfile(MainForm m, Customer c)
        {
            _customer = c;
            _mainForm = m;
            InitializeComponent();
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            var name = _customer.Name.Split(' ');
            firstNameTextBox.Text = name[0];
            lastNameTextBox.Text = name[1];
            addressTextBox.Text = _customer.Address;
            contactTextBox.Text = _customer.Contact;
            if (_customer.Picture != null)
            {
                _stream = new MemoryStream(_customer.Picture);
                customerPictureBox.Image = Image.FromStream(_stream);
                _stream.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _customer.Name = $"{firstNameTextBox.Text} {lastNameTextBox.Text}";
            _customer.Address = addressTextBox.Text;
            _customer.Contact = contactTextBox.Text;
            _stream = new MemoryStream();
            customerPictureBox.Image.Save(_stream, ImageFormat.Jpeg);
            _customer.Picture = _stream.ToArray();
            _data.SaveChanges();
            _mainForm.ReloadData("Customer");
            //SNACKBAR NOTIF
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog { Title = "Choose your profile picture" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            customerPictureBox.ImageLocation = dlg.FileName;
        }
    }
}
