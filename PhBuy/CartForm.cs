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
        private Seller _insertedSeller;
        private Products _insertedProduct;
        private List<Seller> _sellers = new List<Seller>();
        private List<Products> _products = new List<Products>();

        private List<ProductCart> _toDelete = new List<ProductCart>();
        private MemoryStream _stream;
        private PhBuyContext _data = new PhBuyContext();
        private CustomerDashBoard _dashBoard;
        private int _quantity;
        private DateTime _dateNow;

        private List<Seller> _sellersToBuy = new List<Seller>();
        private List<Products> _productsToBuy = new List<Products>();

        private const string ConnectionString =
            "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

        private double _total;
        public CartForm(CustomerDashBoard c)
        {
            _dashBoard = c;
            InitializeComponent();
        }

        public void LoadData(Products p, Seller s, int q)
        {
            _insertedSeller = s;
            _insertedProduct = p;
            _quantity = q;
            if (!_sellers.Contains(s))_sellers.Add(_insertedSeller);
            _products.Add(_insertedProduct);

            LoadOrders();
        }

        private void LoadOrders()
        {
            cartFlowLayoutPanel.Controls.Clear();
            foreach (var s in _sellers)
            { 
                SellerCart sellerCart = new SellerCart();
                _stream = new MemoryStream(s.Picture);
                sellerCart.sellerPictureBox.Image = Image.FromStream(_stream);
                sellerCart.sellerNameLabel.Text = s.Name;
                cartFlowLayoutPanel.Controls.Add(sellerCart);
                foreach(var p in _products.Where(i => i.SellerId == s.Id))
                {
                    ProductCart productCart = new ProductCart();
                    _stream = new MemoryStream(p.Picture);
                    productCart.productPictureBox.Image = Image.FromStream(_stream);
                    productCart.Name = p.Name;
                    productCart.priceLabel.Text = $"₱{p.Price}";
                    productCart.productNameLabel.Text = p.Name;
                    productCart.checkBox.CheckedChanged += checkBox_CheckedChanged;
                    productCart.deleteButton.Click += deleteButton_Clicked;
                    cartFlowLayoutPanel.Controls.Add(productCart);
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
                _toDelete.Add(p);
                if (!_sellersToBuy.Contains(associatedSeller)) _sellersToBuy.Add(associatedSeller);
                _productsToBuy.Add(associatedProduct);
            }
            else
            {
                _toDelete.Remove(p);
                _productsToBuy.Remove(associatedProduct);
            }

            if (_toDelete.Count != 0) deleteButton.Enabled = true;
            else deleteButton.Enabled = false;
        }

        private void deleteButton_Clicked(object sender, EventArgs e)
        {
            BunifuTileButton b = (BunifuTileButton)sender;
            ProductCart p = (ProductCart)b.Parent;
            cartFlowLayoutPanel.Controls.Remove(p);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            bunifuPages2.SelectedIndex++;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

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
            foreach (var s in _sellersToBuy)
            {
                foreach (var p in _productsToBuy.Where(i => i.SellerId == s.Id))
                {
                    Orders o = new Orders();
                    o.Id = GenerateId();
                    o.ProductId = p.ProductId;
                    o.Quantity = _quantity;
                    o.SellerId = s.Id;
                    o.Status = "Processing";
                    o.TotalPrice = _quantity * p.Price;
                    _data.Orders.Add(o);
                }
            }
            _data.SaveChanges();
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
            var myConnection = new SqlConnection(ConnectionString);
            const string queryString = "SELECT ID FROM Orders WHERE Id = @ID";

            myConnection.Open();
            var param = new SqlParameter { ParameterName = "@ID", Value = (int)id };
            var cmd = new SqlCommand(queryString, myConnection);
            cmd.Parameters.Add(param);

            var oReader = cmd.ExecuteReader();

            while (oReader.Read())
            {
                if (oReader["ID"].ToString() != id.ToString()) continue;

                myConnection.Close();
                return false;
            }

            myConnection.Close();
            return true;
        }
    }
}
