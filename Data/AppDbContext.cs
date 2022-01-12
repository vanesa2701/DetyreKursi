using book_review1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace book_review1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
