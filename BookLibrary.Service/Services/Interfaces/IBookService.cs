using BookLibrary.Service.Entities;
using BookLibrary.Service.Filters;

namespace BookLibrary.Service.Services.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> Get(BookFilter filter);
    }
}
