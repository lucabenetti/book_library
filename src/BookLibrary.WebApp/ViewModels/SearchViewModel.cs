using BookLibrary.Core.Models.Response;
using BookLibrary.Domain.Enums;
using BookLibrary.WebApp.ViewModels;

namespace BookLibrary.WebApp.Models
{
    public class SearchViewModel
    {
        public SearchType SearchType { get; set; } 
        public string? SearchValue { get; set; }

        public IEnumerable<BookViewModel> Books { get; set; } = new List<BookViewModel>();

        public BookRequestModel ToBookRequestModel()
        {
            return new BookRequestModel() { SearchType = SearchType, SearchValue = SearchValue };
        }
    }
}
