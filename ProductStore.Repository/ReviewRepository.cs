using Microsoft.EntityFrameworkCore;
using ProductStore.Core;
using ProductStore.Data;
using ProductStore.Data.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStore.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ProductStoreDbContext context;

        public ReviewRepository(ProductStoreDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Review>> GetReviewForSingleProduct(int id)
        {
            return await context.ProductReviews.Where(p => p.Product.Id == id).ToListAsync();
        }
    }
}
