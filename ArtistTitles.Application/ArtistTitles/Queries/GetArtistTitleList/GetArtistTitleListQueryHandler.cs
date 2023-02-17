using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtistTitles.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleList
{
    public class GetArtistTitleListQueryHandler : IRequestHandler<GetArtistTitleListQuery, ArtistTitleListVm>
    {
        private readonly IArtistTitlesDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetArtistTitleListQueryHandler(IArtistTitlesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ArtistTitleListVm> Handle(GetArtistTitleListQuery request, CancellationToken cancellationToken)
        {
            var artistTitleQuery = await _dbContext.ArtistTitles.Where(artistTitle => artistTitle.offerId >= 0)
                .ProjectTo<ArtistTitleLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new ArtistTitleListVm { ArtistTitles = artistTitleQuery };
        }
    }
}
