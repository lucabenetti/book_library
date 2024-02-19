using BookLibrary.Domain.Contracts;
using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Enums;
using BookLibrary.Domain.Services;
using Moq;
using System.Linq.Expressions;
using Xunit;

namespace BookLibrary.Domain.Tests.Services
{
    public class BookServiceTests
    {
        private readonly BookService _bookService;
        private readonly Mock<IBookRepository> _bookRepository;

        public BookServiceTests()
        {
            _bookRepository = new Mock<IBookRepository>();
            _bookService = new BookService(_bookRepository.Object);

            _bookRepository.Setup(x => x.FilterAsync(It.IsAny<Expression<Func<Book, bool>>>()))
                .Returns<Expression<Func<Book, bool>>>(predicate => Task.FromResult((IReadOnlyList<Book>)BookServiceTestsFixture.GetBooks().Where(predicate).ToList()));
        }

        [Fact]
        public async Task BookService_FilterByAuthor()
        {
            var books = await _bookService.GetAsync(SearchType.Author, "coel");
            
            Assert.True(books.All(x => x.Id == BookServiceTestsFixture.GetTheAlchemistBook().Id));
        }
    }
}
