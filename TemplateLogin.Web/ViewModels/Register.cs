using System.ComponentModel.DataAnnotations;

namespace TemplateLogin.Web.ViewModels
{
    public class Register
    {
        [Required]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage="Password and confirmation password dit not match")]
        public string ConfirmPassword { get; set; }
    }
}
