using Microsoft.AspNetCore.Mvc;

namespace NhaSachOnline.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
