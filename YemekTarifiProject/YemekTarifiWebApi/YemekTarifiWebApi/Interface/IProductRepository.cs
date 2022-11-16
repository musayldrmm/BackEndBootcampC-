using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Interface
{
    public interface IProductRepository:IRepository<Product>
    {
        Task<Product>GetByIdProduct(int id);

    }
}
