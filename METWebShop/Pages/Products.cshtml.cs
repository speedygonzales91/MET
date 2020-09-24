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
    public class ProductModel : PageModel
    {
        private readonly IProductManager _productManager;

        public List<Product> ProductList = new List<Product>();

        public ProductModel(IProductManager productManager)
        {
            _productManager = productManager;
        }
        public void OnGet(int productCatType)
        {
            ProductCategoryType category;

            switch (productCatType)
            {
                case 1:
                    category = ProductCategoryType.WarmUpPack;
                    break;
                case 2:
                    category = ProductCategoryType.SportPack;
                    break;
                case 3:
                    category = ProductCategoryType.SpartaPack;
                    break;
                default:
                    category = ProductCategoryType.WarmUpPack;
                    break;
            }

            ProductList = _productManager.GetProductsByCategory(category);
        }
    }
}
