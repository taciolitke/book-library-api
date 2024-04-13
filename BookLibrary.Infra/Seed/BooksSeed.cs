using BookLibrary.Infra.Context;
using BookLibrary.Service.Entities;

namespace BookLibrary.Infra.Seed
{
    public static class BooksSeed
    {
        public static List<Book> GetInitialSeed()
        {
            var id = 0;
            return new List<Book>()
            {
                BookFactory(++id, "Pride and Prejudice", "Jane", "Austen", 100, 80, "Hardcover", "1234567891", "Fiction"),
                BookFactory(++id, "To Kill a Mockingbird", "Harper", "Lee", 75, 65, "Paperback", "1234567892", "Fiction"),
                BookFactory(++id, "The Catcher in the Rye", "J.D.", "Salinger", 50, 45, "Hardcover", "1234567893", "Fiction"),
                BookFactory(++id, "The Great Gatsby", "F. Scott", "Fitzgerald", 50, 22, "Hardcover", "1234567894", "Non-Fiction"),
                BookFactory(++id, "The Alchemist", "Paulo", "Coelho", 50, 35, "Hardcover", "1234567895", "Biography"),
                BookFactory(++id, "The Book Thief", "Markus", "Zusak", 75, 11, "Hardcover", "1234567896", "Mystery"),
                BookFactory(++id, "The Chronicles of Narnia", "C.S.", "Lewis", 100, 14, "Paperback", "1234567897", "Sci-Fi"),
                BookFactory(++id, "The Da Vinci Code", "Dan", "Brown", 50, 40, "Paperback", "1234567898", "Sci-Fi"),
                BookFactory(++id, "The Grapes of Wrath", "John", "Steinbeck", 50, 35, "Hardcover", "1234567899", "Fiction"),
                BookFactory(++id, "The Hitchhiker's Guide to the Galaxy", "Douglas", "Adams", 50, 35, "Paperback", "1234567900", "Non-Fiction"),
                BookFactory(++id, "Moby-Dick", "Herman", "Melville", 30, 8, "Hardcover", "8901234567", "Fiction"),
                BookFactory(++id, "To Kill a Mockingbird", "Harper", "Lee", 20, 0, "Paperback", "9012345678", "Non-Fiction"),
                BookFactory(++id, "The Catcher in the Rye", "J.D.", "Salinger", 10, 1, "Hardcover", "0123456789", "Non-Fiction"),
            };
        }

        private static Book BookFactory(int id, string title, string firstName, string lastName, int totalCopies, int copiesInUse, string type, string isbn, string category)
        {
            return new Book()
            {
                Id = id,
                Title = title,
                FirstName = firstName,
                LastName = lastName,
                TotalCopies = totalCopies,
                CopiesInUse = copiesInUse,
                Type = type,
                Isbn = isbn,
                Category = category
            };
        }
    }
}
