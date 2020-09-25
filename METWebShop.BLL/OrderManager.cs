using System;
using System.Collections.Generic;
using System.Text;
using METWebShop.BLL.Interfaces;
using METWebShop.Core.Data;
using METWebShop.DAL.Interfaces.Repository;

namespace METWebShop.BLL
{
    public class OrderManager : IOrderManager
    {
        private readonly IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order PlaceOrder(Order newOrder)
        {
            return _orderRepository.PlaceOrder(newOrder);
        }
    }
}
