using System;
using System.Collections.Generic;

namespace PhBuyModels
{
    public partial class Orders
    {
        public decimal Id { get; set; }
        public decimal? ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public double? TotalPrice { get; set; }
        public string Status { get; set; }
        public decimal? SellerId { get; set; }
        public decimal? CustomerId { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime? DateOrdered { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Products Product { get; set; }
        public virtual Seller Seller { get; set; }
    }
}
