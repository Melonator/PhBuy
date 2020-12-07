using System;
using System.Collections.Generic;

namespace PhBuyModels
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public int? Contact { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
