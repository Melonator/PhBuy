using System;
using System.Collections.Generic;

namespace PhBuyModels
{
    public partial class Seller
    {
        public Seller()
        {
            Orders = new List<Orders>();
            Products = new List<Products>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public int? Contact { get; set; }
        public byte[] Picture { get; set; }
        public byte[] Background { get; set; }
        public string Fblink { get; set; }
        public string Descrption { get; set; }
        public string Location { get; set; }

        public virtual List<Orders> Orders { get; set; }
        public virtual List<Products> Products { get; set; }
    }
}
