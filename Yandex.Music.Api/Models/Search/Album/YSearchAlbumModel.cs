using System.Collections.Generic;

using Yandex.Music.Api.Models.Search.Artist;

namespace Yandex.Music.Api.Models.Search.Album
{
    public class YSearchAlbumModel
    {
        #region ��������

        public List<YSearchArtist> Artists { get; set; }
        public bool Available { get; set; }
        public bool AvailableForPremiumUsers { get; set; }
        public string CoverUri { get; set; }
        public string Genre { get; set; }
        public string Id { get; set; }
        public int OriginalReleaseYear { get; set; }
        public List<string> Regions { get; set; }
        public string StorageDir { get; set; }
        public string Title { get; set; }
        public int TrackCount { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }

        #endregion
    }
}