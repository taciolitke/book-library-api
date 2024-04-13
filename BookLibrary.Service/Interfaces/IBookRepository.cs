using BookLibrary.Service.Entities;

namespace BookLibrary.Service.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> Get();
    }
}
