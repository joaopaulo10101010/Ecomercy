using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
