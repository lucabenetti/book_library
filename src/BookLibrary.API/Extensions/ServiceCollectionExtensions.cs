using BookLibrary.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            RegisterApiServices(services);
            RegisterDatabase(services, configuration);
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
