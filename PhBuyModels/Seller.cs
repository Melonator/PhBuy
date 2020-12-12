using System;
using System.Collections.Generic;

namespace PhBuyModels
{
    public partial class Seller
    {
        public Seller()
        {
            Orders = new HashSet<Orders>();
            Products = new HashSet<Products>();
            SellerTypes = new HashSet<SellerTypes>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public byte[] Picture { get; set; }
        public byte[] Background { get; set; }
        public string Fblink { get; set; }
        public string Descrption { get; set; }
        public string Location { get; set; }
        public double? Rating { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<SellerTypes> SellerTypes { get; set; }
    }
}
