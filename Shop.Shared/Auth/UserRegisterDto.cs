﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Auth
{
    public class UserRegisterDto
    {

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPasswrod { get; set; } = string.Empty;

        [Required, MinLength(3)]
        public string UserName { get; set; } = string.Empty;
    }
}
