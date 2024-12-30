using InheritanceEntityFramework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InheritanceEntityFramework.Configurations
{
    static class DataConfig
    {
        public static IServiceCollection AddDataInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options
                    .UseSqlServer("Data source=(localdb)\\mssqllocaldb; Initial Catalog=InheritanceEntityFramework;Integrated Security=true;pooling=true;")
                    .LogTo(Console.WriteLine)                    
                    .EnableSensitiveDataLogging());

            EnsureDeletedAndCreatedDataBase(services);

            return services;
        }

        private static void EnsureDeletedAndCreatedDataBase(IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();

            var context = serviceProvider.GetRequiredService<AppDbContext>();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
