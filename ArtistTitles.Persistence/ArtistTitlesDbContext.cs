using Microsoft.EntityFrameworkCore;
using ArtistTitles.Application.Interfaces;
using ArtistTitles.Domain;
using ArtistTitles.Persistence.EntityTypeConfigurations;

namespace ArtistTitles.Persistence
{
    public class ArtistTitlesDbContext : DbContext, IArtistTitlesDbContext
    {
        public DbSet<ArtistTitle> ArtistTitles { get; set; }
        public ArtistTitlesDbContext(DbContextOptions<ArtistTitlesDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ArtistTitleConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
