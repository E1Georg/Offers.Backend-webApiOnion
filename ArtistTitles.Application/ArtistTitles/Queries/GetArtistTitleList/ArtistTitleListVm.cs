using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleList
{
    public class ArtistTitleListVm
    {
        public IList<ArtistTitleLookupDto> ArtistTitles { get; set; }
    }
}
  