using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class SellerPanel : Form
    {
        private bool isPanelOpen1 = true;
        private bool isPanelOpen2 = true;
        private bool isPanelOpen3 = true;
        private bool isPanelOpen4 = true;
        public SellerPanel()
        {
            InitializeComponent();
        }

        private void dropDown_Click(object sender, EventArgs e)
        {
            BunifuButton btn = (BunifuButton)sender; 
           
            switch(btn.Name)
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
            //TODO: show products
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            //TODO: show add products
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            //TODO: show orders
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
            DatabaseForm form = new DatabaseForm();
            form.Show();
        }
    }
}
