using Microsoft.AspNetCore.Mvc;

namespace NhaSachOnline.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
