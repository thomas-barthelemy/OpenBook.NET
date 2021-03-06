﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenBook.Models.ApiResults.FeaturedSymbols;
using OpenBook.Models.ApiResults.MarketCategories;
using OpenBook.Models.ApiResults.Ranking;
using OpenBook.Models.ApiResults.TopPerformers;
using OpenBook.Models.ApiResults.UserAdditionalData;
using OpenBook.Models.ApiResults.UserPositions;
using OpenBook.Models.ApiResults.UserPreviewStats;
using OpenBook.Models.ApiResults.UserProfileDetails;

namespace OpenBook
{
    public class OpenBookClient : IDisposable
    {
        private HttpClient _client;

        private HttpClient HttpClient
        {
            get { return _client ?? (_client = new HttpClient()); }
        }

        /// <summary>
        ///     Gets the top ranking users for the specified risk level.
        ///     Results are paginated with a maximum of 10 results per
        ///     page.
        /// </summary>
        /// <param name="sortBy">Defines how are sorted the user</param>
        /// <param name="riskLevel">Defines the risk level</param>
        /// <param name="period">
        ///     The period in days to calculate the ranking.
        ///     (Default: 30 days)
        /// </param>
        /// <param name="pageNumber">The requested page. (Default: 1st page)</param>
        /// <returns>
        ///     <see cref="RankingResult" />
        /// </returns>
        public async Task<RankingResult> GetRankingAsync(
            SortBy sortBy,
            RiskLevel riskLevel,
            int period = 30,
            int pageNumber = 1)
        {
            var query = new Dictionary<string, string>
            {
                {"period", period.ToString()},
                {"sort", sortBy.ToString()},
                {"riskLevel", riskLevel.ToString()},
                {"pageNumber", pageNumber.ToString()}
            };

            return await GetResult<RankingResult>(OpenbookUri.Rankings, query);
        }

        /// <summary>
        ///     Gets additional data about one or more specified user over
        ///     the specified period.
        /// </summary>
        /// <param name="usernames">
        ///     A collection of usernames that will be searched
        /// </param>
        /// <param name="period">
        ///     The period in days to search into.
        ///     (Default: 30 days)
        /// </param>
        /// <returns>
        ///     <see cref="UserAdditionalDataResult" />
        /// </returns>
        public async Task<UserAdditionalDataResult> GetAdditionalData(
            ICollection<string> usernames, int period = 30)
        {
            var userParam = "[\"" + string.Join("\", \"", usernames) + "\"]";
            var query = new Dictionary<string, string>
            {
                {"period", period.ToString()},
                {"usernames", userParam}
            };

            return await GetResult<UserAdditionalDataResult>(
                OpenbookUri.Search.AdditionalData, query);
        }

        /// <summary>
        ///     Gets the 5 top ranking users by copiers on a 3, 6 and 9 month period.
        /// </summary>
        /// <returns><see cref="TopPerformersResult"/></returns>
        public async Task<TopPerformersResult> GetTopPerformers()
        {
            return await GetResult<TopPerformersResult>(OpenbookUri.TopPerformers);
        }

        /// <summary>
        ///     Gets a set of the featured symbols.
        /// </summary>
        /// <returns><see cref="FeaturedSymbolsResult"/></returns>
        public async Task<FeaturedSymbolsResult> GetFeaturedSymbols()
        {
            return await GetResult<FeaturedSymbolsResult>(OpenbookUri.Markets.Index);
        }

        /// <summary>
        ///     Gets the featured / top symbols of the specified category.
        /// </summary>
        /// <param name="category">A type of symbol</param>
        /// <returns><see cref="MarketCategoriesResult"/></returns>
        public async Task<MarketCategoriesResult> GetFeaturedSymbols(
            MarketCategory category)
        {
            var query = new Dictionary<string, string>
            {
                {"category", category.ToString().ToLower()}
            };

            return await GetResult<MarketCategoriesResult>(
                OpenbookUri.Markets.Category, query);
        }

        /// <summary>
        ///     Gets preview stats about the specified user.
        /// </summary>
        /// <param name="username">A user's username</param>
        /// <returns><see cref="UserPreviewStatsResult"/></returns>
        public async Task<UserPreviewStatsResult> GetPreviewStats(string username)
        {
            return await GetResult<UserPreviewStatsResult>(
                OpenbookUri.Users.PreviewStats,
                username);
        }

        /// <summary>
        ///     Gets the profile details of the specified user.
        /// </summary>
        /// <param name="username">A user's username</param>
        /// <returns><see cref="UserProfileDetailsResult"/></returns>
        public async Task<UserProfileDetailsResult> GetProfileDetails(string username)
        {
            return await GetResult<UserProfileDetailsResult>(
                OpenbookUri.Users.ProfileDetails + username);
        }

        /// <summary>
        ///     Gets the user's position
        /// </summary>
        /// <param name="username">A user's username</param>
        /// <param name="positionType">A position type: (default)Real or Demo</param>
        /// <param name="positionTime">A position time: (default)Current or History</param>
        /// <returns><see cref="UserPositionsResult"/></returns>
        public async Task<UserPositionsResult> GetUserPositions(string username,
            PositionType positionType = PositionType.Real,
            PositionTime positionTime = PositionTime.Current)
        {
            return await GetResult<UserPositionsResult>(
                OpenbookUri.Users.Positions,
                username,
                positionType.ToString().ToLower(),
                positionTime.ToString().ToLower());
        }

        internal Uri GetQueryUri(string baseUri,
            IDictionary<string, string> queryParams = null)
        {
            var builder = new UriBuilder(baseUri);

            // Return the base URI if no parameters are provided
            if (queryParams == null || queryParams.Count <= 0) return builder.Uri;

            var queries =
                queryParams.Select(pair => string.Format("{0}={1}", pair.Key, pair.Value));
            builder.Query = string.Join("&", queries);
            return builder.Uri;
        }

        /// <summary>
        ///     Sends a GET request to the specified Uri and returns the response
        ///     body as a string in an asynchronous operation.
        ///     By default this uses HttpClient.GetStringAsync(...) but this method
        ///     can be overridden to customize how the requests are made.
        /// </summary>
        protected virtual async Task<string> GetStringAsync(Uri uri)
        {
            return await HttpClient.GetStringAsync(uri);
        }

        internal async Task<T> GetResult<T>(string baseUri, params string[] path)
        {
            var uri = baseUri + string.Join("/", path);
            return await GetResult<T>(uri);
        }

        internal async Task<T> GetResult<T>(string baseUri,
            IDictionary<string, string> queryParams = null)
        {
            var uri = GetQueryUri(baseUri, queryParams);
            var jsonResult = await GetStringAsync(uri);
            return JsonConvert.DeserializeObject<T>(jsonResult);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposeManaged)
        {
            if (disposeManaged && _client != null)
                _client.Dispose();
        }
    }
}