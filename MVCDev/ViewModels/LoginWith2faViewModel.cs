using System.ComponentModel.DataAnnotations;

namespace MVCDev.ViewModels
{
    public class LoginWith2faViewModel
    {
        [Required]
        [StringLength(7, MinimumLength = 6)]
        public string Code { get; set; }

        public bool RememberMe { get; set; }

        [Display(Name = "Remember this browser")]
        public bool RememberMachine { get; set; }
    }
}
