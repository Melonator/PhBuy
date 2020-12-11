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
    public partial class MyOrders : Form
    {
        private List<Orders> _orders;
        private List<Customer> _customers;
        private List<Orders> _ordersQuery;
        private List<Products> _products;
        private MemoryStream _stream;
        private PhBuyContext _data = new PhBuyContext();

        private bool _hasStart = false;
        private bool _hasEnd = false;

        private string _previousLabel = "All";
        public MyOrders()
        {
            InitializeComponent();
        }

        public void LoadData(List<Orders> o, List<Customer> c, List<Products> p)
        {
            _orders = o;
            _customers = c;
            _products = p;
            DisplayOrders();
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            DisplayOrders();
        }

        private void DisplayOrders(string status = "All", bool useDate = false, string sort = "Date: New to Old")
        {
            ordersFlowLayoutPanel.Controls.Clear();
            _ordersQuery = _orders.ToList();

            if(status != "All") _ordersQuery = _ordersQuery.Where(o => o.Status == status).ToList();

            if (useDate)
            {
                _ordersQuery = _ordersQuery.Where(s => s.DateOrdered <= datePickerEnd.Value)
                    .Where(e => e.DateOrdered >= datePickerStart.Value).ToList();
            }

            switch(sort)
            {
                case "Date: New to Old":
                    {
                        _ordersQuery = _ordersQuery.OrderByDescending(o => o.DateOrdered).ToList();
                        break;
                    }
                case "Date: Old to New":
                    {
                        _ordersQuery = _ordersQuery.OrderBy(o => o.DateOrdered).ToList();
                        break;
                    }
                case "Total: High to Low":
                    {
                        _ordersQuery = _ordersQuery.OrderByDescending(o => o.TotalPrice).ToList();
                        break;
                    }
                case "Total: Low to High":
                    {
                        _ordersQuery = _ordersQuery.OrderBy(o => o.TotalPrice).ToList();
                        break;
                    }

            }

            foreach(var o in _ordersQuery)
            {
                OrderPanel op = new OrderPanel();
                op.Name = o.Id.ToString();
                Products currentProduct = _products.Find(i => i.ProductId == o.ProductId);
                Customer currentCustomer = _customers.Find(i => i.Id == o.CustomerId);
                op.productNameLabel.Text = currentProduct.Name;
                _stream = new MemoryStream(currentCustomer.Picture);
                op.customerProfilePicture .Image= Image.FromStream(_stream);
                _stream.Close();
                op.customerNameLabel.Text = currentCustomer.Name;
                op.quantityLabel.Text = $"x{o.Quantity}";
                op.priceLabel.Text = $"₱{o.TotalPrice}";
                op.statusDropDown.Text = o.Status;
                op.statusDropDown.SelectedIndexChanged += statusDropDown_SelectedIndexChanged;
                if (o.Status == "Confirmed") op.statusDropDown.Enabled = false;
                ordersFlowLayoutPanel.Controls.Add(op);
            }
        }

        private void datePickerStart_ValueChanged(object sender, EventArgs e)
        {
            _hasStart = true;
            if (_hasEnd) DisplayOrders(_previousLabel, true, sortDropDown.Text);
        }

        private void datePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            _hasEnd = true;
            if (_hasStart) DisplayOrders(_previousLabel, true, sortDropDown.Text);
        }

        private void sortDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_hasStart && _hasEnd) DisplayOrders(_previousLabel, true, sortDropDown.Text);
            else DisplayOrders(_previousLabel, false, sortDropDown.Text);
        }

        private void statusDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var d = (BunifuDropdown)sender;
            var p = (OrderPanel)d.Parent;
            Orders o = _ordersQuery.Find(i => i.Id == decimal.Parse(p.Name));
            o.Status = d.Text;
            _data.Orders.Update(o);
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
