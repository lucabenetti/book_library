using BookLibrary.Domain.Contracts;
using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Enums;

namespace BookLibrary.Domain.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IReadOnlyList<Book>> GetAsync(SearchType searchType, string searchValue)
        {
            return searchType switch
            {
                SearchType.Author => await _bookRepository.FilterAsync(x => x.FirstName.ToLower().Contains(searchValue.ToLower()) || x.LastName.ToLower().Contains(searchValue.ToLower())),
                SearchType.ISBN => await _bookRepository.FilterAsync(x => x.ISBN.ToLower().Contains(searchValue.ToLower())),
                SearchType.Title => await _bookRepository.FilterAsync(x => x.Title.ToLower().Contains(searchValue.ToLower())),
                SearchType.Category => await _bookRepository.FilterAsync(x => x.Category.ToLower().Contains(searchValue.ToLower())),
                _ => await _bookRepository.FilterAsync(x => true)
            };
        }
    }
}
