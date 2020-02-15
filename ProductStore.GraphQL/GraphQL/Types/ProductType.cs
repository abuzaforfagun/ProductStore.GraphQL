using GraphQL.Types;
using ProductStore.Core;
using ProductStore.Data;

namespace ProductStore.GraphQL.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType(IReviewRepository reviewRepository)
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Price);

            Field<EnumProductType>("type");

            Field<ListGraphType<ReviewType>>(
                "reviews",
                resolve: context => reviewRepository.GetReviewForSingleProduct(context.Source.Id));
        }
    }
}
