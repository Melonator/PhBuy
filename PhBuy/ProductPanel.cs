using Bunifu.UI.WinForms;
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
        public string Name;
        public PictureBox Picture = new PictureBox();
        public Label ProductName = new Label();
        public Label Price = new Label();
        public ProductPanel(Image image, string name, string price)
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
            //Price label
            Price.Text = price;
            Price.Location = new Point(3, 195);
            Price.Font = new Font("Mulish", 10);
            Price.ForeColor = Color.FromArgb(249, 58, 39);
            Price.BackColor = Color.Transparent;
            //Add the controls
            Controls.Add(Picture);
            Controls.Add(ProductName);
            Controls.Add(Price);
        }  
    }
}
