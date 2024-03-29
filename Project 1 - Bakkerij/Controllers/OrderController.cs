using Microsoft.AspNetCore.Mvc;

namespace Project_1___Bakkerij.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View("PlaceOrder");
        }
    }
}
