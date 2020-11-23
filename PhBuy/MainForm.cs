using System;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class MainForm : Form
	{
		//Ill just leave this here
		private string _connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

		public MainForm()
		{
			if (new LandingForm().ShowDialog() == DialogResult.OK)
			{
				InitializeComponent();
			}
			else
			{
				Close();
			}
		}
		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void bunifuButton5_Click(object sender, EventArgs e)
		{
			DatabaseForm databaseForm = new DatabaseForm();
			databaseForm.Show();
		}
	}
}
