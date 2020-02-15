using Microsoft.EntityFrameworkCore;
using ProductStore.Core;
using ProductStore.Data;
using ProductStore.Data.Presistance;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductStore.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductStoreDbContext context;

        public ProductRepository(ProductStoreDbContext context)
        {
            this.context = context;
        }
        public Task<List<Product>> GetAll()
        {
            return context.Products.ToListAsync();
        }
    }
}
