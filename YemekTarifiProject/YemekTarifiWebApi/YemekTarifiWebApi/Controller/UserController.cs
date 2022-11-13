using Microsoft.AspNetCore.Mvc;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;


namespace YemekTarifiWebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userRepository.GetAll(); 
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public Task<User> Get(int id)
        {
            return _userRepository.GetById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public Task Post([FromBody] User value)
        {
            return _userRepository.Create(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody] User value)
        {
           return _userRepository.Update(id, value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
           return _userRepository.Delete(id);
        }
    }
}
