using GraphQL.DataLoader;
using GraphQL.Types;
using GraphQLBooks.API.Entities;
using GraphQLBooks.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.GraphQL.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType(IBookRepository bookRepository, IDataLoaderContextAccessor dataLoaderContextAccessor)
        {
            Field(x => x.Id);
            Field(x => x.FirstName);
            Field(x => x.LastName);
            //Field<List<BookType>>("books",
            //    resolve: context =>
            //    {
            //        var loader = dataLoaderContextAccessor.Context.GetOrAddCollectionBatchLoader<int,Book>(
            //            "GetBooksByAuthorId",bookRepository.GetBooksForSpecyficAuthor())
            //    }/*)*/
        }
    }
}
