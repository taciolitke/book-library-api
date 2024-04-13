using BookLibrary.Infra.Seed;
using BookLibrary.Service.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookLibrary.Infra.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("books");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.TotalCopies).IsRequired();
            builder.Property(x => x.CopiesInUse).IsRequired();
            builder.Property(x => x.Type).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Isbn).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Category).IsRequired().HasMaxLength(50);

            builder.HasData(BooksSeed.GetInitialSeed());
        }
    }
}
