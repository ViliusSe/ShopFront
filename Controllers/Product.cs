using Microsoft.AspNetCore.Mvc;

namespace ShopFront.Controllers
{
    public class Product : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
