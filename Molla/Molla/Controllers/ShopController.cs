using Microsoft.AspNetCore.Mvc;

namespace Molla.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
