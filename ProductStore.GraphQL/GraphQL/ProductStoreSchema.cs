using GraphQL;
using GraphQL.Types;

namespace ProductStore.GraphQL.GraphQL
{
    public class ProductStoreSchema : Schema
    {
        public ProductStoreSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ProductStoreQuery>();
            Mutation = resolver.Resolve<ProductStoreMutation>();
        }
    }
}
