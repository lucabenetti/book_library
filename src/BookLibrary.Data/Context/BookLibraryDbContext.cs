using BookLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Data.Context
{
    public class BookLibraryDbContext : DbContext
    {
        public BookLibraryDbContext(DbContextOptions<BookLibraryDbContext> options)
        : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
