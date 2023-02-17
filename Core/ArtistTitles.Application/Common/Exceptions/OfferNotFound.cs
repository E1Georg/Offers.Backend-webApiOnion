using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistTitles.Application.Common.Exceptions
{  
    public class OfferNotFound : Exception
    {
        public OfferNotFound(string name, object key) : base($"Entity \"{name}\" ({key}) not found.") { }
    }
}
