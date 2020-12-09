using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhBuy.Query_Models
{
    public class ProductQuery
    {
        public ProductQuery()
        {
            PriceMin = -1;
            PriceMax = -1;
            RatingMin = 1;
        }
        public double PriceMin { get; set; }
        public double PriceMax { get; set; }
        public double RatingMin { get; set; }
    }
}
