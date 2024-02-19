using BookLibrary.WebApp.ApiRepositories;
using BookLibrary.WebApp.Models;
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

            return View("Search", model);
        }
    }
}