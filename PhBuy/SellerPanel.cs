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
		private bool isPanelOpen1 = true;
		private bool isPanelOpen2 = true;
		private bool isPanelOpen3 = true;
		private bool isPanelOpen4 = true;
		public SellerDashBoard sellerDashBoard;
		private MyProducts myProducts;
		private MyOrders _myOrders;
		private PhBuyContext _data = new PhBuyContext();
		private List<Orders> _orders;
		private List<Products> _products;
		private List<Customer> _customers;

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

			myProducts = new MyProducts(_id, this)
			{
				MdiParent = _form,
				Parent = sellerDashBoard.sellerTabControl.TabPages[3]
			};
			myProducts.Show();
			myProducts.LoadProducts();

			addProduct = new AddProduct(_id, myProducts, this)
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
		}

		private void LoadData()
        {
			_orders = _data.Orders.Where(i => i.SellerId == _id).ToList();
			_products = _data.Products.Where(i => i.SellerId == _id).ToList();
			_customers = _data.Customer.ToList();
        }

		private void dropDown_Click(object sender, EventArgs e)
		{
			var btn = (BunifuButton) sender;

			switch (btn.Name)
			{
				case "storeDropDown":
				{
					if (isPanelOpen1)
					{
						isPanelOpen1 = false;
						panel1.Hide();
					}
					else
					{
						isPanelOpen1 = true;
						panel1.Show();
					}
				}
					break;
				case "productDropDown":
				{
					if (isPanelOpen2)
					{
						isPanelOpen2 = false;
						panel2.Hide();
					}
					else
					{
						isPanelOpen2 = true;
						panel2.Show();
					}
				}
					break;
				case "orderDropDown":
				{
					if (isPanelOpen3)
					{
						isPanelOpen3 = false;
						panel3.Hide();
					}
					else
					{
						isPanelOpen3 = true;
						panel3.Show();
					}
				}
					break;
				case "analyticDropDown":
				{
					if (isPanelOpen4)
					{
						isPanelOpen4 = false;
						panel4.Hide();
					}
					else
					{
						isPanelOpen4 = true;
						panel4.Show();
					}
				}
					break;
			}
		}

		private void profileButton_Click(object sender, EventArgs e)
		{
			//TODO: show seller profile
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
			//TODO: show insights
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