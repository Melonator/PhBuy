﻿using PhBuyModels;
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
    public partial class ProductPage : Form
    {
        private Products _product;
        private MemoryStream _stream = new MemoryStream();
        private Seller _seller;
        private CustomerDashBoard _dashBoard;
        private List<ProductImages> _productImages;
        private List<Profiles> _profiles;
        private string _profileName;
        private int _quantity = 1;
        public ProductPage(CustomerDashBoard c, List<ProductImages> i, List<Profiles> pf)
        {
            _profiles = pf;
            _productImages = i;
            _dashBoard = c;
            InitializeComponent();
        }

        public void LoadData(Products p, Seller s)
        {
            _profileName = _profiles.Where(i => i.Id == s.Id).Select(j => j.Name).FirstOrDefault();
            _quantity = 1;
            _dashBoard.scrollBar.BindTo(mainPanel);
            _dashBoard.scrollBar.ThumbLength = 100;
            _product = p;
            _seller = s;

            quantityTextBox.Text = "1";
            SetPhotos();
            productNameLabel.Text = _product.Name;
            salesLabel.Text = $"{_product.Sales} Sold";
            profileNameLabel.Text = $"@{_profileName}";
            priceLabel.Text = $"₱{p.Price}";
            descLabel.Text = _product.Description;
            stockLabel.Text = $"{_product.Stock} Available";
            ratingLabel.Text = string.Format("{0:0.00}", _product.Rating);
            _stream = new MemoryStream(_seller.Picture);
            sellerPictureBox.Image = Image.FromStream(_stream);
            sellerNameLabel.Text = _seller.Name;   
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {

            _dashBoard.scrollBar.BindTo(mainPanel);
            _dashBoard.scrollBar.ThumbLength = 100;
        }

        private void SetPhotos()
        {
            productImagesFlowPanel.Controls.Clear();
            _stream = new MemoryStream(_product.Picture);
            productPictureBox.Image = Image.FromStream(_stream);
            PictureBox productCover = new PictureBox
            {
                Size = new Size(78, 78),
                Image = Image.FromStream(_stream),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            productCover.Click += productPictureBox_Click;
            productImagesFlowPanel.Controls.Add(productCover);
            foreach (var i in _productImages.Where(d => d.ProductId == _product.ProductId).ToList())
            {
                _stream = new MemoryStream(i.Picture);
                PictureBox p = new PictureBox
                {
                    Size = new Size(78, 78),
                    Image = Image.FromStream(_stream),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                p.Click += productPictureBox_Click;
                productImagesFlowPanel.Controls.Add(p);
            }
        }

        private void productPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            productPictureBox.Image = p.Image;
        }

        private void viewShopButton_Click(object sender, EventArgs e)
        {
            List<Products> Products = _dashBoard.CustomerHomePage._products;
            _dashBoard.SellerShop.LoadData(Products.Where(s => s.SellerId == _product.SellerId).ToList(),_seller,
                _profileName);
            _dashBoard.scrollBar.Value = 0;
            _dashBoard.customerTabControl.SelectedIndex = 3;
            _dashBoard.scrollBar.ThumbLength = 100;
        }

        private void chatNowButton_Click(object sender, EventArgs e)
        {
            _dashBoard.Chat.LoadElementIo(sellerNameLabel.Text);
            _dashBoard.customerTabControl.SelectedIndex = 10;
            _dashBoard.scrollBar.Value = 0;
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            _dashBoard.CartForm.LoadData(_product, _seller, _quantity);
            bunifuSnackbar1.Show(_dashBoard._mainForm, "Added to cart", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
        }

        private void addQuantityButton_Click(object sender, EventArgs e)
        {
            if (_quantity < _product.Stock) _quantity++;
            quantityTextBox.Text = _quantity.ToString();
        }

        private void subtractQuantityButton_Click(object sender, EventArgs e)
        {
            if(_quantity != 1) _quantity--;
            quantityTextBox.Text = _quantity.ToString();
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quantityTextBox.Text != string.Empty)
            {
                if (int.Parse(quantityTextBox.Text) > _product.Stock)
                {
                    quantityTextBox.Text = _product.Stock.ToString();
                }
                else
                {
                    _quantity = int.Parse(quantityTextBox.Text);
                }
            }
        }

        private void buyNowButton_Click(object sender, EventArgs e)
        {
            _dashBoard.CartForm.BuyNow(_product, _seller, _quantity);
            _dashBoard.customerTabControl.SelectedIndex = 7;
            _dashBoard.scrollBar.ThumbLength = 100;
            _dashBoard.scrollBar.Value = 0;
        }
    }
}
