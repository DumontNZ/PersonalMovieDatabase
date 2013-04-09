using Ninject.Modules;
using PersonalMovieDatabase.Common.Configuration;
using PersonalMovieDatabase.Core;

namespace PersonalMovieDatabase.Website.DependencyModule
{
    public class DependencyModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<IUserManager>().To<UserManager>();
            Bind<IConfig>().To<Config>();
        }
    }
}