using GraphQL.Types;

namespace ProductStore.GraphQL.GraphQL.Types
{
    public class EnumProductType : EnumerationGraphType<Data.ProductType>
    {
        public EnumProductType()
        {
            Name = "Type";
            Description = "The type of product";
        }
    }
}
