using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YemekTarifiWebApi.Dto;
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
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
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
        public Task Post([FromBody] ProductDto value)
        {
            var product = _mapper.Map<Product>(value);
            return _productRepository.Create(product);
        }

     

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody] ProductDto value)
        {
            Product product = _mapper.Map<Product>(value);
            product.Id = id;
            return _productRepository.Update(product);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
           return _productRepository.Delete(id);
        }
    }
}
