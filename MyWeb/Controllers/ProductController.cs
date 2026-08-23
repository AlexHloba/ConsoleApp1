using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }


        public ActionResult Product()
        {
            List<string> products = new List<string> { "сосиски", "молоко"  };
            return View(products);
        }
    }
}
