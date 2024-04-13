using BookLibrary.Service.Filters.Enums;

namespace BookLibrary.Service.Filters
{
    public class BookFilter
    {
        public BookFilterType FilterType { get; set; }  
        public string? Filter { get; set; }
    }
}
