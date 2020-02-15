using GraphQL.Types;
using ProductStore.Data;

namespace ProductStore.GraphQL.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Price);

        }
    }
}
