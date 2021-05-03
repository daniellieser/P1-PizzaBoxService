using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBoxData
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Order>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
