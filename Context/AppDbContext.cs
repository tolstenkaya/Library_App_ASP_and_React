using Library_App_ASP_and_React.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_App_ASP_and_React.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null !;
        public DbSet<UserRelationBook> RelationBooks { get; set; }= null!;
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRelationBook>().HasKey(urb => new { urb.UserId, urb.BookId });
        }
    }
}
