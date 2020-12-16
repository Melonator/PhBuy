using Bunifu.UI.WinForms;
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
    public partial class SellerShop : Form
    {
        private List<string> _selectedTypes = new List<string>();
        private List<Products> _products;
        private List<Products> _productsQuery;
        private MemoryStream _stream;
        private Seller _currentSeller;
        private ProductQuery _queryInput = new ProductQuery();

        private string _previousPanel = string.Empty;

        private int ratingMin = 0;
        private CustomerDashBoard _dashBoard;
        public SellerShop(CustomerDashBoard main)
        {
            _dashBoard = main;
            InitializeComponent();
        }

        public void LoadData(List<Products> p, Seller s, string profileName)
        {
            ResetPage();
            _products = p;
            _currentSeller = s;
            profileNameLabel.Text = $"@{profileName}";
            LoadSellerInfo();
            DisplayProducts();

            DisplayTopProducts();
        }

        private void ResetPage()
        {
            tabControl1.SelectedIndex = 0;
            homeSeparator.LineColor = Color.White;
            homeSeparator.LineThickness = 2;
            allSeparator.LineColor = Color.FromArgb(248, 58, 38);
            allSeparator.LineThickness = 1;

            if (_previousPanel != string.Empty)
            {
                var previous = (BunifuPanel)Controls.Find(_previousPanel, true).First();
                previous.BorderColor = Color.Transparent;
            }
        }

        private void DisplayTopProducts()
        {
            topProductsFlowPanel.Controls.Clear();
          _productsQuery = _products.OrderByDescending(o => o.Sales).ToList();
            int count = _productsQuery.Count < 5 ? _productsQuery.Count : 5;
            for (int i = 0; i < count; i++) 
            {
                ProductDisplaySeller product = new ProductDisplaySeller();
                _stream = new MemoryStream(_productsQuery[i].Picture);
                product.productPictureBox.Image = Image.FromStream(_stream);
                product.NameLabel.Text = _productsQuery[i].Name;
                product.PriceLabel.Text = $"₱{_productsQuery[i].Price}";
                product.statusLabel.Text = _productsQuery[i].Condition;
                product.ratingLabel.Text = string.Format("{0:0.00}", _productsQuery[i].Rating);
                product.statusPanel.Location = new Point(product.statusLabel.Width + 12, 198);
                product.Click += product_Click;
                product.productPictureBox.Click += product_Click2;
                topProductsFlowPanel.Controls.Add(product);
            }
        }

        private void LoadSellerInfo()
        {
            _stream = new MemoryStream(_currentSeller.Picture);
            sellerProfilePicture.Image = Image.FromStream(_stream);
            _stream = new MemoryStream(_currentSeller.Background);
            sellerBackground.Image = Image.FromStream(_stream);
            descLabel.Text = _currentSeller.Descrption;
            sellerShopLabel.Text = _currentSeller.Name;
            productCountLabel.Text = $"Products: {_products.Count}";
            if (_currentSeller.Rating != null) ratingLabel.Text = "Rating: " + string.Format("{0:0.00}", _currentSeller.Rating);
            else ratingLabel.Text = "Rating: 0";
        }
        #region Events

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

        private void startFilterButton_Click(object sender, EventArgs e)
        {
            if (priceMinTextBox.Text != string.Empty)
                _queryInput.PriceMin = double.Parse(priceMinTextBox.Text);
            if (priceMaxTextBox.Text != string.Empty)
                _queryInput.PriceMax = double.Parse(priceMaxTextBox.Text);
            
            //ADD PRODUCT RATINGS
            //_queryInput.Rating = rating stuff
            DisplayProducts("", _queryInput.PriceMin, _queryInput.PriceMax, sortDropDown.Text, ratingMin);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DisplayProducts(productNametextBox.Text);
        }

        private void page_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            if (l.Name == "home")
            {
                BunifuSeparator s = (BunifuSeparator)Controls.Find($"{l.Name}Separator", true).First();
                s.LineColor = Color.White;
                s.LineThickness = 2;
                s = (BunifuSeparator)Controls.Find("allSeparator", true).First();
                s.LineColor = Color.FromArgb(248, 58, 38);
                s.LineThickness = 1;
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                BunifuSeparator s = (BunifuSeparator)Controls.Find($"{l.Name}Separator", true).First();
                s.LineColor = Color.White;
                s.LineThickness = 2;
                s = (BunifuSeparator)Controls.Find("homeSeparator", true).First();
                s.LineColor = Color.FromArgb(248, 58, 38);
                s.LineThickness = 1;
                tabControl1.SelectedIndex = 1;
            }
        }

        private void SellerShop_Load(object sender, EventArgs e)
        {
            _dashBoard.scrollBar.BindTo(mainPanel);
            _dashBoard.scrollBar.ThumbLength = 100;
        }

        private void product_Click(object sender, EventArgs e)
        {
            ProductDisplaySeller d = (ProductDisplaySeller)sender;
            Products p = _products.Find(i => i.Name == d.NameLabel.Text);
            _dashBoard.ProductPage.LoadData(p, _currentSeller);
            _dashBoard.customerTabControl.SelectedIndex = 5;
            _dashBoard.scrollBar.ThumbLength = 100;
            _dashBoard.scrollBar.Value = 0;
        }

        private void product_Click2(object sender, EventArgs e)
        {
            PictureBox s = (PictureBox)sender;
            ProductDisplaySeller d = (ProductDisplaySeller)s.Parent;
            Products p = _products.Find(i => i.Name == d.NameLabel.Text);
            _dashBoard.ProductPage.LoadData(p, _currentSeller);
            _dashBoard.customerTabControl.SelectedIndex = 5;
            _dashBoard.scrollBar.ThumbLength = 100;
            _dashBoard.scrollBar.Value = 0;
        }

        #endregion

        #region Helper Functions
        private void DisplayProducts(string productName = "", double priceMin = -1, double priceMax = -1, string sort = "Top Sales", double rating = 0)
        {
            productsFlowLayoutPanel.Controls.Clear();
            _productsQuery = _products.ToList();
            if (productName == "")
            {
                if (_selectedTypes.Count != 0)
                {
                    foreach (var p in _products)
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
            }

            else
            {
                _productsQuery = _productsQuery.Where(p => p.Name == productName).ToList();
            }

            foreach(var p in _productsQuery)
            {
                ProductDisplaySeller product = new ProductDisplaySeller();
                _stream = new MemoryStream(p.Picture);
                product.productPictureBox.Image = Image.FromStream(_stream);
                product.NameLabel.Text = p.Name;
                product.PriceLabel.Text = $"₱{p.Price}";
                product.statusLabel.Text = p.Condition;
                product.ratingLabel.Text = string.Format("{0:0.00}", p.Rating);
                product.statusPanel.Location = new Point(product.statusLabel.Width + 12, 198);
                product.Click += product_Click;
                product.productPictureBox.Click += product_Click2;
                productsFlowLayoutPanel.Controls.Add(product);
            }
        }

        private void FilterTypes(Products p)
        {
            for (int i = 0; i < _selectedTypes.Count; i++)
            {
                if (p.Type == _selectedTypes[i]) return;
            }
            _productsQuery.Remove(p);
        }


        #endregion

        private void chatNowButton_Click(object sender, EventArgs e)
        {
            _dashBoard.customerTabControl.SelectedIndex = 10;
            _dashBoard.scrollBar.Value = 0;
            _dashBoard.Chat.LoadElementIo(_currentSeller.Name);
        }
    }
}
