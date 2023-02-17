using ArtistTitles.Application.Interfaces;
using MediatR;
using AutoMapper;
using ArtistTitles.Application.Interfaces;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using ArtistTitles.Application.Common.Exceptions;
using ArtistTitles.Domain;

namespace ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleDetails
{
    public class GetArtistTitleDetailsQueryHandler : IRequestHandler<GetArtistTitleDetailsQuery, ArtistTitleDetailsVm>
    {
        private readonly IArtistTitlesDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetArtistTitleDetailsQueryHandler(IArtistTitlesDbContext dbContext, IMapper mapper)
            => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<ArtistTitleDetailsVm> Handle(GetArtistTitleDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.ArtistTitles
                .FirstOrDefaultAsync(artistTitle => artistTitle.offerId == request.offerId, cancellationToken);

            if (entity == null) 
            {
                throw new OfferNotFound(nameof(ArtistTitle), request.offerId);
            }

            return _mapper.Map<ArtistTitleDetailsVm>(entity);
        }
    }
}
