using BookWork.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWork.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<App> Apps { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
      
    }
}
