using GraphQL.Types;
using ProductStore.Core;
using ProductStore.Data;
using ProductStore.GraphQL.GraphQL.Types;

namespace ProductStore.GraphQL.GraphQL
{
    public class ProductStoreMutation : ObjectGraphType
    {
        public ProductStoreMutation(IReviewRepository reviewRepository)
        {
            FieldAsync<ReviewType>(
                "addReview",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ReviewInputType>> { Name = "review" }),
                resolve: async context =>
                {
                    var review = context.GetArgument<Review>("review");
                    return await context.TryAsyncResolve(
                        async c => await reviewRepository.Add(review));
                }
            );
        }
    }
}
