using System.ComponentModel.DataAnnotations;

namespace ITELEC1C_FinalLabAct3.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required")]
        public string? Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must confirm your password")]
        public string? ConfirmPassword { get; set; }

        [Display(Name = "First name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email address is required")]
        public string? Email { get; set; }

        [RegularExpression("[0-9]{3} - [0-9]{3} - [0-9]{4}", ErrorMessage="You must follow the format 000-000-0000")]
        [Display(Name = "Phone Number")]
        public string? Phone { get; set; }
    }
}
