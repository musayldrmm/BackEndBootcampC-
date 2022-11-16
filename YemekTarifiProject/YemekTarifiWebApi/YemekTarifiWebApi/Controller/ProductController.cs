using Microsoft.AspNetCore.Mvc;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YemekTarifiWebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _productRepository;
        private readonly IUserRepository _userRepository;
        public ProductController(IProductRepository productRepository,IUserRepository userRepository)
        {
            _productRepository = productRepository;
            _userRepository = userRepository;
        }


        // GET: api/<UserController>
        [HttpGet]
        public List<Product> Get()
        {
            return _productRepository.GetAll(); 
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public Task<Product> Get(int id)
        {
            return _productRepository.GetByIdProduct(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public Task Post([FromBody] Product value)
        {
           return _productRepository.Create(value);
        }

     

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody] Product value)
        {
           return _productRepository.Update(id, value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
           return _productRepository.Delete(id);
        }
    }
}
