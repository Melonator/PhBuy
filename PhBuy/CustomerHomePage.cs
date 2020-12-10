using Bunifu.UI.WinForms;
using PhBuyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class CustomerHomePage : Form
    {
        private CustomerDashBoard _cd;
        private PhBuyContext _data;
        public List<Products> _products = new List<Products>();
        public List<Seller> _sellers = new List<Seller>();
        public List<SellerTypes> _sellerTypes = new List<SellerTypes>();
        private Seller _currentSeller;
        private MemoryStream _stream;
        public CustomerHomePage(CustomerDashBoard form, PhBuyContext d)
        {
            _data = d;
            _cd = form;
            InitializeComponent();
        }
        private void CustomerHomePage_Load(object sender, EventArgs e)
        { 
            _cd.scrollBar.BindTo(panel);
            LoadData();
            LoadProducts();
            LoadSellers();
        }

        private void LoadData()
        {
            _products = _data.Products.ToList();
            _sellers = _data.Seller.ToList();
            _sellerTypes = _data.SellerTypes.ToList();
        }

        private void LoadProducts()
        {
            foreach (var p in _products)
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
                product.statusLabel.Text = p.Condition;
                product.productPictureBox.Click += productPicture_click;
                product.Click += productPanel_Click;
                productsFlowLayoutPanel.Controls.Add(product);
            }
        }

        private void LoadSellers()
        {
            foreach(var s in _sellers)
            {
                SellerDisplay seller = new SellerDisplay();
                _stream = new MemoryStream(s.Picture);
                seller.sellerProfilePicture.Image = Image.FromStream(_stream);
                _stream = new MemoryStream(s.Background);
                seller.sellerCoverPicture.Image = Image.FromStream(_stream);
                seller.shopNameLabel.Text= s.Name;
                seller.SetTypes(_sellerTypes.Where(t => t.SellerId == s.Id).Select(i => i.Type).ToArray());
                seller.Click += sellerPanel_Click;
                seller.sellerCoverPicture.Click += sellerPanel_Click2;
                sellerFlowLayoutPanel.Controls.Add(seller);
            }
        }

        private void discoverSellersLabel_Click(object sender, EventArgs e)
        {
            //Switch to the discover sellers page 
            _cd.customerTabControl.SelectedIndex = 2;
        }

        private void moreProductsLabel_Click(object sender, EventArgs e)
        {
            //Switch to the products query page 
        }

        private void productPicture_click(object sender, EventArgs e)
        {
            //Go to products page
            PictureBox b = (PictureBox)sender;
            ProductDisplay d = (ProductDisplay)b.Parent;
            _cd.scrollBar.BindTo(_cd.ProductPage.mainPanel);
            _cd.scrollBar.ThumbLength = 100;
            Products p = _products.Find(i => i.Name == d.NameLabel.Text);
            _cd.ProductPage.LoadData(p, _sellers.Find(s => s.Id == p.SellerId));
            _cd.customerTabControl.SelectedIndex = 5;
        }

        private void productPanel_Click(object sender, EventArgs e)
        {
            //Go to products page
            ProductDisplay d = (ProductDisplay)sender;
            _cd.scrollBar.BindTo(_cd.ProductPage.mainPanel);
            _cd.scrollBar.ThumbLength = 100;
            Products p = _products.Find(i => i.Name == d.NameLabel.Text);
            _cd.ProductPage.LoadData(p, _sellers.Find(s => s.Id == p.SellerId));
            _cd.customerTabControl.SelectedIndex = 5;
        }
        private void sellerPanel_Click(object sender, EventArgs e)
        {
            SellerDisplay p = (SellerDisplay)sender;
            Seller seller = _sellers.Where(s => s.Name == p.shopNameLabel.Text).First();
            _cd.SellerShop.LoadData(_products.Where(i => i.SellerId == seller.Id).ToList(), seller);
            _cd.scrollBar.ThumbLength = 100;
            _cd.customerTabControl.SelectedIndex = 3;
        }

        private void sellerPanel_Click2(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            SellerDisplay p = (SellerDisplay)b.Parent;
            Seller seller = _sellers.Where(s => s.Name == p.shopNameLabel.Text).First();
            _cd.SellerShop.LoadData(_products.Where(i => i.SellerId == seller.Id).ToList(), seller);
            _cd.scrollBar.ThumbLength = 100;
            _cd.customerTabControl.SelectedIndex = 3;
        }

        private void product_Click(object sender, EventArgs e)
        {
            ProductDisplay d = (ProductDisplay)sender;
            Products p = _products.Find(i => i.Name == d.NameLabel.Text);
            _currentSeller = _sellers.Find(s => s.Id == p.SellerId);
            _cd.ProductPage.LoadData(p, _currentSeller);
            _cd.customerTabControl.SelectedIndex = 5;
        }

        private void product_Click2(object sender, EventArgs e)
        {
            PictureBox s = (PictureBox)sender;
            ProductDisplay d = (ProductDisplay)s.Parent;
            Products p = _products.Find(i => i.Name == d.NameLabel.Text);
            _currentSeller = _sellers.Find(a => a.Id == p.SellerId);
            _cd.ProductPage.LoadData(p, _currentSeller);
            _cd.customerTabControl.SelectedIndex = 5;
        }
    }
}
