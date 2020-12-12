using PhBuyModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace PhBuy
{
	public partial class MainForm : Form
	{
		private Customer _currentCustomer;
		public Seller CurrentSeller;
		private readonly string _type;
		private CustomerSellerForm _cs = null;
		private CustomerDashBoard _dashBoard;
		public MainForm(Seller s, CustomerSellerForm cs)
		{
			CurrentSeller = s;
			_type = "Seller";
			_cs = cs;
			InitializeComponent();
		}

		public MainForm(Customer c, CustomerSellerForm cs)
        {
			_currentCustomer = c;
			_type = "Customer";
			_cs = cs;
			InitializeComponent();
        }

		public void ReloadData(string type)
        {
			PhBuyContext _data = new PhBuyContext();
			if(type == "Seller") CurrentSeller = _data.Seller.Find(CurrentSeller);
			else _currentCustomer = _data.Customer.Find(_currentCustomer);
			setInformation();
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

				var form = new SellerPanel(this, (int)CurrentSeller.Id) { TopLevel = false };
				form.Show();
				sidePanel.Controls.Add(form);
				setInformation();
				
			}
            else
            {
				_dashBoard = new CustomerDashBoard(this, _currentCustomer) { TopLevel = false};
				dashBoardPanel.Controls.Clear();
				dashBoardPanel.Controls.Add(_dashBoard);
				setInformation();
				_dashBoard.Show();
				userPhoto.Click += showCustomerProfile;
			}
		}

		private void setInformation()
        {
			int panelDistance = 6;
			if(_type == "Seller") userNameLabel.Text = CurrentSeller.Name;
			else userNameLabel.Text = _currentCustomer.Name;
			userPhoto.Image = getUserImage();
			userPanel.Location = new Point(bunifuSeparator1.Location.X - panelDistance - userPanel.Width,0);
        }

		private Image getUserImage()
        {
            MemoryStream stream;
			if (_type == "Seller")
				stream = new MemoryStream(CurrentSeller.Picture);
			else
				stream = new MemoryStream(_currentCustomer.Picture);
            Image image = Image.FromStream(stream);

            return image;
		}

        private void gridButton_Click(object sender, EventArgs e)
        {
			_cs.Show();
			Close();
        }

		private void showCustomerProfile(object sender, EventArgs e)
		{
			_dashBoard.customerTabControl.SelectedIndex = 9;
		}

		private void button1_Click(object sender, EventArgs e)
        {
			LandingForm lf = new LandingForm();
			lf.Show();
			bunifuSnackbar1.Show(lf, "Successfully Logged Out!");
			_cs.Close();
			Close();
        }
    }
}