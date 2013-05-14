using System.Configuration;

namespace PersonalMovieDatabase.Common.Configuration
{
    public class Config : IConfig
    {
        /// <summary>
        /// Gets the configuration values.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        private static string GetConfigurationValues(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// Gets the SQL connection string.
        /// </summary>
        /// <value>
        /// The SQL connection string.
        /// </value>
        public string SqlConnectionString
        {
            get { return GetConfigurationValues(ConfigKeys.SqlConnection); }
        }
    }
}