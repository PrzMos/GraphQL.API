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
                        FirstName = "Andrzej",
                        LastName = "Sapkowski",
                        Books = new List<Book>()
                        {
                            new Book()
                            {
                                Title ="Witcher 1",
                                Description ="About man who slaughter everything on his way...",
                                BookType = BookType.Soft,
                                Quantity = 15,
                                PublishDate = DateTimeOffset.Parse("1997-02-15")
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

                bookDbContext.Authors.Add(
                    new Entities.Author()
                    {
                        FirstName = "Robin",
                        LastName = "Hoob",
                        Books = new List<Book>()
                        {
                            new Book()
                            {
                                Title ="Królewski skrytobójca",
                                Description ="Skrytobójca",
                                BookType = BookType.Soft,
                                Quantity = 8,
                                PublishDate = DateTimeOffset.Parse("2003-12-10")
                            },
                            new Book()
                            {
                                Title ="Uczeń skrytobójcy",
                                Description ="Uczeń",
                                BookType = BookType.Hard,
                                Quantity = 11,
                                PublishDate = DateTimeOffset.Parse("2001-07-07")
                            }
                        }
                    });

                bookDbContext.Authors.Add(
                    new Entities.Author()
                    {
                        FirstName = "Jack",
                        LastName = "Whyte",
                        Books = new List<Book>()
                        {
                            new Book()
                            {
                                Title ="Honor Rycerza",
                                Description ="About knight who slaughter everything on his way...",
                                BookType = BookType.Hard,
                                Quantity = 10,
                                PublishDate = DateTimeOffset.Parse("2008-11-04")
                            },
                            new Book()
                            {
                                Title ="Chaos w zakonie",
                                Description ="About man who gets all girls on his way...",
                                BookType = BookType.Hard,
                                Quantity = 5,
                                PublishDate = DateTimeOffset.Parse("2012-11-06")
                            }
                        }
                    });
                bookDbContext.SaveChanges();
            }
        }
    }
}
