using GraphQL.Types;
using GraphQLBooks.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.GraphQL.Types
{
    public class AuthorInputType : InputObjectGraphType
    {
        public AuthorInputType()
        {
            Name = "createAuthor";
            Field<IdGraphType>("id");
            Field<NonNullGraphType<StringGraphType>>("firstName");
            Field<NonNullGraphType<StringGraphType>>("lastName");
            Field<ListGraphType<BookInputType>>("books");
        }
    }
}
