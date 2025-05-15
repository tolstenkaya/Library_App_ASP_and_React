using Library_App_ASP_and_React.Models;
using Library_App_ASP_and_React.Services;
using Microsoft.AspNetCore.Mvc;


namespace Library_App_ASP_and_React.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly LibraryService libraryService;
        public LibraryController(LibraryService _libraryService)
        {
            libraryService = _libraryService;
        }

        [HttpGet]
        public ActionResult<List<Book>> getBooks()
        {
            return libraryService.GetBooks();
        }

        [HttpPost]
        public ActionResult<List<Book>> addBook([FromBody]Book new_book)
        {
            return libraryService.AddBook(new_book);
        }

        [HttpDelete("/{id}")]
        public ActionResult<List<Book>> deleteBook(int id) {
            return libraryService.DeleteBook(id);
        }
    }
}
