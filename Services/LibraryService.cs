using Library_App_ASP_and_React.Models;

namespace Library_App_ASP_and_React.Services
{
    public class LibraryService
    {
        public List<Book> books = new List<Book>()
        {
            new Book(){Id=Guid.NewGuid().ToString(), Title="Yuriy Kisil. Road to the dream.", Author="Yuriy Kisil", Publishing_House="ESL Pro League", Publishing_Date=new DateTime(2027,3,9), Image="https://static-cdn.jtvnw.net/jtv_user_pictures/9d442cfb-4dcc-431a-b5de-e52b7eb08d5d-profile_image-70x70.png"}
        };

        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}
