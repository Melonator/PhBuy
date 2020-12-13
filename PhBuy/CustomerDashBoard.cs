using Microsoft.EntityFrameworkCore;
using PhBuyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class CustomerDashBoard : Form
    {
        public SellerShop SellerShop;
        public ProductPage ProductPage;
        public CustomerHomePage CustomerHomePage;
        public ProductSearch ProductSearch;
        private PhBuyContext _data = new PhBuyContext();
        public CartForm CartForm;
        public MainForm _mainForm;
        public Customer _currentCustomer;
        private CustomerMyOrders _customerOrderPanel;
        public DiscoverSellers DiscoverSellers;
        private CustomerProfile _customerProfile;
        public CustomerBrowser Chat;
        private List<Profiles> _profiles;
        private List<Products> _products;
        private List<Seller> _sellers;
        private List<SellerTypes> _sellerTypes;
        private List<ProductImages> _productImages;
        public CustomerDashBoard(MainForm f, Customer c)
        {
            _mainForm = f;
            _currentCustomer = c;
            InitializeComponent();
        }

        private void CustomerDashBoard_Load(object sender, EventArgs e)
        {
            LoadData();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            scrollBar.ThumbLength = 100;
            CustomerHomePage = new CustomerHomePage(this, _products, _sellers, _sellerTypes, _profiles)
            {
                MdiParent = _mainForm,
                Parent = customerTabControl.TabPages[0]
            };
            CustomerHomePage.Show();
            DiscoverSellers = new DiscoverSellers(_sellers, _sellerTypes, _products, this, _profiles)
            {
                MdiParent = _mainForm,
                Parent = customerTabControl.TabPages[2]
            };
            DiscoverSellers.Show();
            SellerShop = new SellerShop(this)
            {
                MdiParent = _mainForm,
                Parent = customerTabControl.TabPages[3]
            };
            SellerShop.Show();
            ProductPage = new ProductPage(this, _productImages, _profiles)
            {
                MdiParent = _mainForm,
                Parent = customerTabControl.TabPages[5]
            };
            ProductPage.Show();
            ProductSearch = new ProductSearch(this)
            {
                MdiParent = _mainForm,
                Parent = customerTabControl.TabPages[1]
            };
            ProductSearch.Show();
            CartForm = new CartForm(this, _currentCustomer)
            {
                MdiParent = _mainForm,
                Parent = customerTabControl.TabPages[7]
            };
            CartForm.Show();
            _customerOrderPanel = new CustomerMyOrders(this)
            {
                MdiParent = _mainForm,
                Parent = customerTabControl.TabPages[8]
            };
            _customerOrderPanel.Show();
            _customerProfile = new CustomerProfile(_mainForm, _currentCustomer)
            {
                MdiParent = _mainForm,
                Parent = customerTabControl.TabPages[9]
            };
            _customerProfile.Show();
            _customerOrderPanel.LoadData(_sellers, _products);
            Chat = new CustomerBrowser
            {
                MdiParent = _mainForm,
                Parent = customerTabControl.TabPages[10]
            };
            Chat.Show();
        }

        private void LoadData()
        {
            _profiles = _data.Profiles.ToList();
            _products = _data.Products.Where(i => i.Status == "Listed" && i.Stock > 0).ToList();
            _sellers = _data.Seller.ToList();
            _sellerTypes = _data.SellerTypes.ToList();
            _productImages = _data.ProductImages.ToList();
        }
        private void homePictureBox_Click(object sender, EventArgs e)
        { 
            scrollBar.DataBindings.Clear();
            scrollBar.BindTo(CustomerHomePage.panel);
            scrollBar.ThumbLength = 100;
            scrollBar.Value = 0;
            customerTabControl.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dropDown.Text == "Product")
            {
                ProductSearch.CustomSearch(CustomerHomePage._products
                    .Where(s => s.Name.Contains($"{searchTextBox.Text}")).ToList(), CustomerHomePage._sellers);
                if (customerTabControl.SelectedIndex != 1)
                {
                    customerTabControl.SelectedIndex = 1;
                }
            }
            else
            {
                DiscoverSellers.CustomSearch(_sellers
                    .Where(s => s.Name.Contains($"{searchTextBox.Text}")).ToList());
                if (customerTabControl.SelectedIndex != 2)
                {
                    customerTabControl.SelectedIndex = 2;
                }
            }
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            customerTabControl.SelectedIndex = 7;
            scrollBar.BindTo(CartForm.panel);
            scrollBar.ThumbLength = 100;
            scrollBar.Value = 0;
        }

        private void TESTBUTTON_Click(object sender, EventArgs e)
        {
            LoadData();
            customerTabControl.SelectedIndex = 8;
            _customerOrderPanel.LoadData(_sellers, _products);
            scrollBar.ThumbLength = 100;
            scrollBar.Value = 0;
        }
    }
}
