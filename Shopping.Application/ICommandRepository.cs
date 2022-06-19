using Shopping.Domain;

namespace Shopping.Application;

public interface ICommandRepository<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}

public interface IOrderCommandRepository: ICommandRepository<Order>
{

}