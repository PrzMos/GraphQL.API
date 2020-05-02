using GraphQL.Types;
using GraphQLBooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.GraphQL.Types
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Field(x => x.Id);
            Field(x => x.Title).Description("Title of book");
            Field(x => x.Description);
            Field(x => x.PublishDate).Description("When the book was published");
            Field(x => x.Quantity).Description("Quantity of books in storage");
            Field<BookTypeEnum>("Type", "Type of Book Cover");
        }
    }
}
