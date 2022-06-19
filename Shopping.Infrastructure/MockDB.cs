using Shopping.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Infrastructure
{
    public class MockDB: IMockDB
    {
        private readonly Product[] _products = new Product[]
        {
            new Product {
                        ID = 1,
                        Title = "Casaco maneiro",
                        Price = 290.9
                },
            new Product
                {
                    ID = 2,
                    Title = "Óculos barato",
                    Price = 20.9
                },
            new Product
                {
                    ID = 3,
                    Title = "Tênis da moda",
                    Price = 500.1
                }

        };

        public List<Product> GetProducts()
        {
            return this._products.ToList();
        }
    }

    public interface IMockDB
    {
        List<Product> GetProducts();
    }
}
