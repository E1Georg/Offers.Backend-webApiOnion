using System;
using ArtistTitles.Application.Common.Mappings;
using ArtistTitles.Domain;
using MediatR;
using AutoMapper;

namespace ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleList
{
    public class ArtistTitleLookupDto : IMapWith<ArtistTitle>
    {
        public Guid Id { get; set; }
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

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ArtistTitle, ArtistTitleLookupDto>()
            .ForMember(artistTitleDto => artistTitleDto.Id,
            opt => opt.MapFrom(artistTitle => artistTitle.Id))
            .ForMember(artistTitleDto => artistTitleDto.price,
            opt => opt.MapFrom(artistTitle => artistTitle.price))
            .ForMember(artistTitleDto => artistTitleDto.currencyId,
            opt => opt.MapFrom(artistTitle => artistTitle.currencyId))
            .ForMember(artistTitleDto => artistTitleDto.categoryId,
            opt => opt.MapFrom(artistTitle => artistTitle.categoryId))
            .ForMember(artistTitleDto => artistTitleDto.picture,
            opt => opt.MapFrom(artistTitle => artistTitle.picture))
            .ForMember(artistTitleDto => artistTitleDto.delivery,
            opt => opt.MapFrom(artistTitle => artistTitle.delivery))
            .ForMember(artistTitleDto => artistTitleDto.artist,
            opt => opt.MapFrom(artistTitle => artistTitle.artist))
            .ForMember(artistTitleDto => artistTitleDto.title,
            opt => opt.MapFrom(artistTitle => artistTitle.title))
            .ForMember(artistTitleDto => artistTitleDto.year,
            opt => opt.MapFrom(artistTitle => artistTitle.year))
            .ForMember(artistTitleDto => artistTitleDto.media,
            opt => opt.MapFrom(artistTitle => artistTitle.media))
            .ForMember(artistTitleDto => artistTitleDto.url,
            opt => opt.MapFrom(artistTitle => artistTitle.url));
        }
    }
}
