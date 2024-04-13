using BookLibrary.Infra.Context;
using BookLibrary.Service.Entities;
using BookLibrary.Service.Interfaces;

namespace BookLibrary.Infra.Repositories
{
    public class BookRepository: IBookRepository
    {
        private readonly LibraryContext _context;
        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> Get()
        {
            return _context.Books;
        }
    }
}
