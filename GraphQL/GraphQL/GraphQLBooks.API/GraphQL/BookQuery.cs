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
            Field<AuthorType>("author",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> {Name="id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return authorRepository.GetAuthor(id);
                });
            Field<ListGraphType<BookType>>("booksInYear",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "year" }),
                resolve: context =>
                {
                    var year = context.GetArgument<int>("year");
                    return bookRepository.GetBooksByYear(year);
                });
        }
    }
}
