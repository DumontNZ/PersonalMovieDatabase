using System;
using System.ComponentModel.DataAnnotations;
using PersonalMovieDatabase.Website.Attributes;

namespace PersonalMovieDatabase.Website.Models
{
    public class AccountModel
    {
        [Required]
        [LocalisedDisplayName("Username")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [LocalisedDisplayName("EmailAddress")]
        public string EmailAddress { get; set; }

        [Required]
        [LocalisedDisplayName("FirstName")]
        public string FdfdirstName { get; set; }

        [Required]
        [LocalisedDisplayName("Surname")]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [LocalisedDisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [LocalisedDisplayName("ReenterPassword")]
        public string ReenterPassword { get; set; }
    }
}