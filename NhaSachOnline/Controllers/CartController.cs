using Microsoft.AspNetCore.Mvc;

namespace NhaSachOnline.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
