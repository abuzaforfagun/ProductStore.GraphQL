using Microsoft.EntityFrameworkCore;
using ProductStore.Core;
using ProductStore.Data;
using ProductStore.Data.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        public async Task<Review> Add(Review review)
        {
            context.ProductReviews.Add(review);
            await context.SaveChangesAsync();
            return review;
        }

        public  async Task<ILookup<int, Review>> GetReviewForProducts(IEnumerable<int> productsId, CancellationToken arg2)
        {
            var reviews = await context.ProductReviews.Where(r => productsId.Contains(r.ProductId)).ToListAsync();

            return reviews.ToLookup(r => r.ProductId);
        }

        public async Task<List<Review>> GetReviewForSingleProduct(int id)
        {
            return await context.ProductReviews.Where(p => p.Product.Id == id).ToListAsync();
        }
    }
}
