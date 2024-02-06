using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.AppUsers
{
    public class UserRegisterModel
    {
       // [Required(ErrorMessage = "Username field requirement")]
        public string UserName { get; set; }

        //[Required(ErrorMessage = "Password field is required")]
        //[MinLength(3, ErrorMessage = "Min 3 characters required to be entered")]
        public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Passwords don't match")]
        //public string ConfirmPassword { get; set; }

        //[EmailAddress(ErrorMessage = "Please log in according to the email address format.")]
        public string Email { get; set; }

    }
}
