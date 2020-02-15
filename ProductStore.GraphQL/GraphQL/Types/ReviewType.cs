using GraphQL.Types;
using ProductStore.Data;

namespace ProductStore.GraphQL.GraphQL.Types
{
    public class ReviewType : ObjectGraphType<Review>
    {
        public ReviewType()
        {
            Field(t => t.Id);
            Field(t => t.Description);
        }
    }
}
