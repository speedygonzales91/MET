using System;
using System.Collections.Generic;
using System.Text;
using METWebShop.Core.Data;

namespace METWebShop.BLL.Interfaces
{
    public interface IProductManager
    {
        List<Product> GetProductsByCategory(ProductCategoryType category);
    }
}
