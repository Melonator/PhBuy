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
        private ProductSearch _productSearch;
        private PhBuyContext _data = new PhBuyContext();
        public CartForm CartForm;
        public CustomerDashBoard()
        {
            InitializeComponent();
        }

        private void CustomerDashBoard_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            scrollBar.ThumbLength = 100;
            CustomerHomePage = new CustomerHomePage(this, _data)
            {
                MdiParent = this,
                Parent = customerTabControl.TabPages[0]
            };
            CustomerHomePage.Show();
            DiscoverSellers discoverSellers = new DiscoverSellers(CustomerHomePage._sellers, CustomerHomePage._sellerTypes)
            {
                MdiParent = this,
                Parent = customerTabControl.TabPages[2]
            };
            discoverSellers.Show();
            SellerShop = new SellerShop(this)
            {
                MdiParent = this,
                Parent = customerTabControl.TabPages[3]
            };
            SellerShop.Show();
            ProductPage = new ProductPage(this)
            {
                MdiParent = this,
                Parent = customerTabControl.TabPages[5]
            };
            ProductPage.Show();
            _productSearch = new ProductSearch(this)
            {
                MdiParent = this,
                Parent = customerTabControl.TabPages[1]
            };
            _productSearch.Show();
            CartForm = new CartForm(this)
            {
                MdiParent = this,
                Parent = customerTabControl.TabPages[7]
            };
            CartForm.Show();
        }

        private void homePictureBox_Click(object sender, EventArgs e)
        { 
            scrollBar.DataBindings.Clear();
            scrollBar.BindTo(CustomerHomePage.panel);
            scrollBar.ThumbLength = 100;
            customerTabControl.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dropDown.Text == "Product")
            {
                _productSearch.CustomSearch(CustomerHomePage._products.Where(s => s.Name.Contains($"{searchTextBox.Text}")).ToList(), CustomerHomePage._sellers);
                if (customerTabControl.SelectedIndex != 1)
                {
                    customerTabControl.SelectedIndex = 1;
                }
            }
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            customerTabControl.SelectedIndex = 7;
        }
    }
}
