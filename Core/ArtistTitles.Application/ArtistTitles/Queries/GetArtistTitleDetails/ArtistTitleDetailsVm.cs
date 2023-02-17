using ArtistTitles.Application.Common.Mappings;
using ArtistTitles.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleDetails
{
    public class ArtistTitleDetailsVm : IMapWith<ArtistTitle>
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
        public string description { get; set; }        

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ArtistTitle, ArtistTitleDetailsVm>()
            .ForMember(artistTitleVm => artistTitleVm.Id,
            opt => opt.MapFrom(artistTitle => artistTitle.Id))
            .ForMember(artistTitleVm => artistTitleVm.price,
            opt => opt.MapFrom(artistTitle => artistTitle.price))
            .ForMember(artistTitleVm => artistTitleVm.currencyId,
            opt => opt.MapFrom(artistTitle => artistTitle.currencyId))
            .ForMember(artistTitleVm => artistTitleVm.categoryId,
            opt => opt.MapFrom(artistTitle => artistTitle.categoryId))
            .ForMember(artistTitleVm => artistTitleVm.picture,
            opt => opt.MapFrom(artistTitle => artistTitle.picture))
            .ForMember(artistTitleVm => artistTitleVm.delivery,
            opt => opt.MapFrom(artistTitle => artistTitle.delivery))
            .ForMember(artistTitleVm => artistTitleVm.artist,
            opt => opt.MapFrom(artistTitle => artistTitle.artist))
            .ForMember(artistTitleVm => artistTitleVm.title,
            opt => opt.MapFrom(artistTitle => artistTitle.title))
            .ForMember(artistTitleVm => artistTitleVm.year,
            opt => opt.MapFrom(artistTitle => artistTitle.year))
            .ForMember(artistTitleVm => artistTitleVm.media,
            opt => opt.MapFrom(artistTitle => artistTitle.media))
            .ForMember(artistTitleVm => artistTitleVm.description,
            opt => opt.MapFrom(artistTitle => artistTitle.description))
            .ForMember(artistTitleVm => artistTitleVm.url,
            opt => opt.MapFrom(artistTitle => artistTitle.url));
        }
    }
}