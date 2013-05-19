using Mvc.Mailer;
using PersonalMovieDatabase.Domain;

namespace PersonalMovieDatabase.Website.Mailers
{
    public interface IUserMailer
    {
        MvcMailMessage Welcome(User user);
        MvcMailMessage PasswordReset();
    }
}