using System.ComponentModel;
using PersonalMovieDatabase.Common.Resources;

namespace PersonalMovieDatabase.Website.Attributes
{
    public class LocalisedDisplayNameAttribute : DisplayNameAttribute 
    {

        private readonly string _resourceName;

        public LocalisedDisplayNameAttribute(string resourceName)
        {
            _resourceName = resourceName;
        }

        public override string DisplayName
        {
            get { return DisplayNames.ResourceManager.GetString(_resourceName); }
        }
    }
}