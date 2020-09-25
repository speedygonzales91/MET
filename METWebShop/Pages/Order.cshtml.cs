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
    public class OrderModel : PageModel
    {
        private readonly IOrderProductManager _manager;

        public OrderModel(IOrderProductManager manager)
        {
            _manager = manager;
        }

        [BindProperty]
        public Order Order { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Order.UserId = this.User.Identity.Name;
            _manager.OrderProductWithAmount(1, Order, 10);
        }

    }
}
