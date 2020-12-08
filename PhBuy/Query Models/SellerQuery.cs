using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhBuy.Query_Models
{
    public class SellerQuery
    {
        public SellerQuery()
        {
            ProductName = "";
            StockMin = -1;
            StockMax = -1;
            Type = "";
            Status = "Listed";
        }

        public string ProductName { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
