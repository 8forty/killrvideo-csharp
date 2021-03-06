﻿using KillrVideo.Host;
using KillrVideo.Host.Config;

namespace KillrVideo.Search
{
    /// <summary>
    /// Configuration helper for configuring the search service.
    /// </summary>
    public static class SearchConfig
    {
        /// <summary>
        /// The configuration key that determines whether to use DSE search for the Search Service.
        /// </summary>
        public const string UseDseKey = "UseDse";

        /// <summary>
        /// Returns true if using DSE Search is enabled.
        /// </summary>
        internal static bool UseDseSearch(IHostConfiguration config)
        {
            string useDse = config.GetConfigurationValueOrDefault(UseDseKey, bool.FalseString);
            return bool.Parse(useDse);
        }
    }
}
