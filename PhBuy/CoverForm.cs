using System;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class CoverForm : Form
	{
		private readonly SellerRegisterForm _form;
		private PictureBox _pictureBox;

		public CoverForm(SellerRegisterForm form)
		{
			InitializeComponent();
			_form = form;
		}

		private void cover_Click(object sender, EventArgs e)
		{
			_pictureBox = (PictureBox)sender;
			_form.sellerBackground.Image = _pictureBox.Image;
		}

		private void uploadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog { Title = "Choose your product image" };
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				// TODO: Do Something
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			_form.SetImage();
			Close();
		}
	}
}
