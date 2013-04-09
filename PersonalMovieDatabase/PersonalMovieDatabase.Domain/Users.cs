﻿using System;

namespace PersonalMovieDatabase.Domain
{
    public class Users
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public DateTime DateCreateUTC { get; set; }
        public DateTime DateDeleteUTC { get; set; }
    }
}