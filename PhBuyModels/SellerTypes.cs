using System;
using System.Collections.Generic;

namespace PhBuyModels
{
    public partial class SellerTypes
    {
        public decimal? SellerId { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
