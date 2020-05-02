using GraphQL.Types;
using GraphQLBooks.API.GraphQL.Types;
using GraphQLBooks.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.GraphQL
{
    public class BookQuery : ObjectGraphType
    {
        public BookQuery(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            Field<ListGraphType<BookType>>(
                "books",
                resolve: context => bookRepository.GetAllBooks());
            Field<ListGraphType<AuthorType>>(
                "authors",
                resolve: context => authorRepository.GetAuthors());
        }
    }
}
