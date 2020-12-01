using System;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class CustomerSellerForm : Form
	{
		private readonly int _id;

		public CustomerSellerForm(int id)
		{
			_id = id;
			InitializeComponent();
		}

		private void sellerPanel_Click(object sender, EventArgs e)
		{
			var form = new SellerRegisterForm(_id);
			mainPanel.Controls.Clear();
			form.TopLevel = false;
			mainPanel.Controls.Add(form);
		}

		private void customerPanel_Click(object sender, EventArgs e)
		{
		}
	}
}