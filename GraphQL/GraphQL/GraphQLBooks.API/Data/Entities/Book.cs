using GraphQLBooks.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.Entities
{
    // add data annotation
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string  Description { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public BookType BookType { get; set; }
        public int Quantity { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
