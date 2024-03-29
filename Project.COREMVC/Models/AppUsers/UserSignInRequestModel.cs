﻿using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.AppUsers
{
    public class UserSignInRequestModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
