using Mvc.Mailer;
using PersonalMovieDatabase.Domain;
using PersonalMovieDatabase.Website.Models;

namespace PersonalMovieDatabase.Website.Mailers
{ 
	public class UserMailer : MailerBase, IUserMailer 	
	{
		public UserMailer()
		{
			MasterName="_Layout";
		}
		
		public virtual MvcMailMessage Welcome(User user)
		{
			ViewBag.Name = "Joel";

		    ViewData.Model = user; 

			return Populate(x =>
			{
				x.Subject = "Welcome";
				x.ViewName = "Welcome";
				x.To.Add("joel_tennant@hotmail.com");
			});
		}
 
		public virtual MvcMailMessage PasswordReset()
		{
			//ViewBag.Data = someObject;
			return Populate(x =>
			{
				x.Subject = "PasswordReset";
				x.ViewName = "PasswordReset";
				x.To.Add("some-email@example.com");
			});
		}
	}
}