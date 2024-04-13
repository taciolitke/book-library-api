using BookLibrary.Service.Entities;
using BookLibrary.Service.Filters;
using BookLibrary.Service.Filters.Enums;
using BookLibrary.Service.Interfaces;
using BookLibrary.Service.Services.Interfaces;

namespace BookLibrary.Service.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> Get(BookFilter filter)
        {
            var result = _bookRepository.Get();

            if(!string.IsNullOrEmpty(filter.Filter) && (BookFilterType) filter.FilterType != BookFilterType.All)
            {
                switch ((BookFilterType) filter.FilterType)
                {
                    case BookFilterType.Title:
                        return result.Where(x => x.Title.Contains(filter.Filter));
                    case BookFilterType.Author:
                        return result.Where(x => x.FirstName.Contains(filter.Filter) || x.LastName.Contains(filter.Filter));
                    case BookFilterType.Type:
                        return result.Where(x => x.Type.Contains(filter.Filter));
                    case BookFilterType.Category:
                        return result.Where(x => x.Category.Contains(filter.Filter));
                    case BookFilterType.AvailableNow:
                        return result.Where(x => x.TotalCopies > 0 && x.CopiesInUse != x.TotalCopies);
                    default:
                        break;
                }
            }

            return result;
        }
    }
}
