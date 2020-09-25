using System;
using System.Collections.Generic;
using System.Text;
using METWebShop.Core.Data;

namespace METWebShop.BLL.Interfaces
{
    public interface IOrderManager
    {

        Order PlaceOrder(Order newOrder);
    }
}
