using BookLibrary.WebApp.ApiRepositories;
using BookLibrary.WebApp.Models;
using BookLibrary.WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookApiRepository _bookApiRepository;

        public HomeController(IBookApiRepository bookApiRepository)
        {
            _bookApiRepository = bookApiRepository;
        }

        public IActionResult Index()
        {
            return View("Search");
        }

        [HttpPost]
        public async Task<IActionResult> SearchPost(SearchViewModel model)
        {
            var result = await _bookApiRepository.GetBooksAsync(model.ToBookRequestModel());

            var viewModel = new SearchViewModel()
            {
                Books = result?.Select(x => new BookViewModel(x)),
                SearchType = model.SearchType,
                SearchValue = model.SearchValue
            };

            return View("Search", viewModel);
        }
    }
}