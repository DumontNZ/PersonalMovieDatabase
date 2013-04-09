using System.Configuration;

namespace PersonalMovieDatabase.Common.Configuration
{
    public class Config : IConfig
    {
        private string GetConfigurationValues(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public string SomethingImportant
        {
            get { return GetConfigurationValues(ConfigKeys.SomethingImportant); }
        }
    }
}