using Bunifu.UI.WinForms;
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
    public partial class MyProducts : Form
    {
        string previousLabel = string.Empty;
        public MyProducts()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {    
            Label label = (Label)sender;
            if (label.Name != previousLabel)
            {
                BunifuSeparator s = (BunifuSeparator)Controls.Find($"{label.Name}Separator", true).First();
                s.LineThickness = 2;
                s.LineColor = Color.FromArgb(249, 58, 39);
   
                if (previousLabel != string.Empty)
                {
                    s = (BunifuSeparator)Controls.Find($"{previousLabel}Separator", true).First();
                    s.LineThickness = 1;
                    s.LineColor = Color.FromArgb(45, 41, 66);
                }

                previousLabel = label.Name;
            }

            ChangeCategory(previousLabel);
        }

        private void ChangeCategory(string SelectedLabel, string productName = "", string type = "", int stockMin = -1, int stockMax = -1)
        {
            switch (SelectedLabel)
            {
                case "all":
                    {
                        DisplayProducts(productName, stockMin, stockMax, type, "all");
                        break;
                    }
                case "soldOut":
                    {
                        DisplayProducts(productName, 0, 0, type);
                        break;
                    }
                case "unlisted":
                    {
                        DisplayProducts(productName, stockMin, stockMax, type, "Unlisted");
                        break;
                    }
                case "listed":
                    {
                        DisplayProducts(productName, stockMin, stockMax, type);
                        break;
                    }
            }
        }
        private void DisplayProducts(string productName = "", int stockMin = -1, int stockMax = -1, string type = "", string status = "Listed")
        {
            //TODO: Use filter parameter to display products
        }
    }
}
