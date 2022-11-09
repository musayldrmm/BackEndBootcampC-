using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Migrations;
using YemekTarifiApp.Context;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Repository
{
   public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly MyDatabaseContext _dbContext;

       GenericRepository(MyDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbContext.Set<TEntity>()
                          .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Update(int id, TEntity entity)
        {
            _dbContext.Set<TEntity>().AddOrUpdate(entity);
            await _dbContext.SaveChangesAsync();
        }

    }
}
