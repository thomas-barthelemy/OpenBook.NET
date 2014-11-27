using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenBook.Models.ApiResults;

namespace OpenBook
{
    public class OpenBookClient
    {
        private readonly HttpClient _client;

        public OpenBookClient()
        {
            _client = new HttpClient();
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
        ///     <see cref="AdditionalDataResult" />
        /// </returns>
        public async Task<AdditionalDataResult> GetAdditionalData(
            ICollection<string> usernames, int period = 30)
        {
            var userParam = "[\"" + string.Join("\", \"", usernames) + "\"]";
            var query = new Dictionary<string, string>
            {
                {"period", period.ToString()},
                {"usernames", userParam}
            };

            return await GetResult<AdditionalDataResult>(
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

        internal async Task<T> GetResult<T>(string baseUri,
            IDictionary<string, string> queryParams = null)
        {
            var uri = GetQueryUri(baseUri, queryParams);
            var jsonResult = await _client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<T>(jsonResult);
        }
    }
}