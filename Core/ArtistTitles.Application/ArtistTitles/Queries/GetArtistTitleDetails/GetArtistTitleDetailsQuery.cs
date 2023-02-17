using System;
using MediatR;


namespace ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleDetails
{
    public class GetArtistTitleDetailsQuery : IRequest<ArtistTitleDetailsVm>
    {
        public Guid Id { get; set; }
        public int offerId { get; set; }
    }
}
