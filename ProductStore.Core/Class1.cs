using ProductStore.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductStore.Core
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
    }
}
