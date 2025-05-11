using Library_App_ASP_and_React.Models;
using Library_App_ASP_and_React.Services;
using Microsoft.AspNetCore.Mvc;


namespace Library_App_ASP_and_React.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
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
            return libraryService.GetAllBooks();
        }
    }
}
