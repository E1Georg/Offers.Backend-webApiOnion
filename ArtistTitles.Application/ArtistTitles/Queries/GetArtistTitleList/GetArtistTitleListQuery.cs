using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleList
{
    public class GetArtistTitleListQuery : IRequest<ArtistTitleListVm>
    {
        public int offerId { get; set; }
    }
}
