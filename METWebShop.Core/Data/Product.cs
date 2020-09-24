using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace METWebShop.Core.Data
{
    public class Product
    {
        public int Id  { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        public ProductCategoryType ProductType { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }


        public ICollection<ShoppingCart> ShoppingCart { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
