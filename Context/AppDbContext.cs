using Library_App_ASP_and_React.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_App_ASP_and_React.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2V9CUIT;Database=Library;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
