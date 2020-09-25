using System;
using System.Collections.Generic;
using System.Text;
using METWebShop.Core.Data;

namespace METWebShop.DAL.Interfaces.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts(ProductCategoryType category);
    }
}
