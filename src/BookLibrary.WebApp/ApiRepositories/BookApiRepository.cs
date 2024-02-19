using BookLibrary.Core.Models.Response;
using Newtonsoft.Json;

namespace BookLibrary.WebApp.ApiRepositories
{
    public class BookApiRepository : IBookApiRepository
    {
        private readonly HttpClient _httpClient;

        public BookApiRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(Environment.GetEnvironmentVariable("API_URL"));
        }

        public async Task<IEnumerable<BookResponseModel>> GetBooksAsync(BookRequestModel model)
        {
            var url = $"/books?searchType={model.SearchType}&searchValue={model.SearchValue}";
            var response = await _httpClient.GetAsync(url);

            var responseContent = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<IEnumerable<BookResponseModel>>(responseContent);

            return result;
        }
    }
}
