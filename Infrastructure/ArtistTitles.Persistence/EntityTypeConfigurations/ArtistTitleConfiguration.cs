using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ArtistTitles.Domain; 

namespace ArtistTitles.Persistence.EntityTypeConfigurations
{
    public class ArtistTitleConfiguration : IEntityTypeConfiguration<ArtistTitle>
    {
        public void Configure(EntityTypeBuilder<ArtistTitle> builder)
        {
            builder.HasKey(artistTitle => artistTitle.Id);
            builder.HasIndex(artistTitle => artistTitle.Id).IsUnique();
        }
    }
}
