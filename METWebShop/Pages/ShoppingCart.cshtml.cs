using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using METWebShop.BLL.Interfaces;
using METWebShop.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace METWebShop.Pages
{
    public class ShoppingCartModel : PageModel
    {
        private readonly IProductManager _productManager;
        public List<Product> Products { get; set; }

        public ShoppingCartModel(IProductManager productManager)
        {
            _productManager = productManager;

        }


        public void OnGet()
        {
            var products = _productManager.GetProductsByCategory(ProductCategoryType.WarmUpPack);

            Products = new List<Product>();
            Products.Add(products[0]);
            Products.Add(products[1]);
        }
    }
}
