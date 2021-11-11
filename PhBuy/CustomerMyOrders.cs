using Bunifu.UI.WinForms;
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
    public partial class CustomerMyOrders : Form
    {
        private List<Orders> _orders;
        private List<Seller> _sellers;
        private List<Orders> _ordersQuery;
        private List<Products> _products;
        private MemoryStream _stream;
        private PhBuyContext _data = new PhBuyContext();
        private CustomerDashBoard _dashBoard;
        private string _previousLabel = "All";

        public CustomerMyOrders(CustomerDashBoard c)
        {
            _dashBoard = c;
            InitializeComponent();
        }

        public void LoadData(List<Seller> s, List<Products> p)
        {
            PhBuyContext _data = new PhBuyContext();
            _orders = _data.Orders.Where(i => i.CustomerId == _dashBoard._currentCustomer.Id).ToList();
            _sellers = s;
            _products = p;
            if(_previousLabel != string.Empty)
            {
                var l = (BunifuSeparator)Controls.Find($"{_previousLabel}Separator", true).First();
                l.LineThickness = 1;
                l.LineColor = Color.DarkGray;
            }
            var q = (BunifuSeparator)Controls.Find("AllSeparator", true).First();
            q.LineThickness = 2;
            q.LineColor = Color.FromArgb(249, 58, 39);
            DisplayOrders();
        }

        private void CustomerMyOrders_Load(object sender, EventArgs e)
        {
            _dashBoard.scrollBar.BindTo(ordersFlowLayoutPanel);
            _dashBoard.scrollBar.ThumbLength = 100;
        }

        private void DisplayOrders(string status = "All")
        {
            ordersFlowLayoutPanel.Controls.Clear();
            _ordersQuery = _orders.OrderByDescending(i => i.DateOrdered).ToList();

            if (status != "All")
                _ordersQuery = _ordersQuery.Where(p => p.Status == status).ToList();

            foreach(var o in _ordersQuery)
            {
                CustomerOrderPanel co = new CustomerOrderPanel();
                co.Name = o.Id.ToString();
                Products currentProduct = _products.Find(i => i.ProductId == o.ProductId);
                Seller currenSeller = _sellers.Find(i => i.Id == currentProduct.SellerId);
                co.productNameLabel.Text = currentProduct.Name;
                _stream = new MemoryStream(currenSeller.Picture);
                co.sellerPictureBox.Image = Image.FromStream(_stream);
                _stream = new MemoryStream(currentProduct.Picture);
                co.productPictureBox.Image = Image.FromStream(_stream);
                co.quantityLabel.Text = $"Quantity: x{o.Quantity}";
                co.priceLabel.Text = $"₱{o.TotalPrice}";
                co.sellerNameLabel.Text = currenSeller.Name;
                co.statusLabel.Text = o.Status;

                if (o.Status == "Confirmed")
                {
                    co.deliveredButton.Enabled = true;
                    co.deliveredButton.Click += deliveredButton_Click;
                    co.rateButton.Click += rateButton_Click;
                }
                else if(o.Status == "Processing")
                {
                    co.cancelButton.Enabled = true;
                    co.cancelButton.Click += cancelButton_Click;
                }
                ordersFlowLayoutPanel.Controls.Add(co);
            }
        }

        private void deliveredButton_Click(object sender, EventArgs e)
        {
            var button = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
            button.Enabled = false;
            var c = (CustomerOrderPanel) button.Parent;
            c.rateButton.Enabled = true;
            Orders o = _orders.Find(i => i.Id == decimal.Parse(c.Name));
            Products p = _data.Products.Where(i => i.Name == c.productNameLabel.Text).FirstOrDefault();
            p.Sales++;
            o.Status = "Delivered";
            _data.Orders.Update(o);
            _data.SaveChanges();
            //Bunifu Snackbar Notifcation
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            //RATE THE PRODUCT
            var button = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
            var a = (CustomerOrderPanel)button.Parent;
            RateForm form = new RateForm(_products.Find(i => i.Name == a.productNameLabel.Text).Name);
            form.ShowDialog();
            bunifuSnackbar1.Show(_dashBoard._mainForm, "Product rated, thank you for your review", BunifuSnackbar.MessageTypes.Success);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //CANCEL THE PRODUCT
            var button = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
            var c = (CustomerOrderPanel)button.Parent;
            Orders o = _orders.Find(i => i.Id == decimal.Parse(c.Name));
            ordersFlowLayoutPanel.Controls.Remove(c);
            _data.Orders.Remove(o);
            _data.SaveChanges();
        }

        private void category_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Name != _previousLabel)
            {
                BunifuSeparator s = (BunifuSeparator)Controls.Find($"{label.Name}Separator", true).First();
                s.LineThickness = 2;
                s.LineColor = Color.FromArgb(249, 58, 39);

                s = (BunifuSeparator)Controls.Find($"{_previousLabel}Separator", true).First();
                s.LineThickness = 1;
                s.LineColor = Color.DarkGray;

                _previousLabel = label.Name;
            }

            DisplayOrders(_previousLabel);
        }

    }
}
