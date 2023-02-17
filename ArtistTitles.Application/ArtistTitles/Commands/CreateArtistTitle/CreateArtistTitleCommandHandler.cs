using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ArtistTitles.Domain;
using ArtistTitles.Application.Common.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ArtistTitles.Application.ArtistTitles.Commands.CreateArtistTitle
{
    public class CreateArtistTitleCommandHandler : IRequestHandler<CreateArtistTitleCommand, Guid>
    {
        private readonly Interfaces.IArtistTitlesDbContext _dbContext;
        public CreateArtistTitleCommandHandler(Interfaces.IArtistTitlesDbContext dbContext) => _dbContext = dbContext;
        public async Task<Guid> Handle(CreateArtistTitleCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.ArtistTitles.FirstOrDefaultAsync(artistTitle => artistTitle.offerId == request.offerId, cancellationToken);

            if (entity == null || entity.offerId != request.offerId)
            {
                var Temp = new ArtistTitle
                {
                    Id = Guid.NewGuid(),
                    url = request.url,
                    price = request.price,
                    currencyId = request.currencyId,
                    categoryId = request.categoryId,
                    picture = request.picture,
                    delivery = request.delivery,
                    artist = request.artist,
                    title = request.title,
                    year = request.year,
                    media = request.media,
                    description = request.description,
                    offerId = request.offerId
                };

                await _dbContext.ArtistTitles.AddAsync(Temp, cancellationToken);
                await _dbContext.SaveChangesAsync(cancellationToken);
                return Temp.Id;
            }
            else
            {
                throw new OfferAlreadyExistException(nameof(ArtistTitle), request.offerId);
            }
        }
    }
}
