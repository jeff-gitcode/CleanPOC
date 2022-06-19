using Shopping.Domain;

namespace Shopping.Application;

public interface IQueryRepository<T> where T : class
{

}

public interface IProductQueryRepository : IQueryRepository<Product>
{
    Task<List<Product>> GetAllAsync();
}