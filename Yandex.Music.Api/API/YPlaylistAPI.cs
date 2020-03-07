﻿using System;
using System.Threading.Tasks;
using Yandex.Music.Api.Common;
using Yandex.Music.Api.Requests.Playlist;
using Yandex.Music.Api.Requests.Track;
using Yandex.Music.Api.Responses;

namespace Yandex.Music.Api.API
{
    public class YPlaylistAPI
    {
        #region Поля

        private readonly YandexMusicApi api;

        #endregion Поля

        #region Вспомогательные функции

        #endregion Вспомогательные функции

        #region Основные функции

        #region Стандартные плейлисты

        public async Task<YPlaylist> OfDayAsync(YAuthStorage storage)
        {
            return await new YGetPlaylistOfDayRequest(storage)
                .Create()
                .GetResponseAsync<YPlaylist>("playlist");
        }

        public YPlaylist OfDay(YAuthStorage storage)
        {
            return OfDayAsync(storage).GetAwaiter().GetResult();
        }

        public async Task<YPlaylistFavoritesResponse> FavoritesAsync(YAuthStorage storage)
        {
            return await new YGetPlaylistFavoritesRequest(storage)
                .Create()
                .GetResponseAsync<YPlaylistFavoritesResponse>();
        }

        public YPlaylistFavoritesResponse Favorites(YAuthStorage storage)
        {
            return FavoritesAsync(storage).GetAwaiter().GetResult();
        }

        public async Task<YPlaylist> DejaVuAsync(YAuthStorage storage)
        {
            return await new YGetPlaylistDejaVuRequest(storage)
                .Create()
                .GetResponseAsync<YPlaylist>("playlist");
        }

        public YPlaylist DejaVu(YAuthStorage storage)
        {
            return DejaVuAsync(storage).GetAwaiter().GetResult();
        }

        #endregion Стандартные плейлисты

        #region Операции над плейлистами

        public async Task<YPlaylist> GetAsync(YAuthStorage storage, string kinds)
        {
            return await new YGetPlaylistRequest(storage)
                .Create(kinds)
                .GetResponseAsync<YPlaylist>("playlist");
        }

        public YPlaylist Get(YAuthStorage storage, string kinds)
        {
            return GetAsync(storage, kinds).GetAwaiter().GetResult();
        }

        public async Task<YPlaylistChangeResponse> CreateAsync(YAuthStorage storage, string name)
        {
            return await new YPlaylistChangeRequest(storage)
                .Create(name)
                .GetResponseAsync<YPlaylistChangeResponse>();
        }

        public YPlaylistChangeResponse Create(YAuthStorage storage, string name)
        {
            return CreateAsync(storage, name).GetAwaiter().GetResult();
        }

        public async Task<bool> RemoveAsync(YAuthStorage storage, long kind)
        {
            try {
                await new YPlaylistRemoveRequest(storage)
                    .Create(kind)
                    .GetResponseAsync();

                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }

            return false;
        }

        public bool Remove(YAuthStorage storage, long kind)
        {
            return RemoveAsync(storage, kind).GetAwaiter().GetResult();
        }

        public async Task<YInsertTrackToPlaylistResponse> InsertTrackAsync(YAuthStorage storage, string trackId, string albumId,
            string playlistKind)
        {
            return await new YInsertTrackToPlaylistRequest(storage)
                .Create(0, trackId, albumId, playlistKind)
                .GetResponseAsync<YInsertTrackToPlaylistResponse>();
        }

        public YInsertTrackToPlaylistResponse InsertTrack(YAuthStorage storage, string trackId, string albumId, string playlistKind)
        {
            return InsertTrackAsync(storage, trackId, albumId, playlistKind).GetAwaiter().GetResult();
        }

        public async Task<YDeleteTrackFromPlaylistResponse> DeleteTrackAsync(YAuthStorage storage, int from, int to, int revision,
            string playlistKind)
        {
            return await new YDeleteTrackFromPlaylistRequest(storage)
                .Create(from, to, revision, playlistKind)
                .GetResponseAsync<YDeleteTrackFromPlaylistResponse>();
        }

        public YDeleteTrackFromPlaylistResponse DeleteTrack(YAuthStorage storage, int from, int to, int revision, string playlistKind)
        {
            return DeleteTrackAsync(storage, from, to, revision, playlistKind).GetAwaiter().GetResult();
        }

        #endregion Операции над плейлистами

        public YPlaylistAPI(YandexMusicApi yandexApi)
        {
            api = yandexApi;
        }

        #endregion Main function
    }
}