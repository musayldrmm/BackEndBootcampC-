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
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository,IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper=mapper;
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
        public Task Post([FromBody] CategoryDto value)
        {
            Category category = _mapper.Map<Category>(value);
            return _categoryRepository.Create(category);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody] CategoryDto value)
        {
            Category category = _mapper.Map<Category>(value);
            category.Id = id;
            return _categoryRepository.Update(category);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
           return _categoryRepository.Delete(id);
        }
    }
}
