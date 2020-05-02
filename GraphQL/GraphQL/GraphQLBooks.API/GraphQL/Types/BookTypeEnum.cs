using GraphQL.Types;
using GraphQLParser.AST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.GraphQL.Types
{
    public class BookTypeEnum : ObjectGraphType<Data.BookType>
    {
        public BookTypeEnum()
        {
            Name = "Type";
            Description = "Type of Book Cover";
        }
    }
}
