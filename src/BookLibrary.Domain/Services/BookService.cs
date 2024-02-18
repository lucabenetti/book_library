using BookLibrary.Domain.Contracts;
using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Enums;

namespace BookLibrary.Domain.Services
{
    public class BookService : IBookService
    {
        public Task<IReadOnlyList<Book>> GetAsync(SearchType searchType, string searchValue)
        {
            throw new NotImplementedException();
        }
    }
}
