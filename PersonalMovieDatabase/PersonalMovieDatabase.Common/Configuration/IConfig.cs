namespace PersonalMovieDatabase.Common.Configuration
{
    public interface IConfig
    {

        string SomethingImportant { get; }
        string SqlConnectionString { get;  }
    }
}
