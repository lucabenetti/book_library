using BookLibrary.Domain.Entities;

namespace BookLibrary.Domain.Tests.Services
{
    public class BookServiceTestsFixture
    {
        public static IQueryable<Book> GetBooks()
        {
            return new EnumerableQuery<Book>(new List<Book>()
            {
                GetPrideAndPrejudiceBook(),
                GetTheAlchemistBook()
            });
        }

        public static Book GetPrideAndPrejudiceBook()
        {
            return new Book()
            {
                Id = 1,
                Title = "Pride and Prejudice",
                FirstName = "Jane",
                LastName = "Austen",
                TotalCopies = 100,
                CopiesInUse = 80,
                Type = "Hardcover",
                ISBN = "1234567891",
                Category = "Fiction"
            };
        }

        public static Book GetTheAlchemistBook()
        {
            return new Book()
            {
                Id = 5,
                Title = "The Alchemist",
                FirstName = "Paulo",
                LastName = "Coelho",
                TotalCopies = 50,
                CopiesInUse = 35,
                Type = "Hardcover",
                ISBN = "1234567895",
                Category = "Biography"
            };
        }
    }
}
