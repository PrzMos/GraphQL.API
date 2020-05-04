using GraphQLBooks.API.Data;
using GraphQLBooks.API.Entities;
using GraphQLBooks.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookDbContext _context;

        public AuthorRepository(BookDbContext context)
        {
            _context = context;
        }

        public async Task CreateAuthor(Author author)
        {
            _context.Authors.Add(author);

            await _context.SaveChangesAsync();
        }

        public Author GetAuthor(int id)
        {
            if (id == 0)
            {
                return null;
            }

            return _context.Authors.Find(id);
        }

        public List<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }
    }
}
