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
        private int _id = 65376;

        private LineSeries sales = new LineSeries();
        public DataAnalytics()
        {
            InitializeComponent();
        }

        private void DataAnalytics_Load(object sender, EventArgs e)
        {
            _products = _data.Products.Where(i => i.SellerId == _id).ToList();
            _orders = _data.Orders.Where(i => i.SellerId == _id).ToList();

            ChartValues<double> values = new ChartValues<double>();
            List<string> months = new List<string>();

            var something = _orders.Select(i => new { i.DateOrdered, i.TotalPrice })
                .GroupBy(a => a.DateOrdered.Value.ToString("MMMM"), (key, group) => new
                {
                    sales = group.Sum(k => k.TotalPrice),
                    month = key
                }).ToList();

            foreach(var o in something)
            {
                values.Add((double)o.sales);
                months.Add(o.month);
            }

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

            sales.Values = values;

            generalChart.Series.Add(sales);

     

        }
    }
}
