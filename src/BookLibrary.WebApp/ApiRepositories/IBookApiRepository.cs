using BookLibrary.Core.Models.Response;

namespace BookLibrary.WebApp.ApiRepositories
{
    public interface IBookApiRepository
    {
        Task<IEnumerable<BookResponseModel>> GetBooksAsync(BookRequestModel model);
    }
}
