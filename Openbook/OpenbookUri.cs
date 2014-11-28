namespace OpenBook
{
    /// <summary>
    ///     Constants for OpenBooks API URIs
    /// </summary>
    /// <remarks>
    ///     APIs seems to take a '_' parameter that seems to be the current user token
    /// </remarks>
    public static class OpenbookUri
    {
        public const string Protocol = "https://";
        public const string Hostname = "openbook.etoro.com";
        public const string BaseUri = Protocol + Hostname + "/API";

        /// <summary>
        ///     Gets the top ranking users depending on the filters.
        ///     Known parameters and values:
        /// <code>
        ///     period => Number of days (e.g. 30, 90)
        ///     riskLevel => low, medium, high
        ///     sort => copiers, gain
        ///     pageNumber => (Optional) Page requested (default to 1)
        /// </code>
        /// </summary>
        public const string Rankings = BaseUri + "/Rankings/";

        /// <summary>
        ///     Gets the 5 top ranking users by copiers on a 3, 6 and 9 month period.
        /// </summary>
        public const string TopPerformers = Rankings + "/TopPerformers/";

        public static class ClientInformation
        {
            internal const string BaseApiUri = BaseUri + "/ClientInformation/";

            /// <summary>
            ///     Gets the current user information and features available to him
            /// </summary>
            public const string Information = BaseApiUri + "/Information/";
        }

        public static class Markets
        {
            internal const string BaseApiUri = BaseUri + "/Markets";

            /// <summary>
            ///     Gets a set of featured symbols from currencies, stocks and
            ///     commodities.
            /// </summary>
            /// <remarks>
            ///     Surprisingly any unknown sub query of /Markets will give
            ///     this same result.
            /// </remarks>
            /// >
            public const string Index = BaseApiUri + "/index";

            /// <summary>
            ///     Gets a set of featured specified symbol.
            ///     Known Parameters and values:
            /// <code>
            ///     category => currencies, stocks, commodities
            /// </code>
            /// </summary>
            public const string Category = BaseApiUri + "/Category";
        }

        public static class Search
        {
            internal const string BaseApiUri = BaseUri + "/Search";

            /// <summary>
            ///     Gets details one or more specific users.
            ///     Known parameters and values:
            /// <code>
            ///     usernames => ["username1", "username2", ..., "usernameX"]
            ///     timeFrame => Number of days (e.g. 30, 90)
            /// </code>
            /// </summary>
            public const string AdditionalData = BaseApiUri + "/AdditionalData/";
        }

        public static class Users
        {
            internal const string BaseApiUri = BaseUri + "/Users";

            /// <summary>
            ///     Gets basic stats information about the specified user.
            ///     The username is not specified as a GET parameter but in the URI:
            ///     <code>var uri = PreviewStats + "username";</code>
            /// </summary>
            public const string PreviewStats = BaseApiUri + "/PreviewStats/";

            /// <summary>
            ///     Gets detailed stats about a specific user.
            ///     The username is not specified as a GET parameter but in the URI:
            ///     <code>var uri = ProfileDetails + "username";</code>
            /// </summary>
            public const string ProfileDetails = BaseApiUri + "/ProfileDetails/";

            /// <summary>
            ///     Gets the positions of a specific user.
            /// <code>
            ///     /Positions/username/demo/current
            ///     /Positions/username/real/history
            /// </code>
            /// <code>var uri = Positions + "real" + "/" + "current"</code>
            /// </summary>
            public const string Positions = BaseApiUri + "/Positions/";
        }
    }
}