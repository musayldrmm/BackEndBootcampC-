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
            return "Get iþlemi yaptýn";
        }
        [HttpPost]
        public User Post(User user)
        {
            return "Post iþlemi yaptýn";
        }

        [HttpPut]
        public string Put()
        {
            return "Put iþlemi yaptýn";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Delete iþlemi yaptýn";
        }
    }

}