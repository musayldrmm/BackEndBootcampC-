using Microsoft.AspNetCore.Mvc;

namespace YemekTarifiWebApi.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
