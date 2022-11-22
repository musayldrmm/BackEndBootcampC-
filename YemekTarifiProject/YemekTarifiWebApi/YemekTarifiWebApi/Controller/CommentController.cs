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
    public class CommentController : ControllerBase
    {

        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentController(ICommentRepository commentRepository,IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
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
        public Task Post([FromBody] CommentDto value)
        {
            Comment comment = _mapper.Map<Comment>(value);
            return _commentRepository.Create(comment);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody] CommentDto value)
        {
            Comment comment = _mapper.Map<Comment>(value);
            comment.Id = id;
            return _commentRepository.Update(comment);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
           return _commentRepository.Delete(id);
        }
    }
}
