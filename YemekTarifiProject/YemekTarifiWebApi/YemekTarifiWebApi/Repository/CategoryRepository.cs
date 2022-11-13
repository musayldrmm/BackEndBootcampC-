using YemekTarifiApp.Context;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BackEndContext dbContext) : base(dbContext)
        {
        }
    }
}
