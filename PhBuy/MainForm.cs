using PhBuyModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PhBuy
{
	public partial class MainForm : Form
	{
		private Customer _currentCustomer;
		private Seller _currentSeller;
		private readonly string _type;
		public MainForm(string type, Customer c = null, Seller s = null)
		{
			if (type == "Seller")
				_currentSeller = s;

			else
				_currentCustomer = c;

			_type = type;
			InitializeComponent();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			Application.Exit();
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
			if (_type == "Seller")
			{
				var form2 = new SellerDashBoard() { TopLevel = false };
				form2.Show();
				mainPanel.Controls.Add(form2);

				var form = new SellerPanel(this, (int)_currentSeller.Id) { TopLevel = false };
				form.Show();
				sidePanel.Controls.Add(form);
				setInformation();
			}
            else
            {
				CustomerDashBoard dashBoard = new CustomerDashBoard(this, _currentCustomer) { TopLevel = false};
				dashBoardPanel.Controls.Clear();
				dashBoardPanel.Controls.Add(dashBoard);
				setInformation();
				dashBoard.Show();
            }
		}

		private void setInformation()
        {
			int panelDistance = 6;
			if(_type == "Seller") userNameLabel.Text = _currentSeller.Name;
			else userNameLabel.Text = _currentCustomer.Name;
			userPhoto.Image = getUserImage();
			userPanel.Location = new Point(bunifuSeparator1.Location.X - panelDistance - userPanel.Width,0);
        }

		private Image getUserImage()
        {
            MemoryStream stream;
			if (_type == "Seller")
				stream = new MemoryStream(_currentSeller.Picture);
			else
				stream = new MemoryStream(_currentCustomer.Picture);
            Image image = Image.FromStream(stream);

            return image;
		}
    }
}