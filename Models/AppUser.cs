﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IdentityDotNet.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string? Name { get; set; } 
        public string? Address { get; set; } 
    }
}
