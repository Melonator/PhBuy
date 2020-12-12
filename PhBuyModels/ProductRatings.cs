using System;
using System.Collections.Generic;

namespace PhBuyModels
{
    public partial class ProductRatings
    {
        public int Id { get; set; }
        public decimal? ProductId { get; set; }
        public int? Rating { get; set; }

        public virtual Products Product { get; set; }
    }
}
