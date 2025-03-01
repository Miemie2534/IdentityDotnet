﻿using System.ComponentModel.DataAnnotations;

namespace IdentityDotNet.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Username is required.")]
        public string? Username { get; set; }
        
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool Remember { get; set; }
    }
}
