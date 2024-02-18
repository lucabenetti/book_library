using BookLibrary.API.Models.Request;
using BookLibrary.API.Models.Response;
using BookLibrary.Core;
using BookLibrary.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.API.Controllers
{
    [ApiController]
    [Route("books")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(BookRequestModel model)
        {
            var result = await _bookService.GetAsync(model.SearchType, model.SearchValue);

            var response = result?.Select(x => new BookResponseModel(x));

            return Ok(Result<IEnumerable<BookResponseModel>>.Success(response));
        }
    }
}
