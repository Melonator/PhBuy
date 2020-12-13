using PhBuy.Properties;
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
using Bunifu.UI.WinForms;

namespace PhBuy
{
    public partial class CustomerRegisterForm : Form
    {
        private PhBuyContext _data = new PhBuyContext();
        private MemoryStream _stream;
        private int _id;
        private CustomerSellerForm _cs = null;
        public CustomerRegisterForm(int id, CustomerSellerForm cs)
        {
            _id = id;
            _cs = cs;
            InitializeComponent();
        }

        private bool CompleteFields()
        {
            return (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && addressTextBox.Text != "");
        }

        private void Confirm()
        {
            if (CompleteFields())
            {
                Customer c = new Customer();
                c.Name = $"{firstNameTextBox.Text} {lastNameTextBox.Text}";
                c.Id = _id;
                c.Contact = contactTextBox.Text;
                c.Address = addressTextBox.Text;
                _stream = new MemoryStream();
                Resources.ProPicIcon22.Save(_stream, ImageFormat.Jpeg);
                c.Picture = _stream.ToArray();
                _stream.Close();
                _data.Customer.Add(c);
                _data.SaveChanges();

                var main = new MainForm(c, _cs) { TopLevel = true };
                main.Show();
                bunifuSnackbar1.Show(main, "Registered Successfully!", BunifuSnackbar.MessageTypes.Success);
                Close();
            }
            else bunifuSnackbar1.Show(this, "Please fill in all fields!", BunifuSnackbar.MessageTypes.Error);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Confirm();
        }
    }
}
