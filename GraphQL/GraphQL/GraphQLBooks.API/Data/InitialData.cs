using GraphQLBooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBooks.API.Data
{
    public static class InitialData
    {
        public static void Seed(this BookDbContext bookDbContext)
        {
            if (!bookDbContext.Authors.Any())
            {
                bookDbContext.Authors.Add(
                    new Entities.Author()
                    {
                        FirtName = "Andrzej",
                        LastName = "Sapkowski",
                        Books = new List<Book>()
                        {
                            new Book()
                            {
                                Title ="Witcher 1",
                                Description ="About man who slaughter everything on his way...",
                                BookType = BookType.Soft,
                                Quantity = 15,
                                PublishDate = DateTimeOffset.Parse("1997-15-02")
                            },
                            new Book()
                            {
                                Title ="Witcher 2",
                                Description ="About man who gets all girls on his way...",
                                BookType = BookType.Hard,
                                Quantity = 20,
                                PublishDate = DateTimeOffset.Parse("2000-10-06")
                            }
                        }
                    });
                
                // add two more authors before seeding the database
            }
        }
    }
}
