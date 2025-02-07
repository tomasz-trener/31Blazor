using BookBlazorServer.Entities;
using BookBlazorServer.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookBlazorServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpPost]
        public async Task<ActionResult<Book>> CreateBook(Book book)
        {
            await bookService.AddBookAsync(book);
            return Ok(book);
        }


        [HttpPut]
        public async Task<ActionResult<Book>> UpdateBook(Book book)
        {
            await bookService.UpdateBook(book);
            return Ok(book);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook([FromRoute] int id)
        {
            var book = await bookService.GetBookById(id);
            return Ok(book);
        }

    }
}
