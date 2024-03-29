﻿using Bunifu.UI.WinForms;
using PhBuy.Query_Models;
using PhBuyModels;
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
    public partial class ProductSearch : Form
    {
        private List<Products> _allProducts;
        private List<Seller> _sellers;
        private Seller _currentSeller = new Seller();
        private List<Products> _productsQuery;
        private List<string> _selectedTypes = new List<string>();

        private CustomerDashBoard _dashBoard;
        private MemoryStream _stream;

        private string _previousPanel = string.Empty;
        private ProductQuery _queryInput = new ProductQuery();
        private int ratingMin = 0;
        public ProductSearch (CustomerDashBoard d)
        {
            _dashBoard = d;
            InitializeComponent();
        }
        private void ProductSearch_Load(object sender, EventArgs e)
        {
            _dashBoard.scrollBar.BindTo(mainPanel);
            _dashBoard.scrollBar.ThumbLength = 100;
            DisplayProducts();
        }

        public void LoadData(List<Products> p, List<Seller>s)
        {
            _allProducts = p;
            _sellers = s;
        }

        public void CustomSearch(List<Products> products, List<Seller> sellers, string type = "")
        {
            _selectedTypes.Clear();
            typeFlowLayoutPanel.Controls.Clear();
            if (products != null)
            {
                if (type != "")
                {
                    SellerTypeControl t = new SellerTypeControl();
                    t.Name = type;
                    t.typeLabel.Text = type;
                    t.Width = t.typeLabel.Width + 25;
                    t.Click += sellerTypeControl_Click;
                    t.label1.Click += sellerTypeControl_Click2;
                    t.typeLabel.Click += sellerTypeControl_Click2;
                    _selectedTypes.Add(t.Name);
                    typeFlowLayoutPanel.Controls.Add(t);
                }
                _sellers = sellers;
                _allProducts = products;
                DisplayProducts();
            }
        }

        private void startFilterButton_Click(object sender, EventArgs e)
        {
            if (priceMinTextBox.Text != string.Empty)
                _queryInput.PriceMin = double.Parse(priceMinTextBox.Text);
            if (priceMaxTextBox.Text != string.Empty)
                _queryInput.PriceMax = double.Parse(priceMaxTextBox.Text);

            //ADD PRODUCT RATINGS
            //_queryInput.Rating = rating stuff
            DisplayProducts(_queryInput.PriceMin, _queryInput.PriceMax, sortDropDown.Text, ratingMin);
        }

        private void DisplayProducts(double priceMin = -1, double priceMax = -1, string sort = "Top Sales", double rating = 0)
        {
            productsFlowLayoutPanel.Controls.Clear();
            _productsQuery = _allProducts.ToList();

            if (_selectedTypes.Count != 0)
            {
                foreach (var p in _allProducts)
                {
                    FilterTypes(p);
                }
            }
            if (priceMin != -1)
                _productsQuery = _productsQuery.Where(p => p.Price >= priceMin).ToList();
            if (priceMax != -1)
                _productsQuery = _productsQuery.Where(p => p.Price <= priceMax).ToList();

            _productsQuery = _productsQuery.Where(p => p.Rating >= rating).ToList();

            switch (sort)
            {
                case "Top Sales":
                    {
                        //ADD TOP SALES
                            break;
                    }
                case "Price: High to Low":
                    {
                        _productsQuery = _productsQuery.OrderByDescending(p => p.Price).ToList();
                        break;
                    }
                case "Price: Low to High":
                    {
                        _productsQuery = _productsQuery.OrderBy(p => p.Price).ToList();
                        break;
                    }
            }


            foreach (var p in _productsQuery)
            {
                ProductDisplay product = new ProductDisplay();
                Seller currentSeller = _sellers.Find(i => i.Id == p.SellerId);
                _stream = new MemoryStream(p.Picture);
                product.productPictureBox.Image = Image.FromStream(_stream);
                product.NameLabel.Text = p.Name;
                product.PriceLabel.Text = $"₱{p.Price}";
                _stream = new MemoryStream(currentSeller.Picture);
                product.sellerProfilePicture.Image = Image.FromStream(_stream);
                product.sellerNameLabel.Text = currentSeller.Name;
                product.ratingLabel.Text = string.Format("{0:0.00}", p.Rating);
                product.statusLabel.Text = p.Condition;
                product.Click += product_Click;
                product.productPictureBox.Click += product_Click2;
                productsFlowLayoutPanel.Controls.Add(product);
            }
        }

        private void FilterTypes(Products p)
        {
            for (int i = 0; i < _selectedTypes.Count; i++)
            {
                if (p.Type == _selectedTypes[i])
                {
                    return;
                }
            }
            _productsQuery.Remove(p);
        }

        private void product_Click(object sender, EventArgs e)
        {
            ProductDisplay d = (ProductDisplay)sender;
            Products p = _allProducts.Find(i => i.Name == d.NameLabel.Text);
            _currentSeller = _sellers.Find(s => s.Id == p.SellerId);
            _dashBoard.ProductPage.LoadData(p, _currentSeller);
            _dashBoard.customerTabControl.SelectedIndex = 5;
            _dashBoard.scrollBar.Value = 0;
        }

        private void product_Click2(object sender, EventArgs e)
        {
            PictureBox s = (PictureBox)sender;
            ProductDisplay d = (ProductDisplay)s.Parent;
            Products p = _allProducts.Find(i => i.Name == d.NameLabel.Text);
            _currentSeller = _sellers.Find(a => a.Id == p.SellerId);
            _dashBoard.ProductPage.LoadData(p, _currentSeller);
            _dashBoard.customerTabControl.SelectedIndex = 5;
            _dashBoard.scrollBar.Value = 0;
        }

        private void typeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SellerTypeControl type = new SellerTypeControl();
            type.Name = typeDropDown.Text;
            type.typeLabel.Text = typeDropDown.Text;
            type.Width = type.typeLabel.Width + 25;
            if (!_selectedTypes.Contains(type.Name))
            {
                type.Click += sellerTypeControl_Click;
                type.label1.Click += sellerTypeControl_Click2;
                type.typeLabel.Click += sellerTypeControl_Click2;
                _selectedTypes.Add(type.Name);
                typeFlowLayoutPanel.Controls.Add(type);
            }
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

        private void star_Click(object sender, EventArgs e)
        {
            var a = (BunifuPictureBox)sender;
            var p = (BunifuPanel)a.Parent;
            if (_previousPanel != p.Name)
            {
                p.BorderColor = Color.FromArgb(248, 58, 38);

                if (_previousPanel != string.Empty)
                {
                    BunifuPanel previous = (BunifuPanel)Controls.Find(_previousPanel, true).First();
                    previous.BorderColor = Color.Transparent;
                }

                ratingMin = int.Parse(p.Tag.ToString());
                _previousPanel = $"panel{p.Tag}";
            }
            else
            {
                p.BorderColor = Color.Transparent;
                _previousPanel = string.Empty;
                ratingMin = 0;
            }
        }

        private void ratingPanel_Click(object sender, EventArgs e)
        {
            var p = (BunifuPanel)sender;
            if (_previousPanel != p.Name)
            {
                p.BorderColor = Color.FromArgb(248, 58, 38);

                if (_previousPanel != string.Empty)
                {
                    BunifuPanel previous = (BunifuPanel)Controls.Find(_previousPanel, true).First();
                    previous.BorderColor = Color.Transparent;
                }

                ratingMin = int.Parse(p.Tag.ToString());
                _previousPanel = $"panel{p.Tag}";
            }
            else
            {
                p.BorderColor = Color.Transparent;
                _previousPanel = string.Empty;
                ratingMin = 0;
            }

        }
    }
}
