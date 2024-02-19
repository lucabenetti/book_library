using BookLibrary.Domain.Enums;

namespace BookLibrary.Core.Models.Response
{
    public class BookRequestModel
    {
        public SearchType SearchType { get; set; }
        public string? SearchValue { get; set; }
    }
}
