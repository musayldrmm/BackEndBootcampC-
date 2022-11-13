using YemekTarifiApp.Context;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Repository
{
    public class UserRepository : GenericRepository<User>,IUserRepository
    {
        public UserRepository(BackEndContext dbContext) : base(dbContext)
        {
        }
    }
}
