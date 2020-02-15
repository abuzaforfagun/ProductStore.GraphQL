using ProductStore.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductStore.Core
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetReviewForSingleProduct(int id);
    }
}
