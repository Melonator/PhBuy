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
    public partial class CoverForm : Form
    {
        private Seller_Register _form;
        private PictureBox pictureBox;
        private Image cover;
        public CoverForm(Seller_Register form)
        {
            InitializeComponent();
            _form = form;
        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cover_Click(object sender, EventArgs e)
        {
            pictureBox = (PictureBox)sender;
            _form.sellerBackground.Image = pictureBox.Image;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose your product image";
            if (dlg.ShowDialog() == DialogResult.OK)
            { 
                //Something
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            _form.SetImage();
            Close();
        }
    }
}
