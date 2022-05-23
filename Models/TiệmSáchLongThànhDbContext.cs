using Microsoft.EntityFrameworkCore;
using TiệmSáchLongThành.Models;

namespace BooksStore.Models
{
    public class BooksStoreDbContext : DbContext
    {
        public BooksStoreDbContext(DbContextOptions<BooksStoreDbContext>
       options)
        : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}