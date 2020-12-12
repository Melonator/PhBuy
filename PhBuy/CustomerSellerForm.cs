﻿using PhBuyModels;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class CustomerSellerForm : Form
	{
		private readonly int _id;
		private readonly string _userName;
		private const string ConnectionString =
			"Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";
		private PhBuyContext _data = new PhBuyContext();

		public CustomerSellerForm(string name, int id)
		{
			_id = id;
			_userName = name;
			InitializeComponent();
		}

		private void sellTileButton_Click(object sender, EventArgs e)
		{
			if (isNewSeller())
			{
				var reg = new SellerRegisterForm(_userName, _id, this);
				reg.ShowDialog();
				Hide();
			}

            else
            {
				var main = new MainForm(GetSeller(), this);
				main.Show();
				Hide();
			}
		}

		private Customer GetCustomer()
        {
			return _data.Customer.Where(i => i.Id == _id).FirstOrDefault();
        }

		private Seller GetSeller()
        {
			return _data.Seller.Where(i => i.Id == _id).FirstOrDefault();
		}
		private bool isNewSeller()
        {
			return _data.Customer.Find(GetSeller()) == null;
        }

		private bool isNewCustomer()
        {
			return _data.Customer.Find(GetCustomer()) == null;
		}

        private void buyTileButton_Click(object sender, EventArgs e)
        {
			if (isNewCustomer())
            {
				var register = new CustomerRegisterForm(_id, this);
				register.Show();
				Hide();
            }
            else
            {
				var main = new MainForm(GetCustomer(), this);
				main.Show();
				Hide();
			}
        }

        private void button1_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }
    }
}