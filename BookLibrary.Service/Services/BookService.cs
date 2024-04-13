using BookLibrary.Service.Entities;
using BookLibrary.Service.Interfaces;
using BookLibrary.Service.Services.Interfaces;

namespace BookLibrary.Service.Services
{
    public class BookService: IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> Get() => _bookRepository.Get();
    }
}
