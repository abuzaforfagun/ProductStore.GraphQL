using GraphQL.Types;
using ProductStore.Core;
using ProductStore.Data;
using GraphQL.DataLoader;

namespace ProductStore.GraphQL.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType(IReviewRepository reviewRepository, IDataLoaderContextAccessor dataLoader)
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Price);

            Field<EnumProductType>("type");

            Field<ListGraphType<ReviewType>>(
                "reviews",
                resolve: context =>
                {
                    var loader =
                        dataLoader.Context.GetOrAddCollectionBatchLoader<int, Review>(
                            "GetReviewsByProductId", reviewRepository.GetReviewForProducts);
                    return loader.LoadAsync(context.Source.Id);
                });
        }
    }
}
