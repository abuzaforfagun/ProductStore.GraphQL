using GraphQL.Types;

namespace ProductStore.GraphQL.GraphQL.Types
{
    public class ReviewInputType: InputObjectGraphType
    {
        public ReviewInputType()
        {
            Name = "reviewInput";
            Field<NonNullGraphType<StringGraphType>>("description");
            Field<NonNullGraphType<IdGraphType>>("productId");
        }
    }
}
