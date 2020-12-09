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
        private CustomerHomePage customerHomePage;
        public CustomerDashBoard()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void CustomerDashBoard_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            scrollBar.ThumbLength = 100;
            customerHomePage = new CustomerHomePage(this)
            {
                MdiParent = this,
                Parent = customerTabControl.TabPages[0]
            };
            customerHomePage.Show();
            DiscoverSellers discoverSellers = new DiscoverSellers(customerHomePage._sellers, customerHomePage._sellerTypes)
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
        }

        private void homePictureBox_Click(object sender, EventArgs e)
        { 
            scrollBar.DataBindings.Clear();
            scrollBar.BindTo(customerHomePage.panel);
            scrollBar.ThumbLength = 100;
            customerTabControl.SelectedIndex = 0;
        }
    }
}
