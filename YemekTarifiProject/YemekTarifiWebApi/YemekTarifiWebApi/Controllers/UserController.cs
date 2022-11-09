using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Get i�lemi yapt�n";
        }
        [HttpPost]
        public User Post(User user)
        {
            return "Post i�lemi yapt�n";
        }

        [HttpPut]
        public string Put()
        {
            return "Put i�lemi yapt�n";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Delete i�lemi yapt�n";
        }
    }

}