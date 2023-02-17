using System;
using FluentValidation;

namespace ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleList
{
    public class GetArtistTitleListQueryValidator : AbstractValidator<GetArtistTitleListQuery>
    {
        public GetArtistTitleListQueryValidator() 
        {
            //RuleFor(x => x.offerId).NotEmpty();
        }
    }
}
