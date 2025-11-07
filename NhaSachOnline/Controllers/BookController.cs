using Microsoft.AspNetCore.Mvc;

namespace NhaSachOnline.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
