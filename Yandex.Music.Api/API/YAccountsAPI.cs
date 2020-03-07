﻿using System.Threading.Tasks;
using Yandex.Music.Api.Common;
using Yandex.Music.Api.Requests.Account;
using Yandex.Music.Api.Responses;

namespace Yandex.Music.Api.API
{
    public class YAccountsAPI
    {
        #region Поля

        private readonly YandexMusicApi api;

        #endregion Поля

        #region Основные функции

        public async Task<YAccountResponse> GetAsync(YAuthStorage storage)
        {
            return await new YGetAccountRequest(storage)
                .Create()
                .GetResponseAsync<YAccountResponse>();
        }

        public YAccountResponse Get(YAuthStorage storage)
        {
            return GetAsync(storage).GetAwaiter().GetResult();
        }

        public YAccountsAPI(YandexMusicApi yandexApi)
        {
            api = yandexApi;
        }

        #endregion Основные функции
    }
}