using Bunifu.UI.WinForms;
using LiveCharts;
using LiveCharts.Wpf;
using PhBuyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        ChartValues<double> values = new ChartValues<double>();
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
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            isMonth = true;
            FilterValues(filterType);
        }

        private void filter_Click(object sender, EventArgs e)
        {
            var panel = (BunifuPanel)sender;
            filterType = panel.Name;
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
                    var monthlyData = _orders.Where(i => i.DateOrdered.Value.Month == datePicker.Value.Month).ToList();

                    foreach (var i in monthlyData)
                    {
                        values.Add((double)i.TotalPrice);
                        months.Add(i.DateOrdered.Value.ToString("MMMM"));
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
            generalChart.AxisY.Add(new Axis
            {
                Title = "Income",
                LabelFormatter = value => value.ToString("C")
            });

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
