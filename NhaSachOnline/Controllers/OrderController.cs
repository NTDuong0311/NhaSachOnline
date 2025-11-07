using Microsoft.AspNetCore.Mvc;

namespace NhaSachOnline.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
