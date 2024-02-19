using BookLibrary.Domain.Entities;

namespace BookLibrary.Core.Models.Response
{
    public class BookResponseModel
    {
        public BookResponseModel()
        {
            
        }

        public BookResponseModel(Book book)
        {
            Title = book.Title;
            Author = string.Concat(book.FirstName, " ", book.LastName);
            TotalCopies = book.TotalCopies;
            CopiesInUse = book.CopiesInUse;
            Type = book.Type;
            ISBN = book.ISBN;
            Category = book.Category;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int TotalCopies { get; set; }
        public int CopiesInUse { get; set; }
        public string Type { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
    }
}
