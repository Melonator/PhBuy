using Bunifu.UI.WinForms;
using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Media;

namespace PhBuy
{
    public partial class DataAnalytics : Form
    {
        private PhBuyContext _data = new PhBuyContext();
        private List<Products> _products;
        private List<Orders> _orders;
        private Seller _currentSeller;
        private int _id = 21629;

        private LineSeries income = new LineSeries();
        private ChartValues<double> values = new ChartValues<double>();
        private MemoryStream _stream;
        List<string> months = new List<string>();

        private bool isMonth = false;
        private string filterType = "sales";
        public DataAnalytics()
        {
            InitializeComponent();
        }

        private void DataAnalytics_Load(object sender, EventArgs e)
        {
            _products = _data.Products.Where(i => i.SellerId == _id).ToList();
            _orders = _data.Orders.Where(i => i.SellerId == _id).ToList();
            FilterValues();
            AddTopProducts();
            LoadPieSeries();

            mainPanel.HorizontalScroll.Maximum = 0;
            mainPanel.AutoScroll = false;
            mainPanel.VerticalScroll.Visible = false;
            mainPanel.AutoScroll = true;
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            isMonth = true;
            FilterValues(filterType);
        }

        private void AddTopProducts()
        {
            _products = _products.OrderByDescending(o => o.Sales).ToList();
            int counter = _products.Count < 10 ? _products.Count : 10;
            for (int i = 0; i < counter; i++)
            {
                TopProduct t = new TopProduct();
                t.nameLabel.Text = _products[i].Name;
                _stream = new MemoryStream(_products[i].Picture);
                t.productPictureBox.Image = Image.FromStream(_stream);
                t.salesLabel.Text = _products[i].Sales.ToString();
                t.rankLabel.Text = $"{i + 1}";
                topProductsFlowLayoutPanel.Controls.Add(t);
            }
        }

        private void LoadPieSeries()
        {
            var data = _orders.Select(i => new { i.ProductId, i.TotalPrice })
                        .GroupBy(a => a.ProductId, (key, group) => new
                        {
                            total = group.Sum(k => k.TotalPrice),
                            productID = key
                        }).ToList();

            foreach(var o in data)
            {
                string productName = _products.Where(i => i.ProductId == o.productID).Select(d => d.Name).FirstOrDefault();
                PieSeries p = new PieSeries
                {
                    Title = productName,
                    Values = new ChartValues<double> {(double) o.total},
                    DataLabels = true
                };
                pieChart.Series.Add(p);
            }

            pieChart.LegendLocation = LegendLocation.Bottom;
        }

        private void filter_Click(object sender, EventArgs e)
        {
            var panel = (BunifuPanel)sender;
            filterType = panel.Name;
            panel.BorderColor = System.Drawing.Color.FromArgb(249, 58, 39);
            if(panel.Name == "sales")
            {
                var p = (BunifuPanel)Controls.Find("orders", true).First();
                p.BorderColor = System.Drawing.Color.Transparent;
            }
            else
            {
                var p = (BunifuPanel)Controls.Find("sales", true).First();
                p.BorderColor = System.Drawing.Color.Transparent;
            }

            FilterValues(filterType);
        }

        private void FilterValues(string type = "sales")
        {
            ClearData();
            if(type == "sales")
            {
                if(!isMonth)
                {
                    var monthlyData = _orders.Select(i => new { i.DateOrdered, i.TotalPrice })
                        .GroupBy(a => a.DateOrdered.Value.ToString("MMMM"), (key, group) => new
                        {
                            sales = group.Sum(k => k.TotalPrice),
                            month = key
                        }).ToList();

                    foreach (var o in monthlyData)
                    {
                        values.Add((double)o.sales);
                        months.Add(o.month);
                    }

                    SetData();
                }
                else
                {
                    var monthlyData = _orders.Where(i => i.DateOrdered.Value.Month == datePicker.Value.Month)
                        .Select(j => new { j.TotalPrice, j.DateOrdered }).GroupBy(k => k.DateOrdered.Value.ToString("dddd")
                        , (key, group) => new
                        {
                            totalIncome = group.Sum(l => l.TotalPrice),
                            day = key
                        });

                    foreach (var i in monthlyData)
                    {
                        values.Add((double)i.totalIncome);
                        months.Add(i.day);
                    }
                    SetData();
                }
            }
            else
            {
                if (!isMonth)
                {
                    var monthlyData = _orders.Select(i => new { i.DateOrdered, i.TotalPrice })
                        .GroupBy(a => a.DateOrdered.Value.ToString("MMMM"), (key, group) => new
                        {
                            orders = group.Count(),
                            month = key
                        }).ToList();

                    foreach(var i in monthlyData)
                    {
                        values.Add(i.orders);
                        months.Add(i.month);
                    }

                    SetData();
                }
                else
                {
                    var monthlyData = _orders.Select(i => i.DateOrdered)
                        .Where(j => j.Value.Month == datePicker.Value.Month)
                        .GroupBy(a => a.Value.ToString("dddd"), (key, group) => new {
                            orders = group.Count(),
                            date = key
                        }).ToList();
                    
                    foreach (var i in monthlyData)
                    {
                        values.Add(i.orders);
                        months.Add(i.date);
                    }
                    SetData();
                }
            }
        }

        private void ClearData()
        {
            values.Clear();
            months.Clear();
            generalChart.Series.Clear();
            generalChart.AxisX.Clear();
            generalChart.AxisY.Clear();
        }

        private void SetData()
        {
            if (filterType == "sales")
            {
                generalChart.AxisY.Add(new Axis
                {
                    Title = "Income",
                    LabelFormatter = value => value.ToString("C")
                });
            }
            else
            {
                generalChart.AxisY.Add(new Axis
                {
                    Title = "Orders"
                });
            }

            generalChart.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = months
            });

            income.Values = values;

            generalChart.Series.Add(income);
        }
        private void viewDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            isMonth = viewDropDown.Text == "Month";
            FilterValues(filterType);
        }
    }
}
