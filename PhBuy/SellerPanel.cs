using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;
using PhBuyModels;

namespace PhBuy
{
	public partial class SellerPanel : Form
	{
		private readonly MainForm _form;
		private readonly int _id;
		public SellerDashBoard sellerDashBoard;
		public MyProducts MyProducts;
		private MyOrders _myOrders;
		private PhBuyContext _data = new PhBuyContext();
		private List<Orders> _orders;
		private List<Products> _products;
		private List<Customer> _customers;
		private DataAnalytics _dataAnalytics;

		public AddProduct addProduct;
		public SellerPanel(MainForm form, int id)
		{
			_form = form;
			_id = id;
			InitializeComponent();
		}
		private void SellerPanel_Load(object sender, EventArgs e)
		{
			LoadData();
			sellerDashBoard =(SellerDashBoard) _form.mainPanel.Controls[0];

			SellerProfile profile = new SellerProfile(_form, _form.CurrentSeller)
			{
				MdiParent = _form,
				Parent = sellerDashBoard.sellerTabControl.TabPages[0]
			};
			profile.Show();

			MyProducts = new MyProducts(_id, this)
			{
				MdiParent = _form,
				Parent = sellerDashBoard.sellerTabControl.TabPages[3]
			};
			MyProducts.Show();
			MyProducts.LoadProducts();

			addProduct = new AddProduct(_id, MyProducts, this)
			{
				MdiParent = _form,
				Parent = sellerDashBoard.sellerTabControl.TabPages[4]
			};
			addProduct.Show();
			_myOrders = new MyOrders()
			{
				MdiParent = _form,
				Parent = sellerDashBoard.sellerTabControl.TabPages[5]
			};
			_myOrders.LoadData(_orders, _customers, _products);
			_myOrders.Show();
			_dataAnalytics = new DataAnalytics()
			{
				MdiParent = _form,
				Parent = sellerDashBoard.sellerTabControl.TabPages[7]
			};
			_dataAnalytics.Show();
		}

		private void LoadData()
        {
			_orders = _data.Orders.Where(i => i.SellerId == _id).ToList();
			_products = _data.Products.Where(i => i.SellerId == _id).ToList();
			_customers = _data.Customer.ToList();
        }

		private void PanelVisibility(Panel p)
        {
			if (p.Visible == true) p.Hide();
			else
			{
				p.Show();
			}
        }

		private void dropDown_Click(object sender, EventArgs e)
		{
			var btn = (BunifuButton) sender;

			switch (btn.Name)
			{
				case "productDropDown":
				{
						PanelVisibility(panel2);
				}
					break;
				case "orderDropDown":
				{
						PanelVisibility(panel3);
				}
					break;
			}
		}

		private void profileButton_Click(object sender, EventArgs e)
		{
			sellerDashBoard.sellerTabControl.SelectedIndex = 0;
		}

		private void ratingButton_Click(object sender, EventArgs e)
		{
			//TODO: show seller rating 
		}

		private void reportButton_Click(object sender, EventArgs e)
		{
			//TODO: show seller reports
		}

		private void productButton_Click(object sender, EventArgs e)
		{
			sellerDashBoard.sellerTabControl.SelectedIndex = 3;
		}

		private void addProductButton_Click(object sender, EventArgs e)
		{
			addProduct.addProductPages.PageIndex = 0;
			addProduct.ClearValues();
			sellerDashBoard.sellerTabControl.SelectedIndex = 4;
		}

		private void ordersButton_Click(object sender, EventArgs e)
		{
			//TODO: show orders
			sellerDashBoard.sellerTabControl.SelectedIndex = 5;
		}

		private void incomeButton_Click(object sender, EventArgs e)
		{
			//TODO: show income
		}

		private void insightButton_Click(object sender, EventArgs e)
		{
			sellerDashBoard.sellerTabControl.SelectedIndex = 7;
		}

		private void inventoryButton_Click(object sender, EventArgs e)
		{
			//TODO: show inventory
		}

		private void databaseButton_Click(object sender, EventArgs e)
		{
			var form = new DatabaseForm();
			form.Show();
		}
    }
}