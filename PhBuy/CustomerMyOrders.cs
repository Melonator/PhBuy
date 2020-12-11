﻿using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
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

        public void LoadData(List<Orders> o, List<Seller> s, List<Products> p)
        {
            _orders = o;
            _sellers = s;
            _products = p;
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
            _ordersQuery = _orders;

            if (status != "All")
                _ordersQuery = _ordersQuery.Where(p => p.Status == status).ToList();

            foreach(var o in _ordersQuery)
            {
                CustomerOrderPanel co = new CustomerOrderPanel();
                co.Name = o.Id.ToString();
                Products currentProduct = _products.Find(i => i.ProductId == o.ProductId);
                Seller currenSeller = _sellers.Find(i => i.Id == o.CustomerId);
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
                    co.deliveredButton.Enabled = false;
                    co.deliveredButton.Click += deliveredButton_Click;
                    co.rateButton.Click += rateButton_Click;
                }
                ordersFlowLayoutPanel.Controls.Add(co);
            }
        }

        private void deliveredButton_Click(object sender, EventArgs e)
        {
            var button = (BunifuButton)sender;
            button.Enabled = false;
            var c = (CustomerOrderPanel) button.Parent;
            c.rateButton.Enabled = true;
            Orders o = _orders.Find(i => i.Id == decimal.Parse(c.Name));
            o.Status = "Delivered";
            _data.Orders.Update(o);
            _data.SaveChanges();
            //Bunifu Snackbar Notifcation
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
           //RATE THE PRODUCT
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