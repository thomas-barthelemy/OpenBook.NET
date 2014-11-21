namespace OpenBook
{
    /// <summary>
    ///     Constants for OpenBooks API URIs
    /// </summary>
    /// <remarks>
    ///     Apis seems to take a '_' parameter that seems to be the current user token
    /// </remarks>
    class OpenbookUri
    {
        public const string Protocol = "https://";
        public const string Hostname = "openbook.etoro.com";
        public const string BaseUri = Protocol + Hostname + "/API";

        /// <summary>
        ///     Gets the top ranking users depending on the filters
        ///     Known parameters and values:
        ///         period => Number of days (e.g. 30, 90)
        ///         riskLevel => low, ??
        ///         sort => copiers, ??
        ///         pageNumber => Page requested starting 1
        /// </summary>
        public const string Rankings = BaseUri + "/Rankings/";

        public class ClientInformation
        {
            public const string BaseApiUri = BaseUri + "/ClientInformation/";

            /// <summary>
            ///     Gets the current user information and features available to him
            /// </summary>
            public const string Information = BaseApiUri + "/Information/";
        }

        public class Search
        {
            public const string BaseApiUri = BaseUri + "/Search";

            /// <summary>
            ///     Gets details one or more specific users
            ///     Known parameters and values:
            ///         usernames => ["username1", "username2", ..., "usernamex"]
            ///         timeFrame => Number of days (e.g. 30, 90)
            /// </summary>
            public const string AdditionalData = BaseApiUri + "/AdditionalData/";
        }
    }
}
