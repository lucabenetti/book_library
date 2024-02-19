using BookLibrary.Data.Context;
using BookLibrary.Data.Repositories;
using BookLibrary.Domain.Contracts;
using BookLibrary.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            RegisterApiServices(services);
            RegisterDatabase(services, configuration);

            RegisterRepositories(services);
            RegisterServices(services);
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
        }

        private static void RegisterApiServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        private static void RegisterDatabase(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookLibraryDbContext>(options =>
                        options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
        }
    }
}
