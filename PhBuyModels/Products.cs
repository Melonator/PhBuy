using System;
using System.Collections.Generic;

namespace PhBuyModels
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
            ProductImages = new HashSet<ProductImages>();
            ProductRatings = new HashSet<ProductRatings>();
        }

        public decimal ProductId { get; set; }
        public decimal? SellerId { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public byte[] Picture { get; set; }
        public int? Stock { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public string FdaNumber { get; set; }
        public string Type { get; set; }
        public double? Rating { get; set; }
        public int? Sales { get; set; }

        public virtual Seller Seller { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<ProductImages> ProductImages { get; set; }
        public virtual ICollection<ProductRatings> ProductRatings { get; set; }
    }
}
