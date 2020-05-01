using GraphQLBooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBook(int id);
        List<Book> GetBooksForSpecyficAuthor(int authorId);
        Book GetBookForSpecyficAuthor(int bookId,int authorId);
    }
}
