using Microsoft.AspNetCore.Mvc;
using Project_1___Bakkerij.Data;
using Project_1___Bakkerij.Models;

namespace Project_1___Bakkerij.Controllers
{
    public class OrderController : Controller
    {
        private readonly ContosoBreadContext _context;

        public OrderController(ContosoBreadContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult PlaceOrder()
        {
            // Toon formulier om bestelling te plaatsen
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(OrderModel order)
        {
            // Verwerk de ontvangen bestelling en sla deze op in de database
            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToAction("OrderSummary");
        }
    }

}
