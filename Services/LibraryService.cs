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

        public Book GetBook(int id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == id);
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

        public List<Category> AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return _context.Categories.ToList();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public List<Category> DeleteCategory(int id) { 
            var find_category = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (find_category != null)
            {
                _context.Categories.Remove(find_category);
                _context.SaveChanges();
            }
            return _context.Categories.ToList();
        }

        public List<Category> UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return _context.Categories.ToList();
        }
    }
}
