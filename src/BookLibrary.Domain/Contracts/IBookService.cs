using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Enums;

namespace BookLibrary.Domain.Contracts
{
    public interface IBookService
    {
        public Task<IReadOnlyList<Book>> GetAsync(SearchType searchType, string searchValue);
    }
}
