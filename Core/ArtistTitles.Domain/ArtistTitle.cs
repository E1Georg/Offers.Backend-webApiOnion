using System;
namespace ArtistTitles.Domain
{
    public class ArtistTitle
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
        public int offerId { get; set; }
    }
}
