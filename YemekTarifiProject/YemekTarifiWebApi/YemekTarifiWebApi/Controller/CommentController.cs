using Microsoft.AspNetCore.Mvc;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YemekTarifiWebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {

        private readonly ICommentRepository _commentRepository;

        public CommentController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }


        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return _commentRepository.GetAll(); 
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public Task<Comment> Get(int id)
        {
            return _commentRepository.GetByIdComment(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public Task Post([FromBody] Comment value)
        {
            return _commentRepository.Create(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody] Comment value)
        {
           return _commentRepository.Update(id, value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
           return _commentRepository.Delete(id);
        }
    }
}
