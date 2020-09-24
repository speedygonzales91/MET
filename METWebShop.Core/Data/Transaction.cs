using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace METWebShop.Core.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string InfoToDelivery { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
