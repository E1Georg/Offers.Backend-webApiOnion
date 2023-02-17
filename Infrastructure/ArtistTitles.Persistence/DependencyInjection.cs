using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ArtistTitles.Application.Interfaces;

namespace ArtistTitles.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<ArtistTitlesDbContext>(options => {
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<IArtistTitlesDbContext>(provider => provider.GetService<ArtistTitlesDbContext>());

            return services;
        }
    }
}
