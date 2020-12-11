﻿using PhBuy.Properties;
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
    public partial class CustomerRegisterForm : Form
    {
        private PhBuyContext _data = new PhBuyContext();
        private MemoryStream _stream;
        private int _id;
        public CustomerRegisterForm(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Name = $"{firstNameTextBox.Text} {lastNameTextBox.Text}";
            c.Id = _id;
            c.Contact = contactTextBox.Text;
            _stream = new MemoryStream();
            Resources.ProPicIcon22.Save(_stream, ImageFormat.Jpeg);
            c.Picture = _stream.ToArray();
            _stream.Close();
            _data.Customer.Add(c);
            _data.SaveChanges();

            var main = new MainForm("Customer", c) { TopLevel = true };
            main.Show();
            Hide();
        }
    }
}