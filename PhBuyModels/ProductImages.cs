using System;
using System.Collections.Generic;

namespace PhBuyModels
{
    public partial class ProductImages
    {
        public decimal? ProductId { get; set; }
        public byte[] Picture { get; set; }
        public int ImageiD { get; set; }

        public virtual Products Product { get; set; }
    }
}
