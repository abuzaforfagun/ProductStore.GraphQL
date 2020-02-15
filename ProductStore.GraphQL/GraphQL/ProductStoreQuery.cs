using GraphQL.Types;
using ProductStore.Core;
using ProductStore.GraphQL.GraphQL.Types;

namespace ProductStore.GraphQL.GraphQL
{
    public class ProductStoreQuery : ObjectGraphType
    {

        public ProductStoreQuery(IProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => productRepository.GetAll()
            ) ;

            Field<ProductType>(
                "product",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return productRepository.Get(id);
                }
            );
        }
    }
}
