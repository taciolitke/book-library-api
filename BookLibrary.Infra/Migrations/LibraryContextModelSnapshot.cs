﻿// <auto-generated />
using BookLibrary.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookLibrary.Infra.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookLibrary.Service.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CopiesInUse")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TotalCopies")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("books", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Fiction",
                            CopiesInUse = 80,
                            FirstName = "Jane",
                            Isbn = "1234567891",
                            LastName = "Austen",
                            Title = "Pride and Prejudice",
                            TotalCopies = 100,
                            Type = "Hardcover"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Fiction",
                            CopiesInUse = 65,
                            FirstName = "Harper",
                            Isbn = "1234567892",
                            LastName = "Lee",
                            Title = "To Kill a Mockingbird",
                            TotalCopies = 75,
                            Type = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Fiction",
                            CopiesInUse = 45,
                            FirstName = "J.D.",
                            Isbn = "1234567893",
                            LastName = "Salinger",
                            Title = "The Catcher in the Rye",
                            TotalCopies = 50,
                            Type = "Hardcover"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Non-Fiction",
                            CopiesInUse = 22,
                            FirstName = "F. Scott",
                            Isbn = "1234567894",
                            LastName = "Fitzgerald",
                            Title = "The Great Gatsby",
                            TotalCopies = 50,
                            Type = "Hardcover"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Biography",
                            CopiesInUse = 35,
                            FirstName = "Paulo",
                            Isbn = "1234567895",
                            LastName = "Coelho",
                            Title = "The Alchemist",
                            TotalCopies = 50,
                            Type = "Hardcover"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Mystery",
                            CopiesInUse = 11,
                            FirstName = "Markus",
                            Isbn = "1234567896",
                            LastName = "Zusak",
                            Title = "The Book Thief",
                            TotalCopies = 75,
                            Type = "Hardcover"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Sci-Fi",
                            CopiesInUse = 14,
                            FirstName = "C.S.",
                            Isbn = "1234567897",
                            LastName = "Lewis",
                            Title = "The Chronicles of Narnia",
                            TotalCopies = 100,
                            Type = "Paperback"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Sci-Fi",
                            CopiesInUse = 40,
                            FirstName = "Dan",
                            Isbn = "1234567898",
                            LastName = "Brown",
                            Title = "The Da Vinci Code",
                            TotalCopies = 50,
                            Type = "Paperback"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Fiction",
                            CopiesInUse = 35,
                            FirstName = "John",
                            Isbn = "1234567899",
                            LastName = "Steinbeck",
                            Title = "The Grapes of Wrath",
                            TotalCopies = 50,
                            Type = "Hardcover"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Non-Fiction",
                            CopiesInUse = 35,
                            FirstName = "Douglas",
                            Isbn = "1234567900",
                            LastName = "Adams",
                            Title = "The Hitchhiker's Guide to the Galaxy",
                            TotalCopies = 50,
                            Type = "Paperback"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Fiction",
                            CopiesInUse = 8,
                            FirstName = "Herman",
                            Isbn = "8901234567",
                            LastName = "Melville",
                            Title = "Moby-Dick",
                            TotalCopies = 30,
                            Type = "Hardcover"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Non-Fiction",
                            CopiesInUse = 0,
                            FirstName = "Harper",
                            Isbn = "9012345678",
                            LastName = "Lee",
                            Title = "To Kill a Mockingbird",
                            TotalCopies = 20,
                            Type = "Paperback"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Non-Fiction",
                            CopiesInUse = 1,
                            FirstName = "J.D.",
                            Isbn = "0123456789",
                            LastName = "Salinger",
                            Title = "The Catcher in the Rye",
                            TotalCopies = 10,
                            Type = "Hardcover"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
