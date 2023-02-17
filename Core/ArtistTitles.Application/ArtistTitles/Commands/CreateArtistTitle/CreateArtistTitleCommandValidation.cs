using System;
using FluentValidation;

namespace ArtistTitles.Application.ArtistTitles.Commands.CreateArtistTitle
{
    public class CreateArtistTitleCommandValidation : AbstractValidator<CreateArtistTitleCommand>
    {
        public CreateArtistTitleCommandValidation() 
        {
           // RuleFor(createArtistTitleCommand => createArtistTitleCommand.artist).NotEmpty().MaximumLength(250);
           // RuleFor(createArtistTitleCommand => createArtistTitleCommand.Id).NotEqual(Guid.Empty);
        }
    }
}
