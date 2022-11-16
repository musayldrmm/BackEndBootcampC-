using Microsoft.EntityFrameworkCore;
using YemekTarifiApp.Context;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        private readonly BackEndContext _dbContext;

        public CommentRepository(BackEndContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<Comment> GetByIdComment(int id)
        {
            return  _dbContext.Set<Comment>().Include(c => c.User).Include(d => d.Product)
                         .ToList().FirstOrDefault(e => e.Id == id);
        }
    }
}
