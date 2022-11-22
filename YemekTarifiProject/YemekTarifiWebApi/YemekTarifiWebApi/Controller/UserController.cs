using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using YemekTarifiWebApi.Dto;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;


namespace YemekTarifiWebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
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
        public Task Post([FromBody] UserDto value)
        {
            var user = _mapper.Map<User>(value);
            return _userRepository.Create(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody] UserDto value)
        {
            User user = _mapper.Map<User>(value);
            user.Id = id;
            return _userRepository.Update(user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            return _userRepository.Delete(id);
        }
    }
}
