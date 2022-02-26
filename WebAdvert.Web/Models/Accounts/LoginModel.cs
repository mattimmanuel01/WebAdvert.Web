using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Accounts
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [Display(Name ="My Password")]
        public string Password { get; set; }

        [Display(Name ="Remember Me.")]
        public bool RememberMe { get; set; }
    }
}
