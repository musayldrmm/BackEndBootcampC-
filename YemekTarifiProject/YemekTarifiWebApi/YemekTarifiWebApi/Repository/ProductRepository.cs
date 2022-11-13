using YemekTarifiApp.Context;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(BackEndContext dbContext) : base(dbContext)
        {
        }
    }
}
