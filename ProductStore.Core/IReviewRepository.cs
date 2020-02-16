using ProductStore.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductStore.Core
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetReviewForSingleProduct(int id);
        Task<ILookup<int, Review>> GetReviewForProducts(IEnumerable<int> productId, CancellationToken arg2);
        Task<Review> Add(Review review);
    }
}
