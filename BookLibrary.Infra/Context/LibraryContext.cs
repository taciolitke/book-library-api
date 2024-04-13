using BookLibrary.Infra.Configuration;
using BookLibrary.Service.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Infra.Context
{
    public class LibraryContext: DbContext
    {
        public DbSet<Book> Books { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
        }
    }
}
