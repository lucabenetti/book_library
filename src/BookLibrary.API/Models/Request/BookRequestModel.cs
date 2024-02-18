using BookLibrary.Domain.Enums;

namespace BookLibrary.API.Models.Request
{
    public class BookRequestModel
    {
        public SearchType SearchType { get; set; }
        public string SearchValue { get; set; }
    }
}
