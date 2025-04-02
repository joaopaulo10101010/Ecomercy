using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
