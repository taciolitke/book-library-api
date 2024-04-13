using BookLibrary.Service.Entities;

namespace BookLibrary.Service.Services.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> Get();
    }
}
