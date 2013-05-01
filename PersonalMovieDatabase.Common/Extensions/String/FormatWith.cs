namespace PersonalMovieDatabase.Common.Extensions.String
{
    public static partial class StringExtensions
    {
        public static string FormatWith(this string instance, params object[] parameters)
        {
            return string.Format(instance, parameters); 
        }
    }
}
