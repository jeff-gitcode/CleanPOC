using Shopping.Application;

namespace Shopping.Infrastructure;

public class CommandRepository<T> : ICommandRepository<T> where T : class
{
    protected readonly MockDB _db;

    public Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}