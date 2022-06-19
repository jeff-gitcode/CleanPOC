using Shopping.Application;
using Shopping.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Infrastructure
{
    public class QueryRepository<T>: IQueryRepository<T> where T : class
    {

    }

    public class ProductQueryRepository : QueryRepository<Product>, IProductQueryRepository
    {
        private readonly IMockDB _mockDB;

        public ProductQueryRepository(IMockDB mockDB)
        {
            this._mockDB = mockDB;
        }
        public Task<List<Product>> GetAllAsync()
        {
            return Task.Run(() => _mockDB.GetProducts());
        }
    }
}
