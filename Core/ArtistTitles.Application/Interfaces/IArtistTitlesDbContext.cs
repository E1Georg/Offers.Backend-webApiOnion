using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArtistTitles.Domain;

namespace ArtistTitles.Application.Interfaces
{
    public interface IArtistTitlesDbContext
    {
        DbSet<ArtistTitle> ArtistTitles { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
