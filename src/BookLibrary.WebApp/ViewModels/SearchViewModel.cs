using BookLibrary.Core.Models.Response;
using BookLibrary.Domain.Enums;

namespace BookLibrary.WebApp.Models
{
    public class SearchViewModel
    {
        public SearchType SearchType { get; set; } 
        public string? SearchValue { get; set; }

        public BookRequestModel ToBookRequestModel()
        {
            return new BookRequestModel() { SearchType = SearchType, SearchValue = SearchValue };
        }
    }
}
