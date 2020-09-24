using System;
using System.Collections.Generic;
using System.Text;

namespace METWebShop.Core.Data
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
    }
}
