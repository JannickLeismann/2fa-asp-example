using System.ComponentModel.DataAnnotations;

namespace MVCDev.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-Mail required")]
        [EmailAddress(ErrorMessage = "Invalid E-Mail")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Stay logged in")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
