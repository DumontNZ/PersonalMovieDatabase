using Ninject.Modules;
using PersonalMovieDatabase.Common.Configuration;
using PersonalMovieDatabase.Common.Cryptography;
using PersonalMovieDatabase.Core;

namespace PersonalMovieDatabase.Website.DependencyModule
{
    public class DependencyModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<IUserManager>().To<UserManager>();
            Bind<ICryptography>().To<Cryptography>();
            Bind<IConfig>().To<Config>();
        }
    }
}