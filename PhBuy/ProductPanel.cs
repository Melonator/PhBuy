using Bunifu.UI.WinForms;
using PhBuy.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    class ProductPanel : BunifuShadowPanel
    {
        public PictureBox Picture = new PictureBox();
        public Label ProductName = new Label();
        public Label Price = new Label();
        public Label Stock = new Label();
        private BunifuSeparator _separatorH = new BunifuSeparator();
        private BunifuSeparator _separatorV = new BunifuSeparator();
        public BunifuCheckBox CheckButton = new BunifuCheckBox();
        public Bunifu.Framework.UI.BunifuTileButton EditButton = new Bunifu.Framework.UI.BunifuTileButton();
        public Bunifu.Framework.UI.BunifuTileButton DeleteButton = new Bunifu.Framework.UI.BunifuTileButton();
        public ProductPanel(Image image, string name, string price, string stock)
        {
            Size = new Size(164, 265);
            Name = name;
            BackColor = Color.White;
            BorderColor = Color.Transparent;
            ShadowDepth = 2;
            ShadowTopLeftVisible = true;
            //Picture properties
            Picture.Location = new Point(7,0);
            Picture.Size = new Size(150, 162);
            Picture.SizeMode = PictureBoxSizeMode.Zoom;
            Picture.Image = image;
            Picture.BackColor = Color.Transparent;
            //Name label
            ProductName.Text = name;
            ProductName.Location = new Point(3, 166);
            ProductName.Font = new Font("Mulish", 10);
            ProductName.ForeColor = Color.FromArgb(45, 41, 66);
            ProductName.BackColor = Color.Transparent;
            ProductName.AutoSize = true;
            //Price label
            Price.Text = price;
            Price.AutoSize = true;
            Price.Location = new Point(3, 195);
            Price.Font = new Font("Mulish", 10);
            Price.ForeColor = Color.FromArgb(249, 58, 39);
            Price.BackColor = Color.Transparent;
            //Stock Label
            Stock.Text = stock;
            Stock.Font = new Font("Mulish", 10);
            Stock.AutoSize = true;
            Stock.ForeColor = Color.FromArgb(45, 41, 66);
            Stock.BackColor = Color.Transparent;
            //First separator
            _separatorH.LineColor = Color.Silver;
            _separatorH.Location = new Point(1, 228);
            _separatorH.Size = new Size(161, 14);
            //Second Separator
            _separatorV.LineColor = Color.Silver;
            _separatorV.Orientation = BunifuSeparator.LineOrientation.Vertical;
            _separatorV.Location = new Point(76, 237);
            _separatorV.Size = new Size(14, 23);
            //Checkbox
            CheckButton.Location = new Point(6, 5);
            CheckButton.OnCheck.BorderColor = Color.FromArgb(249, 58, 39);
            CheckButton.OnCheck.CheckBoxColor = Color.FromArgb(249, 58, 39);
            CheckButton.OnHoverChecked.BorderColor = Color.FromArgb(192, 50, 43);
            CheckButton.OnHoverChecked.CheckBoxColor = Color.FromArgb(192, 50, 43);
            CheckButton.OnHoverUnchecked.BorderColor = Color.DarkGray;
            CheckButton.OnHoverUnchecked.CheckBoxColor = Color.DarkGray;
            CheckButton.Checked = false;
            CheckButton.BackColor = Color.Transparent;

            //Add the controls
            Controls.Add(Picture);
            Controls.Add(ProductName);
            Controls.Add(Price);
            Controls.Add(Stock);
            Controls.Add(_separatorH);
            Controls.Add(_separatorV);
            Controls.Add(CheckButton); 
        }  
        public void SetStockLocation(string stock)
        {
            _separatorV.BringToFront();
            CheckButton.BringToFront();
            switch (stock.Count())
            {
                case 1:
                    {
                        Stock.Location = new Point(97, 195);
                        break;
                    }
                case 2:
                    {
                        Stock.Location = new Point(89, 195);
                        break;
                    }
                case 3:
                    {
                        Stock.Location = new Point(81, 195);
                        break;
                    }
                case 4:
                    {
                        Stock.Location = new Point(73, 195);
                        break;
                    }
                default:
                    {
                        Stock.Location = new Point(66, 195);
                        break;
                    }
            }
        }
        public void SetButtonImages()
        {
            //TODO: Set button image and locations here
            EditButton.Image = Resources.Pencil;
            EditButton.Size = new Size(55, 26);
            EditButton.Location = new Point(14, 237);
            EditButton.color = Color.WhiteSmoke;
            EditButton.colorActive = Color.Gainsboro;
            EditButton.LabelText = string.Empty;
            EditButton.LabelPosition = 0;
            EditButton.ImageZoom = 33;
            EditButton.ImagePosition = 3;

            DeleteButton.Image = Resources.Trash;
            DeleteButton.Size = new Size(55, 26);
            DeleteButton.Location = new Point(97, 237);
            DeleteButton.color = Color.WhiteSmoke;
            DeleteButton.colorActive = Color.Gainsboro;
            DeleteButton.LabelText = string.Empty;
            DeleteButton.LabelPosition = 0;
            DeleteButton.ImageZoom = 33;
            DeleteButton.ImagePosition = 3;

            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
        }
    }
}
