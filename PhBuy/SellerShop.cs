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

        private CustomerDashBoard _dashBoard;
        public SellerShop(CustomerDashBoard main)
        {
            _dashBoard = main;
            InitializeComponent();
        }

        public void LoadData(List<Products> p, Seller s)
        {
            _products = p;
            _currentSeller = s;
            _productsQuery = _products.ToList();
            LoadSellerInfo();
            DisplayProducts();
        }

        private void LoadSellerInfo()
        {
            _stream = new MemoryStream(_currentSeller.Picture);
            sellerProfilePicture.Image = Image.FromStream(_stream);
            _stream = new MemoryStream(_currentSeller.Background);
            sellerBackground.Image = Image.FromStream(_stream);
            descLabel.Text = _currentSeller.Descrption;
            sellerShopLabel.Text = _currentSeller.Name;
        }
        #region Events

        private void typeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SellerTypeControl type = new SellerTypeControl();
            type.Name = typeDropDown.Text;
            type.typeLabel.Text = typeDropDown.Text;
            type.Width = type.typeLabel.Width + 25;
            type.Click += sellerTypeControl_Click;
            type.label1.Click += sellerTypeControl_Click2;
            type.typeLabel.Click += sellerTypeControl_Click2;
            _selectedTypes.Add(type.Name);
            typeFlowLayoutPanel.Controls.Add(type);
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

        private void start_Click(object sender, EventArgs e)
        {
            BunifuPictureBox b = (BunifuPictureBox)sender;
            BunifuPanel p = (BunifuPanel)b.Parent;
            p.BorderColor = Color.FromArgb(248, 58, 38);

            if (_previousPanel != string.Empty)
            {
                BunifuPanel previous = (BunifuPanel)Controls.Find(_previousPanel, true).First();
                previous.BorderColor = Color.FromArgb(45, 41, 66);
            }

            _previousPanel = $"panel{p.Tag}";
        }

        private void ratingPanel_Click(object sender, EventArgs e)
        {
            BunifuPanel p = (BunifuPanel)sender;
            p.BorderColor = Color.FromArgb(248, 58, 38);

            if (_previousPanel != string.Empty)
            {
                BunifuPanel previous = (BunifuPanel)Controls.Find(_previousPanel, true).First();
                previous.BorderColor = Color.FromArgb(45, 41, 66);
            }

            _previousPanel = $"panel{p.Tag}";
        }

        private void startFilterButton_Click(object sender, EventArgs e)
        {
            if (priceMinTextBox.Text != string.Empty)
                _queryInput.PriceMin = double.Parse(priceMinTextBox.Text);
            if (priceMaxTextBox.Text != string.Empty)
                _queryInput.PriceMax = double.Parse(priceMaxTextBox.Text);
            
            //ADD PRODUCT RATINGS
            //_queryInput.Rating = rating stuff
            DisplayProducts("", _queryInput.PriceMin, _queryInput.PriceMax, sortDropDown.Text);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DisplayProducts(productNametextBox.Text);
        }

        #endregion

        #region Helper Functions
        private void DisplayProducts(string productName = "", double priceMin = -1, double priceMax = -1, string sort = "Top Sales", double rating = 1)
        {
            productsFlowLayoutPanel.Controls.Clear();
            _productsQuery = _products.ToList();
            if (productName != "")
            {
                if (priceMin != -1)
                    _productsQuery = _productsQuery.Where(p => p.Price >= priceMin).ToList();
                if (priceMax != -1)
                    _productsQuery = _productsQuery.Where(p => p.Price <= priceMax).ToList();
                if (_selectedTypes.Count != 0)
                {
                    foreach (var p in _productsQuery)
                        FilterTypes(p);
                }
                switch(sort)
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
                ProductDisplay product = new ProductDisplay();
                _stream = new MemoryStream(p.Picture);
                product.productPictureBox.Image = Image.FromStream(_stream);
                product.NameLabel.Text = p.Name;
                product.PriceLabel.Text = $"₱{p.Price}";
                _stream = new MemoryStream(_currentSeller.Picture);
                product.sellerProfilePicture.Image = Image.FromStream(_stream);
                product.sellerNameLabel.Text = _currentSeller.Name;
                product.statusLabel.Text = p.Condition;
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

        private void page_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            if (l.Name == "home")
            {
                BunifuSeparator s = (BunifuSeparator)Controls.Find($"{l.Name}Separator", true).First();
                s.LineColor = Color.FromArgb(248, 58, 38);
                s.LineThickness = 2;
                s = (BunifuSeparator)Controls.Find("allSeparator", true).First();
                s.LineColor = Color.FromArgb(45, 41, 66);
                s.LineThickness = 1;
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                BunifuSeparator s = (BunifuSeparator)Controls.Find($"{l.Name}Separator", true).First();
                s.LineColor = Color.FromArgb(248, 58, 38);
                s.LineThickness = 2;
                s = (BunifuSeparator)Controls.Find("homeSeparator", true).First();
                s.LineColor = Color.FromArgb(45, 41, 66);
                s.LineThickness = 1;
                tabControl1.SelectedIndex = 1;
            }
        }

        private void SellerShop_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            _dashBoard.scrollBar.BindTo(mainPanel);
            _dashBoard.scrollBar.ThumbLength = 100;
        }
    }
}
