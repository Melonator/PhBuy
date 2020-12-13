using PhBuyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace PhBuy
{
    public partial class RateForm : Form
    {
        private PhBuyContext _data = new PhBuyContext();
        private string _product;
        private int value;
        public RateForm(string product)
        {
            _product = product;
            InitializeComponent();
        }


        private void UpdateDataBase(int rating)
        {
            Products p = _data.Products.Where(i => i.Name == _product).FirstOrDefault();
            ProductRatings r = new ProductRatings();
            r.ProductId = p.ProductId;
            r.Rating = rating;
            r.Id = (int)GenerateId();
            _data.ProductRatings.Add(r);
            _data.SaveChanges();
            CalculateAverage(p);
        }

        private void CalculateAverage(Products p)
        {
            var query = _data.ProductRatings.GroupBy(i => i.ProductId).Select(d => new
            {
                ProductID = d.Key,
                Total = d.Average(a => a.Rating)
            }).ToList();

            var average = query.Where(i => i.ProductID == p.ProductId).Select(d => d.Total).FirstOrDefault();
            p.Rating = average;
            _data.Products.Update(p);
            _data.SaveChanges();

            var selleraverage = _data.Products.GroupBy(i => i.SellerId).Select(d => new
            {
                SellerId = d.Key,
                Average = d.Average(q => q.Rating)
            }).ToList();

            Seller s = _data.Seller.Where(i => i.Id == p.SellerId).First();
            s.Rating = selleraverage.Where(i => i.SellerId == p.SellerId).Select(a => a.Average).FirstOrDefault();
            _data.Seller.Update(s);
            _data.SaveChanges();
        }

        private uint GenerateId()
        {
            uint id;
            // Keep on generating the ID until it is a new one
            do
            {
                id = Get5Digits();
            } while (!IsIdValid(id));

            return id;
        }

        private uint Get5Digits()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            return 10000 + BitConverter.ToUInt32(bytes, 0) % 90000;
        }

        private bool IsIdValid(uint id)
        {
            PhBuyContext data = new PhBuyContext();

            if (data.Orders.Select(i => i.Id).Where(d => d == id).Count() == 1) return false;
            else return true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            UpdateDataBase(value);
            bunifuSnackbar1.Show(this, "Thank you for your rating!", BunifuSnackbar.MessageTypes.Success);
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var r = (RadioButton)sender;
            switch (r.Name)
            {
                case "one":
                    {
                        value = 1;
                        break;
                    }
                case "two":
                    {
                        value = 2;
                        break;
                    }
                case "three":
                    {
                        value = 3;
                        break;
                    }
                case "four":
                    {
                        value = 4;
                        break;
                    }
                case "five":
                    {
                        value = 5;
                        break;
                    }
            }
        }
    }
}
