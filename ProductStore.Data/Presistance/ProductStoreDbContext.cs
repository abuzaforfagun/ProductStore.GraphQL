using Microsoft.EntityFrameworkCore;

namespace ProductStore.Data.Presistance
{
    public class ProductStoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> ProductReviews { get; set; }
        public ProductStoreDbContext(DbContextOptions<ProductStoreDbContext> options) : base(options)
        {
        }
    }
}
