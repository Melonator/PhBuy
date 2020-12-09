using PhBuyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class DiscoverSellers : Form
    {
        private List<string> _selectedTypes = new List<string>();
        private List<Seller> _sellers = new List<Seller>();
        private List<SellerTypes> _sellerTypes;
        private List<Seller> _sellerQuery;
        private List<SellerTypes> _sellerTypeQuery = new List<SellerTypes>();
        private MemoryStream _stream;
        public DiscoverSellers(List<Seller> s, List<SellerTypes> t)
        {
            _sellers = s;
            _sellerTypes = t;
            InitializeComponent();
        }

        private void DiscoverSellers_Load(object sender, EventArgs e)
        {
            _sellerQuery = _sellers.ToList();
            DisplaySellers();
        }

        #region events
        private void typeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        { 
            SellerTypeControl type = new SellerTypeControl();
            type.Name = typeDropDown.Text;
            type.typeLabel.Text = typeDropDown.Text;
            type.Width = type.typeLabel.Width + 25;
            type.Click += sellerTypeControl_Click;
            type.label1.Click += sellerTypeControl_Click2;
            type.typeLabel.Click += sellerTypeControl_Click2;
            _selectedTypes.Add(type.Name);
            typeFlowLayoutPanel.Controls.Add(type);
        }

        private void sellerTypeControl_Click(object sender, EventArgs e)
        {
            SellerTypeControl t = (SellerTypeControl)sender;
            typeFlowLayoutPanel.Controls.Remove(t);
            _selectedTypes.Remove(t.Name);
        }

        private void sellerTypeControl_Click2(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            SellerTypeControl t = (SellerTypeControl)l.Parent;
            typeFlowLayoutPanel.Controls.Remove(t);
            _selectedTypes.Remove(t.Name);
        }
        #endregion

        #region Helper Functions

        private void DisplaySellers(string location = "", bool isAscending = true)
        {
            //YEAH GOTTA IMPLEMENT LOCATION SOON
            //if (location != string.Empty)
            //query shit
            _sellerQuery = _sellers.ToList();
            sellerFlowLayoutPanel.Controls.Clear();
            if(_selectedTypes.Count != 0)
            {
                foreach(var s in _sellers)
                {
                    filterTypes(s);
                }    
            }
             
            //if (isAscending)
                //_sellerQuery.OrderBy(s => s.rating);
            //else
           
            foreach(var s in _sellerQuery)
            {
                SellerDisplay seller = new SellerDisplay();
                _stream = new MemoryStream(s.Picture);
                seller.sellerProfilePicture.Image = Image.FromStream(_stream);
                _stream = new MemoryStream(s.Background);
                seller.sellerCoverPicture.Image = Image.FromStream(_stream);
                seller.shopNameLabel.Text = s.Name;
                seller.SetTypes(_sellerTypes.Where(t => t.SellerId == s.Id).Select(i => i.Type).ToArray());
                sellerFlowLayoutPanel.Controls.Add(seller);
            }
        }

        private void filterTypes(Seller currentSeller)
        {
            _sellerTypeQuery = _sellerTypes.Where(s => s.SellerId == currentSeller.Id).ToList();

            for(int i = 0; i < _selectedTypes.Count; i++)
            {
                for(int j = 0; j < _sellerTypeQuery.Count; j++)
                {
                    if (_selectedTypes[i] == _sellerTypeQuery[j].Type) return;
                }
            }

            _sellerQuery.Remove(currentSeller);
        }

        #endregion

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            DisplaySellers();
        }
    }
}
