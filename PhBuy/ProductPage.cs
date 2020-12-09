using PhBuyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class ProductPage : Form
    {
        private Products _product;
        private PhBuyContext _data = new PhBuyContext();
        private MemoryStream _stream = new MemoryStream();
        private Seller _seller;
        private CustomerDashBoard _dashBoard;
        public ProductPage(CustomerDashBoard c)
        {
            _dashBoard = c;
            InitializeComponent();
        }

        public void LoadData(Products p, Seller s)
        {
            _dashBoard.scrollBar.BindTo(mainPanel);
            _dashBoard.scrollBar.ThumbLength = 100;
            _product = p;
            _seller = s;

            SetPhotos();
            productNameLabel.Text = _product.Name;
            priceLabel.Text = _product.Price.ToString();
            descLabel.Text = _product.Description;
            stockLabel.Text = $"Stock: {_product.Stock}";
            /*ADD RATING AND SALES8*/
            _stream = new MemoryStream(_seller.Picture);
            sellerPictureBox.Image = Image.FromStream(_stream);
            sellerNameLabel.Text = _seller.Name;
            /*ADD SELLER INFO N STUFF*/
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            _dashBoard.scrollBar.BindTo(mainPanel);
            _dashBoard.scrollBar.ThumbLength = 100;
        }

        private void SetPhotos()
        {
            productImagesFlowPanel.Controls.Clear();
            _stream = new MemoryStream(_product.Picture);
            productPictureBox.Image = Image.FromStream(_stream);
            PictureBox productCover = new PictureBox
            {
                Size = new Size(78, 78),
                Image = Image.FromStream(_stream),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            productCover.Click += productPictureBox_Click;
            productImagesFlowPanel.Controls.Add(productCover);
            foreach (var i in _data.ProductImages.Where(d => d.ProductId == _product.ProductId).ToList())
            {
                _stream = new MemoryStream(i.Picture);
                PictureBox p = new PictureBox
                {
                    Size = new Size(78, 78),
                    Image = Image.FromStream(_stream),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                p.Click += productPictureBox_Click;
                productImagesFlowPanel.Controls.Add(p);
            }
        }

        private void productPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            productPictureBox.Image = p.Image;
        }
    }
}
