using Microsoft.AspNetCore.Mvc;
using BooksApi.Models;

namespace BooksApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>();

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(books);
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            book.Id = books.Count + 1;

            books.Add(book);

            return Ok(book);
        }
    }
}

