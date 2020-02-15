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
        }
    }
}
