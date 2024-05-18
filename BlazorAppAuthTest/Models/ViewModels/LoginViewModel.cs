using System.ComponentModel.DataAnnotations;

namespace BlazorAppAuthTest.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "User Name cannot be Empty!")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password cannot be Empty!")]
        public string? Password { get; set; }
    }
}
