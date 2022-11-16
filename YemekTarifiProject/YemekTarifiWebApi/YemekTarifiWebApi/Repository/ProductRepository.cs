using Microsoft.EntityFrameworkCore;
using YemekTarifiApp.Context;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly BackEndContext _dbContext;

        public ProductRepository(BackEndContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> GetByIdProduct(int id)
        {
            return await _dbContext.Set<Product>().Include(c=>c.User).Include(d=>d.Category)
                         .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
