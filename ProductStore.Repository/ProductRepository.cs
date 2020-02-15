using ProductStore.Core;
using ProductStore.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductStore.Repository
{
    public class ProductRepository : IProductRepository
    {

        public Task<List<Product>> GetAll()
        {
            var products = new List<Product>
            {
                new Product{Id = 1, Name = "Product 1", Price = 1.1m},
                new Product{Id = 2, Name = "Product 2", Price = 1.2m}
            };

            return Task.FromResult(products);
        }
    }
}
