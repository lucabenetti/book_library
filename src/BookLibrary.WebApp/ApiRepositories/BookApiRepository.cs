using BookLibrary.Core.Models.Response;

namespace BookLibrary.WebApp.ApiRepositories
{
    public class BookApiRepository : IBookApiRepository
    {
        public async Task<IEnumerable<BookResponseModel>> GetBooksAsync(BookRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
