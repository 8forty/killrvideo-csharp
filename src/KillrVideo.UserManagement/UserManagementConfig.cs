﻿using KillrVideo.Host;
using KillrVideo.Host.Config;

namespace KillrVideo.UserManagement
{
    /// <summary>
    /// Configuration helper for the User Management service.
    /// </summary>
    public static class UserManagementConfig
    {
        /// <summary>
        /// Configuration key that determines whether or not to use the LINQ User Management service implementation.
        /// </summary>
        public const string UseLinqKey = "UseLinq";

        /// <summary>
        /// Returns true if the LINQ implementation should be used.
        /// </summary>
        internal static bool UseLinq(IHostConfiguration config)
        {
            string useLinq = config.GetConfigurationValueOrDefault(UseLinqKey, bool.FalseString);
            return bool.Parse(useLinq);
        }
    }
}
