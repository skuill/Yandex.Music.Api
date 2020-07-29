using System;
using System.Collections.Generic;

namespace Yandex.Music.Api.Models.Artist
{
    public class YConcert
    {
        #region ��������

        public string Address { get; set; }
        public string AfishaUrl { get; set; }
        public YArtist Artist { get; set; }
        public string City { get; set; }
        public string ConcertTitle { get; set; }
        public string ContentRating { get; set; }
        public List<decimal> Coordinates { get; set; }
        public string DataSessionId { get; set; }
        public DateTime DateTime { get; set; }
        public string Hash { get; set; }
        public string Id { get; set; }
        public List<string> Images { get; set; }
        public string Map { get; set; }
        public string MapUrl { get; set; }
        public List<YMetroStation> MetroStations { get; set; }
        public string Place { get; set; }

        #endregion
    }
}