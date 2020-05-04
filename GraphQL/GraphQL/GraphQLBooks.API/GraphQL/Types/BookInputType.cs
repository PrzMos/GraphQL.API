using GraphQL.Types;

namespace GraphQLBooks.API.GraphQL.Types
{
    public class BookInputType : InputObjectGraphType
    {
        public BookInputType()
        {
            Name = "bookInput";
            Field<IdGraphType>("id");
            Field<NonNullGraphType<StringGraphType>>("title");
            Field<StringGraphType>("description");
            Field<DateTimeGraphType>("dateTime");
            Field<IntGraphType>("quantity");
            Field<NonNullGraphType<IntGraphType>>("authorId");
        }
    }
}
