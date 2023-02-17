using System;
using FluentValidation;

namespace ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleDetails
{
    public class GetArtistTitleDetailsQueryValidator : AbstractValidator<GetArtistTitleDetailsQuery>
    {
        public GetArtistTitleDetailsQueryValidator() 
        {
            //RuleFor(artistTitle => artistTitle.Id).NotEqual(Guid.Empty);
        }
    }
}
