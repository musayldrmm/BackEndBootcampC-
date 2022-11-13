using Microsoft.AspNetCore.Mvc;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YemekTarifiWebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _categoryRepository.GetAll(); 
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public Task<Category> Get(int id)
        {
            return _categoryRepository.GetById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public Task Post([FromBody] Category value)
        {
            return _categoryRepository.Create(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody] Category value)
        {
           return _categoryRepository.Update(id, value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
           return _categoryRepository.Delete(id);
        }
    }
}
