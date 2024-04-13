using BookLibrary.Service.Filters;
using BookLibrary.Service.Services;
using BookLibrary.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get([FromQuery]BookFilter bookFilter)
        {
            return Ok(_bookService.Get(bookFilter));
        }
    }
}
