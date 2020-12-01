using System;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class MainForm : Form
	{
		//Ill just leave this here
		private string _connectionString =
			"Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

		public MainForm()
		{
			InitializeComponent();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void bunifuButton5_Click(object sender, EventArgs e)
		{
			var databaseForm = new DatabaseForm();
			databaseForm.Show();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//Determine if the user is a seller or not
			//If seller
			var form = new SellerPanel(this);
			form.TopLevel = false;
			form.Show();
			sidePanel.Controls.Add(form);
		}
	}
}