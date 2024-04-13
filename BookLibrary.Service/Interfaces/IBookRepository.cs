using BookLibrary.Service.Entities;

namespace BookLibrary.Service.Interfaces
{
    public interface IBookRepository
    {
        IQueryable<Book> Get();
    }
}
