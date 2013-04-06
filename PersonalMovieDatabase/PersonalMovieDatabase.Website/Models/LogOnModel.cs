using System;
using System.ComponentModel.DataAnnotations;
using PersonalMovieDatabase.Website.Attributes;

namespace PersonalMovieDatabase.Website.Models
{
    public class LogOnModel
    {
        [Required]
        [LocalisedDisplayName("Username")]
        public String Username { get; set; }

        [Required]
        [LocalisedDisplayName("Password")]
        public String Password { get; set; }

        [LocalisedDisplayName("RememberMe")]
        public bool RememberMe { get; set; }
    }
}