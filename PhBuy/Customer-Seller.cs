using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class Customer_Seller : Form
    {
        private int ID;
        public Customer_Seller(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void sellerPanel_Click(object sender, EventArgs e)
        {
            Seller_Register form = new Seller_Register(ID);
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            mainPanel.Controls.Add(form);
        }

        private void customerPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
