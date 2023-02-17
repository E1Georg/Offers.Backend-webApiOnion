using ArtistTitles.Application.Common.Mappings;
using ArtistTitles.Application.ArtistTitles.Commands.CreateArtistTitle;
using AutoMapper;

namespace ArtistTitles.WebApi.Models
{
    public class CreateArtistTitleDto : IMapWith<CreateArtistTitleCommand>
    {
        public string url { get; set; }
        public double price { get; set; }
        public string currencyId { get; set; }
        public int categoryId { get; set; }
        public string picture { get; set; }
        public bool delivery { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string media { get; set; }
        public string description { get; set; }
        public int offerId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateArtistTitleDto, CreateArtistTitleCommand>()
            .ForMember(artistTitleCommand => artistTitleCommand.price,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.price))
            .ForMember(artistTitleCommand => artistTitleCommand.currencyId,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.currencyId))
            .ForMember(artistTitleCommand => artistTitleCommand.categoryId,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.categoryId))
            .ForMember(artistTitleCommand => artistTitleCommand.picture,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.picture))
            .ForMember(artistTitleCommand => artistTitleCommand.delivery,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.delivery))
            .ForMember(artistTitleCommand => artistTitleCommand.artist,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.artist))
            .ForMember(artistTitleCommand => artistTitleCommand.title,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.title))
            .ForMember(artistTitleCommand => artistTitleCommand.year,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.year))
            .ForMember(artistTitleCommand => artistTitleCommand.media,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.media))
            .ForMember(artistTitleCommand => artistTitleCommand.description,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.description))
            .ForMember(artistTitleCommand => artistTitleCommand.url,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.url))
             .ForMember(artistTitleCommand => artistTitleCommand.offerId,
            opt => opt.MapFrom(artistTitleDto => artistTitleDto.offerId));
        }
    }
}
