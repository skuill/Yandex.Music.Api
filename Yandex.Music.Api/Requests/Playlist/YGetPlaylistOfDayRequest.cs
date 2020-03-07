using System.Collections.Generic;
using Yandex.Music.Api.Common;

namespace Yandex.Music.Api.Requests.Playlist
{
    internal class YGetPlaylistOfDayRequest : YRequest
    {
        public YGetPlaylistOfDayRequest(YAuthStorage storage) : base(storage)
        {
        }

        public YRequest Create()
        {
            Dictionary<string, string> query = new Dictionary<string, string> {
                { "kinds", storage.User.Uid },
                { "lang", storage.User.Lang },
                { "owner", "yamusic-daily" },
                { "light", "true" },
                { "external-domain", "music.yandex.ru" },
                { "overembed", "false" },
                { "ncrnd", "ncrnd=0.9083773647705418" }
            };

            FormRequest(YEndpoints.Playlist, query: query);

            return this;
        }
    }
}