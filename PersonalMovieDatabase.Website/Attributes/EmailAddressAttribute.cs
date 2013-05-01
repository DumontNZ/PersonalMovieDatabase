using System.ComponentModel.DataAnnotations;
using PersonalMovieDatabase.Common.Resources;

namespace PersonalMovieDatabase.Website.Attributes
{
    public class EmailAddressAttribute : RegularExpressionAttribute
    {

        public EmailAddressAttribute(): base(@"[A-Za-z0-9._%+-]+[A-Za-z0-9.-]+\.[A-Za-z] {2,4}")
        {
            ErrorMessage = ErrorMessages.InvalidEmailAddress;
        }

    }
}