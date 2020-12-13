using Bunifu.Framework.UI;
using PhBuyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class CartForm : Form
    {
        private List<Seller> _sellers = new List<Seller>();
        private List<Products> _products = new List<Products>();

        private List<ProductCart> _toDelete = new List<ProductCart>();
        private MemoryStream _stream;
        private PhBuyContext _data = new PhBuyContext();
        private CustomerDashBoard _dashBoard;
        private List<int> _quantities = new List<int>();
        
        private List<Seller> _sellersToBuy = new List<Seller>();
        private List<Products> _productsToBuy = new List<Products>();
        private List<int> _quantitiesToBuy = new List<int>();
        private Customer _currentCustomer;
     
        private double _total;
        public CartForm(CustomerDashBoard d, Customer c)
        {
            _dashBoard = d;
            _currentCustomer = c;
            InitializeComponent();
        }

        public void BuyNow(Products p, Seller s, int q)
        {
            if (!_sellers.Contains(s)) _sellers.Add(s);
            if (!_products.Contains(p))
            {
                _products.Add(p);
                _quantities.Add(q);
            }
            else
            {
                _quantities[_products.IndexOf(p)] += q;
            }
            addresstextBox.Text = _currentCustomer.Address;
            LoadOrders();
            DeSelectAllSellers();
            SelectAll(s.Name, p.Name);
            bunifuPages2.SelectedIndex = 1;
        }

        private void SelectAll(string currentSeller, string productName = "")
        {
            foreach (var c in cartFlowLayoutPanel.Controls)
            {
                if (c is ProductCart)
                {
                    var p = (ProductCart)c;
                    if (p.Seller == currentSeller && productName == "")
                    {
                        p.checkBox.Checked = true;
                    }

                    else if (productName != "")
                    {
                        if (p.productNameLabel.Text == productName)
                        {
                            p.checkBox.Checked = true;
                        }
                    }
                }
            }
        }

        private void DeSelectAll(string currentSeller)
        {
            foreach (var c in cartFlowLayoutPanel.Controls)
            {
                if (c is ProductCart)
                {
                    var p = (ProductCart)c;
                    if (p.Seller == currentSeller)
                    {
                        p.checkBox.Checked = false;
                    }
                    else
                        break;
                }
            }
        }

        private void DeSelectAllSellers()
        {
            _total = 0;
            foreach(var c in cartFlowLayoutPanel.Controls)
            {
                if (c is SellerCart)
                {
                    var o = (SellerCart)c;
                    o.checkBox.Checked = false;
                }
                else
                {
                    var o = (ProductCart)c;
                    o.checkBox.Checked = false;
                }
            }
        }

        private void checkAll_CheckChanged(object sender, EventArgs e)
        {
            var c = (CheckBox)sender;
            if (c.Checked)
            {
                var o = (SellerCart)c.Parent;
                SelectAll(o.Name);
            }
            else
            {
                var o = (SellerCart)c.Parent;
                DeSelectAll(o.Name);
            }
        }

        public void LoadData(Products p, Seller s, int q)
        {
            addresstextBox.Text = _currentCustomer.Address;
            if (!_sellers.Contains(s)) 
                _sellers.Add(s);

            if (!_products.Contains(p))
            {
                _products.Add(p);
                _quantities.Add(q);
            }

            else
                _quantities[_products.IndexOf(p)] += q;
            
            LoadOrders();
        }

        private void LoadOrders()
        {
            int index = 0;
            _productsToBuy.Clear();
            _sellersToBuy.Clear();
            _toDelete.Clear();
            
            cartFlowLayoutPanel.Controls.Clear();
            foreach (var s in _sellers)
            { 
                SellerCart sellerCart = new SellerCart();
                sellerCart.Name = s.Name;
                _stream = new MemoryStream(s.Picture);
                sellerCart.sellerPictureBox.Image = Image.FromStream(_stream);
                sellerCart.sellerNameLabel.Text = s.Name;
                sellerCart.checkBox.CheckedChanged += checkAll_CheckChanged;
                cartFlowLayoutPanel.Controls.Add(sellerCart);
                foreach(var p in _products.Where(i => i.SellerId == s.Id))
                {
                    ProductCart productCart = new ProductCart();
                    _stream = new MemoryStream(p.Picture);
                    productCart.productPictureBox.Image = Image.FromStream(_stream);
                    productCart.Seller = s.Name;
                    productCart.Name = p.Name;
                    productCart.priceLabel.Text = $"₱{p.Price}";
                    productCart.productNameLabel.Text = p.Name;
                    productCart.checkBox.CheckedChanged += checkBox_CheckedChanged;
                    productCart.deleteButton.Click += deleteButton_Clicked;
                    productCart.quantityTextBox.Text = _quantities[index].ToString();
                    cartFlowLayoutPanel.Controls.Add(productCart);
                    index++;
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            ProductCart p = (ProductCart)c.Parent;
            Products associatedProduct = _products.Find(i => i.Name == p.productNameLabel.Text);
            Seller associatedSeller = _sellers.Find(i => i.Id == associatedProduct.SellerId);
            if (c.Checked)
            {
                _total += (double)associatedProduct.Price * _quantities.Find(i => i == int.Parse(p.quantityTextBox.Text));
                _toDelete.Add(p);
                if (!_sellersToBuy.Contains(associatedSeller)) _sellersToBuy.Add(associatedSeller);
                _productsToBuy.Add(associatedProduct);
                _quantitiesToBuy.Add(int.Parse(p.quantityTextBox.Text));
                totalPriceLabel.Text = $"₱{_total}";
            }
            else
            {
                _total -= (double)associatedProduct.Price * _quantities.Find(i => i == int.Parse(p.quantityTextBox.Text));
                _toDelete.Remove(p);
                _productsToBuy.Remove(associatedProduct);
                _quantitiesToBuy.Remove(int.Parse(p.quantityTextBox.Text));
                totalPriceLabel.Text = $"₱{_total}";
            }

            if (_toDelete.Count != 0) deleteButton.Enabled = true;
            else deleteButton.Enabled = false;
        }

        private void deleteButton_Clicked(object sender, EventArgs e)
        {
            BunifuTileButton b = (BunifuTileButton)sender;
            ProductCart p = (ProductCart)b.Parent;
           
            Seller associatedSeller = _sellers.Find(i => i.Name == p.Seller);
            if (_products.Where(i => i.SellerId == associatedSeller.Id).Count() == 1)
            {
                cartFlowLayoutPanel.Controls.RemoveAt(cartFlowLayoutPanel.Controls.IndexOf(p) - 1);
                _sellersToBuy.Remove(associatedSeller);
                _sellers.Remove(associatedSeller);
            }

            if(p.checkBox.Checked)
            {
                _productsToBuy.Remove(_products.Find(i => i.Name == p.productNameLabel.Text));
            }

            _quantities.RemoveAt(_products.IndexOf(_products.Find(i => i.Name == p.productNameLabel.Text)));
            _products.Remove(_products.Find(i => i.Name == p.productNameLabel.Text));
            cartFlowLayoutPanel.Controls.Remove(p);     
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            bunifuPages2.SelectedIndex++;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (var d in _toDelete)
            {
                cartFlowLayoutPanel.Controls.Remove(d);
                Seller s = _sellers.Find(i => i.Name == d.Seller);
                Products p = _products.Find(i => i.Name == d.productNameLabel.Text);
                _productsToBuy.Remove(p);
                _products.Remove(p);
                if (_products.Where(i => i.SellerId == s.Id).Count() == 0)
                {
                    _sellers.Remove(s);
                    _sellersToBuy.Remove(s);
                    cartFlowLayoutPanel.Controls.Remove(cartFlowLayoutPanel.Controls.Find(s.Name, true).First());
                }
            }
            _toDelete.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            bunifuPages2.SelectedIndex--;
        }

        private void editAddressLabel_Click(object sender, EventArgs e)
        {
            addresstextBox.Enabled = true;
        }

        private void confirmOrderButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var s in _sellersToBuy)
            {
                foreach (var p in _productsToBuy.Where(i => i.SellerId == s.Id))
                {
                    Orders o = new Orders();
                    o.Id = GenerateId();
                    o.ProductId = p.ProductId;
                    o.Quantity = (short)_quantitiesToBuy[index];
                    o.SellerId = s.Id;
                    o.DateOrdered = DateTime.Now;
                    o.Status = "Processing";
                    o.CustomerAddress = _currentCustomer.Address;
                    o.CustomerId = _currentCustomer.Id;
                    o.TotalPrice = _quantitiesToBuy[index] * p.Price;
                    p.Stock -= _quantitiesToBuy[index];
                    _data.Products.Update(p);
                    _data.Orders.Add(o);
                    index++;
                }
            }
            _total = 0;
            totalPriceLabel.Text = $"₱{_total}";
            _quantitiesToBuy.Clear();
            RemoveOrders();
            _sellersToBuy.Clear();
            _productsToBuy.Clear();
            _data.Customer.Update(_currentCustomer);
            _data.SaveChanges();
            bunifuSnackbar1.Show(_dashBoard._mainForm, "Order Placed!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
        }

        private void RemoveOrders()
        {
            foreach(var s in _sellersToBuy)
            {
                foreach (var p in _productsToBuy.Where(i => i.SellerId == s.Id))
                {
                    var c = (ProductCart)cartFlowLayoutPanel.Controls.Find(p.Name, true).First();
                    cartFlowLayoutPanel.Controls.Remove(c);
                    _quantities.Remove(_products.IndexOf(p));
                    _products.Remove(p);
                    if (_products.Where(i => i.SellerId == s.Id).Count() == 0)
                    {
                        _sellers.Remove(s);
                        var sc = (SellerCart)cartFlowLayoutPanel.Controls.Find(s.Name, true).First();
                        cartFlowLayoutPanel.Controls.Remove(sc);
                    }
                }
            }
        }

        private uint GenerateId()
        {
            uint id;
            // Keep on generating the ID until it is a new one
            do
            {
                id = Get5Digits();
            } while (!IsIdValid(id));

            return id;
        }

        private uint Get5Digits()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            return 10000 + BitConverter.ToUInt32(bytes, 0) % 90000;
        }

        private bool IsIdValid(uint id)
        {
            PhBuyContext data = new PhBuyContext();

            if (data.Orders.Select(i => i.Id).Where(d => d == id).Count() == 1) return false;
            else return true;
        }

        private void addresstextBox_TextChanged(object sender, EventArgs e)
        {
            _currentCustomer.Address = addresstextBox.Text;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            _dashBoard.scrollBar.BindTo(panel);
            _dashBoard.scrollBar.ThumbLength = 100;
        }
    }
}
