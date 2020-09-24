using System;
using System.Collections.Generic;
using System.Text;

namespace METWebShop.Core.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string UserId { get; set; }

        public ICollection<Transaction> Transaction { get; set; }
    }
}
