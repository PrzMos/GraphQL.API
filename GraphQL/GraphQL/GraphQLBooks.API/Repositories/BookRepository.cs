using GraphQLBooks.API.Data;
using GraphQLBooks.API.Entities;
using GraphQLBooks.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _context;

        public BookRepository(BookDbContext context)
        {
            _context = context;
        }

        public async Task AddBook(Book book)
        {
            if (book == null)
            {

            }
            else
            {
                _context.Books.Add(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                _context.Books.Add(book);
            }

            await _context.SaveChangesAsync();
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBook(int id)
        {
            if (id == 0)
            {
                return null;
            }

            var book = _context.Books.Where(x => x.Id == id).FirstOrDefault();

            if (book != null)
            {
                return book;
            }

            return null;

        }

        public Book GetBookForSpecyficAuthor(int bookId, int authorId)
        {
            if (bookId == 0 || authorId == 0)
            {
                return null;
            }

            var bookForAuthor = _context.Books.Where(x => x.Id == bookId && x.AuthorId == authorId).FirstOrDefault();

            if (bookForAuthor != null)
            {
                return bookForAuthor;
            }

            return null;
        }

        public List<Book> GetBooksByYear(int year)
        {
            return _context.Books.Where(x => x.PublishDate.Year == year).ToList();
        }

        public List<Book> GetBooksForSpecyficAuthor(int authorId)
        {
            if (authorId == 0)
            {
                return null;
            }

            return _context.Books.Where(x => x.AuthorId == authorId).ToList();
        }
    }
}
