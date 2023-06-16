using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Fiorello_backend.ViewModels.Account
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "The full name is required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "The email address is required")]
        public int Username { get; set; }
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The email address is required")]
        public string Password { get; set; }
        public string RepeatPassword { get; set; }

    }
}
