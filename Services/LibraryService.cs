using Library_App_ASP_and_React.Context;
using Library_App_ASP_and_React.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_App_ASP_and_React.Services
{
    public class LibraryService
    {
        private readonly AppDbContext _context;

        public LibraryService(AppDbContext context)
        {
            _context = context;
        }

        public List<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public List<Book> AddBook(Book book) {
           _context.Books.Add(book);
            _context.SaveChanges();
            return _context.Books.ToList();
        }

        public List<Book> DeleteBook(int id) { 
        var find_book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (find_book != null)
            {
                _context.Books.Remove(find_book);
                _context.SaveChanges();
            }
            return _context.Books.ToList();
        }

        public List <Book> UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
            return _context.Books.ToList();
        }
    }
}
