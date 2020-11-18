using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class MainForm : Form
	{
		//Ill just leave this here
		public string connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123";

		public MainForm()
		{
			InitializeComponent();
		}
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}
