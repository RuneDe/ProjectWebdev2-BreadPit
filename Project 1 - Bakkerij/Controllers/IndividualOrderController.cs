using Microsoft.AspNetCore.Mvc;
using Project_1___Bakkerij.Data;
using Project_1___Bakkerij.Models;
using System.Linq;

namespace Project_1___Bakkerij.Controllers
{
    public class IndividualOrderController : Controller
    {
        private readonly ContosoBreadContext _context;

        public IndividualOrderController(ContosoBreadContext context)
        {
            _context = context;
        }

        public IActionResult IndividualOrders()
        {
            var individualOrders = _context.Orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new IndividualOrderViewModel
                {
                    UserId = g.Key.ToString(), // CustomerId gebruiken als UserId
                    TotalPrice = g.Sum(o => o.TotalPrice)
                }).ToList();

            return View(individualOrders);
        }
    }
}
