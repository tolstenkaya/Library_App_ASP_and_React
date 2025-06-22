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

        [HttpPost("signup")]
        public IActionResult createNewUser([FromBody] User user)
        {
            var adding_result = libraryService.AddNewUser(user);
            if (adding_result.state == false)
            {
                return BadRequest(adding_result.message);
            }
            else
            {
                return Ok(adding_result.message);
            }
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

        [HttpDelete("{id}")]
        public ActionResult<List<Book>> deleteBook(int id) {
            Console.WriteLine("Attempting to delete book with ID: " + id);
            return libraryService.DeleteBook(id);
        }

        [HttpPut("{id}")]
        public ActionResult<List<Book>> updateBook([FromBody]Book updated_book) {
            return libraryService.UpdateBook(updated_book);
        }

        [HttpGet("book/{id}")]
        public ActionResult<Book> getBook(int id) { 
            var book = libraryService.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        [HttpGet("categories")]
        public ActionResult<List<Category>> getCategories(){
            return libraryService.GetCategories();
        }

        [HttpPost("categories")]
        public ActionResult<List<Category>> addCategore([FromBody] Category new_category)
        {
            return libraryService.AddCategory(new_category);
        }

        [HttpDelete("categories/{id}")]
        public ActionResult<List<Category>> deleteCategory(int id)
        {
            return libraryService.DeleteCategory(id);
        }

        [HttpPut("categories/{id}")]
        public ActionResult<List<Category>> updateCategory([FromBody] Category updated_category)
        {
            return libraryService.UpdateCategory(updated_category);
        }
    }
}
