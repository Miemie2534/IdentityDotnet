using System.ComponentModel.DataAnnotations;

namespace IdentityDotNet.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage ="Passwords don't match")]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; } = string.Empty;
    }
}
