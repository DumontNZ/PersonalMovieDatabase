using Ninject.Modules;
using PersonalMovieDatabase.Repository;

namespace PersonalMovieDatabase.Core.DependencyModule
{
    public class DependencyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
