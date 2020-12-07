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
using PhBuy.Query_Models;
using PhBuyModels;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace PhBuy
{
    public partial class MyProducts : Form
    {
        private string _previousLabel = string.Empty;
        private SellerQuery _sellerQuery = new SellerQuery();
        private PhBuyContext data = new PhBuyContext();
        private List<Products> products = new List<Products>();
        private List<Products> displayQuery = new List<Products>();
        private List<string> selectedCards = new List<string>();
        private MemoryStream _stream;

        private int _id;

        public MyProducts(int id)
        {
            _id = id;
            InitializeComponent();
        }
        private void MyProducts_Load(object sender, EventArgs e)
        {
            products = data.Products.Where(p => p.SellerId == _id).ToList();
        }

        private void label_Click(object sender, EventArgs e)
        {    
            Label label = (Label)sender;
            if (label.Name != _previousLabel)
            {
                BunifuSeparator s = (BunifuSeparator)Controls.Find($"{label.Name}Separator", true).First();
                s.LineThickness = 2;
                s.LineColor = Color.FromArgb(249, 58, 39);
   
                if (_previousLabel != string.Empty)
                {
                    s = (BunifuSeparator)Controls.Find($"{_previousLabel}Separator", true).First();
                    s.LineThickness = 1;
                    s.LineColor = Color.FromArgb(45, 41, 66);
                }

                _previousLabel = label.Name;
            }

            ChangeCategory(_previousLabel);
        }

        private void ChangeCategory(string SelectedLabel, string productName = "", int stockMin = -1, int stockMax = -1, string type = null)
        {
            switch (SelectedLabel)
            {
                case "all":
                    {
                        DisplayProducts(productName, stockMin, stockMax, type);
                        break;
                    }
                case "soldOut":
                    {
                        DisplayProducts(productName, 0, 0, type);
                        break;
                    }
                case "unlisted":
                    {
                        DisplayProducts(productName, -1, -1, type, "Unlisted");
                        break;
                    }
                case "listed":
                    {
                        DisplayProducts(productName, -1,-1,type);
                        break;
                    }
            }
        }
       
        private void DisplayProducts(string productName = "", int stockMin = -1, int stockMax = -1, string type = null, string status = "Listed")
        {
            //Reset the display
            productsFlowLayoutPanel.Controls.Clear();
            displayQuery = products;

            //Code block for specific queries
            if (productName != "")
                displayQuery = displayQuery.Where(p => p.Name == productName).ToList();
            if (stockMin != -1)
                displayQuery = displayQuery.Where(p => p.Stock >= stockMin).ToList();
            if (stockMax != -1)
                displayQuery = displayQuery.Where(p => p.Stock <= stockMax).ToList();
            if (type != null)
                displayQuery = displayQuery.Where(p => p.Type == type).ToList();
            //if (type != "Listed")
                //TODO: Update the database to add status (god i hate this part)
            

            foreach(var p in displayQuery)
            {
                int stock = (int)p.Stock;
                _stream = new MemoryStream(p.Picture);
                ProductPanel product = new ProductPanel(Image.FromStream(_stream), p.Name, $"₱{p.Price}", $"Stock: {stock}");
                product.SetStockLocation(stock.ToString());
                product.SetButtonImages();
                product.MouseHover += shadowPanel_Hover;
                product.MouseLeave += shadowPanel_Leave;
                product.CheckButton.CheckedChanged += checkBox_CheckChanged;
                product.DeleteButton.Click += deleteButton_Click;
                product.Picture.MouseHover += shadowPanelPicture_Hover;
                product.Picture.MouseLeave += shadowPanelPicture_Leave;
                _stream.Close();
                productsFlowLayoutPanel.Controls.Add(product);
            }
        }
       
        private void searchButton_Click(object sender, EventArgs e)
        {
            StartQuery();
        }

        private void shadowPanel_Hover(object sender, EventArgs e)
        {
            BunifuShadowPanel p = (BunifuShadowPanel)sender;
            p.ShadowDepth = 6;
        }

        private void shadowPanel_Leave(object sender, EventArgs e)
        {
            BunifuShadowPanel p = (BunifuShadowPanel)sender;
            p.ShadowDepth = 2;
        }

        private void shadowPanelPicture_Hover(object sender, EventArgs e)
        {
            PictureBox s = (PictureBox)sender;
            ProductPanel p = (ProductPanel)s.Parent;
            p.ShadowDepth = 6;
        }

        private void shadowPanelPicture_Leave(object sender, EventArgs e)
        {
            PictureBox s = (PictureBox)sender;
            ProductPanel p = (ProductPanel)s.Parent;
            p.ShadowDepth = 2;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //TODO: User Prompt, Custom messagebox
            Bunifu.Framework.UI.BunifuTileButton b = (Bunifu.Framework.UI.BunifuTileButton)sender;
            ProductPanel a = (ProductPanel)b.Parent;
            Products p = products.Find(s => s.Name == a.Name);
            RemoveProductImages((int)p.ProductId);
            data.Products.Remove(p);
            RemoveDeletedProducts();
        }

        private void checkBox_CheckChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            BunifuCheckBox c = (BunifuCheckBox)sender;
            ProductPanel p = (ProductPanel)c.Parent;
            if (c.Checked) selectedCards.Add(p.Name);
            else selectedCards.Remove(p.Name);
            deleteAllButton.Enabled = true;

            if (selectedCards.Count == 0) deleteAllButton.Enabled = false;
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            Products p;
            foreach (var name in selectedCards)
            {
                p = products.Find(s => s.Name == name);
                RemoveProductImages((int)p.ProductId);
                products.Remove(p);
                data.Products.Remove(p);
            }
            data.SaveChanges();
            RemoveDeletedProducts();
        }

        private void RemoveProductImages(int id)
        {
            var Images = data.ProductImages.ToList().Where(p => p.ProductId == id);
            foreach(var p in Images)
            {
                data.Remove(p);
            }
            data.SaveChanges();
        }
        private void StartQuery()
        {
            if (stockMinTextBox.Text != string.Empty)
                _sellerQuery.StockMin = int.Parse(stockMinTextBox.Text);
            if (stockMaxTextBox.Text != string.Empty)
                _sellerQuery.StockMax = int.Parse(stockMaxTextBox.Text);
            if (nameTextBox.Text != string.Empty)
                _sellerQuery.ProductName = nameTextBox.Text;
            if (categoryDropDown.Text != string.Empty)
                _sellerQuery.Type = categoryDropDown.Text;

            ChangeCategory(_previousLabel, _sellerQuery.ProductName, _sellerQuery.StockMin, _sellerQuery.StockMax, _sellerQuery.Type);
        }
        private void RemoveDeletedProducts()
        {
            foreach(var p in selectedCards)
            {
                ProductPanel panel = (ProductPanel)productsFlowLayoutPanel.Controls.Find(p, true).First();
                productsFlowLayoutPanel.Controls.Remove(panel);
            }
            selectedCards.Clear();
        }
    }
}
