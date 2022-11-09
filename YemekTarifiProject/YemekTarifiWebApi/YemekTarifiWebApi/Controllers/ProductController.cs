using Microsoft.AspNetCore.Mvc;

namespace YemekTarifiWebApi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
