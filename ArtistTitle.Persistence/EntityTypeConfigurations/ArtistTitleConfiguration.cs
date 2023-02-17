using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ArtistTitles.Domain;

namespace ArtistTitle.Persistence.EntityTypeConfigurations
{
    public class ArtistTitleConfiguration : IEntityTypeConfiguration<ArtistTitle>
    {
        public void Configure(EntityTypeBuilder<ArtistTitle> builder)
        {

        }
    }
}
