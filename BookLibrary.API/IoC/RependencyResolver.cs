using BookLibrary.Service.Interfaces;
using BookLibrary.Infra.Repositories;
using BookLibrary.Service.Services.Interfaces;
using BookLibrary.Service.Services;
using BookLibrary.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.API.IoC
{
    public static class RependencyResolver
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookService, BookService>();
        }
        public static void AddDatabaseConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<LibraryContext>(options =>
                            options.UseSqlServer(configuration.GetConnectionString("LibraryDb")));
        }
    }
}
