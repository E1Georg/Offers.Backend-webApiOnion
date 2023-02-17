using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistTitles.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(ArtistTitlesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
