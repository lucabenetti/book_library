using BookLibrary.Core.Models.Response;

namespace BookLibrary.WebApp.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(BookResponseModel model)
        {
            Title = model.Title;
            Author = model.Author;
            TotalCopies = model.TotalCopies;
            CopiesInUse = model.CopiesInUse;
            Type = model.Type;
            ISBN = model.ISBN;
            Category = model.Category;
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
