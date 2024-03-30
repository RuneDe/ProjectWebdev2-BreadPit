using Microsoft.AspNetCore.Mvc;
using Project_1___Bakkerij.Data;
using Project_1___Bakkerij.Models;
using System.Linq;

namespace Project_1___Bakkerij.Controllers
{
    public class SummaryController : Controller
    {
        private readonly ContosoBreadContext _context;

        public SummaryController(ContosoBreadContext context)
        {
            _context = context;
        }

        public IActionResult OrderSummary()
        {
            var orderSummary = _context.Orders
                .SelectMany(o => o.OrderItems) // We selecteren alle order items van alle orders
                .GroupBy(oi => oi.ProductId) // Groeperen op ProductId
                .Select(g => new OrderSummaryViewModel
                {
                    ProductName = _context.Products.FirstOrDefault(p => p.Id == g.Key).ProductName,
                    Quantity = g.Sum(oi => oi.Quantity),
                    TotalPrice = g.Sum(oi => oi.Quantity * (_context.Products.FirstOrDefault(p => p.Id == g.Key) != null ? _context.Products.FirstOrDefault(p => p.Id == g.Key).Price : 0)) // Voorwaardelijke nullcontrole
                }).ToList();

            return View(orderSummary);
        }
    }
}
