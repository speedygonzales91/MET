﻿using System;
using System.Collections.Generic;
using System.Text;
using METWebShop.Core.Data;

namespace METWebShop.BLL.Interfaces
{
    public interface IOrderProductManager
    {
        public Product GetProductToOrder(int id);

        void OrderProductWithAmount(int productId, Order order, int amount);

    }
}
