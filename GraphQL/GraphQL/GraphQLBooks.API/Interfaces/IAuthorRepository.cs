using GraphQLBooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.Interfaces
{
    public interface IAuthorRepository
    {
        Author GetAuthor(int id);
        List<Author> GetAuthors();
    }
}
