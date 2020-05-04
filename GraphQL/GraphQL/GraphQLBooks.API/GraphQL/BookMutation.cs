using GraphQL.Types;
using GraphQLBooks.API.Entities;
using GraphQLBooks.API.GraphQL.Types;
using GraphQLBooks.API.Interfaces;
using GraphQLBooks.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.GraphQL
{
    public class BookMutation : ObjectGraphType
    {
        public BookMutation(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            FieldAsync<BookType>("createBook",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<BookInputType>> { Name = "book" }),
                resolve: async context =>
                {
                    var book = context.GetArgument<Book>("book");
                    await bookRepository.AddBook(book);
                    return book;
                });

            FieldAsync<AuthorType>("createAuthor",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<AuthorInputType>> { Name = "author", Description = "Create single author." }),
                resolve: async context =>
                {
                    var author = context.GetArgument<Author>("author");

                    await authorRepository.CreateAuthor(author);
                    return author;
                });

            //FieldAsync<AuthorType>("craeteAuthorWithBooks",
            //    arguments: new QueryArguments(new QueryArgument<NonNullGraphType<AuthorWithBooksInputType>> { Name = "author", Description = "Create a single author with or without books." }),
            //    resolve: async context =>
            //    {
            //        var author = context.GetArgument<Author>("author");
            //        await authorRepository.CreateAuthor(author);
            //        return author;
            //    });
        }
    }
}
