using YemekTarifiApp.Context;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(BackEndContext dbContext) : base(dbContext)
        {
        }
    }
}
