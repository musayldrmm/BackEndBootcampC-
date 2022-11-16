using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Interface
{
    public interface ICommentRepository:IRepository<Comment>
    {
        Task<Comment> GetByIdComment(int id);

    }
}
